using ConsoleApp2;

while (true)
{
    try
    {
        Run();
    }
    catch (Exception exception)
    {
        Error(exception.Message);
    }
}

static void Run()
{
    bool res;
    do
    {
        Console.WriteLine("1.Add New User\n2.Show User Detail\n3.Add New Special Item");
        res = int.TryParse(Console.ReadLine()!, out int option);
        switch (option)
        {
            case 1 :
                var name =GetString("Enter Ur Name:");
                var id = GetString("Enter Ur Id:");
                var newDaraiiNezami = new DaraiiNezami(soldier:50 , tank:15 ,jet:20 , vizhes:new List<Vizhe>());
                Manager.AddNewUser(name , id , newDaraiiNezami);
                break;
            case 2:
                var userName = GetString("Enter The User Name:");
                Manager.ShowUserDetail(userName);
                Manager.ShowDaraiiNezami(userName);
                break;
            case 3 :
                userName = GetString("Enter The User Name:");
                var itemName = GetString("Enter Item Name:");
                var stock = GetInt("Enter Item Count:");
                Manager.AddSpecialItem(userName , new Vizhe(itemName , stock));
                break;
        }
    } while (!res);
}



static int GetInt(string message)
{
    Console.WriteLine(message);
    var value = int.Parse(Console.ReadLine()!);
    return value;
}
static string GetString(string message)
{
    Console.WriteLine(message);
    var value = Console.ReadLine()!;
    return value;
}

static void Error(string error)
{
    Console.WriteLine($"Error = {error}");
}