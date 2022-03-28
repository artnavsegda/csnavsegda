using GenHTTP.Engine;

using GenHTTP.Modules.IO;
using GenHTTP.Modules.Practices;

namespace avia
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

            var content = Content.From(Resource.FromString("Hello World!"));

            Host.Create()
               .Console()
               .Defaults()
               .Handler(content)
               .Run();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}