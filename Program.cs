using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VIMS
{
    static class Program
    {
        public static string UserName = "";
        public static int LoginID = 0;
        public static bool LogType = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //public class SomeGlobalVariables
        //{
        //    public static string  username = "";

        //}

        //public static SomeGlobalVariables LogUserG = new SomeGlobalVariables();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
