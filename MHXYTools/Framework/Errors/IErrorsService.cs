using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHXYTools.Framework.Errors
{
    public interface IErrorsService
    {
        /// <summary>
        /// Installs global exception handlers to handle all common TOPS related exceptions
        /// in an expected way.
        /// </summary>
        void InstallGlobalExceptionHandler();

        /// <summary>
        /// Uninstalls global exception handlers to stop handling all common TOPS related exceptions.
        /// </summary>
        void UninstallGlobalExceptionHandler();
    }
}
