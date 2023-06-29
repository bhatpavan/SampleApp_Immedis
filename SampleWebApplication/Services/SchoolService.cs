using SampleWebApplication.Models;
using SampleWebApplication.Repositories;

namespace SampleWebApplication.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ILogger<SchoolService> _logger;
        private readonly IStudentRepository studentRepository;
        private readonly ITeacherRepository teacherRepository;
        public SchoolService(ILogger<SchoolService> logger, IStudentRepository studentRepository, ITeacherRepository teacherRepository)
        {
            _logger = logger;
            this.studentRepository = studentRepository;
            this.teacherRepository = teacherRepository;
        }
        public IEnumerable<Student> GetStudents()
        {
            return studentRepository.GetStudents();
        }

        public void AddStudent(Student student)
        {
            studentRepository.AddStudent(student);
        }
        public IEnumerable<Student> GetStudentByClass(string className, string section)
        {
            return studentRepository.GetStudentsByClass(className, section);
        }
        public Student GetStudentById(int id)
        {
            return studentRepository.GetStudent(id);
        }

        public IEnumerable<Teacher> GetTeachers()
        {
            return teacherRepository.GetTeachers();
        }

        public Teacher GetTeacherById(int id)
        {
            return teacherRepository.GetTeacher(id);
        }

        public IEnumerable<Teacher> GetTeacherByClassName(string className, string section)
        {
            return teacherRepository.GetTeacherByClass(className, section);
        }
    }
}
