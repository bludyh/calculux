﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculux.Maths {
    class RealNumber : Function {

        public double Value { get; private set; }

        public RealNumber(double value) {
            Value = value;
        }

        public override string ToString() {
            return (Value == Math.PI) ? "\u03C0" : Value.ToString();
        }

        public override string CreateGraphRecursively(ref int nodeIndex, int prevIndex = 0) {
            string graph = string.Format("{0}\tnode{1} [ label = \"{2}\" ]", Environment.NewLine, nodeIndex, (Value == Math.PI) ? "\u03C0" : Value.ToString());

            if (prevIndex != 0) {
                graph += string.Format("{0}\tnode{1} -- node{2}", Environment.NewLine, prevIndex, nodeIndex);
            }

            nodeIndex++;

            return graph;
        }

    }
}
