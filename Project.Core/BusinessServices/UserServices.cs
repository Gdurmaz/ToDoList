using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.BusinessServices
{
    public class UserServices
    {
        //Control ve  Kayıt ol olunacak
        public Entities.User Control(string name,string pass)
        {
            return Connection.VirtualData.GetUsers.Where(I => I.Username == name && I.Password == pass).FirstOrDefault();
        }
    }
}
