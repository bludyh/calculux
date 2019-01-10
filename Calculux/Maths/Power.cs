using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class Power : Function {

        public Function Base { get; }
        public NaturalNumber Exponent { get; }

        public Power(Function baseFunction, NaturalNumber exponent) {
            Base = baseFunction;
            Exponent = exponent;
        }

        public override string ToString() {
            return $"{Base} ^ {Exponent}";
        }

        public override double Evaluate(double x) {
            return Math.Pow(Base.Evaluate(x), Exponent.Evaluate(0));
        }

        public override Function Simplify() {
            if (Exponent.Evaluate(0) == 0)
                return new NaturalNumber(1);
            if (Exponent.Evaluate(0) == 1)
                return Base.Simplify();
            return new Power(Base.Simplify(), (NaturalNumber)Exponent.Simplify());
        }

        public override Function Differentiate() {
            return new Multiplication(new Multiplication(Exponent, new Power(Base, new NaturalNumber((int)Exponent.Evaluate(0) - 1))), Base.Differentiate());
        }

        public override string CreateTreeRecursively(ref int nodeIndex, int prevIndex) {
            var graph = $"{Environment.NewLine}\tnode{nodeIndex} [ label = \"^\" ]";

            if (prevIndex != 0) {
                graph += $"{Environment.NewLine}\tnode{prevIndex} -- node{nodeIndex}";
            }

            prevIndex = nodeIndex;
            nodeIndex++;
            graph += Base.CreateTreeRecursively(ref nodeIndex, prevIndex);
            graph += Exponent.CreateTreeRecursively(ref nodeIndex, prevIndex);

            return graph;
        }

    }
}
