using OOPCourseWorkZimin23VP1.forms;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartForm form = new StartForm();
            form.Text = "��������� ����";
            Application.Run(form);
        }
    }
}