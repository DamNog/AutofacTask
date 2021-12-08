using Autofac;
using Contract.Infrastructures;
using System;

namespace AutofacTask
{
  class Program
  {
    static void Main(string[] args)
    {
      var container = new MyContainer();

      var config = container.Container.Resolve<IConfiguration>();

      Console.WriteLine("Hello World!");
    }
  }
}
