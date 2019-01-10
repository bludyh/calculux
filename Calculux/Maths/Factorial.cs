using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Factorial : Function {

        public NaturalNumber Operand { get; }

        public Factorial(NaturalNumber operand) {
            Operand = operand;
        }

        private int CalculateFactorial(int i) {
            if (i <= 1)
                return 1;
            return i * CalculateFactorial(i - 1);
        }

        public override string ToString() {
            return $"{Operand}!";
        }

        public override double Evaluate(double x) {
            return CalculateFactorial((int)Operand.Evaluate(0));
        }

        public override Function Simplify() {
            return new Factorial((NaturalNumber)Operand.Simplify());
        }

        public override Function Differentiate() {
            return new NaturalNumber(0);
        }

        public override string CreateTreeRecursively(ref int nodeIndex, int prevIndex) {
            var graph = $"{Environment.NewLine}\tnode{nodeIndex} [ label = \"!\" ]";

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
