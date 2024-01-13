using System.Threading.Channels;

namespace ConsoleApp2;

public static class Manager
{
    public static List<User> Users = new();

    public static void AddNewUser(string name, string id , DaraiiNezami daraiiNezami)
    {
        User newUser = new(name, id,  daraiiNezami);
        Users.Add(newUser);
    }

    public static void ShowDaraiiNezami(string userName)
    {
        var user = Users.Find(_ => _.Name == userName);
        if (user?.Name==null)
        {
            throw new Exception("Invalid Name!!");
        }
        Console.WriteLine($"Count Of Soldiers = {user.DaraiiNezami.Soldier} | Count Of Tanks = {user.DaraiiNezami.Tank}" +
                          $"Count Of Jets = {user.DaraiiNezami.Jet}");
        Console.WriteLine($"Special Items: ");
        foreach (var item in user.DaraiiNezami.Vizhes)
        {
            Console.WriteLine($"Name  = {item.ItemName} | Count = {item.Stock}"); 
        }
    }

    public static void ShowUserDetail(string userName)
    {
        var user = Users.Find(_ => _.Name == userName);
        if (user?.Name==null)
        {
            throw new Exception("Invalid Name!");
        }

        Console.WriteLine($"User Name = {user.Name} | User Id = {user.Id} ");
    }

    public static void AddSpecialItem(string userName, Vizhe vizhe)
    {
        User user = Users.Find(_ => _.Name == userName);
        if (user?.Name==null)
        {
            throw new Exception("Invalid Name!!");
        }
        user.DaraiiNezami.Vizhes.Add(vizhe);
    }
}