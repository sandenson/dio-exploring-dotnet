// using ExploringExample.Models;

// Person p1 = new(name: "Luiz", surname: "Sandes", age: 20);
// Person p2 = new(name: "Robertiño", surname: "Baêa", age: 42);
// Person p3 = new();

// Course englishCourse = new(name: "English", students: new List<Person>{p1, p2});

// englishCourse.AddStudent(p3);
// englishCourse.ListStudents();
// // Students enrolled in the course: English
// // #1 - LUIZ SANDES
// // #2 - ROBERTIÑO BAÊA
// // #3 - DIEGO FERNANDES

// using System.Globalization;

// decimal value = 82.40M;

// Console.WriteLine($"{value:c}"); // ¤82.40

// CultureInfo.DefaultThreadCurrentCulture = new("en-US");
// Console.WriteLine($"{value:c}"); // $82.40

// CultureInfo.DefaultThreadCurrentCulture = new("en-GB");
// Console.WriteLine($"{value:c}"); // £82.40

// CultureInfo.DefaultThreadCurrentCulture = new("pt-BR");
// Console.WriteLine($"{value:c}"); // R$ 82,40

// Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("pt-PT"))); // 82,40 €

// Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("cn-CN"))); // CN¥ 82.40

// Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("jp-JP"))); // ¥ 82

// Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"))); // $ 82,40

// Console.WriteLine(value.ToString("C8")); // R$ 82,40000000

// Console.WriteLine(value.ToString("N8")); // 82,40000000

// Console.WriteLine(.3421D.ToString("P2")); // 34,21%

// Console.WriteLine(123456.ToString("##-##-##")); // 12-34-56

// using System.Globalization;

// var date = DateTime.Now;

// Console.WriteLine(date.ToString("yyyy-MM-ddTHH:mm:ss")); // 2023-10-14T22:02:27

// Console.WriteLine(date.ToShortDateString()); // 10/14/2023

// var ptBrCulture = CultureInfo.CreateSpecificCulture("pt-BR");

// Console.WriteLine(date.ToString("d", ptBrCulture)); // 14/10/2023

// Console.WriteLine(DateTime.Parse("14/10/2023 22:11", ptBrCulture).ToString(ptBrCulture)); // 14/10/2023 22:11:00

// void DateExactTryParser(string dateString) {
//     if (DateTime.TryParseExact(
//         dateString,
//         "yyyy-MM-dd HH:mm",
//         CultureInfo.InvariantCulture,
//         DateTimeStyles.None,
//         out var date
//     ))
//     {
//         Console.WriteLine(date);
//     }
//     else
//     {
//         Console.WriteLine($"{dateString} is not a valid date");
//     }
// }

// DateExactTryParser("2023-13-14 22:16"); // 2023-13-14 22:16 is not a valid date

// DateExactTryParser("2023-10-14 22:25"); // 10/14/2023 22:25:00

// using ExploringExample.Utils;

// try
// {
//     string[] lines = File.ReadAllLines( // can throw error
//         Path.Join(Utils.CurrentWorkingDirectory, "Files/file.txt")
//         // Line one of the file
//         // Line two of the file - Random content
//     );

//     foreach (var line in lines)
//     {
//         Console.WriteLine(line);
//     }
// }
// catch (FileNotFoundException err)
// {
//     // An unexpected exception has ocurred. File was not found: Could not find file '/random_path/exploring-csharp/ExploringExample/Files/wrong_file_path.txt'
//     Console.WriteLine($"An unexpected exception has ocurred. File was not found: {err.Message}");
// }
// catch (DirectoryNotFoundException err)
// {
//     // An unexpected exception has ocurred. Directory was not found: Could not find a part of the path '/random_path/exploring-csharp/ExploringExample/wrong_directory/file.txt'
//     Console.WriteLine($"An unexpected exception has ocurred. Directory was not found: {err.Message}");
// }
// catch (Exception err)
// {
//     // An unexpected exception has ocurred: random message'
//     Console.WriteLine($"An unexpected exception has ocurred: {err.Message}");
// }
// finally // run regardless of whether an exception was thrown or not
// {
//     Console.WriteLine("This is ran after everything else.");
// }

