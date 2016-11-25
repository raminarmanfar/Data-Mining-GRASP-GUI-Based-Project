namespace DataMining_TermProject_Code
{
    partial class FrmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterType = new System.Windows.Forms.ComboBox();
            this.txtTotalFeatures = new System.Windows.Forms.TextBox();
            this.cbNeighAlg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudIterations = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudConstractionDuration = new System.Windows.Forms.NumericUpDown();
            this.nudImprovingDuration = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudInitialSeed = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudRCL = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudTestSetPercentage = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudKNNDegree = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstractionDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImprovingDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRCL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTestSetPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKNNDegree)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(275, 7);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 397);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(490, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbFilterType, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtTotalFeatures, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbNeighAlg, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.nudIterations, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.nudConstractionDuration, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.nudImprovingDuration, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.nudInitialSeed, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.nudRCL, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.nudTestSetPercentage, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.label13, 2, 8);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.nudKNNDegree, 1, 9);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(482, 309);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Impoving Phase Duration";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(6, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Number of Feature";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbFilterType
            // 
            this.cbFilterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterType.FormattingEnabled = true;
            this.cbFilterType.Items.AddRange(new object[] {
            "Entropy",
            "Gain",
            "Correlation"});
            this.cbFilterType.Location = new System.Drawing.Point(191, 65);
            this.cbFilterType.Name = "cbFilterType";
            this.cbFilterType.Size = new System.Drawing.Size(256, 24);
            this.cbFilterType.TabIndex = 7;
            // 
            // txtTotalFeatures
            // 
            this.txtTotalFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalFeatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalFeatures.Location = new System.Drawing.Point(191, 5);
            this.txtTotalFeatures.Name = "txtTotalFeatures";
            this.txtTotalFeatures.ReadOnly = true;
            this.txtTotalFeatures.Size = new System.Drawing.Size(256, 22);
            this.txtTotalFeatures.TabIndex = 0;
            this.txtTotalFeatures.TabStop = false;
            this.txtTotalFeatures.Text = "0";
            this.txtTotalFeatures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbNeighAlg
            // 
            this.cbNeighAlg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNeighAlg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNeighAlg.FormattingEnabled = true;
            this.cbNeighAlg.Items.AddRange(new object[] {
            "Adjacent Pairwise Interchange",
            "General Pairwise Interchange",
            "Top Priority Upfront",
            "Variable Neighborhood Generation"});
            this.cbNeighAlg.Location = new System.Drawing.Point(191, 97);
            this.cbNeighAlg.Name = "cbNeighAlg";
            this.cbNeighAlg.Size = new System.Drawing.Size(256, 24);
            this.cbNeighAlg.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Neighborhood Generation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of Iteration";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudIterations
            // 
            this.nudIterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudIterations.Location = new System.Drawing.Point(191, 129);
            this.nudIterations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudIterations.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudIterations.Name = "nudIterations";
            this.nudIterations.Size = new System.Drawing.Size(256, 22);
            this.nudIterations.TabIndex = 11;
            this.nudIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudIterations.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Construction Phase Duration";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudConstractionDuration
            // 
            this.nudConstractionDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudConstractionDuration.Location = new System.Drawing.Point(191, 159);
            this.nudConstractionDuration.Name = "nudConstractionDuration";
            this.nudConstractionDuration.Size = new System.Drawing.Size(256, 22);
            this.nudConstractionDuration.TabIndex = 13;
            this.nudConstractionDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudConstractionDuration.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudConstractionDuration.ValueChanged += new System.EventHandler(this.nudConstractionDuration_ValueChanged);
            // 
            // nudImprovingDuration
            // 
            this.nudImprovingDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudImprovingDuration.Location = new System.Drawing.Point(191, 189);
            this.nudImprovingDuration.Name = "nudImprovingDuration";
            this.nudImprovingDuration.Size = new System.Drawing.Size(256, 22);
            this.nudImprovingDuration.TabIndex = 15;
            this.nudImprovingDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudImprovingDuration.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudImprovingDuration.ValueChanged += new System.EventHandler(this.nudImprovingDuration_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(456, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "%";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(456, 186);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "%";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudInitialSeed
            // 
            this.nudInitialSeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudInitialSeed.Location = new System.Drawing.Point(191, 219);
            this.nudInitialSeed.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.nudInitialSeed.Name = "nudInitialSeed";
            this.nudInitialSeed.Size = new System.Drawing.Size(256, 22);
            this.nudInitialSeed.TabIndex = 19;
            this.nudInitialSeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(6, 216);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 28);
            this.label11.TabIndex = 17;
            this.label11.Text = "Initial Seed";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudRCL
            // 
            this.nudRCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRCL.Location = new System.Drawing.Point(191, 35);
            this.nudRCL.Name = "nudRCL";
            this.nudRCL.Size = new System.Drawing.Size(256, 22);
            this.nudRCL.TabIndex = 5;
            this.nudRCL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "RCL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(6, 246);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 28);
            this.label12.TabIndex = 20;
            this.label12.Text = "Test-Set Persentage";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudTestSetPercentage
            // 
            this.nudTestSetPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTestSetPercentage.Location = new System.Drawing.Point(191, 249);
            this.nudTestSetPercentage.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTestSetPercentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTestSetPercentage.Name = "nudTestSetPercentage";
            this.nudTestSetPercentage.Size = new System.Drawing.Size(256, 22);
            this.nudTestSetPercentage.TabIndex = 21;
            this.nudTestSetPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTestSetPercentage.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(456, 246);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 28);
            this.label13.TabIndex = 22;
            this.label13.Text = "%";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(6, 276);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 28);
            this.label14.TabIndex = 23;
            this.label14.Text = "KNN Degree";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudKNNDegree
            // 
            this.nudKNNDegree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudKNNDegree.Location = new System.Drawing.Point(191, 279);
            this.nudKNNDegree.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKNNDegree.Name = "nudKNNDegree";
            this.nudKNNDegree.Size = new System.Drawing.Size(256, 22);
            this.nudKNNDegree.TabIndex = 24;
            this.nudKNNDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudKNNDegree.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 346);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(490, 46);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(129, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DataMining_TermProject_Code.Properties.Resources._1431391325_tools_preferences;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConstractionDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudImprovingDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRCL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTestSetPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKNNDegree)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudRCL;
        private System.Windows.Forms.ComboBox cbFilterType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalFeatures;
        private System.Windows.Forms.ComboBox cbNeighAlg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudIterations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudConstractionDuration;
        private System.Windows.Forms.NumericUpDown nudImprovingDuration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudInitialSeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudTestSetPercentage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudKNNDegree;
    }
}