using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Variable : Function {

        public override string ToString() {
            return "x";
        }

        public override double Evaluate(double x) {
            return x;
        }

        public override Function Simplify() {
            return new Variable();
        }

        public override Function Differentiate() {
            return new NaturalNumber(1);
        }

        public override string CreateTreeRecursively(ref int nodeIndex, int prevIndex) {
            var graph = $"{Environment.NewLine}\tnode{nodeIndex} [ label = \"{ToString()}\" ]";

            if (prevIndex != 0) {
                graph += $"{Environment.NewLine}\tnode{prevIndex} -- node{nodeIndex}";
            }

            nodeIndex++;

            return graph;
        }

    }
}
