using System;
using System.Collections.Generic;
using System.Text;

namespace ForTrainee
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public Announcement()
        {

        }
        public Announcement(int id, string title, string description, DateTime dateAdded)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.DateAdded = dateAdded;
        }
    }
}
