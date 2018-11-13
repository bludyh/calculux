using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Cosine : Function {

        public Function Operand { get; private set; }

        public Cosine(Function operand) {
            Operand = operand;
        }

        public override string ToString() {
            return string.Format("cos({0})", Operand.ToString());
        }

        public override string CreateGraphRecursively(ref int nodeIndex, int prevIndex = 0) {
            string graph = string.Format("{0}\tnode{1} [ label = \"cos\" ]", Environment.NewLine, nodeIndex);

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
