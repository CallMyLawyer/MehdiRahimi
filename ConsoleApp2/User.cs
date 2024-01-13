namespace ConsoleApp2;

public class User
{
    private string _name;
    private string _id;
    public User(string name ,string id , DaraiiNezami daraiiNezami )
    {
        Name = name;
        Id = id;
        DaraiiNezami = daraiiNezami;
    }

    public DaraiiNezami DaraiiNezami { get; set; }
    public string Name
    {
        get { return _name;}
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Invalid Name!");
            }

            _name = value;
        }   
    }

    public string Id
    {
        get { return _id;}
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length>3 )
            {
                throw new Exception("Invalid Id!");
            }

            _id = value;
        }
    }
}