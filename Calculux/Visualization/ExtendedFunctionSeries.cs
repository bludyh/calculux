using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using OxyPlot;
using OxyPlot.Series;

namespace Calculux.Visualization {
    class ExtendedFunctionSeries : FunctionSeries {

        public ExtendedFunctionSeries(Func<double, double> f, double x0, double x1, string title = null, PerformanceMode mode = PerformanceMode.BALANCE) {
            Title = title;
            PopulateSeries(f, x0, x1, mode);
        }

        private void PopulateSeries(Func<double, double> f, double x0, double x1, PerformanceMode mode) {
            var x = x0;
            var dx = (x1 - x0) / (int)mode;
            var y = f(x);
            var isOutOfBound = double.IsInfinity(y) || double.IsNaN(y);

            for (var i = 0; i < (int)mode + 1; i++) {
                y = f(x);

                if (!isOutOfBound) {
                    if (y < x0) {
                        isOutOfBound = true;
                        Points.Add(new DataPoint(x, x0));
                        Points.Add(DataPoint.Undefined);
                    }
                    else if (y > x1) {
                        isOutOfBound = true;
                        Points.Add(new DataPoint(x, x1));
                        Points.Add(DataPoint.Undefined);
                    }
                    else if (i % ((int)mode / 100000) == 0)
                        Points.Add(new DataPoint(x, y));
                }
                else {
                    if (y >= x0 && y <= x1 && Math.Abs(y - x0) < Math.Abs(y - x1)) {
                        isOutOfBound = false;
                        Points.Add(new DataPoint(x, x0));
                    }
                    if (y >= x0 && y <= x1 && Math.Abs(y - x0) > Math.Abs(y - x1)) {
                        isOutOfBound = false;
                        Points.Add(new DataPoint(x, x1));
                    }
                }

                x += dx;
            }
        }

    }
}
