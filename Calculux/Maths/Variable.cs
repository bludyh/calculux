using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Variable : Function {

        public char Letter { get; private set; }

        public Variable(char letter) {
            Letter = letter;
        }

        public override string ToString() {
            return Letter.ToString();
        }

        public override double Evaluate(double x) {
            return x;
        }

        public override Function Differentiate() {
            return new NaturalNumber(1);
        }

        public override string CreateGraphRecursively(ref int nodeIndex, int prevIndex = 0) {
            string graph = string.Format("{0}\tnode{1} [ label = \"{2}\" ]", Environment.NewLine, nodeIndex, Letter);

            if (prevIndex != 0) {
                graph += string.Format("{0}\tnode{1} -- node{2}", Environment.NewLine, prevIndex, nodeIndex);
            }

            nodeIndex++;

            return graph;
        }

    }
}
