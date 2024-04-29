using System;
using System.Collections.Generic;

namespace Assignment4_0501.Models;

public partial class Task
{
    public int Id { get; set; }

    public string Tasktype { get; set; } = null!;

    public string? Taskdescription { get; set; }

    public string? Taskstatus { get; set; }

    public int? RoomNum { get; set; }

    public virtual Room? RoomNumNavigation { get; set; }
}
