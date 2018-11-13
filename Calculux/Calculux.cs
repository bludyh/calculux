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
        }

        private void ResetForm() {
            tbPrefix.Text = string.Empty;
            tbInfix.Text = string.Empty;
            btnVisualize.Enabled = false;
        }

        private void btnRead_Click(object sender, EventArgs e) {
            try {
                if (string.IsNullOrWhiteSpace(tbPrefix.Text))
                    throw new Exception("Please enter a formula!");

                function = Parser.Parse(tbPrefix.Text);

                tbInfix.Text = function.ToString();
                btnVisualize.Enabled = true;
            }
            catch(Exception ex) {
                if (ex is FormatException || ex is InvalidOperationException || ex is NullReferenceException) 
                    MessageBox.Show("Input was not in correct prefix notation. Please check and try again!");
                else
                    MessageBox.Show(ex.Message);
                ResetForm();
            }
        }

        private void btnVisualize_Click(object sender, EventArgs e) {
            try {
                Utilities.DrawGraph("visualization", function.CreateGraph());
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                ResetForm();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            ResetForm();
        }
    }
}
