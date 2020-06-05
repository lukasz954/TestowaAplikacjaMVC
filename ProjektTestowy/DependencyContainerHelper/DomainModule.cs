using Autofac;
using DbService.DependencyContainerHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektTestowy.DependencyContainerHelper
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(IDetermineDomainAssembly).Assembly).AsImplementedInterfaces().InstancePerRequest();
            base.Load(builder);
        }
    }
}