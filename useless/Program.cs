using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleHttp;
using System.Threading;

namespace useless
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Route.Add("/", (req, res, props) =>
            {
                res.AsText("Welcome to the Simple Http Server");
            });

            Route.Add("/users/{id}", (req, res, props) =>
            {
                res.AsText($"You have requested user #{props["id"]}");
            }, "POST");

            Route.Add("/header", (req, res, props) =>
            {
                res.AsText($"Value of my-header is: {req.Headers["my-header"]}");
            });

            HttpServer.ListenAsync(
                    1337,
                    CancellationToken.None,
                    Route.OnHttpRequestAsync
                )
                .Wait();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
