using System;
using System.Collections.Generic;

namespace WpfApp.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int RoomNum { get; set; }

    public DateTime Checkin { get; set; }

    public DateTime Checkout { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Room RoomNumNavigation { get; set; } = null!;
}