// using ExploringExample.Models;

// ExceptionExample.Method1();
// // Unhandled exception. System.Exception: An exception has ocurred.
// //    at ExploringExample.Models.ExceptionExample.Method4() in /random_path/exploring-csharp/ExploringExample/Models/ExceptionExample.cs:line 27
// //    at ExploringExample.Models.ExceptionExample.Method3() in /random_path/exploring-csharp/ExploringExample/Models/ExceptionExample.cs:line 22
// //    at ExploringExample.Models.ExceptionExample.Method2() in /random_path/exploring-csharp/ExploringExample/Models/ExceptionExample.cs:line 17
// //    at ExploringExample.Models.ExceptionExample.Method1() in /random_path/exploring-csharp/ExploringExample/Models/ExceptionExample.cs:line 12
// //    at Program.<Main>$(String[] args) in /random_path/exploring-csharp/ExploringExample/Program.cs:line 119

// Queue<int> queue = new();
// queue.Enqueue(2);
// queue.Enqueue(4);
// queue.Enqueue(6);
// queue.Enqueue(8);

// foreach (var item in queue)
// {
//     Console.WriteLine(item); // 2 4 6 8
// }

// Console.WriteLine($"Removing queue item {queue.Dequeue()}"); // Removing queue item 2

// queue.Enqueue(10);

// foreach (var item in queue)
// {
//     Console.WriteLine(item); // 4 6 8 10
// }

// Console.WriteLine($"{new Queue<int>().TryDequeue(out int test)} - {test}"); // False - 0

// Stack<int> stack = new();
// stack.Push(2);
// stack.Push(4);
// stack.Push(6);
// stack.Push(8);

// foreach (var item in stack)
// {
//     Console.WriteLine(item); // 8 6 4 2
// }

// Console.WriteLine($"Removing stack item {stack.Pop()}"); // Removing stack item 8

// stack.Push(10);

// foreach (var item in stack)
// {
//     Console.WriteLine(item); // 10 6 4 2
// }

// Console.WriteLine($"{new Stack<int>().TryPop(out int test)} - {test}"); // False - 0

// Dictionary<string, string> states = new()
// {
//     { "AL", "Alagoas" },
//     { "SE", "Sergipe" },
//     { "BA", "Bahia" },
//     { "SP", "São Paulo" }
// };

// foreach (var item in states)
// {
//     Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//     // Key: AL, Value: Alagoas
//     // Key: SE, Value: Sergipe
//     // Key: BA, Value: Bahia
//     // Key: SP, Value: São Paulo
// }

// // states.Add("SP", "São Paulo"); // throws exception: Unhandled exception. System.ArgumentException: An item with the same key has already been added. Key: SP

// states.Add("SP2", "São Paulo"); // doesn't throw exception
// states.Remove("SP2");

// states["SP"] = "São Paulo - updated value";
// states["RN"] = "Rio Grande do Norte"; // this also works
// states["RN"] = "Rio Grande do Norte - updated value"; // doesn't throw exception

// Console.WriteLine("-----------");

// foreach (var item in states)
// {
//     Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//     // Key: AL, Value: Alagoas
//     // Key: SE, Value: Sergipe
//     // Key: BA, Value: Bahia
//     // Key: SP, Value: São Paulo - updated value
//     // Key: RN, Value: Rio Grande do Norte - updated value
// }

// Console.WriteLine(states.ContainsKey("RN")); // True
// Console.WriteLine(states.ContainsValue("Rio Grande do Sul")); // False

// // Console.WriteLine(states["RS"]); // throws exception
// Console.WriteLine(states["AL"]); // Alagoas
