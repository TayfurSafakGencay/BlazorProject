﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace MealOrder.Server.Data.Models
{
  public class Order
  {
    public Guid Id { get; set; }
    
    public DateTime CreateDate { get; set; }
    
    public Guid CreateUserId { get; set; }
    
    public Guid SupplierId { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public DateTime ExpireDate { get; set; }
    
    public virtual User CreateUser { get; set; }
    
    public virtual Supplier Supplier { get; set; }
    
    public virtual ICollection<OrderItem> OrderItems { get; set; }
  }
}