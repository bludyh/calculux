using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Factorial : Function {

        public NaturalNumber Operand { get; private set; }

        public Factorial(NaturalNumber operand) {
            Operand = operand;
        }

        private int CalculateFactorial(int i) {
            if (i <= 1)
                return 1;
            return i * CalculateFactorial(i - 1);
        }

        public override string ToString() {
            return string.Format("({0})!", Operand);
        }

        public override double Evaluate(double x) {
            return CalculateFactorial(Convert.ToInt32(Operand.Evaluate(x)));
        }

        public override Function Differentiate() {
            throw new NotSupportedOperationException("Symbolic differentiation of factorial is not supported!");
        }

        public override string CreateGraphRecursively(ref int nodeIndex, int prevIndex = 0) {
            string graph = string.Format("{0}\tnode{1} [ label = \"!\" ]", Environment.NewLine, nodeIndex);

            if (prevIndex != 0) {
                graph += string.Format("{0}\tnode{1} -- node{2}", Environment.NewLine, prevIndex, nodeIndex);
            }

            prevIndex = nodeIndex;
            nodeIndex++;
            graph += Operand.CreateGraphRecursively(ref nodeIndex, prevIndex);

            return graph;
        }

    }
}
