using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    abstract class Function {

        public abstract override string ToString();

        public abstract double Evaluate(double x);

        public abstract Function Differentiate();

        public double DifferentiateAtPoint(double x) {
            double h = 1e-7;
            return (Evaluate(x + h) - Evaluate(x)) / h;
        }

        public string CreateGraph() {
            int nodeIndex = 1;
            return string.Format("graph calculux {{{0}\tnode [ fontname = \"Arial\" ]{1}{0}}}", Environment.NewLine, CreateGraphRecursively(ref nodeIndex));
        }

        public abstract string CreateGraphRecursively(ref int nodeIndex, int prevIndex = 0);

    }
}
