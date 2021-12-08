using Contract.Managers;
using Contract.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
  class ClientManager : IClientManager
  {
    private readonly IClientRepository clientRepository;

    public ClientManager(IClientRepository clientRepository)
    {
      this.clientRepository = clientRepository;
    }

    public IEnumerable<Client> GetActiveClients()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Client> GetClients()
    {
      throw new NotImplementedException();
    }
  }
}
