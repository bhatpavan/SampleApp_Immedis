using SampleWebApplication.Models;

namespace SampleWebApplication.Services
{
    public interface ISchoolService
    {
        IEnumerable<Student> GetStudentByClass(string className, string section);
        Student GetStudentById(int id);
        IEnumerable<Student> GetStudents();
        IEnumerable<Teacher> GetTeacherByClassName(string className, string section);
        Teacher GetTeacherById(int id);
        IEnumerable<Teacher> GetTeachers();
        void AddStudent(Student student);
    }
}