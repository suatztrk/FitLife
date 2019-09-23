using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLife.DAL.Context
{
    public class GymInitializer:DropCreateDatabaseIfModelChanges<GymContext>
    {
        protected override void Seed(GymContext context)
        {
            var users = new List<User>()
            {
                new User() {UserName="Suat",UserSurname="Öztürk",UserBirthday="21.01.1994",UserCreatedTime=new DateTime(2019,09,23)},
                new User() {UserName="Bekir",UserSurname="Tırpan",UserBirthday="21.01.1990",UserCreatedTime=new DateTime(2019,09,23)}
            };




            base.Seed(context);
        }
    }
}
