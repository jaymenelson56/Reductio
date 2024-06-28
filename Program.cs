// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

List<ProductType> types = new List<ProductType>()
{
    new ProductType()
    {
        Id = 1,
        Name = "Apparel"
    },
     new ProductType()
    {
        Id = 2,
        Name = "Potions"
    },
     new ProductType()
    {
        Id = 3,
        Name = "Enchanted objects"
    },
     new ProductType()
    {
        Id = 4,
        Name = "Wands"
    }

};

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Hoodie",
        Price = 20.00M,
        Available = true,
        Type = 1,
        DateStocked = new DateTime(2024, 1, 1)

    },
    new Product()
    {
        Name = "Scarf",
        Price = 5.00M,
        Available = true,
        Type = 1,
        DateStocked = new DateTime(2024, 1, 1)

    },
    new Product()
    {
        Name = "Santa Hat",
        Price = 15.00M,
        Available = false,
        Type = 1,
        DateStocked = new DateTime(2024, 1, 1)

    },
        new Product()
    {
        Name = "Red Potion",
        Price = 60.00M,
        Available = true,
        Type = 2,
        DateStocked = new DateTime(2024, 1, 1)

    },
       new Product()
    {
        Name = "Green Potion",
        Price = 50.00M,
        Available = false,
        Type = 2,
        DateStocked = new DateTime(2024, 1, 1)
        

    },
       new Product()
    {
        Name = "Blue Potion",
        Price = 70.00M,
        Available = true,
        Type = 2,
        DateStocked = new DateTime(2024, 1, 1)

    },
       new Product()
    {
        Name = "Happy Block",
        Price = 30.00M,
        Available = true,
        Type = 3,
        DateStocked = new DateTime(2024, 2, 1)

    },
      new Product()
    {
        Name = "Angry Block",
        Price = 30.00M,
        Available = true,
        Type = 3,
        DateStocked = new DateTime(2024, 2, 1)

    },
      new Product()
    {
        Name = "Indifferent Block",
        Price = 30.00M,
        Available = true,
        Type = 3,
        DateStocked = new DateTime(2024, 2, 1)

    },
      new Product()
    {
        Name = "Pretzel Stick",
        Price = 1.00M,
        Available = true,
        Type = 4,
        DateStocked = new DateTime(2024, 3, 1)

    },
       new Product()
    {
        Name = "Bread Stick",
        Price = 1.00M,
        Available = true,
        Type = 4,
        DateStocked = new DateTime(2024, 3, 1)

    },
    
    
};
Console.WriteLine("Hello, World!");
string choice = null;
while(choice != "0")
{
    Console.WriteLine(@"Select one of the following Options:
                        0. Exit
                        1. View All Products
                        2. View Products by type
                        3. Add Product
                        4. Update Innventory
                        5. Delete Product from inventory");
    choice = Console.ReadLine();
    if (choice =="0")
    {
        Console.WriteLine("Closing App, too bad");
    }
    else if (choice == "1")
    {
        ListProducts();
    }
    else if (choice == "2")
    {
        TypeList();
    }
    else if (choice == "3")
    {
        AddProduct();
    }
    else if (choice == "4")
    {
        EditProduct();
    }
    else if (choice == "5")
    {
        DeleteProduct();
    }
}

void ListProducts()
{
    Console.WriteLine("All Products");
    
    int count = 1;
    foreach (Product product in products)
    {
        Console.WriteLine(@$"{count}.{product.Name} in {types[product.Type - 1].Name}, {(product.Available ? "is available" : "was sold for")} for {product.Price} dollars. It has been on the shelf for {product.DaysOnShelf} days.
        ");
        count++;
    }
}

void TypeList()
{
    string option = null;
    while(option != "0")
    {
    Console.WriteLine(@"Select type of product you wish to view
                        0. Back to menu
                        1. Apparel
                        2. Potions
                        3. Enchanted Objects
                        4. Wands");
    option = Console.ReadLine();
    if (option == "1")
    {
        ProductTypes(1);
        
    }
    else if (option == "2")
    {
        ProductTypes(2);
        
    }
    else if (option == "3")
    {
        ProductTypes(3);
        
    }
    else if (option == "4")
    {
        ProductTypes(4);
        
    }
    
    
    else if (option == "0")
    {
        return;
    }
    else
    {
        Console.WriteLine("Try Again");
    }
    }
}

void ProductTypes(int typeId)
{
    Console.WriteLine($"{types[typeId -1].Name} Products");
    
    int count = 1;
    foreach (Product product in products)
    {
        if (product.Type == typeId)
        {
        Console.WriteLine($"{count}.{product.Name} in {types[product.Type - 1].Name}, {(product.Available ? "is available" : "was sold for")} for {product.Price} dollars.");
        count++;
        }
    }
}
void AddProduct()
{
    Console.WriteLine("Add item to the inventory");
    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    decimal price;
    while(!decimal.TryParse(Console.ReadLine(), out price))
    {
        Console.WriteLine("Wrong Format");
    }
    Console.WriteLine(@"What type of product is it?
                        1. Apparel
                        2. Potions
                        3. Enchanted Objects
                        4. Wands");
    Console.Write("Type in the number: ");
    int type;
    while(!int.TryParse(Console.ReadLine(), out type) || type < 1 || type > 4)
    {
        Console.WriteLine("Unnacceptable, use the proper format and pick from 1-4");
    }
    Product newProduct = new Product()
    {
        Name = name,
        Price = price,
        Available = true,
        Type = type
    };
    products.Add(newProduct);
    Console.WriteLine("Thank you, Our low paid Warehouse workers will store it");
}
void EditProduct ()
{
    Console.WriteLine("Select product from Inventory to Update");
    // List Plants
    ListProducts();
    // Select Plant you want to edit
    Console.WriteLine("Type the number of the product you want to edit");
    if (!int.TryParse(Console.ReadLine(), out int productIndex) || productIndex < 1 || productIndex > products.Count)
    {
        Console.WriteLine("Invalid input.");
        return;
    }
    Product selectedProduct = products[productIndex - 1];

    Console.WriteLine("Select property to update:");
    Console.WriteLine("1. Price");
    Console.WriteLine("2. Availability");
    Console.Write("Enter your choice: ");

    if(!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > 2)
    {
        Console.WriteLine("Invalid input.");
        return;
    }

    switch (option)
    {
        case 1:
            Console.WriteLine($"Current Price: {selectedProduct.Price}");
            Console.Write("What should the new price be?");
            if (!decimal.TryParse(Console.ReadLine(), out decimal newPrice))
            {
                Console.WriteLine("Invalid price.");
                return;
            }
            selectedProduct.Price = newPrice;
            break;
        case 2:
            Console.WriteLine($"{(selectedProduct.Available ? "Is this item still available?" : "Did you get this item in stock?")}: ");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            int availability;
            if (!int.TryParse(Console.ReadLine(), out  availability) || availability < 1 || availability > 2)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            
            selectedProduct.Available = (availability == 1);
            break;
    }
    Console.WriteLine("Thank you for updating the inventory");

 
}

void DeleteProduct()
{
    Console.WriteLine("Select product to delete");
    ListProducts();

    Console.WriteLine("Type the number of the producct you want to delete:");
    // list all products
    // choose which product to delete
    if (!int.TryParse(Console.ReadLine(), out int productIndex) || productIndex < 1 || productIndex > products.Count)
    {
        Console.WriteLine("Invalid input.");
        return;
    }
    Product selectedProduct = products[productIndex - 1];
    // delete that product
    Console.WriteLine($"Are you sure you want to delete {selectedProduct.Name}? Y/N");
    string confirmation = Console.ReadLine();
    if(confirmation.ToUpper() == "Y")
    {
        products.RemoveAt(productIndex - 1);
        Console.WriteLine("Product deleted successfully");
    }
    else if (confirmation.ToUpper() == "N")
    {
        Console.WriteLine("Deletion Cancelled.");
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
    
}
