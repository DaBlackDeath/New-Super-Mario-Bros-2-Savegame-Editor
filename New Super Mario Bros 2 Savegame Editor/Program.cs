using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace New_Super_Mario_Bros_2_Savegame_Editor
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NSMB2_SGE());
        }
    }
}
