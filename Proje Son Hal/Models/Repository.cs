namespace AnnouncementApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();
        private static List<Announcement> _announcements = new();
        static Repository(){
            // ...existing code...
        }
        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }
        public static List<Announcement> Announcements{
            get{
                return _announcements;
            }
        }
        public static void AddAnnouncement(Announcement announcement){
            announcement.Id = _announcements.Count + 1;
            _announcements.Add(announcement);
                // User bilgilerini de listeye eklemek gerekebilir
            if (!_users.Contains(announcement.User))
            {
                _users.Add(announcement.User);
            }
        }
        public static Announcement? GetAnnouncement(int id){
            return _announcements.FirstOrDefault(x => x.Id == id);
        }
        public static UserInfo? GetUserByEmail(string email){
            return _users.FirstOrDefault(x => x.Email == email);
        }
    }
}
