using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Calculux.Maths;
using Calculux.Visualization;
using MathNet.Numerics.LinearAlgebra;

namespace Calculux {
    public partial class Calculux : Form {

        private readonly List<Task> tasks;
        private Function function;
        private Function derivative;
        private Function maclaurin;
        private Function nPolynomial;

        public Calculux() {
            InitializeComponent();
            ActiveControl = tbPrefix;

            tasks = new List<Task>();

            var model = new PlotModel {
                PlotAreaBorderColor = OxyColors.Transparent,
                PlotMargins = new OxyThickness(50, 10, 10, 40),
                PlotType = PlotType.Cartesian
            };
            model.Axes.Add(new LinearAxis {
                AbsoluteMaximum = 1000,
                AbsoluteMinimum = -1000,
                AxislineStyle = LineStyle.Solid,
                AxisTitleDistance = 10,
                Maximum = 3,
                Minimum = -3,
                MinimumRange = 0.1,
                Position = AxisPosition.Bottom,
                PositionAtZeroCrossing = true,
                Title = "x",
                TitlePosition = 0
            });
            model.Axes.Add(new LinearAxis {
                AbsoluteMaximum = 1000,
                AbsoluteMinimum = -1000,
                AxislineStyle = LineStyle.Solid,
                AxisTitleDistance = 10,
                Maximum = 3,
                Minimum = -3,
                MinimumRange = 0.1,
                Position = AxisPosition.Left,
                PositionAtZeroCrossing = true,
                Title = "y",
                TitlePosition = 0
            });
            pvVisualization.Model = model;
            pvVisualization.Model.MouseDown += PvVisualization_MouseDown;
        }

        private PerformanceMode GetVisualizationPerformanceMode() {
            var checkedButton = gbSettings.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            switch (checkedButton?.Text) {
                case "Fast":

                    return PerformanceMode.FAST;
                case "Accurate":

                    return PerformanceMode.ACCURATE;
                default:

                    return PerformanceMode.BALANCE;
            }
        }

        private void ResetForm() {
            tbPrefix.Text = string.Empty;
            tbInfix.Text = string.Empty;
            tbValue.Text = string.Empty;
            tbXValue1.Text = string.Empty;
            tbSymDerivative.Text = string.Empty;
            tbNumDerivative.Text = string.Empty;
            tbXValue2.Text = string.Empty;
            tbIntegral.Text = string.Empty;
            tbAValue.Text = string.Empty;
            tbBValue.Text = string.Empty;
            tbMaclaurin.Text = string.Empty;
            tbNValue.Text = string.Empty;
            tbNPolynomial.Text = string.Empty;
            tbXCoord.Text = string.Empty;
            tbYCoord.Text = string.Empty;
            btnRead.Enabled = true;
            btnShowInfixTree.Enabled = false;
            btnCalculateValue.Enabled = false;
            btnCalculateSymDerivative.Enabled = false;
            btnShowSymDerivativeTree.Enabled = false;
            btnCalculateNumDerivative.Enabled = false;
            btnCalculateIntegral.Enabled = false;
            btnCalculateMaclaurin.Enabled = false;
            btnShowMaclaurinTree.Enabled = false;
            btnShowNPolynomialTree.Enabled = false;
            lbPoints.Items.Clear();
            pvVisualization.Model.Series.Clear();
            pvVisualization.InvalidatePlot(true);
        }

        public void UpdateVisualization() {
            pvVisualization.InvalidatePlot(true);

            if (!tasks.All(t => t.IsCompleted)) return;

            pbLoading.Visible = false;
            tasks.Clear();
        }

