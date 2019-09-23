using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLife.DAL
{
    public class UserNatification
    {
        public int UserNotificationId { get; set; }
        public int UserId { get; set; }
        public int? UserDetailId { get; set; }
        public string Message { get; set; }
        public string MessageType { get; set; }
        public DateTime SendDate { get; set; }
    }
}
