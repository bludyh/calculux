using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Addition : Function {

        public Function LeftOperand { get; }
        public Function RightOperand { get; }

        public Addition(Function leftOperand, Function rightOperand) {
            LeftOperand = leftOperand;
            RightOperand = rightOperand;
        }

        public override string ToString() {
            return $"({LeftOperand} + {RightOperand})";
        }

        public override double Evaluate(double x) {
            return LeftOperand.Evaluate(x) + RightOperand.Evaluate(x);
        }

        public override Function Simplify() {
            if (LeftOperand.Simplify() is NaturalNumber n1 && n1.Evaluate(0) == 0)
                return RightOperand.Simplify();
            if (RightOperand.Simplify() is NaturalNumber n2 && n2.Evaluate(0) == 0)
                return LeftOperand.Simplify();
            return new Addition(LeftOperand.Simplify(), RightOperand.Simplify());
        }

        public override Function Differentiate() {
            return new Addition(LeftOperand.Differentiate(), RightOperand.Differentiate());
        }

        public override string CreateTreeRecursively(ref int nodeIndex, int prevIndex) {
            var graph = $"{Environment.NewLine}\tnode{nodeIndex} [ label = \"+\" ]";

            if (prevIndex != 0)
                graph += $"{Environment.NewLine}\tnode{prevIndex} -- node{nodeIndex}";

            prevIndex = nodeIndex;
            nodeIndex++;

            graph += LeftOperand.CreateTreeRecursively(ref nodeIndex, prevIndex);
            graph += RightOperand.CreateTreeRecursively(ref nodeIndex, prevIndex);

            return graph;
        }

    }
}
