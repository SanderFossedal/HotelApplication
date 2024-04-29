using System;
using System.Collections.Generic;

namespace WpfApp.Models;

public partial class Task
{
    public int Id { get; set; }

    public string Tasktype { get; set; } = null!;

    public string? Taskdescription { get; set; }

    public string? Taskstatus { get; set; }

    public int? RoomNum { get; set; }

    public string? Note { get; set; }

    public virtual Room? RoomNumNavigation { get; set; }
}
