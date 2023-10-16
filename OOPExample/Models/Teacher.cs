namespace OOPExample.Models
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
        }

        public decimal Salary { get; set; }

        public sealed override void IntroduceSelf()
        {
            Console.WriteLine($"Hello! My name is {Name}, I'm {Age} years old. I'm a teacher with a salary of {Salary}.");
        }
    }
}