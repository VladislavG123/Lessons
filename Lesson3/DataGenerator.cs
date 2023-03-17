using Bogus;

namespace Lesson3;

public static class DataGenerator
{
    private static Faker _faker = new Faker("en");
    
    public static List<Department> Generate()
    {
        var employees = new List<Employee>();
        
        for (int i = 0; i < 99; i++)
        {
            employees.Add(new Employee
            {
                Birthday = _faker.Date.Past(50),
                FirstName = _faker.Name.FirstName(),
                LastName = _faker.Name.LastName(),
                Sex = _faker.Random.Bool(),
                HireDate = _faker.Date.Past(50),
                Salaries = GenerateSalaries(new Random().Next(1, 10)),
                Titles = GenerateTitles(new Random().Next(1, 5))
            });
        }

        var departments = new List<Department>();
        
        for (int i = 0; i < 3; i++)
        {
            departments.Add(new Department
            {
                Name = _faker.Company.CompanyName(),
                Employees = employees.Skip(i * 33).Take(33).ToList()
            });
        }

        return departments;
    }

    private static List<Salary> GenerateSalaries(int number)
    {
        var salaries = new List<Salary>();

        for (int i = 0; i < number; i++)
        {
            salaries.Add(new Salary
            {
                Value = _faker.Finance.Amount(100, 9999)
            });
        }
        
        return salaries;
    }
    
    private static List<Title> GenerateTitles(int number)
    {
        var titles = new List<Title>();

        for (int i = 0; i < number; i++)
        {
            titles.Add(new Title
            {
                Value = _faker.Name.JobTitle()
            });
        }
        
        return titles;
    }
}
