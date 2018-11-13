using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Power : Function {

        public Function Base { get; private set; }
        public Function Exponent { get; private set; }

        public Power(Function baseFunction, Function exponent) {
            Base = baseFunction;
            Exponent = exponent;
        }

        public override string ToString() {
            return string.Format("({0} ^ {1})", Base.ToString(), Exponent.ToString());
        }

        public override string CreateGraphRecursively(ref int nodeIndex, int prevIndex = 0) {
            string graph = string.Format("{0}\tnode{1} [ label = \"^\" ]", Environment.NewLine, nodeIndex);

            if (prevIndex != 0) {
                graph += string.Format("{0}\tnode{1} -- node{2}", Environment.NewLine, prevIndex, nodeIndex);
            }

            prevIndex = nodeIndex;
            nodeIndex++;
            graph += Base.CreateGraphRecursively(ref nodeIndex, prevIndex);
            graph += Exponent.CreateGraphRecursively(ref nodeIndex, prevIndex);

            return graph;
        }

    }
}
