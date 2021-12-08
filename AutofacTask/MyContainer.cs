using Autofac;
using BusinessLogic;
using Contract.Infrastructures;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutofacTask
{
  public class MyContainer : IMyContainer
  {
    private static IContainer container;
    public IContainer Container => container ?? BuildContainer();

    private IContainer BuildContainer()
    {
      var cBuilder = new ContainerBuilder();

      cBuilder.RegisterModule<AutofacTaskModule>();
      cBuilder.RegisterModule<BusinessLogicModule>();
      cBuilder.RegisterModule<RepositoryModule>();
      
      container = cBuilder.Build();
      return container;
    }
  }
}
