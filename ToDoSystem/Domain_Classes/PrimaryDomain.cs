namespace ToDoSystem.Domain_Classes
{
    public abstract class PrimaryDomain
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class UserData : PrimaryDomain 
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public enum Gender
        {
            Male,
            Female
        }  
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class ToDoData : PrimaryDomain
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class Task : PrimaryDomain
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public enum Status
        {
            ToDo,
            InProgress,
            Compleated,
            Abandoned
        } 
    }



}
