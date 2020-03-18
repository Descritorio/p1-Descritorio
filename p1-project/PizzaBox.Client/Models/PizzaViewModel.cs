using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Models
{
  public class PizzaViewModel
  {
    public List<Order> OrderList { get; set; }
    public List<Pizza> PizzaList { get; set; }
    public List<Store> StoreList { get; set; }
    public List<User> UserList { get; set; }

    public PizzaViewModel()
    {
      OrderList = new List<Order>();
      PizzaList = new List<Pizza>();
      StoreList = new List<Store>();
      UserList = new List<User>();
    }
  }
}