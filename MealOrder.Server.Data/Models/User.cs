using System;
using System.Collections.Generic;

namespace MealOrder.Server.Data.Models
{
  public class User
  {
    public Guid Id { get; set; }
    
    public DateTime CreateDate { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string EMailAddress { get; set; }
    
    public bool IsActive { get; set; }
    
    public virtual ICollection<Order> Orders { get; set; }
    
    public virtual ICollection<OrderItem> CreatedOrderItems { get; set; }
  }
}