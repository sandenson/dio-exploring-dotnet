namespace ExploringExample.Models
{
    public class Course
    {
        public Course(string name)
        {
            Name = name;
        }

        public Course(string name, List<Person> students)
        {
            Name = name;
            Students = students;
        }

        public string Name { get; set; }
        public readonly List<Person> Students = new();

        public void AddStudent(Person student)
        {
            if (Students.Any(x => x.Equals(student))) {
                throw new ArgumentException("This student is already enrolled in the course.");
            }
            Students.Add(student);
        }

        public int CountEnrolledStudents()
        {
            return Students.Count;
        }

        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }

        public void ListStudents()
        {
            Console.WriteLine($"Students enrolled in the course: {Name}");
            
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"#{i + 1} - {Students[i].FullName}");
            }
        }
    }
}