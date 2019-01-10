using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Negation : Function {

        public Function Operand { get; }

        public Negation(Function operand) {
            Operand = operand;
        }

        public override string ToString() {
            return $"-{Operand}";
        }

        public override double Evaluate(double x) {
            return -Operand.Evaluate(x);
        }

        public override Function Simplify() {
            if (Operand.Simplify() is NaturalNumber n && n.Evaluate(0) == 0)
                return new NaturalNumber(0);
            return new Negation(Operand.Simplify());
        }

        public override Function Differentiate() {
            return new Negation(Operand.Differentiate());
        }

        public override string CreateTreeRecursively(ref int nodeIndex, int prevIndex) {
            var graph = $"{Environment.NewLine}\tnode{nodeIndex} [ label = \"-\" ]";

            if (prevIndex != 0) {
                graph += $"{Environment.NewLine}\tnode{prevIndex} -- node{nodeIndex}";
            }

            prevIndex = nodeIndex;
            nodeIndex++;
            graph += Operand.CreateTreeRecursively(ref nodeIndex, prevIndex);

            return graph;
        }

    }
}
