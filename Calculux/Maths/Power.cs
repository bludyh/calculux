using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Power : Function {

        public Function Base { get; private set; }
        public NaturalNumber Exponent { get; private set; }

        public Power(Function baseFunction, NaturalNumber exponent) {
            Base = baseFunction;
            Exponent = exponent;
        }

        public override string ToString() {
            return string.Format("{0} ^ {1}", Base.ToString(), Exponent.ToString());
        }

        public override double Evaluate(double x) {
            return Math.Pow(Base.Evaluate(x), Exponent.Evaluate(x));
        }

        public override Function Differentiate() {
            return new Multiplication(new Multiplication(Exponent, new Power(Base, new NaturalNumber(Exponent.Value - 1))), Base.Differentiate());
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
