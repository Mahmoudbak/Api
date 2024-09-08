using finalCS.Data;
using Microsoft.EntityFrameworkCore;

namespace finalCS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MyDbContext myDBContext = new MyDbContext();
            myDBContext.Database.EnsureCreated();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainDashboard());
        }
    }
}