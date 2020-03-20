using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaBoxRepository
  {
    private static readonly PizzaBoxDbContext _db = new PizzaBoxDbContext();
    
    // public PizzaBoxRepository(PizzaBoxDbContext dbContext)
    // {
    //   _db = dbContext;
    // }
    public IEnumerable<T> Read<T>() where T : class
    {
      return _db.Set<T>();
    }
  }
}