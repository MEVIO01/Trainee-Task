using System;
using System.Collections.Generic;
using System.Linq;

namespace ForTrainee
{
    class Program
    {
        static void Main(string[] args)
        {
            AnnouncementDB announcementDB = new AnnouncementDB();
            announcementDB.Add(new Announcement(1, "Title", "My name is Bob", new DateTime(2020, 3, 4)));
            announcementDB.Add(new Announcement(2, "Hello", "My name is Alice", new DateTime(2020, 3, 4)));
            announcementDB.Add(new Announcement(3, "Title", "It is sunny today", new DateTime(2020, 3, 4)));
            announcementDB.Add(new Announcement(4, "Hello", "It is rainy today", new DateTime(2020, 3, 4)));
            announcementDB.Add(new Announcement(5, "Title", "My name is Alex", new DateTime(2020, 3, 4)));
            announcementDB.Add(new Announcement(6, "Hello", "My name is Nazar", new DateTime(2020, 3, 4)));
            Announcement announcement = new Announcement(3, "Title", "It is sunny today", new DateTime(2020, 3, 4));
            announcementDB.ShowTopThreeSimilar(announcement);
        }
    }
}
