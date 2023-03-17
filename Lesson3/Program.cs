using Lesson3;

var employees = DataGenerator.GenerateEmployees();
var departments = DataGenerator.GenerateDepartments();

// T1: {FirstName} {FirstName}, {Title1} {Title2}

// 1, 2, 3, 4 -> Select(x => x + 1) -> 2, 3, 4, 5

var results = employees
    .Select(employee => 
        new
        {
            Employee = employee, 
            Titles = string.Join(" ", employee.Titles.Select(title => title.Value))
        })
    .Select(x => $"{x.Employee.FirstName} {x.Employee.LastName}, {x.Titles}");

foreach (var result in results)
{
    Console.WriteLine(result);
}



