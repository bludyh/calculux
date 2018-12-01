using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Sine : Function {

        public Function Operand { get; private set; }

        public Sine(Function operand) {
            Operand = operand;
        }

        public override string ToString() {
            return string.Format("sin({0})", Operand.ToString());
        }

        public override double Evaluate(double x) {
            return Math.Sin(Operand.Evaluate(x));
        }

        public override Function Differentiate() {
            return new Multiplication(new Cosine(Operand), Operand.Differentiate());
        }

        public override string CreateGraphRecursively(ref int nodeIndex, int prevIndex = 0) {
            string graph = string.Format("{0}\tnode{1} [ label = \"sin\" ]", Environment.NewLine, nodeIndex);

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
