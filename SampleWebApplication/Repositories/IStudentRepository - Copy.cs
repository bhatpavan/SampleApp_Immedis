using SampleWebApplication.Models;

namespace SampleWebApplication.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetTeachers();

        Teacher GetTeacher(int id);

        IEnumerable<Teacher> GetTeacherByClass(string className,string Section);

    }
}
