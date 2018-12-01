using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculux.Maths;

namespace Calculux {
    public partial class Calculux : Form {

        private Function function;

        public Calculux() {
            InitializeComponent();
            ActiveControl = tbPrefix;
        }

        private void ResetForm() {
            tbPrefix.Text = string.Empty;
            tbInfix.Text = string.Empty;
            tbSymDerivative.Text = string.Empty;
            tbNumDerivative.Text = string.Empty;
            tbXValue.Text = string.Empty;
            btnVisualizeTree.Enabled = false;
            btnCalculateSymDerivative.Enabled = false;
            btnVisualizeSymDerivative.Enabled = false;
            btnCalculateNumDerivative.Enabled = false;
        }

        private void BtnRead_Click(object sender, EventArgs e) {
            try {
                if (string.IsNullOrWhiteSpace(tbPrefix.Text))
                    throw new Exception("Please enter a formula!");

                function = Parser.Parse(tbPrefix.Text);

                tbInfix.Text = function.ToString();

                btnVisualizeTree.Enabled = true;
                btnCalculateSymDerivative.Enabled = true;
                btnCalculateNumDerivative.Enabled = true;
            }
            catch(Exception ex) {
                if (ex is FormatException || ex is InvalidOperationException || ex is NullReferenceException) 
                    MessageBox.Show("Input was not in correct prefix notation. Please check and try again!");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void BtnVisualizeTree_Click(object sender, EventArgs e) {
            try {
                Utilities.DrawGraph("tree", function.CreateGraph());
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            ResetForm();
        }

        private void BtnVisualizeSymDerivative_Click(object sender, EventArgs e) {
            try {
                Utilities.DrawGraph("derivative", function.Differentiate().CreateGraph());
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCalculateNumDerivative_Click(object sender, EventArgs e) {
            try {
                if (string.IsNullOrWhiteSpace(tbXValue.Text))
                    throw new Exception("Please enter a value for x!");

                tbNumDerivative.Text = function.DifferentiateAtPoint(Convert.ToDouble(tbXValue.Text)).ToString();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCalculateSymDerivative_Click(object sender, EventArgs e) {
            try {
                tbSymDerivative.Text = function.Differentiate().ToString();

                btnVisualizeSymDerivative.Enabled = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
