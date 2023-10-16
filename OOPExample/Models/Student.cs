namespace OOPExample.Models
{
    public sealed class Student : Person
    {
        public Student(string name, int age) : base(name)
        {
            Age = age;
        }

        public Student(string name) : base(name)
        {
        }

        public double Grade { get; set; }

        public override void IntroduceSelf()
        {
            Console.WriteLine($"Hello! My name is {Name}, I'm {Age} years old. I'm a student with a grade of {Grade}.");
        }
    }
}