using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace MHXYTools.Framework.Errors
{
    class ErrorsService : IErrorsService
    {
        public void InstallGlobalExceptionHandler()
        {
            Application.Current.DispatcherUnhandledException += GlobalUnhandledDispatcherExceptionHandler;
            AppDomain.CurrentDomain.UnhandledException += GlobalUnhandledExceptionHandler;
        }

        private void GlobalUnhandledDispatcherExceptionHandler(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;

            GlobalExceptionHandler(e.Exception);
        }

        private void GlobalUnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            GlobalExceptionHandler((Exception)e.ExceptionObject);
        }

        public void UninstallGlobalExceptionHandler()
        {
            AppDomain.CurrentDomain.UnhandledException -= GlobalUnhandledExceptionHandler;
            Application.Current.DispatcherUnhandledException -= GlobalUnhandledDispatcherExceptionHandler;
        }

        private void GlobalExceptionHandler(Exception e)
        {
            string s = e.ToString();
            File.WriteAllText("exception2.txt", e.ToString() + "\nStackTrace:\n" + e.StackTrace);
            Application.Current.Shutdown();
        }
    }
}
