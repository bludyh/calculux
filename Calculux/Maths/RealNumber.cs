using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class RealNumber : Function {

        private readonly double value;

        public RealNumber(double value) {
            this.value = value;
        }

        public override string ToString() {
            switch (value) {
                case Math.E:
                    return "e";
                case Math.PI:
                    return "\u03C0";
            }
            return value.ToString();
        }

        public override double Evaluate(double x) {
            return value;
        }

        public override Function Simplify() {
            return new RealNumber(value);
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
