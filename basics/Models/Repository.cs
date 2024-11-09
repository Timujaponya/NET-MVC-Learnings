namespace basics.Models{
    public class Repository{
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>(){
            new Course { Id = 1, Title = "C#", Description = "C# Kursu", Duration = 30, Image = "1.jpg" , Tags = new string[] { "C#", "Programming", "Backend" }, isActive = true, isHome = false},
            new Course { Id = 2, Title = "ASP.NET", Description = "ASP.NET Kursu", Duration = 40, Image = "2.jpg", Tags = new string[] { "ASP.NET", "Programming", "Backend" }, isActive = true, isHome = true},
            new Course { Id = 3, Title = "SQL Server", Description = "SQL Server Kursu", Duration = 20, Image = "3.jpg", Tags = new string[] { "SQL Server", "Database", "Backend" }, isActive = false, isHome = true},
            new Course { Id = 4, Title = "Python", Description = "Python Kursu", Duration = 40, Image = "4.png", isActive = true, isHome = true},
            new Course { Id = 5, Title = "Java", Description = "Java Kursu", Duration = 40, Image = "5.png" , Tags = new string[] { "Java", "Programming", "Backend" }, isActive = true, isHome = false},
            };
        }
        public static List<Course> Courses{
            get{
                return _courses;
            }
        }
        public static Course? GetById(int? id){
            return _courses.FirstOrDefault(x => x.Id == id);
        }
    }
}