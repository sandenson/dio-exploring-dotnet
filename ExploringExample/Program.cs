// using ExploringExample.Models;

// Person p1 = new(name: "Luiz", surname: "Sandes", age: 20);
// Person p2 = new(name: "Robertiño", surname: "Baêa", age: 42);
// Person p3 = new();

// Course englishCourse = new()
// {
//     Name = "English"
// };

// englishCourse.AddStudent(p1);
// englishCourse.AddStudent(p2);
// englishCourse.AddStudent(p3);
// englishCourse.ListStudents();

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

using System.Globalization;

var date = DateTime.Now;

Console.WriteLine(date.ToString("yyyy-MM-ddTHH:mm:ss")); // 2023-10-14T22:02:27

Console.WriteLine(date.ToShortDateString()); // 10/14/2023

var ptBrCulture = CultureInfo.CreateSpecificCulture("pt-BR");

Console.WriteLine(date.ToString("d", ptBrCulture)); // 14/10/2023

Console.WriteLine(DateTime.Parse("14/10/2023 22:11", ptBrCulture).ToString(ptBrCulture)); // 14/10/2023 22:11:00

void DateExactTryParser(string dateString) {
    if (DateTime.TryParseExact(
        dateString,
        "yyyy-MM-dd HH:mm",
        CultureInfo.InvariantCulture,
        DateTimeStyles.None,
        out var date
    ))
    {
        Console.WriteLine(date);
    }
    else
    {
        Console.WriteLine($"{dateString} is not a valid date");
    }
}

DateExactTryParser("2023-13-14 22:16"); // 2023-13-14 22:16 is not a valid date

DateExactTryParser("2023-10-14 22:25"); // 10/14/2023 22:25:00
