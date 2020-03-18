using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Models
{
  public class Pizza
  {
    [Required]
    [Key]
    public long PizzaId { get; set; }
    public string PizzaName { get; set; }
    public string PizzaDetails { get; set; }
    public decimal PizzaPrice { get; set; }

    #region NAVIGATION
    public Order Order { get; set; }
    public long OrderId { get; set; }
    #endregion
  }
}