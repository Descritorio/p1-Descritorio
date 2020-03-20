using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Models
{
  public class OrderPizza
  {
    [Required]
    [Key]
    public long OrderPizzaId { get; set; }

    #region NAVIGATIONAL PROPERTIES
    public Pizza Pizza { get; set; }
    public long PizzaId { get; set; }
    public Order Order { get; set; }
    public long OrderId { get; set; }
    #endregion

  }
}