using Microsoft.Deployment.WindowsInstaller;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WixSharp;

namespace Installer
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var project = new Project("Scheduler-Installer",
                          new Dir(@"C:\Program Files\elecbug\scheduler",
                              new DirFiles(@"C:\Users\user\source\repos\elecbug\Scheduler\Scheduler\bin\Debug\net7.0-windows\*.*")),
                          new ManagedAction(CustomActions.MyAction));

            Compiler.BuildMsi(project);
        }
    }

    public class CustomActions
    {
        [CustomAction]
        public static ActionResult MyAction(Session session)
        {
            return ActionResult.Success;
        }
    }
}
