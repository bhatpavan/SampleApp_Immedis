using SampleWebApplication.Enums;

namespace SampleWebApplication.Models
{
    public abstract class Person
    {
        /// <summary>
        /// Id of Person.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Type of PersonType.
        /// </summary>
        public abstract PersonType PersonType { get; set; }

        /// <summary>
        /// FirstName of Person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// LastName of Person.
        /// </summary>
        public string LastName { get; set; }

    }
}
