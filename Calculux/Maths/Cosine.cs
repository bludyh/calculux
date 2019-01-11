using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Cosine : Function {

        public Function Operand { get; }

        public Cosine(Function operand) {
            Operand = operand;
        }

        public override string ToString() {
            return $"cos({Operand})";
        }

        public override double Evaluate(double x) {
            return Math.Cos(Operand.Evaluate(x));
        }

        public override Function Simplify() {
            return new Cosine(Operand.Simplify());
        }

        public override Function Differentiate() {
            return new Multiplication(new Negation(new Sine(Operand)), Operand.Differentiate());
        }

        public override string CreateTreeRecursively(ref int nodeIndex, int prevIndex) {
            var graph = $"{Environment.NewLine}\tnode{nodeIndex} [ label = \"cos\" ]";

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
