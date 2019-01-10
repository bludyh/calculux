using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Calculux.Maths;

namespace Calculux {
    static class Utilities {

        public static void ShowTree(Function function) {
            File.WriteAllText("tree.dot", function.CreateTree());

            var dot = new Process();
            dot.StartInfo.FileName = "dot.exe";
            dot.StartInfo.Arguments = "-Tpng -Gdpi=300 -otree.png tree.dot";
            dot.Start();
            dot.WaitForExit();

            Process.Start("tree.png");
        }

    }
}
