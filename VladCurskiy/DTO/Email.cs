using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VladCurskiy.Tools;

namespace VladCurskiy.DTO
{
    [Table("Email")]
    public class Email : BaseDTO
    {
        [Column("StatusMail")]
        public string StatusMail { get; set; }

        [Column("Message_id")]
        public int MessageId { get; set; }

        [Column("User_id")]
        public int UserId { get; set; }

    }
}
