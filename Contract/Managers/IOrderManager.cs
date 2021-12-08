using Model;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Managers
{
  public interface IOrderManager
  {
    IEnumerable<Order> GetAllOrders();
    
    IEnumerable<Order> GetOrderForClient(Client client);

    Order CreateNewOrderForClient(Client client);

    Order CreateNewOrder();
  }
}
