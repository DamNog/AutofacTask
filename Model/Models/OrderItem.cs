using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
  public class OrderItem
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Tax { get; set; }
  }
}
