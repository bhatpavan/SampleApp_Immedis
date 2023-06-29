using SampleWebApplication.Models;

namespace SampleWebApplication.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student>();

        static StudentRepository()
        {
            _students.Add(new Student() { FirstName = "Pavan", LastName = "Bhat", Id = 1, Standard = new Class() { Id = 1, ClassName = "10th", Section = "A" } });
            _students.Add(new Student() { FirstName = "xyz", LastName = "Bhat", Id = 2, Standard = new Class() { Id = 1, ClassName = "10th", Section = "A" } });
            _students.Add(new Student() { FirstName = "xsx", LastName = "Bhat", Id = 3, Standard = new Class() { Id = 2, ClassName = "10th", Section = "B" } });
            _students.Add(new Student() { FirstName = "sdsd", LastName = "Bhat", Id = 4, Standard = new Class() { Id = 2, ClassName = "10th", Section = "B" } });
            _students.Add(new Student() { FirstName = "dssd", LastName = "Bhat", Id = 5, Standard = new Class() { Id = 2, ClassName = "10th", Section = "B" } });
            _students.Add(new Student() { FirstName = "ds", LastName = "Bhat", Id = 6, Standard = new Class() { Id = 3, ClassName = "9th", Section = "A" } });
        }
        
        public Student GetStudent(int id)
        {
           return _students.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }

        public IEnumerable<Student> GetStudentsByClass(string className, string Section)
        {
            return _students.Where(x=>x.Standard.ClassName == className && x.Section == Section);
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
    }
}
