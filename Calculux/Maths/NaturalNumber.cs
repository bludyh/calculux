using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class NaturalNumber : Function {

        public int Value { get; private set; }

        public NaturalNumber(int value) {
            Value = value;
        }

        public override string ToString() {
            return Value.ToString();
        }

        public override double Evaluate(double x) {
            return Value;
        }

        public override Function Differentiate() {
            return new NaturalNumber(0);
        }

        public override string CreateGraphRecursively(ref int nodeIndex, int prevIndex = 0) {
            string graph = string.Format("{0}\tnode{1} [ label = \"{2}\" ]", Environment.NewLine, nodeIndex, Value);

            if (prevIndex != 0) {
                graph += string.Format("{0}\tnode{1} -- node{2}", Environment.NewLine, prevIndex, nodeIndex);
            }

            nodeIndex++;

            return graph;
        }

    }
}
