using System;
using SQLite;

namespace DoToo.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Workout { get; set; }
        public bool Completed { get; set; }
        public DateTime Day { get; set; }
        public string Notes { get; set; }
    }
}
