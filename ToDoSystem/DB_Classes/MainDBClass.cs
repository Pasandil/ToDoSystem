using ToDoSystem.Methord_Classes;
using ToDoSystem.Domain_Classes;
using ToDoSystem.Controllers;
using static System.Reflection.Metadata.BlobBuilder;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ToDoSystem.DB_Classes
{
    public class MainDBClass
    { 
        public List<ToDoData> GetToDoData(long id)
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();
            var myConnectionString = _configuration.GetConnectionString("DefaultConnection");


            List<ToDoData> list = new List<ToDoData>();

            using (SqlConnection con = new SqlConnection(myConnectionString))
            {
                string query = "SELECT * FROM ToDoListTable";

                if(id > 0)
                {
                    query += " Where ToDoListTable.id = "+id+" ";
                }

                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ToDoData toDoData = new ToDoData();

                            toDoData.Id = Convert.ToInt32(sdr["ID"]);
                            toDoData.CreatedDate = (DateTime)sdr["CreatedDate"];
                            toDoData.Description = sdr["Description"].ToString();
                            toDoData.Name = sdr["Name"].ToString();

                            list.Add(toDoData);
                        }
                    }
                    con.Close();
                }
            }

            return list;

        }

        public List<ToDoData> AddToDoItem(long id, string name, string desc)
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();
            var myConnectionString = _configuration.GetConnectionString("DefaultConnection");


            List<ToDoData> list = new List<ToDoData>();

            using (SqlConnection con = new SqlConnection(myConnectionString))
            {
                string query = "INSERT INTO [dbo].[ToDoListTable]  ([ID] ,[Name] ,[Description] ,[CreatedDate]) VALUES ('"+id+"' ,'"+name+"' ,'"+desc+"' , GETDATE()) ";
                 
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        { 
                            //TODO
                        }
                    }
                    con.Close();
                }
            }

            return list;

        }

    }

}