        private async void BtnRead_Click(object sender, EventArgs e) {
            try {
                var input = tbPrefix.Text;

                if (string.IsNullOrWhiteSpace(input))
                    throw new Exception("Please enter a formula!");

                function = Parser.Parse(input).Simplify();

                tbInfix.Text = function.ToString();

                btnRead.Enabled = false;
                btnShowInfixTree.Enabled = true;
                btnCalculateValue.Enabled = true;
                btnCalculateSymDerivative.Enabled = true;
                btnCalculateNumDerivative.Enabled = true;
                btnCalculateIntegral.Enabled = true;
                btnCalculateMaclaurin.Enabled = true;
                pbLoading.Visible = true;

                var performanceMode = GetVisualizationPerformanceMode();
                var task = Task.Run(() =>
                    pvVisualization.Model.Series.Add(new ExtendedFunctionSeries(function.Evaluate, -1000, 1000, "f(x)",
                        performanceMode)));
                tasks.Add(task);

                await task;
                UpdateVisualization();
            }
            catch (Exception ex) {
                if (ex is FormatException || ex is InvalidOperationException || ex is NullReferenceException) 
                    MessageBox.Show("Input was not in correct prefix notation. Please check and try again!");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e) {
            ResetForm();
            tasks.Clear();
        }

        private void BtnShowInfixTree_Click(object sender, EventArgs e) {
            try {
                Utilities.ShowTree(function);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnCalculateValue_Click(object sender, EventArgs e) {
            try {
                var input = tbXValue1.Text;

                var (x, result) = await Parser.ParseAndEvaluate(input, function.Evaluate);

                tbValue.Text = result.ToString();

                pbLoading.Visible = true;

                var task = Task.Run(() => {
                    var lineSeries = new LineSeries {
                        MarkerType = MarkerType.Circle,
                        Title = $"f({ x })"
                    };

                    lineSeries.Points.Add(new DataPoint(x.Evaluate(0), result));

                    pvVisualization.Model.Series.Add(lineSeries);
                });
                tasks.Add(task);

                await task;
                UpdateVisualization();
            }
            catch (Exception ex) {
                if (ex is FormatException || ex is InvalidOperationException || ex is NullReferenceException) 
                    MessageBox.Show("Input was not in correct prefix notation. Please check and try again!");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private async void BtnCalculateSymDerivative_Click(object sender, EventArgs e) {
            try {
                derivative = function.Differentiate().Simplify();

                tbSymDerivative.Text = derivative.ToString();

                btnCalculateSymDerivative.Enabled = false;
                btnShowSymDerivativeTree.Enabled = true;
                pbLoading.Visible = true;

                var performanceMode = GetVisualizationPerformanceMode();
                var task = Task.Run(() =>
                    pvVisualization.Model.Series.Add(new ExtendedFunctionSeries(derivative.Evaluate, -1000, 1000,
                        "f'(x)", performanceMode)));
                tasks.Add(task);

                await task;
                UpdateVisualization();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowSymDerivativeTree_Click(object sender, EventArgs e) {
            try {
                Utilities.ShowTree(derivative);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnCalculateNumDerivative_Click(object sender, EventArgs e) {
            try {
                var input = tbXValue2.Text;

                var (x, result) = await Parser.ParseAndEvaluate(input, function.Differentiate);

                tbNumDerivative.Text = result.ToString();

                pbLoading.Visible = true;

                var task = Task.Run(()=> {
                    var lineSeries = new LineSeries {
                        MarkerType = MarkerType.Circle,
                        Title = $"f'({ x })"
                    };
                    lineSeries.Points.Add(new DataPoint(x.Evaluate(0), result));

                    pvVisualization.Model.Series.Add(lineSeries);
                });
                tasks.Add(task);

                await task;
                UpdateVisualization();
            }
            catch (Exception ex) {
                if (ex is FormatException || ex is InvalidOperationException || ex is NullReferenceException) 
                    MessageBox.Show("Input was not in correct prefix notation. Please check and try again!");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private async void BtnCalculateIntegral_Click(object sender, EventArgs e) {
            try {
                var input1 = tbAValue.Text;
                var input2 = tbBValue.Text;

                var (a, b, result) = await Parser.ParseAndEvaluate(input1, input2, function.Integrate);

                tbIntegral.Text = result.ToString();

                pbLoading.Visible = true;

                var task = Task.Run(() => {
                    var areaSeries = new AreaSeries {
                        Color2 = OxyColors.Transparent,
                        Title = $"\u222Bf(x)dx"
                    };
                    for (var x = a.Evaluate(0); x <= b.Evaluate(0); x += 0.001) {
                        areaSeries.Points.Add(new DataPoint(x, function.Evaluate(x)));
                    }

                    pvVisualization.Model.Series.Add(areaSeries);
                });

                await task;
                UpdateVisualization();
            }
            catch (Exception ex) {
                if (ex is FormatException || ex is InvalidOperationException || ex is NullReferenceException) 
                    MessageBox.Show("Input was not in correct prefix notation. Please check and try again!");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private async void BtnCalculateMaclaurin_Click(object sender, EventArgs e) {
            try {
                var input = tbNValue.Text;

                if (!int.TryParse(input, out var n) || n < 0)
                    throw new Exception("Order can only be a positive integer!");

                maclaurin = function.CalculateMaclaurinSeries(n).Simplify();
                tbMaclaurin.Text = maclaurin.ToString();

                btnShowMaclaurinTree.Enabled = true;
                pbLoading.Visible = true;

                var performanceMode = GetVisualizationPerformanceMode();
                var task = Task.Run(() =>
                    pvVisualization.Model.Series.Add(new ExtendedFunctionSeries(maclaurin.Evaluate, -1000, 1000, "m(x)",
                        performanceMode)));
                tasks.Add(task);

                await task;
                UpdateVisualization();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowMaclaurinTree_Click(object sender, EventArgs e) {
            try {
                Utilities.ShowTree(maclaurin);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void PvVisualization_MouseDown(object sender, OxyMouseDownEventArgs e) {
            if (e.ChangedButton != OxyMouseButton.Left) return;

            var xAxis = pvVisualization.Model.Axes.FirstOrDefault(a => a.Position == AxisPosition.Bottom);
            var yAxis = pvVisualization.Model.Axes.FirstOrDefault(a => a.Position == AxisPosition.Left);
            var point = Axis.InverseTransform(e.Position, xAxis, yAxis);

            tbXCoord.Text = point.X.ToString();
            tbYCoord.Text = point.Y.ToString();
        }

        private async void BtnCalculateNPolynomial_Click(object sender, EventArgs e) {
            try {
                var points = lbPoints.Items.Cast<DataPoint>().ToList();

                if (points.Count == 0)
                    throw new Exception("Please add points!");

                var matrixAData = new List<List<double>>();
                var vectorBData = new List<double>();

                foreach (var point in points) {
                    var row = new List<double>();

                    for (var j = points.Count - 1; j >= 0; j--)
                        row.Add(Math.Pow(point.X, j));

                    matrixAData.Add(row);
                    vectorBData.Add(point.Y);
                }

                var matrixA = Matrix<double>.Build.DenseOfRows(matrixAData);
                var vectorB = Vector<double>.Build.DenseOfEnumerable(vectorBData);
                var coefficients = matrixA.Solve(vectorB).ToArray();

                nPolynomial = new NaturalNumber(0);
                for (var i = coefficients.Length - 1; i >= 0; i--) {
                    var coefficient = coefficients[i];
                    var degree = coefficients.Length - 1 - i;
                    nPolynomial =
                        new Addition(
                            new Multiplication(new RealNumber(coefficient),
                                new Power(new Variable(), new NaturalNumber(degree))), nPolynomial);
                }

                nPolynomial = nPolynomial.Simplify();
                tbNPolynomial.Text = nPolynomial.ToString();

                btnShowNPolynomialTree.Enabled = true;
                pbLoading.Visible = true;

                var performanceMode = GetVisualizationPerformanceMode();
                var task = Task.Run(() =>
                    pvVisualization.Model.Series.Add(new ExtendedFunctionSeries(nPolynomial.Evaluate, -1000, 1000, "n(x)",
                        performanceMode)));
                tasks.Add(task);

                await task;
                UpdateVisualization();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowNPolynomialTree_Click(object sender, EventArgs e) {
            try {
                Utilities.ShowTree(nPolynomial);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnAddPoint_Click(object sender, EventArgs e) {
            try {
                var inputX = tbXCoord.Text;
                var inputY = tbYCoord.Text;

                if (!double.TryParse(inputX, out var x) || !double.TryParse(inputY, out var y))
                    throw new Exception("Please select a point to add!");

                var point = new DataPoint(x, y);
                lbPoints.Items.Add(point);

                pbLoading.Visible = true;

                var task = Task.Run(() => {
                    var lineSeries = new LineSeries {
                        MarkerType = MarkerType.Circle,
                        Title = $"n({ x })"
                    };

                    lineSeries.Points.Add(point);

                    pvVisualization.Model.Series.Add(lineSeries);
                });
                tasks.Add(task);

                await task;
                UpdateVisualization();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRemovePoint_Click(object sender, EventArgs e) {
            if (lbPoints.SelectedIndex == -1) return;

            lbPoints.Items.Remove(lbPoints.SelectedItem);
        }

        private void BtnClearPoints_Click(object sender, EventArgs e) {
            lbPoints.Items.Clear();
        }

    }
}
