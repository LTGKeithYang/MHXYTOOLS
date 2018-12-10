using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;
using Autofac;
using Caliburn.Micro;
using MHXYTools.Framework.Errors;

namespace MHXYTools.BootStapper.Framework
{
    public class AppBootstrapper : AutofacBootstapper
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<MHXYToolsMoudle>();
        }

        /// <summary>
        /// 注册程序集的地方
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            var assemblies = new List<Assembly>(base.SelectAssemblies());

            return assemblies;
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            var errorsService = IoC.Get<IErrorsService>();
            errorsService.InstallGlobalExceptionHandler();

            DisplayRootViewFor<ShellViewModel>();
        }

        protected override void OnExit(object sender, EventArgs e)
        {
            var errorsService = IoC.Get<IErrorsService>();
            errorsService.UninstallGlobalExceptionHandler();
        }
    }
}