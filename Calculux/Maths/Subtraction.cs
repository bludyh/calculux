using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Subtraction : Function {

        public Function LeftOperand { get; }
        public Function RightOperand { get; }

        public Subtraction(Function leftOperand, Function rightOperand) {
            LeftOperand = leftOperand;
            RightOperand = rightOperand;
        }

        public override string ToString() {
            return $"({LeftOperand} - {RightOperand})";
        }

        public override double Evaluate(double x) {
            return LeftOperand.Evaluate(x) - RightOperand.Evaluate(x);
        }

        public override Function Simplify() {
            if (RightOperand.Simplify() is NaturalNumber n2 && n2.Evaluate(0) == 0)
                return LeftOperand.Simplify();
            if (LeftOperand.Simplify() is NaturalNumber n1 && n1.Evaluate(0) == 0)
                return new Negation(RightOperand.Simplify());
            return new Subtraction(LeftOperand.Simplify(), RightOperand.Simplify());
        }

        public override Function Differentiate() {
            return new Subtraction(LeftOperand.Differentiate(), RightOperand.Differentiate());
        }

        public override string CreateTreeRecursively(ref int nodeIndex, int prevIndex) {
            var graph = $"{Environment.NewLine}\tnode{nodeIndex} [ label = \"-\" ]";

            if (prevIndex != 0) {
                graph += $"{Environment.NewLine}\tnode{prevIndex} -- node{nodeIndex}";
            }

            prevIndex = nodeIndex;
            nodeIndex++;
            graph += LeftOperand.CreateTreeRecursively(ref nodeIndex, prevIndex);
            graph += RightOperand.CreateTreeRecursively(ref nodeIndex, prevIndex);

            return graph;
        }

    }
}
