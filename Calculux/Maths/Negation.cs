using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Negation : Function {

        public Function Operand { get; private set; }

        public Negation(Function operand) {
            Operand = operand;
        }

        public override string ToString() {
            return string.Format("-{0}", Operand);
        }

        public override double Evaluate(double x) {
            return -Operand.Evaluate(x);
        }

        public override Function Differentiate() {
            return new Negation(Operand.Differentiate());
        }

        public override string CreateGraphRecursively(ref int nodeIndex, int prevIndex = 0) {
            string graph = string.Format("{0}\tnode{1} [ label = \"-\" ]", Environment.NewLine, nodeIndex);

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
