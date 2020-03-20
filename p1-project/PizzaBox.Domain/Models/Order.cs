using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Models
{
  public class Order
  {
    [Required]
    [Key]
    public long OrderId { get; set; }
    public DateTime OrderDateTime { get; set; }

    #region NAVIGATION
    public List<OrderPizza> OrderPizzas { get; set; }
    public Store Store { get; set; }
    public long StoreId { get; set; }
    public User User { get; set; }
    public long UserId { get; set; }
    #endregion
  }
}