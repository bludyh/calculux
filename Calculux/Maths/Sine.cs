using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Sine : Function {

        public Function Operand { get; }

        public Sine(Function operand) {
            Operand = operand;
        }

        public override string ToString() {
            return $"sin({Operand})";
        }

        public override double Evaluate(double x) {
            return Math.Sin(Operand.Evaluate(x));
        }

        public override Function Simplify() {
            return new Sine(Operand.Simplify());
        }

        public override Function Differentiate() {
            return new Multiplication(new Cosine(Operand), Operand.Differentiate());
        }

        public override string CreateTreeRecursively(ref int nodeIndex, int prevIndex) {
            var graph = $"{Environment.NewLine}\tnode{nodeIndex} [ label = \"sin\" ]";

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
