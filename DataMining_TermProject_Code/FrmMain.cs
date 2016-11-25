using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace DataMining_TermProject_Code
{
    public enum FilterType { Entropy=0, Gain, Correlation };
    public enum NeighborHoodSearchAlg { AdjacentPairwise = 0, GeneralPairwise, TopPriorityUpfront, VariableNeighourhoodGeneration };
    public struct SettingsInfo
    {
        public FilterType filterType;
        public NeighborHoodSearchAlg neighborHoodSearchAlg;
        public int NumberOfIterations;
        public int ConstructionPhaseDurationPercent;
        public int ImprovingPhaseDurationPercent;

        public int TotalNumberOfFeatures;
        public int RCL;
        
        public int InitialSeed;

        public int TotalNumberOfData;
        public int TestSetPercentage;
        public int KNNDegree;
        public int ClassesCount;
    }
 
    public partial class FrmMain : Form
    {
        SettingsInfo settingsInfo;
        public FrmMain()
        {
            settingsInfo.filterType = FilterType.Entropy;
            settingsInfo.neighborHoodSearchAlg = NeighborHoodSearchAlg.AdjacentPairwise;
            settingsInfo.NumberOfIterations = 50;
            settingsInfo.ConstructionPhaseDurationPercent = 50;
            settingsInfo.ImprovingPhaseDurationPercent = 50;
            settingsInfo.TotalNumberOfFeatures = 0;
            settingsInfo.RCL = 0;
            settingsInfo.InitialSeed = 0;
            settingsInfo.TotalNumberOfData = 0;
            settingsInfo.TestSetPercentage = 20;
            settingsInfo.KNNDegree = 3;
            settingsInfo.ClassesCount = 0;

            InitializeComponent();
        }

        public void SetLog(string logText,bool pusSeperator)
        {
            txtLog.Text += logText + "\r\n";
            if (pusSeperator) txtLog.Text += "=============================================================\r\n";
        }

        public void SetSettingsInfo(SettingsInfo settingsInfo)
        {
            this.settingsInfo = settingsInfo;
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            openFileDialog1.Filter = "Excel Files (*.xls,*.xlsx)|*.xls;*.xlsx";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Import data from file";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //IsExecuted = false;
                    System.Data.OleDb.OleDbConnection MyConnection;
                    System.Data.DataSet DtSet;
                    System.Data.OleDb.OleDbDataAdapter MyCommand;
                    FileInfo fi = new FileInfo(openFileDialog1.FileName);
                    string excelObject = "Provider=Microsoft.{0}.OLEDB.{1};Data Source={2};Extended Properties=\"Excel {3};HDR=YES\"";

                    if (fi.Extension.Equals(".xls"))
                    {
                        excelObject = string.Format(excelObject, "Jet", "4.0", openFileDialog1.FileName, "8.0");
                    }
                    else if (fi.Extension.Equals(".xlsx"))
                    {
                        excelObject = string.Format(excelObject, "Ace", "12.0", openFileDialog1.FileName, "12.0");
                    }
                    MyConnection = new System.Data.OleDb.OleDbConnection(excelObject);
                    MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
                    MyCommand.TableMappings.Add("Table", "TestTable");
                    DtSet = new System.Data.DataSet();
                    MyCommand.Fill(DtSet);

                    dgvTrainingData.DataSource = DtSet.Tables[0];
                    txtTotalData.Text = (dgvTrainingData.Rows.Count).ToString();
                    txtFeatureCount.Text = dgvTrainingData.Columns.Count.ToString(); 
                    //txtResult.Clear();
                    MyConnection.Close();
                    progressBar1.Value = 100;
                    SetLog(">>>> Data has been imported successfully...\r\nNumber of Data: " + txtTotalData.Text + ", Number of Features: " + txtFeatureCount.Text, true);
                    btnSettings.Enabled = btnClassicalGRASP.Enabled = btnOurGRASP.Enabled = true;
                    settingsInfo.RCL = dgvTrainingData.Columns.Count / 2;
                    settingsInfo.TotalNumberOfData = dgvTrainingData.Rows.Count;
                    settingsInfo.TotalNumberOfFeatures = dgvTrainingData.Columns.Count - 1;

                    List<string> Classes = GetElementsCount(settingsInfo.TotalNumberOfFeatures);

                    List<int> ClassesMembersCount = GetCategorizedMembersCount(Classes, settingsInfo.TotalNumberOfFeatures);
                    settingsInfo.ClassesCount = Classes.Count;
                    SetLog(">>>> Class elements frequencies in imported data...", false);

                    for (int i = 0; i < Classes.Count; i++)
                    {
                        SetLog((i + 1).ToString() + "- " + Classes[i] + ": " + ClassesMembersCount[i].ToString(), false);
                    }
                    SetLog("Total Number of classes: " + Classes.Count.ToString(), true);
                    txtClassesCount.Text = settingsInfo.ClassesCount.ToString();
                    txtSubsetCount.Text = settingsInfo.RCL.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings(this, settingsInfo);
            frmSettings.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = string.Empty;
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.ShowDialog(this);
        }

        private List<string> GetElementsCount(int ColNo)
        {
            List<string> classes = new List<string>();
            for (int i = 0; i < dgvTrainingData.Rows.Count; i++)
            {
                bool repeated = false;
                for (int j = 0; j < i; j++)
                {
                    if (dgvTrainingData[ColNo, i].Value.ToString().ToUpper() == dgvTrainingData[ColNo, j].Value.ToString().ToUpper())
                    {
                        repeated = true;
                        //break;
                    }
                }
                if (!repeated)
                {
                    classes.Add(dgvTrainingData[ColNo, i].Value.ToString());
                }
            }
            return classes;
        }

        private List<List<string>> GetCategorizedList()
        {
            List<List<string>> Elements = new List<List<string>>();
            for (int f = 0; f < settingsInfo.TotalNumberOfFeatures + 1; f++)
            {
                Elements.Add(GetElementsCount(f));
            }
            return Elements;
        }

        private List<int> GetCategorizedMembersCount(List<string> CategorizedList, int ColNo)
        {
            List<int> classCount = new List<int>();
            for (int i = 0; i < CategorizedList.Count; i++)
            {
                int Count = 0;
                for (int j = 0; j < dgvTrainingData.Rows.Count; j++)
                {
                    if (CategorizedList[i].ToUpper() == dgvTrainingData[ColNo, j].Value.ToString().ToUpper())
                    {
                        Count++;
                    }
                }
                classCount.Add(Count);
            }
            return classCount;
        }

        private List<List<int>> GetCategorizedMembersPerClassCount(List<string> CategorizedList, List<string> ClassList, int ColNo)
        {
            List<List<int>> ListPerclassCount = new List<List<int>>();
            for (int c = 0; c < ClassList.Count; c++)
            {
                List<int> classCount = new List<int>();
                for (int i = 0; i < CategorizedList.Count; i++)
                {
                    int Count = 0;
                    for (int j = 0; j < dgvTrainingData.Rows.Count; j++)
                    {
                        if (CategorizedList[i].ToUpper() == dgvTrainingData[ColNo, j].Value.ToString().ToUpper())
                        {
                            if (ClassList[c].ToUpper() == dgvTrainingData[settingsInfo.TotalNumberOfFeatures, j].Value.ToString().ToUpper())
                            {
                                Count++;
                            }
                        }
                    }
                    classCount.Add(Count);
                }
                ListPerclassCount.Add(classCount);
            }
            return ListPerclassCount;
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Start the BackgroundWorker.
            //backgroundWorker1.RunWorkerAsync();
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt;";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.Title = "Save Activity Logs into the text file";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, txtLog.Text);
            }
        }

        private void btnClassicalGRASP_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            GRASP grasp = new GRASP(this, settingsInfo);
            string BestSubset = grasp.DoClassicalGRASP();
            string subsetNames = string.Empty;
            for (int i = 0; i < dgvTrainingData.Columns.Count - 1; i++)
            {
                if (BestSubset[i] == '1')
                {
                    subsetNames += dgvTrainingData.Columns[i].HeaderCell.Value.ToString() + ", ";
                }
            }
            SetLog(">>>> Best subset is: " + BestSubset + "\r\nSelected Subset(s): " + subsetNames, true);
            //grasp.Search(data, dataType, fieldsName, 50, 50, 0.3);
            progressBar1.Value = 100;
        }


        private void btnOurGRASP_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            List<List<string>> CategorizedList = GetCategorizedList();
            List<List<int>> CategorizedListCount = new List<List<int>>();
            List<List<List<int>>> CategorizedListPerClassCount = new List<List<List<int>>>();

            for (int i = 0; i < CategorizedList.Count; i++)
            {
                CategorizedListCount.Add(GetCategorizedMembersCount(CategorizedList[i], i));
                //if (i + 1 < settingsInfo.TotalNumberOfFeatures)
                    CategorizedListPerClassCount.Add(GetCategorizedMembersPerClassCount(CategorizedList[i], CategorizedList[settingsInfo.TotalNumberOfFeatures], i));
            }
            GRASP grasp = new GRASP(this, settingsInfo);
            string BestSubset = grasp.DoOurGRASP(CategorizedList, CategorizedListCount, CategorizedListPerClassCount);

            string subsetNames = string.Empty;
            for (int i = 0; i < dgvTrainingData.Columns.Count - 1; i++)
            {
                if (BestSubset[i] == '1')
                {
                    subsetNames += dgvTrainingData.Columns[i].HeaderCell.Value.ToString() + ", ";
                }
            }
            SetLog(">>>> Best subset is: " + BestSubset + "\r\nSelected Subset(s): " + subsetNames, true);
            //grasp.Search(data, dataType, fieldsName, 50, 50, 0.3);
            progressBar1.Value = 100;
        }
    }
}
