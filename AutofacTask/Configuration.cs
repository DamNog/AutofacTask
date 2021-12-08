using Contract.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacTask
{
  class Configuration : IConfiguration
  {
    public bool IsProductionMode { get; set; }
  }
}
