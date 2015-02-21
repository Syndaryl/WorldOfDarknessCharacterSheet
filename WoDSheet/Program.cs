using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Games.RPG.WoDSheet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WoDCharEditor());
            // Application.Run(new SimpleCharacter());
        }
    }
}
