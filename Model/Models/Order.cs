using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
  public class Order
  {
    public Client Client { get; set; }
    public List<OrderItem> OrderItems { get; set; }

  }
}
