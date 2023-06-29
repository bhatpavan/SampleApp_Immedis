using SampleWebApplication.Models;

namespace SampleWebApplication.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private static readonly List<Teacher> _teacher = new List<Teacher>();
        private static readonly List<Class> _classes = new List<Class>();


        static TeacherRepository()
        {
            _classes.Add(new Class() { Id = 1, ClassName = "10th", Section = "A" });
            _classes.Add(new Class() { Id = 2, ClassName = "10th", Section = "B" });
            _classes.Add(new Class() { Id = 3, ClassName = "9th", Section = "A" });
            _teacher.Add(new Teacher() { FirstName = "Pavan", LastName = "Bhat", Id = 1, Classes = _classes });
            _teacher.Add(new Teacher() { FirstName = "sdsds", LastName = "Bhat", Id = 2, Classes = _classes });
    
        }
        public Teacher GetTeacher(int id)
        {
            return _teacher.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Teacher> GetTeacherByClass(string className, string Section)
        {
            return _teacher.Where(x => x.Classes.Any(x => x.ClassName.Equals(className) && x.Section.Equals(Section)));
        }

        public IEnumerable<Teacher> GetTeachers()
        {
            return _teacher;
        }
    }
}
