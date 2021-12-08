using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Repositories
{
  public interface IOrderRepository
  {
    IEnumerable<Order> GetClients();

    void AddOrder(Order client);

    void UpdateOrder(Order client);

    void DeleteOrder(Order client);
  }
}
