using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Managers
{
  public interface IClientManager
  {
    IEnumerable<Client> GetClients();
    
    IEnumerable<Client> GetActiveClients();
  }
}
