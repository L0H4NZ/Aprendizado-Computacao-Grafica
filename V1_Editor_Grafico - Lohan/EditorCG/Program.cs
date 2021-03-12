using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EditorCG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            float[,] A = {
            {1, 2, 1},
            {3, 2, 4}
        };

            float[,] B = {
            {2, 4, 2, 1},
            {1, 5, 3, 3},
            {1, 1, 6, 2}
        };

            float[,] C = CgUtils.mult(A, B);

            CgUtils.show(C);
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
