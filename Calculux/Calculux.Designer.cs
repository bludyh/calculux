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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.btnVisualizeTree = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInfix = new System.Windows.Forms.TextBox();
            this.tbSymDerivative = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVisualizeSymDerivative = new System.Windows.Forms.Button();
            this.btnCalculateNumDerivative = new System.Windows.Forms.Button();
            this.tbXValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNumDerivative = new System.Windows.Forms.TextBox();
            this.btnCalculateSymDerivative = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prefix formula";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(766, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(100, 25);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(157, 12);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(603, 25);
            this.tbPrefix.TabIndex = 2;
            // 
            // btnVisualizeTree
            // 
            this.btnVisualizeTree.Enabled = false;
            this.btnVisualizeTree.Location = new System.Drawing.Point(766, 62);
            this.btnVisualizeTree.Name = "btnVisualizeTree";
            this.btnVisualizeTree.Size = new System.Drawing.Size(100, 25);
            this.btnVisualizeTree.TabIndex = 3;
            this.btnVisualizeTree.Text = "Visualize";
            this.btnVisualizeTree.UseVisualStyleBackColor = true;
            this.btnVisualizeTree.Click += new System.EventHandler(this.BtnVisualizeTree_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(872, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 25);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Infix formula";
            // 
            // tbInfix
            // 
            this.tbInfix.Location = new System.Drawing.Point(157, 62);
            this.tbInfix.Name = "tbInfix";
            this.tbInfix.Size = new System.Drawing.Size(603, 25);
            this.tbInfix.TabIndex = 6;
            // 
            // tbSymDerivative
            // 
            this.tbSymDerivative.Location = new System.Drawing.Point(157, 112);
            this.tbSymDerivative.Name = "tbSymDerivative";
            this.tbSymDerivative.Size = new System.Drawing.Size(603, 25);
            this.tbSymDerivative.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Symbolic derivative";
            // 
            // btnVisualizeSymDerivative
            // 
            this.btnVisualizeSymDerivative.Enabled = false;
            this.btnVisualizeSymDerivative.Location = new System.Drawing.Point(872, 112);
            this.btnVisualizeSymDerivative.Name = "btnVisualizeSymDerivative";
            this.btnVisualizeSymDerivative.Size = new System.Drawing.Size(100, 25);
            this.btnVisualizeSymDerivative.TabIndex = 9;
            this.btnVisualizeSymDerivative.Text = "Visualize";
            this.btnVisualizeSymDerivative.UseVisualStyleBackColor = true;
            this.btnVisualizeSymDerivative.Click += new System.EventHandler(this.BtnVisualizeSymDerivative_Click);
            // 
            // btnCalculateNumDerivative
            // 
            this.btnCalculateNumDerivative.Enabled = false;
            this.btnCalculateNumDerivative.Location = new System.Drawing.Point(766, 162);
            this.btnCalculateNumDerivative.Name = "btnCalculateNumDerivative";
            this.btnCalculateNumDerivative.Size = new System.Drawing.Size(100, 25);
            this.btnCalculateNumDerivative.TabIndex = 12;
            this.btnCalculateNumDerivative.Text = "Calculate";
            this.btnCalculateNumDerivative.UseVisualStyleBackColor = true;
            this.btnCalculateNumDerivative.Click += new System.EventHandler(this.BtnCalculateNumDerivative_Click);
            // 
            // tbXValue
            // 
            this.tbXValue.Location = new System.Drawing.Point(639, 162);
            this.tbXValue.Name = "tbXValue";
            this.tbXValue.Size = new System.Drawing.Size(121, 25);
            this.tbXValue.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numerical derivative";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "at x =";
            // 
            // tbNumDerivative
            // 
            this.tbNumDerivative.Location = new System.Drawing.Point(157, 162);
            this.tbNumDerivative.Name = "tbNumDerivative";
            this.tbNumDerivative.Size = new System.Drawing.Size(426, 25);
            this.tbNumDerivative.TabIndex = 14;
            // 
            // btnCalculateSymDerivative
            // 
            this.btnCalculateSymDerivative.Enabled = false;
            this.btnCalculateSymDerivative.Location = new System.Drawing.Point(766, 112);
            this.btnCalculateSymDerivative.Name = "btnCalculateSymDerivative";
            this.btnCalculateSymDerivative.Size = new System.Drawing.Size(100, 25);
            this.btnCalculateSymDerivative.TabIndex = 15;
            this.btnCalculateSymDerivative.Text = "Calculate";
            this.btnCalculateSymDerivative.UseVisualStyleBackColor = true;
            this.btnCalculateSymDerivative.Click += new System.EventHandler(this.BtnCalculateSymDerivative_Click);
            // 
            // Calculux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 211);
            this.Controls.Add(this.btnCalculateSymDerivative);
            this.Controls.Add(this.tbNumDerivative);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculateNumDerivative);
            this.Controls.Add(this.tbXValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVisualizeSymDerivative);
            this.Controls.Add(this.tbSymDerivative);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInfix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVisualizeTree);
            this.Controls.Add(this.tbPrefix);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calculux";
            this.Text = "Calculux";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.Button btnVisualizeTree;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInfix;
        private System.Windows.Forms.TextBox tbSymDerivative;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVisualizeSymDerivative;
        private System.Windows.Forms.Button btnCalculateNumDerivative;
        private System.Windows.Forms.TextBox tbXValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNumDerivative;
        private System.Windows.Forms.Button btnCalculateSymDerivative;
    }
}

