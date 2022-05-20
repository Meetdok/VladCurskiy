using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VladCurskiy.Tools;

namespace VladCurskiy.DTO
{
    [Table("User")]
    public class User : BaseDTO
    {
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("StatusUser")]
        public string StatusUser { get; set; }
    }
}
