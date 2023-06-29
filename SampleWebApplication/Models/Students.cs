using SampleWebApplication.Enums;

namespace SampleWebApplication.Models
{
    public class Student : Person
    {

        /// <summary>
        /// Person Type.
        /// </summary>
        public override PersonType PersonType { get; set; } = PersonType.Students;

        /// <summary>
        /// Section of Student.
        /// </summary>
        public string Section { get; set; }

        /// <summary>
        /// Studing Standard.
        /// </summary>
        public Class Standard { get; set; }
    }
}
