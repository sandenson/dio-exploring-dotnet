namespace ExploringExample.Models
{
    public class Person
    {
        public Person(string name, string surname, int age) {
            _name = name;
            Surname = surname;
            Age = age;
        }

        public Person(string name, string surname) {
            _name = name;
            Surname = surname;
        }

        public Person() {
            _name = "Diego";
            Surname = "Fernandes";
            Age = 27;
        }

        public void Deconstruct(out string name, out string surname)
        {
            name = Name;
            surname = Surname;
        }

        public void Deconstruct(out string name, out string surname, out int age)
        {
            name = Name;
            surname = Surname;
            age = Age;
        }

        private string _name;
        public string Name
        {
            get => _name.ToUpper();
            set
            {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("The name can't be empty.");
                }
                _name = value;
            }
        }

        public string Surname { get; set; }
        
        public string FullName => $"{Name} {Surname}".ToUpper();
        
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0) {
                    throw new ArgumentException("Age can't be lower than zero");
                }
                _age = value;
            }
        }

        public void Present() {
            Console.WriteLine($"Name: {FullName}, Age: {Age}");
        }
    }
}