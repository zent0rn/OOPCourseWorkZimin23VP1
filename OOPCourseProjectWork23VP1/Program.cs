using OOPCourseWorkZimin23VP1.dbServices;
using OOPCourseWorkZimin23VP1.forms;
using System;



namespace OOPCourseProjectWork23VP1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


            StartWindowForm startForm = new StartWindowForm();
            Application.Run(startForm);

            
        }
        

    }


}