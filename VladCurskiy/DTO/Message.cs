using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VladCurskiy.Tools;

namespace VladCurskiy.DTO
{
    [Table("Message")]
    public class Message : BaseDTO
    {
        [Column("Title")]
        public string Title { get; set; }
        

        [Column("Discription")]
        public string Discription { get; set; }

        [Column("Data")]
        public DateTime Data { get; set; } = DateTime.Now;

        [Column("user_id")]
        public int UserId { get; set; }
    } }
