using ExploringExample.Models;

Person p1 = new(name: "Luiz", surname: "Sandes", age: 20);

Person p2 = new(name: "Robertiño", surname: "Baêa", age: 42);

Course englishCourse = new()
{
    Name = "English"
};

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);
englishCourse.ListStudents();
