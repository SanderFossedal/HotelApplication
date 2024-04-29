using System;
using System.Collections.Generic;

namespace Assignment4_0501.Models;

public partial class Customer
{
    public int Mobile { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Pass { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
