using MetodosAbstract.Entities;


List<Payers> payers = new List<Payers>();

Console.Write("Enter the number of tax payers: ");

int n = int.Parse(Console.ReadLine());  

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");

    Console.Write("Individual or company (i/c)? ");

    char ch = char.Parse( Console.ReadLine() );

    Console.Write("Name: ");

    string name = Console.ReadLine();

    Console.Write("Anual income: ");

    double anualIncome = double.Parse(Console.ReadLine());

    switch (ch)
    {
        case 'i':
            {
                Console.Write("Health expenditure: ");

                double healthExpenditures = double.Parse(Console.ReadLine());

                payers.Add(new IndividualPayer(name, anualIncome, healthExpenditures));
            }
            break;
        case 'c':
            {
                Console.Write("Number of employees: ");

                int numberEmployees = int.Parse(Console.ReadLine());

                payers.Add(new CompanyPayer(name, anualIncome, numberEmployees));
            }
            break;
    }

}

Console.WriteLine( );
Console.WriteLine("TAXES PAID:");

double soma = 0;

foreach (var item in payers)
{
    soma += item.TotalImposto();
    Console.WriteLine($"{item.Name} $ {item.TotalImposto().ToString("N2")}");
}

Console.WriteLine($"TOTAL TAXAS: {soma.ToString("N2")}");