// using OOPExample.Models;

// Person p1 = new()
// {
//     Name = "Luiz",
//     Age = 20
// };

// p1.IntroduceSelf();

// --------------------------------------------

using OOPExample.Models;

CheckingAccount account = new(123, 1000);

account.DisplayBalance();
account.Withdraw(500);
account.DisplayBalance();
