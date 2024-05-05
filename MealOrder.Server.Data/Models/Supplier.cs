using System;
using System.Collections.Generic;

namespace MealOrder.Server.Data.Models
{
  public class Supplier
  {
    public Guid Id { get; set; }
    
    public DateTime CreateDate { get; set; }
    
    public string Name { get; set; }
    
    public string WebURL { get; set; }
    
    public bool IsActive { get; set; }
    
    public virtual ICollection<Order> Orders { get; set; }
  }
}