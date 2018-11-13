using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Division : Function {

        public Function LeftOperand { get; private set; }
        public Function RightOperand { get; private set; }

        public Division(Function leftOperand, Function rightOperand) {
            LeftOperand = leftOperand;
            RightOperand = rightOperand;
        }

        public override string ToString() {
            return string.Format("({0} / {1})", LeftOperand.ToString(), RightOperand.ToString());
        }

        public override string CreateGraphRecursively(ref int nodeIndex, int prevIndex) {
            string graph = string.Format("{0}\tnode{1} [ label = \"/\" ]", Environment.NewLine, nodeIndex);

            if (prevIndex != 0) {
                graph += string.Format("{0}\tnode{1} -- node{2}", Environment.NewLine, prevIndex, nodeIndex);
            }

            prevIndex = nodeIndex;
            nodeIndex++;
            graph += LeftOperand.CreateGraphRecursively(ref nodeIndex, prevIndex);
            graph += RightOperand.CreateGraphRecursively(ref nodeIndex, prevIndex);

            return graph;
        }

    }
}
