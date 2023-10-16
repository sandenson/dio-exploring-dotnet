namespace OOPExample.Models
{
    public class Student : Person
    {
        public double Grade { get; set; }

        public override void IntroduceSelf()
        {
            Console.WriteLine($"Hello! My name is {Name}, I'm {Age} years old. I'm a student with a grade of {Grade}.");
        }
    }
}