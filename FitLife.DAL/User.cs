using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLife.DAL
{
    public class User
    {
        public int UserId { get; set; }
        [StringLength(15)]
        public string UserName { get; set; }
        [StringLength(15)]
        public string UserSurname { get; set; }
        public DateTime UserCreatedTime { get; set; }
        [StringLength(10)]
        public string UserBirthday { get; set; }
        public string UserPhoto { get; set; }
    }
}
