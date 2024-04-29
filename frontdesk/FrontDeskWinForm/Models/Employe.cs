using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDeskWinForm.Models
{
    [Table("employee")]
    public partial class Employe
    {
        public int Id { get; set; }
        public string EmployeType { get; set; }
    }
}
