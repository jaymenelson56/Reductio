public class ProductType
{
    
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Available { get; set; }
    public int Type { get; set; }
    public DateTime DateStocked { get; set; }
    public int DaysOnShelf
    {
        get
        {
            TimeSpan timeOnShelf = DateTime.Now -DateStocked;
            return timeOnShelf.Days;
        }
    }

}