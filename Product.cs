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
    public ProductType Type { get; set; }

}