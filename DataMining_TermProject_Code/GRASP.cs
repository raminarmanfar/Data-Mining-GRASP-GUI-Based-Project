using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DataMining_TermProject_Code
{
    class GRASP
    {
        FrmMain frmMain;
        SettingsInfo settingsInfo;
        public GRASP(FrmMain frmMain, SettingsInfo settingsInfo)
        {
            this.frmMain = frmMain;
            this.settingsInfo = settingsInfo;
        }

        private string GenerateInitialPsudoRandomFeatures(int initialSeed)
        {
            string randomSeed;
            Random rnd = new Random(initialSeed);
            int OnesCount;
            do
            {
                OnesCount = 0;
                randomSeed = string.Empty;
                for (int i = 0; i < settingsInfo.TotalNumberOfFeatures; i++)
                {
                    int binValue = rnd.Next(Int16.MaxValue) % 2;
                    if (binValue == 1) OnesCount++;
                    if (OnesCount <= settingsInfo.RCL) randomSeed += binValue.ToString();
                    else randomSeed += "0";
                }

            } while (OnesCount < settingsInfo.RCL);

            return randomSeed;
        }

        private double ComputeDistance(string subSet, int NumberOfTrainingSet, int NumberOfTestSet)
        {
            List<double> Distance = new List<double>();
            List<bool> CorrectNess = new List<bool>();

            for (int i = NumberOfTrainingSet; i < settingsInfo.TotalNumberOfData; i++)//--- Loop for test-set
            {
                Distance.Clear();
                for (int j = 0; j < NumberOfTrainingSet; j++) //--- Loop for train-set
                {
                    if (i != j)
                    {
                        double d = 0;
                        for (int k = 0; k < subSet.Length; k++)
                        {
                            if (subSet[k] == '1')
                            {
                                try
                                {
                                    double tstVal = (double)frmMain.dgvTrainingData.Rows[i].Cells[k].Value;
                                    double trnVal = (double)frmMain.dgvTrainingData.Rows[j].Cells[k].Value;
                                    double val = tstVal - trnVal;
                                    d += val * val;
                                }
                                catch (Exception ex)
                                {
                                    d = double.MaxValue;
                                }
                            }
                        }
                        Distance.Add(Math.Sqrt(d));
                    }
                    else
                    {
                        Distance.Add(double.MaxValue);
                    }
                }
                string tstChk = frmMain.dgvTrainingData.Rows[i].Cells[settingsInfo.TotalNumberOfFeatures].Value.ToString();
                int NumberOfCorrect = 0, NumberOfError = 0;
                for (int t = 0; t < settingsInfo.KNNDegree; t++)
                {
                    int minimumValueIndex = Distance.IndexOf(Distance.Min());

                    string trnChk = frmMain.dgvTrainingData.Rows[minimumValueIndex].Cells[settingsInfo.TotalNumberOfFeatures].Value.ToString();
                    if (tstChk.ToUpper() == trnChk.ToUpper()) NumberOfCorrect++;
                    else NumberOfError++;
                    Distance[minimumValueIndex] = double.MaxValue;
                }
                if (NumberOfCorrect >= NumberOfError) CorrectNess.Add(true);
                else CorrectNess.Add(false);
                //frmMain.SetLog(i.ToString() + ") Errors: " + NumberOfError.ToString() + ", Corrects: " + NumberOfCorrect.ToString());
                //frmMain.SetLog("=======================================================");
                //frmMain.SetLog(tstChk + " => " + trnChk);
                //frmMain.SetLog("Distance: " + Distance[minimumValueIndex].ToString());
            }

            int TotalErrors = 0, TotalCorrect = 0;
            for (int i = 0; i < CorrectNess.Count; i++)
            {
                if (CorrectNess[i] == false) TotalErrors++;
                else TotalCorrect++;
            }
            frmMain.SetLog(">>>> Subset ("+subSet+") Result => Number of Errors: " + TotalErrors.ToString() + ", Number of Corrects: " + TotalCorrect.ToString(), false);
            double FitnessScore = 100.0 * TotalCorrect / NumberOfTestSet;
            frmMain.SetLog(">>>> Fitness Score: " + FitnessScore.ToString() + "%", false);

            return FitnessScore;
        }

        private bool isExist(string GivenSubset)
        {
            for (int i = 0; i < Neighborhood.Count; i++)
            {
                if (Neighborhood[i].Contains(GivenSubset) == true)
                {
                    return true;
                }
            }
            return false;
        }
        private void GenerateNeighborhoods(string GivenSubset)
        {
            List<string> neigh = new List<string>();
            StringBuilder sb = new StringBuilder(GivenSubset);
            neigh.Clear();
            switch (settingsInfo.neighborHoodSearchAlg)
            {
                case NeighborHoodSearchAlg.AdjacentPairwise:
                    for (int i = 0; i + 1 < GivenSubset.Length; i++)
                    {
                        sb = new StringBuilder(GivenSubset);
                        char ch = sb[i];
                        sb[i] = sb[i + 1];
                        sb[i + 1] = ch;
                        if (!isExist(sb.ToString())) neigh.Add(sb.ToString());
                    }
                    break;
                case NeighborHoodSearchAlg.GeneralPairwise:
                    for (int gap = 1; gap < GivenSubset.Length; gap++)
                    {
                        for (int i = 0; i + gap < GivenSubset.Length; i++)
                        {
                            sb = new StringBuilder(GivenSubset);
                            char ch = sb[i];
                            sb[i] = sb[i + gap];
                            sb[i + gap] = ch;
                            if (!isExist(sb.ToString())) neigh.Add(sb.ToString());
                        }
                    }
                    break;
                case NeighborHoodSearchAlg.TopPriorityUpfront:
                    for (int i = 1; i < GivenSubset.Length; i++)
                    {
                        sb = new StringBuilder(GivenSubset);
                        char ch = sb[0];
                        sb[0] = sb[i];
                        sb[i] = ch;
                        if (!isExist(sb.ToString())) neigh.Add(sb.ToString());
                    }
                    break;
                case NeighborHoodSearchAlg.VariableNeighourhoodGeneration:
                    //********************* this section should be completed ************************
                    break;
            }
            Neighborhood.Add(neigh);
        }

        List<List<string>> Neighborhood = new List<List<string>>();

        public string DoClassicalGRASP()
        {
            frmMain.SetLog(">>>> Classical GRASP --> Construction phase starts...", false);
            int NumberOfTrainingSet, NumberOfTestSet, DistancesCount;

            NumberOfTestSet = (int)(((double)settingsInfo.TestSetPercentage / 100) * settingsInfo.TotalNumberOfData);
            NumberOfTrainingSet = settingsInfo.TotalNumberOfData - NumberOfTestSet;
            NumberOfTrainingSet += settingsInfo.TotalNumberOfData - (NumberOfTestSet + NumberOfTrainingSet);
            DistancesCount = NumberOfTrainingSet * NumberOfTestSet;

            frmMain.SetLog(">>>> Number of Training Set Records: " + NumberOfTrainingSet.ToString(), false);
            frmMain.SetLog(">>>> Number of Test Set Records: " + NumberOfTestSet.ToString(), false);
            frmMain.SetLog(">>>> Test Set is " + settingsInfo.TestSetPercentage.ToString() + " percent of total data...", false);

            Neighborhood.Clear();

            string InitialSubSetClassical = GenerateInitialPsudoRandomFeatures(settingsInfo.InitialSeed);
            Neighborhood.Add(new List<string> { InitialSubSetClassical });
            frmMain.SetLog("Initial Random Sub-Feature: " + InitialSubSetClassical, false);
            frmMain.SetLog(">>>> Subsets for initial psedu-random set generated successfully...", true);
            int j = 0, MinimumRow = -1, MinimumCol = -1;
            while (Neighborhood[j].Count > 0)
            {
                double MaxFitnessScore = 0;
                int MaxFitnessScoreIndex = 0;
                for (int i = 0; i < Neighborhood[j].Count; i++)
                {
                    double FitnessScore;
                    FitnessScore = ComputeDistance(Neighborhood[j][i], NumberOfTrainingSet, NumberOfTestSet);
                    if (MaxFitnessScore < FitnessScore)
                    {
                        MaxFitnessScore = FitnessScore;
                        MaxFitnessScoreIndex = i;
                        MinimumRow = j;
                        MinimumCol = i;
                    }
                }
                GenerateNeighborhoods(Neighborhood[j][MaxFitnessScoreIndex]);
                frmMain.SetLog(">>>> Iteration: " + j.ToString() + " => Subset (" + Neighborhood[j][MaxFitnessScoreIndex] + ") selected for next iteration...", true);
                j++;
            }
            return Neighborhood[MinimumRow][MinimumCol];
        }

        private double GetTotalEntropy(List<List<double>> Entropy)
        {
            double e=0;
            for (int c = 0; c < Entropy[settingsInfo.TotalNumberOfFeatures].Count; c++)
                e += Entropy[settingsInfo.TotalNumberOfFeatures][c];
            return e;
        }

        private List<List<double>> CalcEntropy(List<List<int>> CategorizedListCount, List<List<List<int>>> CategorizedListPerClassCount)
        {
            List<List<double>> Entropy = new List<List<double>>();
            for (int f = 0; f < CategorizedListPerClassCount.Count; f++)
            {
                List<List<double>> te = new List<List<double>>();
                for (int c = 0; c < CategorizedListPerClassCount[f].Count; c++)
                {
                    List<double> e = new List<double>(CategorizedListPerClassCount[f].Count);
                    for (int i = 0; i < CategorizedListPerClassCount[f][c].Count; i++) e.Add(0);
                    for (int i = 0; i < CategorizedListPerClassCount[f][c].Count; i++)
                    {
                        double dominator=CategorizedListPerClassCount[f][c][i];
                        double denominator = CategorizedListCount[f][i];
                        if (f == settingsInfo.TotalNumberOfFeatures)
                            denominator = settingsInfo.TotalNumberOfData;
                        double v = dominator / denominator;
                        e[i] += -v * Math.Log(v, 2);
                        if (double.IsNaN(e[i])) e[i] = 0;
                        e[i] = Math.Round(e[i], 2);
                    }
                    te.Add(e);
                }
                List<double> te2 = new List<double>(CategorizedListPerClassCount[f].Count);
                double v2;
                for (int i = 0; i < CategorizedListCount[f].Count; i++)
                {
                    v2 = 0;
                    for (int c = 0; c < CategorizedListPerClassCount[f].Count; c++)
                        v2 += te[c][i];
                    te2.Add(v2);
                }

                Entropy.Add(te2);
            }
            return Entropy;
        }

        private string GenerateInitialFeaturesOurMethod(List<List<string>> CategorizedList, List<List<int>> CategorizedListCount, List<List<List<int>>> CategorizedListPerClassCount)
        {
            string InitialFeature = string.Empty;
            switch (settingsInfo.filterType)
            {
                case FilterType.Correlation:
                    break;
                case FilterType.Entropy:
                    List<List<double>> Entropy = CalcEntropy(CategorizedListCount, CategorizedListPerClassCount);
                    double TotalEntropy = GetTotalEntropy(Entropy);
                    for (int i = 0; i < Entropy.Count-1; i++)
                    {
                        for (int j = 0; j < Entropy[i].Count; j++)
                            frmMain.SetLog(">>>> Entropy(" + frmMain.dgvTrainingData.Columns[i].HeaderCell.Value.ToString() + ", " + CategorizedList[i][j] + "): " + Math.Round(Entropy[i][j], 2).ToString(), false);
                    }
                    frmMain.SetLog(">>>> Entropy(S): " + Math.Round(TotalEntropy, 2).ToString(), true);

                    //---- get average of 
                    List<double> EntropyAverage=new List<double>();
                    for (int i = 0; i < Entropy.Count - 1; i++)
                    {
                        double sum = 0;
                        for (int j = 0; j < Entropy[i].Count; j++)
                        {
                            sum += Entropy[i][j];
                        }
                        EntropyAverage.Add(Math.Round(sum / Entropy[i].Count, 2));
                    }

                    bool[] selected = new bool[settingsInfo.TotalNumberOfFeatures];
                    for (int i = 0; i < settingsInfo.RCL; i++)
                    {
                        double min = double.MaxValue;
                        int minIndex = 0;
                        for (int j = 0; j < EntropyAverage.Count; j++)
                        {
                            if (EntropyAverage[j] < min && selected[j] == false)
                            {
                                min = EntropyAverage[j];
                                minIndex = j;
                            }
                        }
                        selected[minIndex] = true;
                    }
                    for (int i = 0; i < settingsInfo.TotalNumberOfFeatures; i++)
                    {
                        if (selected[i]) InitialFeature += "1";
                        else InitialFeature += "0";
                    }
                    break;
                case FilterType.Gain:
                    break;
            }
            return InitialFeature;
        }

        public string DoOurGRASP(List<List<string>> CategorizedList, List<List<int>> CategorizedListCount, List<List<List<int>>> CategorizedListPerClassCount)
        {
            frmMain.SetLog(">>>> Our GRASP --> Construction phase starts...", false);
            int NumberOfTrainingSet, NumberOfTestSet, DistancesCount;

            NumberOfTestSet = (int)(((double)settingsInfo.TestSetPercentage / 100) * settingsInfo.TotalNumberOfData);
            NumberOfTrainingSet = settingsInfo.TotalNumberOfData - NumberOfTestSet;
            NumberOfTrainingSet += settingsInfo.TotalNumberOfData - (NumberOfTestSet + NumberOfTrainingSet);
            DistancesCount = NumberOfTrainingSet * NumberOfTestSet;

            frmMain.SetLog(">>>> Number of Training Set Records: " + NumberOfTrainingSet.ToString(), false);
            frmMain.SetLog(">>>> Number of Test Set Records: " + NumberOfTestSet.ToString(), false);
            frmMain.SetLog(">>>> Test Set is " + settingsInfo.TestSetPercentage.ToString() + " percent of total data...", false);

            string InitialSubSetOurs = GenerateInitialFeaturesOurMethod(CategorizedList, CategorizedListCount, CategorizedListPerClassCount);
            Neighborhood.Clear();

            Neighborhood.Add(new List<string> { InitialSubSetOurs });
            frmMain.SetLog("Initial Subset generated using: " + settingsInfo.filterType.ToString(), false);
            frmMain.SetLog("Initial Subset: " + InitialSubSetOurs, false);
            frmMain.SetLog(">>>> Subsets for initial psedu-random set generated successfully...", true);
            int j = 0, MinimumRow = -1, MinimumCol = -1;
            while (Neighborhood[j].Count > 0)
            {
                double MaxFitnessScore = 0;
                int MaxFitnessScoreIndex = 0;
                for (int i = 0; i < Neighborhood[j].Count; i++)
                {
                    double FitnessScore;
                    FitnessScore = ComputeDistance(Neighborhood[j][i], NumberOfTrainingSet, NumberOfTestSet);
                    if (MaxFitnessScore < FitnessScore)
                    {
                        MaxFitnessScore = FitnessScore;
                        MaxFitnessScoreIndex = i;
                        MinimumRow = j;
                        MinimumCol = i;
                    }
                }
                GenerateNeighborhoods(Neighborhood[j][MaxFitnessScoreIndex]);
                frmMain.SetLog(">>>> Iteration: " + j.ToString() + " => Subset (" + Neighborhood[j][MaxFitnessScoreIndex] + ") selected for next iteration...", true);
                j++;
            }
            return Neighborhood[MinimumRow][MinimumCol];
        }
    }
}
