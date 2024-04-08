// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

List<ProductType> types = new List<ProductType>()
{
    new ProductType()
    {
        Id = 1,
        Name = "apparel"
    },
     new ProductType()
    {
        Id = 2,
        Name = "potions"
    },
     new ProductType()
    {
        Id = 3,
        Name = "enchanted objects"
    },
     new ProductType()
    {
        Id = 4,
        Name = "wands"
    }

};

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Hoodie",
        Price = 20.00M,
        Available = true,
        Type = types.Find(type => type.Id == 1)

    },
    new Product()
    {
        Name = "Scarf",
        Price = 5.00M,
        Available = true,
        Type = types.Find(type => type.Id == 1)

    },
    new Product()
    {
        Name = "Santa Hat",
        Price = 15.00M,
        Available = false,
        Type = types.Find(type => type.Id == 1)

    },
        new Product()
    {
        Name = "Red Potion",
        Price = 60.00M,
        Available = true,
        Type = types.Find(type => type.Id == 2)

    },
       new Product()
    {
        Name = "Green Potion",
        Price = 50.00M,
        Available = false,
        Type = types.Find(type => type.Id == 2)

    },
       new Product()
    {
        Name = "Blue Potion",
        Price = 70.00M,
        Available = true,
        Type = types.Find(type => type.Id == 2)

    },
       new Product()
    {
        Name = "Happy Block",
        Price = 30.00M,
        Available = true,
        Type = types.Find(type => type.Id == 3)

    },
      new Product()
    {
        Name = "Angry Block",
        Price = 30.00M,
        Available = true,
        Type = types.Find(type => type.Id == 3)

    },
      new Product()
    {
        Name = "Indifferent Block",
        Price = 30.00M,
        Available = true,
        Type = types.Find(type => type.Id == 3)

    },
      new Product()
    {
        Name = "Pretzel Stick",
        Price = 1.00M,
        Available = true,
        Type = types.Find(type => type.Id == 4)

    },
       new Product()
    {
        Name = "Bread Stick",
        Price = 1.00M,
        Available = true,
        Type = types.Find(type => type.Id == 4)

    },
    
    
};
Console.WriteLine("Hello, World!");
string choice = null;
while(choice != "0")
{
    Console.WriteLine(@"Select one of the following Options:
                        1. View Products");
    choice = Console.ReadLine();
    if (choice =="0")
    {
        Console.WriteLine("Closing App, too bad");
    }
    if (choice == "1")
    {
        throw new NotImplementedException("Display");
    }
}

