using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Exponentiation : Function {

        public RealNumber Base {
            get {
                return new RealNumber(Math.E);
            }
        }

        public Function Exponent { get; private set; }

        public Exponentiation(Function exponent) {
            Exponent = exponent;
        }

        public override string ToString() {
            return string.Format("exp({0})", Exponent.ToString());
        }

        public override string CreateGraphRecursively(ref int nodeIndex, int prevIndex = 0) {
            string graph = string.Format("{0}\tnode{1} [ label = \"exp\" ]", Environment.NewLine, nodeIndex);

            if (prevIndex != 0) {
                graph += string.Format("{0}\tnode{1} -- node{2}", Environment.NewLine, prevIndex, nodeIndex);
            }

            prevIndex = nodeIndex;
            nodeIndex++;
            graph += Exponent.CreateGraphRecursively(ref nodeIndex, prevIndex);

            return graph;
        }

    }
}
