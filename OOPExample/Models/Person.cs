namespace OOPExample.Models
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void IntroduceSelf()
        {
            Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old!");
        }
    }
}