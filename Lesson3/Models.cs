namespace Lesson3;

public abstract class BaseModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
}

public class Employee : BaseModel
{
    public DateTime Birthday { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    /// <summary>
    /// true - male. false - female
    /// </summary>
    public bool Sex { get; set; }
    
    public DateTime HireDate { get; set; }
    
    public List<Salary> Salaries { get; set; }
    public List<Title> Titles { get; set; }
}


public class Salary : BaseModel
{
    public decimal Value { get; set; }
}

public class Title : BaseModel
{
    public string Value { get; set; }
}


public class Department : BaseModel
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }
}