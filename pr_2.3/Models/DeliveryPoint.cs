using System;
using System.Collections.Generic;
using pr_2._3.Models;

namespace pr_2._3;

public partial class DeliveryPoint
{
    public int Id { get; set; }

    public string DeliveryAddress { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
