using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForTrainee
{
    class AnnouncementDB
    {
        private List<Announcement> announcements;
        public AnnouncementDB()
        {
            this.announcements = new List<Announcement>();
        }

        public void Add(Announcement announcement)
        {
            announcements.Add(announcement);
        }
        private Announcement Find(int id)
        {
            return this.announcements.Single(a => a.Id == id);
        }
        public void Edit(int id)
        {
            Announcement announcement = Find(id);
            Console.WriteLine("Please input Title: ");
            announcement.Title = Console.ReadLine();
            Console.WriteLine("Please input Description: ");
            announcement.Description = Console.ReadLine();
            Console.WriteLine("Please input date(added) Example: 10/22/1987 : ");
            announcement.DateAdded = DateTime.Parse(Console.ReadLine());
        }
        public void Remove(int id)
        {
            this.announcements.Remove(Find(id));
        }
        public void DisplayAll()
        {
            foreach (var announcement in announcements)
            {
                ShowSelectedAnnouncementDetails(announcement.Id);
            }
        }
        public void ShowSelectedAnnouncementDetails(int id)
        {
            Announcement announcement = Find(id);
            Console.WriteLine("Title : " + announcement.Title + Environment.NewLine +
                    "Description : " + announcement.Description + Environment.NewLine + "Date Added : " + announcement.DateAdded);
        }
        public void ShowTopThreeSimilar(Announcement announcement)
        {
            this.Remove(announcement.Id);
            Dictionary<int, int> similarCount = new Dictionary<int, int>();
            var firstHash = (announcement.Title + ' ' + announcement.Description).Split().ToHashSet();
            var secondHash = new HashSet<string>();
            foreach (var item in this.announcements)
            {
                secondHash = (item.Title + ' ' + item.Description).Split().ToHashSet();
                secondHash.IntersectWith(firstHash);
                similarCount[item.Id] = secondHash.Count();
            }
            List<int> toOutPut = new List<int>();
            foreach (var item in similarCount.OrderBy(key => key.Value))
            {
                toOutPut.Add(item.Key);
            }
            for (int i = toOutPut.Count-1; i > toOutPut.Count - 4; i--)
            {
                Console.WriteLine(Find(toOutPut[i]).Description);
            }
            this.Add(announcement);
        }

    }
}
