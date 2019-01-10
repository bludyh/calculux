using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class NaturalLogarithm : Function {

        public RealNumber Base => new RealNumber(Math.E);

        public Function Operand { get; }

        public NaturalLogarithm(Function operand) {
            Operand = operand;
        }

        public override string ToString() {
            return $"ln({Operand})";
        }

        public override double Evaluate(double x) {
            return Math.Log(Operand.Evaluate(x));
        }

        public override Function Simplify() {
            return new NaturalLogarithm(Operand.Simplify());
        }

        public override Function Differentiate() {
            return new Division(Operand.Differentiate(), Operand);
        }

        public override string CreateTreeRecursively(ref int nodeIndex, int prevIndex) {
            var graph = $"{Environment.NewLine}\tnode{nodeIndex} [ label = \"ln\" ]";

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
