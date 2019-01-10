using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    abstract class Function {

        public abstract override string ToString();

        public abstract double Evaluate(double x);

        public abstract Function Simplify();

        public abstract Function Differentiate();

        public double Differentiate(double x) {
            const double h = 1e-7;

            return (Evaluate(x + h) - Evaluate(x)) / h;
        }

        public double Integrate(double a, double b) {
            const double n = 1e7;
            var dx = (b - a) / n;
            double result = 0;

            for (var i = 0; i < n; i++) {
                result += dx * Evaluate(a + i * dx);
            }

            return result;
        }

        public Function CalculateMaclaurinSeries(int order) {
            var derivative = this;
            Function maclaurin = new RealNumber(Evaluate(0));

            for (var i = 1; i <= order; i++) {
                derivative = derivative.Differentiate();

                var difference =
                    new Multiplication(
                        new Division(new RealNumber(derivative.Evaluate(0)), new Factorial(new NaturalNumber(i))),
                        new Power(new Variable(), new NaturalNumber(i)));

                maclaurin = new Addition(maclaurin, difference);
            }

            return maclaurin;
        }

        public string CreateTree() {
            var nodeIndex = 1;
            return string.Format("graph calculux {{{0}\tnode [ fontname = \"Arial\" ]{1}{0}}}", Environment.NewLine, CreateTreeRecursively(ref nodeIndex, 0));
        }

        public abstract string CreateTreeRecursively(ref int nodeIndex, int prevIndex);

    }
}
