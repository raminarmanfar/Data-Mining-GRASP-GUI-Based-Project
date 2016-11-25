using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMining_TermProject_Code
{
    public partial class FrmSettings : Form
    {
        FrmMain frmMain;
        SettingsInfo settingsInfo;
        public FrmSettings(FrmMain frmMain, SettingsInfo settingsInfo)
        {
            this.frmMain = frmMain;
            this.settingsInfo = settingsInfo;

            InitializeComponent();

            txtTotalFeatures.Text = settingsInfo.TotalNumberOfFeatures.ToString();
            nudRCL.Maximum = settingsInfo.TotalNumberOfFeatures;

            cbFilterType.SelectedIndex = (int)settingsInfo.filterType;
            cbNeighAlg.SelectedIndex = (int)settingsInfo.neighborHoodSearchAlg;
            nudIterations.Value = settingsInfo.NumberOfIterations;
            nudConstractionDuration.Value = settingsInfo.ConstructionPhaseDurationPercent;
            nudImprovingDuration.Value = settingsInfo.ImprovingPhaseDurationPercent;
            nudRCL.Value = settingsInfo.RCL;
            nudInitialSeed.Value = settingsInfo.InitialSeed;
            nudTestSetPercentage.Value = settingsInfo.TestSetPercentage;
            nudKNNDegree.Value = settingsInfo.KNNDegree;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settingsInfo.filterType = (FilterType)cbFilterType.SelectedIndex;
            settingsInfo.neighborHoodSearchAlg = (NeighborHoodSearchAlg)cbNeighAlg.SelectedIndex;
            settingsInfo.NumberOfIterations = (int)nudIterations.Value;
            settingsInfo.ConstructionPhaseDurationPercent = (int)nudConstractionDuration.Value;
            settingsInfo.ImprovingPhaseDurationPercent = (int)nudImprovingDuration.Value;
            settingsInfo.RCL = (int)nudRCL.Value;
            settingsInfo.InitialSeed = (int)nudInitialSeed.Value;
            settingsInfo.TestSetPercentage = (int)nudTestSetPercentage.Value;
            settingsInfo.KNNDegree = (int)nudKNNDegree.Value;

            frmMain.SetLog(">>>> Settings for GRASP changed successfully...", false);
            frmMain.SetLog("Filter Type: " + settingsInfo.filterType.ToString(), false);
            frmMain.SetLog("Neighborhood search alg: " + settingsInfo.neighborHoodSearchAlg.ToString(), false);
            frmMain.SetLog("Number of iteration: " + settingsInfo.NumberOfIterations.ToString(), false);
            frmMain.SetLog("Construction phase duration: " + settingsInfo.ConstructionPhaseDurationPercent.ToString()+"%", false);
            frmMain.SetLog("Improving phase duration: " + settingsInfo.ImprovingPhaseDurationPercent+"%".ToString(), false);
            frmMain.SetLog("RCL: " + settingsInfo.RCL.ToString(), false);
            frmMain.SetLog("Initial seed: " + settingsInfo.InitialSeed.ToString(), false);
            frmMain.SetLog("Test set percentage: " + settingsInfo.TestSetPercentage.ToString() + "%", false);
            frmMain.SetLog("KNN Degree: " + settingsInfo.KNNDegree.ToString(), true);
            frmMain.SetSettingsInfo(settingsInfo);

            this.Close();
        }

        private void nudConstractionDuration_ValueChanged(object sender, EventArgs e)
        {
            nudImprovingDuration.Value = 100 - nudConstractionDuration.Value;
        }

        private void nudImprovingDuration_ValueChanged(object sender, EventArgs e)
        {
            nudConstractionDuration.Value = 100 - nudImprovingDuration.Value;
        }
    }
}
