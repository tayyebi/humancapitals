using App.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        static public Dependencies dependencies = new Dependencies();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, args) => MyException(sender, args.ExceptionObject as Exception);
            Application.ThreadException += (sender, args) => MyException(sender, args.Exception);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!Debugger.IsAttached)
                new Splash().ShowDialog();
            Application.Run(new Intro());
        }

        private static void MyException(object sender, Exception exception)
        {
            while (!Debugger.IsAttached
                && MessageBox.Show(exception.Message, "Show inner exception?", MessageBoxButtons.YesNo) == DialogResult.Yes
                && exception.InnerException != null
                )
                exception = exception.InnerException;

        }
    }
}
