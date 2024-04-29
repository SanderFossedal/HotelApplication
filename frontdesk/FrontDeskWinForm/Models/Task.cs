using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDeskWinForm.Models
{
    [Table("tasks")]
    public partial class Task
    {
        public int Id { get; set; }
        public string TaskType { get; set; }
        public string TaskDescription { get; set; }
        public string TaskStatus { get; set; }
        public virtual Room RoomId { get; set; }
        public string? TaskNote { get; set; }
    }
}
