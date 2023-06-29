using SampleWebApplication.Enums;

namespace SampleWebApplication.Models
{
    public class Teacher : Person
    {
        public override PersonType PersonType { get; set; }= PersonType.Teachers;

        public string RelaventSubject { get; set; }

        public IList<Class> Classes { get; set; }

    }
}
