using HerancaPolimorfismo.Entities;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data: ");

    Console.Write("Common, used or imported (c/u/i)");

    char ch = char.Parse(Console.ReadLine());

    Console.Write("Name: ");

    string name = Console.ReadLine();

    Console.Write("Price: ");

    double price = double.Parse(Console.ReadLine());

    switch (ch)
    {
        case 'c':
        {
            products.Add(new Product(name, price));
        }
        break;
        case 'u':
        {
            Console.Write("Manufature date (DD/MM/YYYY): ");

            DateTime manofactureDate = DateTime.Parse(Console.ReadLine());

            products.Add(new UsedProduct(name, price, manofactureDate));

        }
        break;
        case 'i':
        {
            Console.Write("Customs fee: ");

            double customsFee = double.Parse(Console.ReadLine());

            products.Add(new ImportedProduct(name, price, customsFee));

        }
        break;
    }

    
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");

foreach (var item in products)
{
    Console.WriteLine(item.PriceTag());
}



