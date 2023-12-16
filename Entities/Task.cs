using System;

namespace TaskManager
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public State State { get; set; }

        // many-to-one relationship
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}