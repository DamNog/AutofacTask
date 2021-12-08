using Contract.Managers;
using Contract.Repositories;
using Model;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
  class OrderManager : IOrderManager
  {
    private readonly IOrderRepository orderRepository;
    private readonly IClientRepository clientRepository;

    public OrderManager(IOrderRepository orderRepository, IClientRepository clientRepository)
    {
      this.orderRepository = orderRepository;
      this.clientRepository = clientRepository;
    }

    public Order CreateNewOrder()
    {
      throw new NotImplementedException();
    }

    public Order CreateNewOrderForClient(Client client)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Order> GetAllOrders()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Order> GetOrderForClient(Client client)
    {
      throw new NotImplementedException();
    }
  }
}
