using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDeskWinForm.Models
{
    [Table("reservation")]
    public partial class Reservation
    {
        public int Id { get; set; }
        public virtual Customer CustomerId { get; set; }
        public virtual Room RoomId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
