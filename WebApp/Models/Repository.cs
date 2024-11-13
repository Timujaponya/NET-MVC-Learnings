namespace WebApp.Models
{
    public static class Repository
    {
        private static List<Announcement> _announcements = new();
        
        static Repository()
        {

        }

        public static List<Announcement> Announcements => _announcements;

        public static void AddAnnouncement(Announcement announcement)
        {
            announcement.Id = _announcements.Max(a => a.Id) + 1;
            _announcements.Add(announcement);
        }

        public static Announcement GetAnnouncementById(int id)
        {
            return _announcements.FirstOrDefault(a => a.Id == id);
        }

        public static List<Announcement> GetAnnouncementsByTitle(string title)
        {
            return _announcements.Where(a => a.Title.Contains(title)).ToList();
        }


        public static void UpdateAnnouncement(Announcement announcement)
        {
            var existingAnnouncement = GetAnnouncementById(announcement.Id);
            if (existingAnnouncement != null)
            {
                existingAnnouncement.Title = announcement.Title;
                existingAnnouncement.Content = announcement.Content;
                existingAnnouncement.Date = announcement.Date;
            }
        }

        public static void DeleteAnnouncement(int id)
        {
            var existingAnnouncement = GetAnnouncementById(id);
            if (existingAnnouncement != null)
            {
                _announcements.Remove(existingAnnouncement);
            }
        }
    }
}