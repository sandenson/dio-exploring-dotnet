// using OOPExample.Models;

// Person p1 = new()
// {
//     Name = "Luiz",
//     Age = 20
// };

// p1.IntroduceSelf();

// --------------------------------------------

// using OOPExample.Models;

// CheckingAccount account = new(123, 1000);

// account.DisplayBalance();
// account.Withdraw(500);
// account.DisplayBalance();

// --------------------------------------------

using OOPExample.Models;

Student s1 = new()
{
    Name = "Luiz",
    Age = 20,
    Grade = 7.8
};

s1.IntroduceSelf();

Teacher t1 = new()
{
    Name = "Robert Fripp",
    Age = 77,
    Salary = 9803.87M
};

t1.IntroduceSelf();
