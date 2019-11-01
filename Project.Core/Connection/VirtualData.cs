using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Connection
{
    public class VirtualData
    {
        public static List<Entities.User> GetUsers;
        public static List<Entities.ToDo> GetToDos;
        static VirtualData()
        {
            //Sanal Tablolar
            GetUsers = new List<Entities.User>();
            GetUsers.Add(new Entities.User() {ID=Guid.NewGuid(),Username="admin",Password="123" });
            GetToDos = new List<Entities.ToDo>();
        }
    }
}
