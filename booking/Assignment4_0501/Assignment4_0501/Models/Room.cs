using System;
using System.Collections.Generic;

namespace Assignment4_0501.Models;

public partial class Room
{
    public int RoomNum { get; set; }

    public string RoomStatus { get; set; } = null!;

    public int? NumBeds { get; set; }

    public string? RoomSize { get; set; }

    public string? ImageLink { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
