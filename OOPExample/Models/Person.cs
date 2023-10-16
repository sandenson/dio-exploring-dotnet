namespace OOPExample.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void IntroduceSelf()
        {
            Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old!");
        }
    }
}