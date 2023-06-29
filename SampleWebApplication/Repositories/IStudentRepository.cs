using SampleWebApplication.Models;

namespace SampleWebApplication.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();

        Student GetStudent(int id);

        IEnumerable<Student> GetStudentsByClass(string className,string Section);

        void AddStudent(Student student);

    }
}
