namespace ConsoleApp2;

public class Vizhe
{
    private int _stock;
    private string _itemName;
    public Vizhe(string itemName , int stock)
    {
        Stock = stock;
        ItemName = itemName;
    }

    public int Stock
    {
        get { return _stock;}
        private set
        {
            if (value<=0)
            {
                throw new Exception("Invalid Stock!!");
            }

            _stock = value;
        } 
    }
    public string ItemName
    {
        get { return _itemName;}
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Invalid Name!!");
            }

            _itemName = value;
        } 
    }
}