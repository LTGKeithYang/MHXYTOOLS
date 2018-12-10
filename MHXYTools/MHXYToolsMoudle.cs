using Autofac;
using MHXYTools.Framework.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHXYTools
{
    public class MHXYToolsMoudle: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ErrorsService>()
               .AsImplementedInterfaces()
               .SingleInstance();
        }
    }
}
