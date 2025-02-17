using System.CodeDom;
using System.ComponentModel.Design;
using System.Web;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace FileworxsNewsUI
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());



        }
    }


}


