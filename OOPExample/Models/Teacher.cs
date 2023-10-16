namespace OOPExample.Models
{
    public class Teacher : Person
    {
        public decimal Salary { get; set; }

        public override void IntroduceSelf()
        {
            Console.WriteLine($"Hello! My name is {Name}, I'm {Age} years old. I'm a teacher with a salary of {Salary}.");
        }
    }
}