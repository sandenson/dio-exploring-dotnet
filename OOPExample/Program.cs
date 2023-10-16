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

// using OOPExample.Models;

// Student s1 = new()
// {
//     Name = "Luiz",
//     Age = 20,
//     Grade = 7.8
// };

// s1.IntroduceSelf();

// Teacher t1 = new()
// {
//     Name = "Robert Fripp",
//     Age = 77,
//     Salary = 9803.87M
// };

// t1.IntroduceSelf();

// --------------------------------------------

// using OOPExample.Models;

// CheckingAccount account = new(accountNumber: 123, balance: 1000);
// account.Deposit(500);
// account.DisplayBalance();

// --------------------------------------------

// using OOPExample.Models;

// Computer computer = new();
// Console.WriteLine(computer.ToString()); // The ToString method has been overwritten

// --------------------------------------------

// using OOPExample.Interfaces;
// using OOPExample.Models;

// ICalculator calc = new Calculator();
// // ICalculator comp = new Computer(); // invalid
// Console.WriteLine(calc.Multiply(3, 9)); // 27
// Console.WriteLine(calc.Divide(9, 3));
// // 3
// // This is not the default implementation of the Divide method.
