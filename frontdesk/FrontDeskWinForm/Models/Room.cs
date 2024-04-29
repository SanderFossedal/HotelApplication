using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDeskWinForm.Models
{
    [Table("room")]
    public partial class Room
    {
        public int RoomID { get; set; }
        public string RoomStatus { get; set; }
        public int BedsNumber { get; set; }
        public string RoomSize { get; set; }
    }
}
