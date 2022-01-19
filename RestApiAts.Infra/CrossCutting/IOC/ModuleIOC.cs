using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiAts.Infra.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Configuration.Load(builder);
        }
    }
}
