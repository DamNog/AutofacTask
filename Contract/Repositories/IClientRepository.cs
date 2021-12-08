using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Repositories
{
  public interface IClientRepository
  {
    IEnumerable<Client> GetClients();

    void AddClient(Client client);

    void UpdateClient(Client client);

    void DeleteClient(Client client);
  }
}
