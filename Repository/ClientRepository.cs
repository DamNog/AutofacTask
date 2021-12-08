using Contract.Infrastructures;
using Contract.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
  class ClientRepository : IClientRepository
  {
    private readonly IConfiguration configuration;

    public ClientRepository(IConfiguration configuration)
    {
      this.configuration = configuration;
    }

    public void AddClient(Client client)
    {
      throw new NotImplementedException();
    }

    public void DeleteClient(Client client)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Client> GetClients()
    {
      throw new NotImplementedException();
    }

    public void UpdateClient(Client client)
    {
      throw new NotImplementedException();
    }
  }
}
