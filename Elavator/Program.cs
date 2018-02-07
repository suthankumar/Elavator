/// <summary>
/// Sutharshan kumaravel
/// 1404884
/// Assignment 1: Control an Elevator - A C# Project
/// 10th December 2015 
/// <summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elavator
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
            Application.Run(new Lift());
        }
    }
}
