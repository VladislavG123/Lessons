using ConsoleApp1;
using ConsoleApp2;


var users = new List<User>
{
    new() { Id = 1, Name = "Rakhat", Email = "asd@asD", Sex = true},
    new() { Id = 2, Name = "aRLAN", Email = "123@asD", Sex = true },
    new() { Id = null, Name = "Daniar", Email = "cvb@fg", Sex = true },
    new() { Id = 3, Name = "Adema", Email = "cvb@fg", Sex = false }
};


// Show all users, where ID != null, GroupBy Sex
// 1: Rakhat, Arlan
// 2: Adema, Aisha

var groupedGroupMatesBySex = users.Where(IsNotNull);


var groupedGroupMatesBySex2 = users
    .Where(user => user.Id != null)
    .GroupBy(user => user.Sex);

foreach (var group in groupedGroupMatesBySex2)
{
    Console.WriteLine(group.Key ? "\nMale:" : "\nFemale:");
    foreach (var user in group.ToList())
    {
        Console.WriteLine(user.Name);
    }
}

// Why is it ok:
// 1) Both return bool
// 2) Both takes User as an argument

bool IsNotNull(User user) => user.Id != null;



var engineElectric = new EngineElectric();

//var car = new Car<EngineDVS>(new EngineElectric());

//Console.WriteLine(car.GetEngine());

abstract class Engine
{ 
    public override string ToString()
    {
        return "Engine + ";
    }
}
class EngineDVS : Engine
{
    public override string ToString()
    {
        return base.ToString() + "This is EngineDVS";
    }
}
class EngineElectric : Engine
{
    public override string ToString()
    {
        return base.ToString() + "This is EngineElectric";
    }
}






class User
{
    public int? Id { get; set; }
    
    public string Name { get; set; }
    public bool Sex { get; set; }
    public string Email { get; set; }
}