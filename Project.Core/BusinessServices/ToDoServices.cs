using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.BusinessServices
{
    public class ToDoServices
    {
        public int Control()
        {
            return Connection.VirtualData.GetToDos.Count();
        }
        public List<Entities.ToDo> Select()
        {
            return Connection.VirtualData.GetToDos;
        }
        public int Insert(Entities.ToDo t)
        {
            try
            {
                Connection.VirtualData.GetToDos.Add(t);
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
