using Lesson3;

var employees = DataGenerator.GenerateEmployees();
var departments = DataGenerator.GenerateDepartments();

// T2: {FirstName} {FirstName} (only men)

// 1, 2, 3 -> Where(x => x > 1) -> 2, 3 
// 1, 2, 3 -> Where(x => x % 2 == 0) -> 2 
// 1, 2, 3
//
// 2 -> [2]
// 

// 1, 2, 3 -> Select(x => x * 2) -> 2, 4, 6


var results = employees
    .Where(x => x.Sex)
    .Select(x => x.FirstName + " " + x.LastName + " " + (x.Sex ? "Male" : "Female"));


foreach(var res in results) Console.WriteLine(res);




