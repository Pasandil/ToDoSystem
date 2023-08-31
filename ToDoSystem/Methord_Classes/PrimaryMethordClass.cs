using System.Collections.Generic;
using ToDoSystem.DB_Classes;
using ToDoSystem.Domain_Classes;

namespace ToDoSystem.Methord_Classes
{
    public class PrimaryMethordClass : IPrimaryMethordClass
    {

        public MainDBClass MainDBClassDAL;
        public PrimaryMethordClass()
        {
            MainDBClassDAL = new MainDBClass();
        }

        public void CreateToDoList() { 
        
        }

        public List<ToDoData> GetAllToDoLists()
        {
            long id = 0;

            List<ToDoData> list = MainDBClassDAL.GetToDoData(id);

            return list;
        }
         
        public bool AddToDoItem(long id, string name, string desc)
        {

            List<ToDoData> list = MainDBClassDAL.AddToDoItem(id, name, desc);

            return true;
        }

        public List<ToDoData> GetAllToDoLists(long id)
        {

            List<ToDoData> list = MainDBClassDAL.GetToDoData(id);
             
            return list;
        }
    }
}
