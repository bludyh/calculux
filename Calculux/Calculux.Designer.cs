namespace Calculux {
    partial class Calculux {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculux));
            this.lblPrefix = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblInfix = new System.Windows.Forms.Label();
            this.tbInfix = new System.Windows.Forms.TextBox();
            this.tbSymDerivative = new System.Windows.Forms.TextBox();
            this.lblSymDerivative = new System.Windows.Forms.Label();
            this.btnCalculateNumDerivative = new System.Windows.Forms.Button();
            this.tbXValue2 = new System.Windows.Forms.TextBox();
            this.lblNumDerivative = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNumDerivative = new System.Windows.Forms.TextBox();
            this.btnCalculateSymDerivative = new System.Windows.Forms.Button();
            this.gbVisualization = new System.Windows.Forms.GroupBox();
            this.btnToPdf = new System.Windows.Forms.Button();
            this.btnToPng = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pvVisualization = new OxyPlot.WindowsForms.PlotView();
            this.gbFunction = new System.Windows.Forms.GroupBox();
            this.btnRemovePoint = new System.Windows.Forms.Button();
            this.btnClearPoints = new System.Windows.Forms.Button();
            this.lbPoints = new System.Windows.Forms.ListBox();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.tbYCoord = new System.Windows.Forms.TextBox();
            this.tbXCoord = new System.Windows.Forms.TextBox();
            this.lblYCoord = new System.Windows.Forms.Label();
            this.lblXCoord = new System.Windows.Forms.Label();
            this.btnShowNPolynomialTree = new System.Windows.Forms.Button();
            this.btnCalculateNPolynomial = new System.Windows.Forms.Button();
            this.tbNPolynomial = new System.Windows.Forms.TextBox();
            this.lblNPolynomial = new System.Windows.Forms.Label();
            this.btnShowMaclaurinTree = new System.Windows.Forms.Button();
            this.btnCalculateMaclaurin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNValue = new System.Windows.Forms.TextBox();
            this.tbMaclaurin = new System.Windows.Forms.TextBox();
            this.lblMaclaurin = new System.Windows.Forms.Label();
            this.btnCalculateIntegral = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBValue = new System.Windows.Forms.TextBox();
            this.tbIntegral = new System.Windows.Forms.TextBox();
            this.lblIntegral = new System.Windows.Forms.Label();
            this.btnCalculateValue = new System.Windows.Forms.Button();
            this.tbXValue1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnShowSymDerivativeTree = new System.Windows.Forms.Button();
            this.btnShowInfixTree = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.rbAccurate = new System.Windows.Forms.RadioButton();
            this.rbBalance = new System.Windows.Forms.RadioButton();
            this.rbFast = new System.Windows.Forms.RadioButton();
            this.lblNote = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbNPolynomial = new System.Windows.Forms.GroupBox();
            this.gbDistribution = new System.Windows.Forms.GroupBox();
            this.gbVisualization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.gbFunction.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.gbNPolynomial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(40, 25);
            this.lblPrefix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(87, 16);
            this.lblPrefix.TabIndex = 0;
            this.lblPrefix.Text = "Prefix formula";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(549, 21);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(87, 24);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(131, 22);
            this.tbPrefix.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(414, 22);
            this.tbPrefix.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(10, 646);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(731, 24);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblInfix
            // 
            this.lblInfix.AutoSize = true;
            this.lblInfix.Location = new System.Drawing.Point(50, 65);
            this.lblInfix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfix.Name = "lblInfix";
            this.lblInfix.Size = new System.Drawing.Size(77, 16);
            this.lblInfix.TabIndex = 5;
            this.lblInfix.Text = "Infix formula";
            // 
            // tbInfix
            // 
            this.tbInfix.Location = new System.Drawing.Point(131, 62);
            this.tbInfix.Margin = new System.Windows.Forms.Padding(2);
            this.tbInfix.Name = "tbInfix";
            this.tbInfix.Size = new System.Drawing.Size(414, 22);
            this.tbInfix.TabIndex = 6;
            // 
            // tbSymDerivative
            // 
            this.tbSymDerivative.Location = new System.Drawing.Point(131, 142);
            this.tbSymDerivative.Margin = new System.Windows.Forms.Padding(2);
            this.tbSymDerivative.Name = "tbSymDerivative";
            this.tbSymDerivative.Size = new System.Drawing.Size(414, 22);
            this.tbSymDerivative.TabIndex = 8;
            // 
            // lblSymDerivative
            // 
            this.lblSymDerivative.AutoSize = true;
            this.lblSymDerivative.Location = new System.Drawing.Point(9, 145);
            this.lblSymDerivative.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSymDerivative.Name = "lblSymDerivative";
            this.lblSymDerivative.Size = new System.Drawing.Size(118, 16);
            this.lblSymDerivative.TabIndex = 7;
            this.lblSymDerivative.Text = "Symbolic derivative";
            // 
            // btnCalculateNumDerivative
            // 
            this.btnCalculateNumDerivative.Enabled = false;
            this.btnCalculateNumDerivative.Location = new System.Drawing.Point(549, 181);
            this.btnCalculateNumDerivative.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateNumDerivative.Name = "btnCalculateNumDerivative";
            this.btnCalculateNumDerivative.Size = new System.Drawing.Size(87, 24);
            this.btnCalculateNumDerivative.TabIndex = 12;
            this.btnCalculateNumDerivative.Text = "Calculate";
            this.btnCalculateNumDerivative.UseVisualStyleBackColor = true;
            this.btnCalculateNumDerivative.Click += new System.EventHandler(this.BtnCalculateNumDerivative_Click);
            // 
            // tbXValue2
            // 
            this.tbXValue2.Location = new System.Drawing.Point(494, 182);
            this.tbXValue2.Margin = new System.Windows.Forms.Padding(2);
            this.tbXValue2.Name = "tbXValue2";
            this.tbXValue2.Size = new System.Drawing.Size(51, 22);
            this.tbXValue2.TabIndex = 11;
            // 
            // lblNumDerivative
            // 
            this.lblNumDerivative.AutoSize = true;
            this.lblNumDerivative.Location = new System.Drawing.Point(5, 185);
            this.lblNumDerivative.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumDerivative.Name = "lblNumDerivative";
            this.lblNumDerivative.Size = new System.Drawing.Size(122, 16);
            this.lblNumDerivative.TabIndex = 10;
            this.lblNumDerivative.Text = "Numerical derivative";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "at x =";
            // 
            // tbNumDerivative
            // 
            this.tbNumDerivative.Location = new System.Drawing.Point(131, 182);
            this.tbNumDerivative.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumDerivative.Name = "tbNumDerivative";
            this.tbNumDerivative.Size = new System.Drawing.Size(316, 22);
            this.tbNumDerivative.TabIndex = 14;
            // 
            // btnCalculateSymDerivative
            // 
            this.btnCalculateSymDerivative.Enabled = false;
            this.btnCalculateSymDerivative.Location = new System.Drawing.Point(549, 141);
            this.btnCalculateSymDerivative.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateSymDerivative.Name = "btnCalculateSymDerivative";
            this.btnCalculateSymDerivative.Size = new System.Drawing.Size(87, 24);
            this.btnCalculateSymDerivative.TabIndex = 15;
            this.btnCalculateSymDerivative.Text = "Calculate";
            this.btnCalculateSymDerivative.UseVisualStyleBackColor = true;
            this.btnCalculateSymDerivative.Click += new System.EventHandler(this.BtnCalculateSymDerivative_Click);
            // 
            // gbVisualization
            // 
            this.gbVisualization.Controls.Add(this.btnToPdf);
            this.gbVisualization.Controls.Add(this.btnToPng);
            this.gbVisualization.Controls.Add(this.pbLoading);
            this.gbVisualization.Controls.Add(this.pvVisualization);
            this.gbVisualization.Location = new System.Drawing.Point(745, 11);
            this.gbVisualization.Margin = new System.Windows.Forms.Padding(2);
            this.gbVisualization.Name = "gbVisualization";
            this.gbVisualization.Padding = new System.Windows.Forms.Padding(2);
            this.gbVisualization.Size = new System.Drawing.Size(508, 570);
            this.gbVisualization.TabIndex = 16;
            this.gbVisualization.TabStop = false;
            this.gbVisualization.Text = "Visualization";
            // 
            // btnToPdf
            // 
            this.btnToPdf.Location = new System.Drawing.Point(258, 533);
            this.btnToPdf.Name = "btnToPdf";
            this.btnToPdf.Size = new System.Drawing.Size(245, 23);
            this.btnToPdf.TabIndex = 3;
            this.btnToPdf.Text = "Export To PDF";
            this.btnToPdf.UseVisualStyleBackColor = true;
            // 
            // btnToPng
            // 
            this.btnToPng.Location = new System.Drawing.Point(5, 533);
            this.btnToPng.Name = "btnToPng";
            this.btnToPng.Size = new System.Drawing.Size(245, 23);
            this.btnToPng.TabIndex = 2;
            this.btnToPng.Text = "Export To PNG";
            this.btnToPng.UseVisualStyleBackColor = true;
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.White;
            this.pbLoading.Image = global::Calculux.Properties.Resources.infinity_loading;
            this.pbLoading.Location = new System.Drawing.Point(5, 468);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(50, 50);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 1;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // pvVisualization
            // 
            this.pvVisualization.BackColor = System.Drawing.Color.White;
            this.pvVisualization.Location = new System.Drawing.Point(6, 21);
            this.pvVisualization.Name = "pvVisualization";
            this.pvVisualization.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pvVisualization.Size = new System.Drawing.Size(497, 497);
            this.pvVisualization.TabIndex = 0;
            this.pvVisualization.Text = "Visualization";
            this.pvVisualization.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pvVisualization.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pvVisualization.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // gbFunction
            // 
            this.gbFunction.Controls.Add(this.lblPrefix);
            this.gbFunction.Controls.Add(this.btnRead);
            this.gbFunction.Controls.Add(this.tbPrefix);
            this.gbFunction.Controls.Add(this.btnShowMaclaurinTree);
            this.gbFunction.Controls.Add(this.btnCalculateMaclaurin);
            this.gbFunction.Controls.Add(this.label9);
            this.gbFunction.Controls.Add(this.tbNValue);
            this.gbFunction.Controls.Add(this.tbMaclaurin);
            this.gbFunction.Controls.Add(this.lblMaclaurin);
            this.gbFunction.Controls.Add(this.btnCalculateIntegral);
            this.gbFunction.Controls.Add(this.label2);
            this.gbFunction.Controls.Add(this.tbAValue);
            this.gbFunction.Controls.Add(this.label1);
            this.gbFunction.Controls.Add(this.tbBValue);
            this.gbFunction.Controls.Add(this.tbIntegral);
            this.gbFunction.Controls.Add(this.lblIntegral);
            this.gbFunction.Controls.Add(this.btnCalculateValue);
            this.gbFunction.Controls.Add(this.tbXValue1);
            this.gbFunction.Controls.Add(this.label6);
            this.gbFunction.Controls.Add(this.tbValue);
            this.gbFunction.Controls.Add(this.lblValue);
            this.gbFunction.Controls.Add(this.btnShowSymDerivativeTree);
            this.gbFunction.Controls.Add(this.btnShowInfixTree);
            this.gbFunction.Controls.Add(this.lblInfix);
            this.gbFunction.Controls.Add(this.lblNumDerivative);
            this.gbFunction.Controls.Add(this.tbInfix);
            this.gbFunction.Controls.Add(this.label5);
            this.gbFunction.Controls.Add(this.tbNumDerivative);
            this.gbFunction.Controls.Add(this.tbXValue2);
            this.gbFunction.Controls.Add(this.btnCalculateNumDerivative);
            this.gbFunction.Controls.Add(this.btnCalculateSymDerivative);
            this.gbFunction.Controls.Add(this.lblSymDerivative);
            this.gbFunction.Controls.Add(this.tbSymDerivative);
            this.gbFunction.Location = new System.Drawing.Point(10, 11);
            this.gbFunction.Margin = new System.Windows.Forms.Padding(2);
            this.gbFunction.Name = "gbFunction";
            this.gbFunction.Padding = new System.Windows.Forms.Padding(2);
            this.gbFunction.Size = new System.Drawing.Size(731, 311);
            this.gbFunction.TabIndex = 18;
            this.gbFunction.TabStop = false;
            this.gbFunction.Text = "Function";
            // 
            // btnRemovePoint
            // 
            this.btnRemovePoint.Location = new System.Drawing.Point(264, 93);
            this.btnRemovePoint.Name = "btnRemovePoint";
            this.btnRemovePoint.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePoint.TabIndex = 47;
            this.btnRemovePoint.Text = "Remove";
            this.btnRemovePoint.UseVisualStyleBackColor = true;
            this.btnRemovePoint.Click += new System.EventHandler(this.BtnRemovePoint_Click);
            // 
            // btnClearPoints
            // 
            this.btnClearPoints.Location = new System.Drawing.Point(264, 122);
            this.btnClearPoints.Name = "btnClearPoints";
            this.btnClearPoints.Size = new System.Drawing.Size(75, 23);
            this.btnClearPoints.TabIndex = 46;
            this.btnClearPoints.Text = "Clear";
            this.btnClearPoints.UseVisualStyleBackColor = true;
            this.btnClearPoints.Click += new System.EventHandler(this.BtnClearPoints_Click);
            // 
            // lbPoints
            // 
            this.lbPoints.FormattingEnabled = true;
            this.lbPoints.HorizontalScrollbar = true;
            this.lbPoints.ItemHeight = 16;
            this.lbPoints.Location = new System.Drawing.Point(345, 65);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(200, 100);
            this.lbPoints.TabIndex = 45;
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(264, 65);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddPoint.TabIndex = 44;
            this.btnAddPoint.Text = "Add";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.BtnAddPoint_Click);
            // 
            // tbYCoord
            // 
            this.tbYCoord.Location = new System.Drawing.Point(153, 93);
            this.tbYCoord.Name = "tbYCoord";
            this.tbYCoord.Size = new System.Drawing.Size(105, 22);
            this.tbYCoord.TabIndex = 43;
            // 
            // tbXCoord
            // 
            this.tbXCoord.Location = new System.Drawing.Point(153, 65);
            this.tbXCoord.Name = "tbXCoord";
            this.tbXCoord.Size = new System.Drawing.Size(105, 22);
            this.tbXCoord.TabIndex = 42;
            // 
            // lblYCoord
            // 
            this.lblYCoord.AutoSize = true;
            this.lblYCoord.Location = new System.Drawing.Point(128, 96);
            this.lblYCoord.Name = "lblYCoord";
            this.lblYCoord.Size = new System.Drawing.Size(19, 16);
            this.lblYCoord.TabIndex = 41;
            this.lblYCoord.Text = "y:";
            // 
            // lblXCoord
            // 
            this.lblXCoord.AutoSize = true;
            this.lblXCoord.Location = new System.Drawing.Point(128, 68);
            this.lblXCoord.Name = "lblXCoord";
            this.lblXCoord.Size = new System.Drawing.Size(19, 16);
            this.lblXCoord.TabIndex = 40;
            this.lblXCoord.Text = "x:";
            // 
            // btnShowNPolynomialTree
            // 
            this.btnShowNPolynomialTree.Enabled = false;
            this.btnShowNPolynomialTree.Location = new System.Drawing.Point(640, 23);
            this.btnShowNPolynomialTree.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowNPolynomialTree.Name = "btnShowNPolynomialTree";
            this.btnShowNPolynomialTree.Size = new System.Drawing.Size(87, 24);
            this.btnShowNPolynomialTree.TabIndex = 39;
            this.btnShowNPolynomialTree.Text = "Show Tree";
            this.btnShowNPolynomialTree.UseVisualStyleBackColor = true;
            this.btnShowNPolynomialTree.Click += new System.EventHandler(this.BtnShowNPolynomialTree_Click);
            // 
            // btnCalculateNPolynomial
            // 
            this.btnCalculateNPolynomial.Location = new System.Drawing.Point(549, 23);
            this.btnCalculateNPolynomial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateNPolynomial.Name = "btnCalculateNPolynomial";
            this.btnCalculateNPolynomial.Size = new System.Drawing.Size(87, 24);
            this.btnCalculateNPolynomial.TabIndex = 38;
            this.btnCalculateNPolynomial.Text = "Calculate";
            this.btnCalculateNPolynomial.UseVisualStyleBackColor = true;
            this.btnCalculateNPolynomial.Click += new System.EventHandler(this.BtnCalculateNPolynomial_Click);
            // 
            // tbNPolynomial
            // 
            this.tbNPolynomial.Location = new System.Drawing.Point(131, 25);
            this.tbNPolynomial.Name = "tbNPolynomial";
            this.tbNPolynomial.Size = new System.Drawing.Size(414, 22);
            this.tbNPolynomial.TabIndex = 37;
            // 
            // lblNPolynomial
            // 
            this.lblNPolynomial.AutoSize = true;
            this.lblNPolynomial.Location = new System.Drawing.Point(46, 28);
            this.lblNPolynomial.Name = "lblNPolynomial";
            this.lblNPolynomial.Size = new System.Drawing.Size(81, 16);
            this.lblNPolynomial.TabIndex = 36;
            this.lblNPolynomial.Text = "n-polynomial";
            // 
            // btnShowMaclaurinTree
            // 
            this.btnShowMaclaurinTree.Enabled = false;
            this.btnShowMaclaurinTree.Location = new System.Drawing.Point(640, 261);
            this.btnShowMaclaurinTree.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowMaclaurinTree.Name = "btnShowMaclaurinTree";
            this.btnShowMaclaurinTree.Size = new System.Drawing.Size(87, 24);
            this.btnShowMaclaurinTree.TabIndex = 35;
            this.btnShowMaclaurinTree.Text = "Show Tree";
            this.btnShowMaclaurinTree.UseVisualStyleBackColor = true;
            this.btnShowMaclaurinTree.Click += new System.EventHandler(this.BtnShowMaclaurinTree_Click);
            // 
            // btnCalculateMaclaurin
            // 
            this.btnCalculateMaclaurin.Enabled = false;
            this.btnCalculateMaclaurin.Location = new System.Drawing.Point(549, 261);
            this.btnCalculateMaclaurin.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateMaclaurin.Name = "btnCalculateMaclaurin";
            this.btnCalculateMaclaurin.Size = new System.Drawing.Size(87, 24);
            this.btnCalculateMaclaurin.TabIndex = 34;
            this.btnCalculateMaclaurin.Text = "Calculate";
            this.btnCalculateMaclaurin.UseVisualStyleBackColor = true;
            this.btnCalculateMaclaurin.Click += new System.EventHandler(this.BtnCalculateMaclaurin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 265);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "order";
            // 
            // tbNValue
            // 
            this.tbNValue.Location = new System.Drawing.Point(494, 262);
            this.tbNValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbNValue.Name = "tbNValue";
            this.tbNValue.Size = new System.Drawing.Size(51, 22);
            this.tbNValue.TabIndex = 32;
            // 
            // tbMaclaurin
            // 
            this.tbMaclaurin.Location = new System.Drawing.Point(131, 262);
            this.tbMaclaurin.Name = "tbMaclaurin";
            this.tbMaclaurin.Size = new System.Drawing.Size(317, 22);
            this.tbMaclaurin.TabIndex = 31;
            // 
            // lblMaclaurin
            // 
            this.lblMaclaurin.AutoSize = true;
            this.lblMaclaurin.Location = new System.Drawing.Point(24, 265);
            this.lblMaclaurin.Name = "lblMaclaurin";
            this.lblMaclaurin.Size = new System.Drawing.Size(103, 16);
            this.lblMaclaurin.TabIndex = 30;
            this.lblMaclaurin.Text = "Maclaurin series";
            // 
            // btnCalculateIntegral
            // 
            this.btnCalculateIntegral.Enabled = false;
            this.btnCalculateIntegral.Location = new System.Drawing.Point(549, 221);
            this.btnCalculateIntegral.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateIntegral.Name = "btnCalculateIntegral";
            this.btnCalculateIntegral.Size = new System.Drawing.Size(87, 24);
            this.btnCalculateIntegral.TabIndex = 29;
            this.btnCalculateIntegral.Text = "Calculate";
            this.btnCalculateIntegral.UseVisualStyleBackColor = true;
            this.btnCalculateIntegral.Click += new System.EventHandler(this.BtnCalculateIntegral_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "from";
            // 
            // tbAValue
            // 
            this.tbAValue.Location = new System.Drawing.Point(417, 222);
            this.tbAValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbAValue.Name = "tbAValue";
            this.tbAValue.Size = new System.Drawing.Size(50, 22);
            this.tbAValue.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "to";
            // 
            // tbBValue
            // 
            this.tbBValue.Location = new System.Drawing.Point(494, 222);
            this.tbBValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbBValue.Name = "tbBValue";
            this.tbBValue.Size = new System.Drawing.Size(51, 22);
            this.tbBValue.TabIndex = 25;
            // 
            // tbIntegral
            // 
            this.tbIntegral.Location = new System.Drawing.Point(131, 222);
            this.tbIntegral.Name = "tbIntegral";
            this.tbIntegral.Size = new System.Drawing.Size(244, 22);
            this.tbIntegral.TabIndex = 24;
            // 
            // lblIntegral
            // 
            this.lblIntegral.AutoSize = true;
            this.lblIntegral.Location = new System.Drawing.Point(22, 225);
            this.lblIntegral.Name = "lblIntegral";
            this.lblIntegral.Size = new System.Drawing.Size(105, 16);
            this.lblIntegral.TabIndex = 23;
            this.lblIntegral.Text = "Riemann integral";
            // 
            // btnCalculateValue
            // 
            this.btnCalculateValue.Enabled = false;
            this.btnCalculateValue.Location = new System.Drawing.Point(549, 101);
            this.btnCalculateValue.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateValue.Name = "btnCalculateValue";
            this.btnCalculateValue.Size = new System.Drawing.Size(87, 24);
            this.btnCalculateValue.TabIndex = 22;
            this.btnCalculateValue.Text = "Calculate";
            this.btnCalculateValue.UseVisualStyleBackColor = true;
            this.btnCalculateValue.Click += new System.EventHandler(this.BtnCalculateValue_Click);
            // 
            // tbXValue1
            // 
            this.tbXValue1.Location = new System.Drawing.Point(494, 102);
            this.tbXValue1.Margin = new System.Windows.Forms.Padding(2);
            this.tbXValue1.Name = "tbXValue1";
            this.tbXValue1.Size = new System.Drawing.Size(51, 22);
            this.tbXValue1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "at x =";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(131, 102);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(316, 22);
            this.tbValue.TabIndex = 19;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(87, 105);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(40, 16);
            this.lblValue.TabIndex = 18;
            this.lblValue.Text = "Value";
            // 
            // btnShowSymDerivativeTree
            // 
            this.btnShowSymDerivativeTree.Enabled = false;
            this.btnShowSymDerivativeTree.Location = new System.Drawing.Point(640, 141);
            this.btnShowSymDerivativeTree.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowSymDerivativeTree.Name = "btnShowSymDerivativeTree";
            this.btnShowSymDerivativeTree.Size = new System.Drawing.Size(87, 24);
            this.btnShowSymDerivativeTree.TabIndex = 17;
            this.btnShowSymDerivativeTree.Text = "Show Tree";
            this.btnShowSymDerivativeTree.UseVisualStyleBackColor = true;
            this.btnShowSymDerivativeTree.Click += new System.EventHandler(this.BtnShowSymDerivativeTree_Click);
            // 
            // btnShowInfixTree
            // 
            this.btnShowInfixTree.Enabled = false;
            this.btnShowInfixTree.Location = new System.Drawing.Point(640, 61);
            this.btnShowInfixTree.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowInfixTree.Name = "btnShowInfixTree";
            this.btnShowInfixTree.Size = new System.Drawing.Size(87, 24);
            this.btnShowInfixTree.TabIndex = 16;
            this.btnShowInfixTree.Text = "Show Tree";
            this.btnShowInfixTree.UseVisualStyleBackColor = true;
            this.btnShowInfixTree.Click += new System.EventHandler(this.BtnShowInfixTree_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.rbAccurate);
            this.gbSettings.Controls.Add(this.rbBalance);
            this.gbSettings.Controls.Add(this.rbFast);
            this.gbSettings.Controls.Add(this.lblNote);
            this.gbSettings.Controls.Add(this.label3);
            this.gbSettings.Location = new System.Drawing.Point(745, 586);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(508, 84);
            this.gbSettings.TabIndex = 19;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // rbAccurate
            // 
            this.rbAccurate.AutoSize = true;
            this.rbAccurate.Location = new System.Drawing.Point(343, 27);
            this.rbAccurate.Name = "rbAccurate";
            this.rbAccurate.Size = new System.Drawing.Size(78, 20);
            this.rbAccurate.TabIndex = 8;
            this.rbAccurate.Text = "Accurate";
            this.rbAccurate.UseVisualStyleBackColor = true;
            // 
            // rbBalance
            // 
            this.rbBalance.AutoSize = true;
            this.rbBalance.Checked = true;
            this.rbBalance.Location = new System.Drawing.Point(264, 27);
            this.rbBalance.Name = "rbBalance";
            this.rbBalance.Size = new System.Drawing.Size(73, 20);
            this.rbBalance.TabIndex = 7;
            this.rbBalance.TabStop = true;
            this.rbBalance.Text = "Balance";
            this.rbBalance.UseVisualStyleBackColor = true;
            // 
            // rbFast
            // 
            this.rbFast.AutoSize = true;
            this.rbFast.Location = new System.Drawing.Point(205, 27);
            this.rbFast.Name = "rbFast";
            this.rbFast.Size = new System.Drawing.Size(52, 20);
            this.rbFast.TabIndex = 6;
            this.rbFast.Text = "Fast";
            this.rbFast.UseVisualStyleBackColor = true;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(6, 61);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(405, 16);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Note: On Accurate mode, visualization may take long time to render.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Visualization performance mode";
            // 
            // gbNPolynomial
            // 
            this.gbNPolynomial.Controls.Add(this.lbPoints);
            this.gbNPolynomial.Controls.Add(this.tbXCoord);
            this.gbNPolynomial.Controls.Add(this.lblYCoord);
            this.gbNPolynomial.Controls.Add(this.btnRemovePoint);
            this.gbNPolynomial.Controls.Add(this.tbYCoord);
            this.gbNPolynomial.Controls.Add(this.lblXCoord);
            this.gbNPolynomial.Controls.Add(this.tbNPolynomial);
            this.gbNPolynomial.Controls.Add(this.btnAddPoint);
            this.gbNPolynomial.Controls.Add(this.btnClearPoints);
            this.gbNPolynomial.Controls.Add(this.btnShowNPolynomialTree);
            this.gbNPolynomial.Controls.Add(this.lblNPolynomial);
            this.gbNPolynomial.Controls.Add(this.btnCalculateNPolynomial);
            this.gbNPolynomial.Location = new System.Drawing.Point(10, 327);
            this.gbNPolynomial.Name = "gbNPolynomial";
            this.gbNPolynomial.Size = new System.Drawing.Size(731, 183);
            this.gbNPolynomial.TabIndex = 48;
            this.gbNPolynomial.TabStop = false;
            this.gbNPolynomial.Text = "N-Polynomial";
            // 
            // gbDistribution
            // 
            this.gbDistribution.Location = new System.Drawing.Point(10, 516);
            this.gbDistribution.Name = "gbDistribution";
            this.gbDistribution.Size = new System.Drawing.Size(731, 125);
            this.gbDistribution.TabIndex = 49;
            this.gbDistribution.TabStop = false;
            this.gbDistribution.Text = "Distribution";
            // 
            // Calculux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gbDistribution);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbNPolynomial);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbFunction);
            this.Controls.Add(this.gbVisualization);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculux";
            this.Text = "Calculux";
            this.gbVisualization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.gbFunction.ResumeLayout(false);
            this.gbFunction.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbNPolynomial.ResumeLayout(false);
            this.gbNPolynomial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblInfix;
        private System.Windows.Forms.TextBox tbInfix;
        private System.Windows.Forms.TextBox tbSymDerivative;
        private System.Windows.Forms.Label lblSymDerivative;
        private System.Windows.Forms.Button btnCalculateNumDerivative;
        private System.Windows.Forms.TextBox tbXValue2;
        private System.Windows.Forms.Label lblNumDerivative;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNumDerivative;
        private System.Windows.Forms.Button btnCalculateSymDerivative;
        private System.Windows.Forms.GroupBox gbVisualization;
        private System.Windows.Forms.GroupBox gbFunction;
        private System.Windows.Forms.Button btnShowSymDerivativeTree;
        private System.Windows.Forms.Button btnShowInfixTree;
        private OxyPlot.WindowsForms.PlotView pvVisualization;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox tbXValue1;
        private System.Windows.Forms.Button btnCalculateValue;
        private System.Windows.Forms.Button btnCalculateIntegral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBValue;
        private System.Windows.Forms.TextBox tbIntegral;
        private System.Windows.Forms.Label lblIntegral;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCalculateMaclaurin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNValue;
        private System.Windows.Forms.TextBox tbMaclaurin;
        private System.Windows.Forms.Label lblMaclaurin;
        private System.Windows.Forms.Button btnShowMaclaurinTree;
        private System.Windows.Forms.RadioButton rbAccurate;
        private System.Windows.Forms.RadioButton rbBalance;
        private System.Windows.Forms.RadioButton rbFast;
        private System.Windows.Forms.Button btnToPdf;
        private System.Windows.Forms.Button btnToPng;
        private System.Windows.Forms.Button btnShowNPolynomialTree;
        private System.Windows.Forms.Button btnCalculateNPolynomial;
        private System.Windows.Forms.TextBox tbNPolynomial;
        private System.Windows.Forms.Label lblNPolynomial;
        private System.Windows.Forms.ListBox lbPoints;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.TextBox tbYCoord;
        private System.Windows.Forms.TextBox tbXCoord;
        private System.Windows.Forms.Label lblYCoord;
        private System.Windows.Forms.Label lblXCoord;
        private System.Windows.Forms.Button btnClearPoints;
        private System.Windows.Forms.Button btnRemovePoint;
        private System.Windows.Forms.GroupBox gbNPolynomial;
        private System.Windows.Forms.GroupBox gbDistribution;
    }
}

