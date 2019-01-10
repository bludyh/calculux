using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class NaturalNumber : Function {

        private readonly int value;

        public NaturalNumber(int value) {
            this.value = value;
        }

        public override string ToString() {
            return value.ToString();
        }

        public override double Evaluate(double x) {
            return value;
        }

        public override Function Simplify() {
            return new NaturalNumber(value);
        }

        public override Function Differentiate() {
            return new NaturalNumber(0);
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
