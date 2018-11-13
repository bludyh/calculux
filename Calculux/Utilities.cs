using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Calculux {
    static class Utilities {

        public static void DrawGraph(string name, string graph) {
            File.WriteAllText(string.Format("{0}.dot", name), graph);

            Process dot = new Process();
            dot.StartInfo.FileName = "dot.exe";
            dot.StartInfo.Arguments = string.Format("-Tpng -o{0}.png {0}.dot", name);
            dot.Start();
            dot.WaitForExit();

            Process.Start(string.Format("{0}.png", name));
        }

    }
}
