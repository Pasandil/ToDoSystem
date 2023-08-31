using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoSystem.Domain_Classes;

namespace ToDoSystem.Methord_Classes
{
    public interface IPrimaryMethordClass
    {
       
        void CreateToDoList();

        List<ToDoData> GetAllToDoLists();
        List<ToDoData> GetAllToDoLists(long id);
        bool AddToDoItem(long id, string name, string description);
    }
}
