using System.Collections.Generic;

namespace TaskManager
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // one-to-many relationship
        public virtual ICollection<Task> Tasks { get; set; }
    }
}