                        using EnumComposicao.Entities.Enums;
                        using EnumComposicao.Entities;
                        using System.Threading.Channels;

                        Console.WriteLine( "Enter cliente data:");

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        Console.Write("Birth  date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Order data: ");

                        Console.Write("Status: ");
                        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

                        Client client = new Client(name, email, date);
                        Order order = new Order(status, client);

                        Console.Write($"How many items to this order? ");
                        int n = Int32.Parse(Console.ReadLine());

                        for (int i = 1; i <= n; i++)
                        {
                            Console.WriteLine($"Enter com o #{i} item data:");

                            Console.Write($"Product name: ");
                            string nameprod = Console.ReadLine();

                            Console.Write($"Product price: ");
                            double price = double.Parse(Console.ReadLine());

                            Product product = new Product(nameprod, price);

                            Console.Write($"Product quantity: ");
                            int quantity = Int32.Parse(Console.ReadLine());


                            OrderItem orderItem = new OrderItem(quantity, price, product);

                            order.AddItem(orderItem);
                        }

                        Console.WriteLine();
                        Console.WriteLine("ORDER SUMMARY:");
                        Console.WriteLine(order);


