using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Infrastructures
{
  public interface IConfiguration
  {
    bool IsProductionMode { get; set; }
  }
}
