using System;
using System.Collections.Generic;

namespace ATCP.IPS.MS.Aguilar.Model.Entity;

public partial class OrderByProductView
{
    public string ProductName { get; set; } = null!;

    public string? CustomerFullName { get; set; }

    public string DeliveryAddress { get; set; } = null!;

    public int ItemCount { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal TotalAmount { get; set; }
}
