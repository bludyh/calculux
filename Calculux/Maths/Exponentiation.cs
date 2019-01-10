using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Exponentiation : Function {

        public RealNumber Base => new RealNumber(Math.E);

        public Function Exponent { get; }

        public Exponentiation(Function exponent) {
            Exponent = exponent;
        }

        public override string ToString() {
            return $"exp({Exponent})";
        }

        public override double Evaluate(double x) {
            return Math.Exp(Exponent.Evaluate(x));
        }

        public override Function Simplify() {
            return new Exponentiation(Exponent.Simplify());
        }

        public override Function Differentiate() {
            return new Multiplication(new Exponentiation(Exponent), Exponent.Differentiate());
        }

        public override string CreateTreeRecursively(ref int nodeIndex, int prevIndex) {
            var graph = $"{Environment.NewLine}\tnode{nodeIndex} [ label = \"exp\" ]";

            if (prevIndex != 0) {
                graph += $"{Environment.NewLine}\tnode{prevIndex} -- node{nodeIndex}";
            }

            prevIndex = nodeIndex;
            nodeIndex++;
            graph += Exponent.CreateTreeRecursively(ref nodeIndex, prevIndex);

            return graph;
        }

    }
}
