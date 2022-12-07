using vetoresParte2;
using System.Globalization;

int n = int.Parse(Console.ReadLine());

Product[] prodvec = new Product[n];

for (int i = 0; i< n; i++)
{
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    prodvec[i] = new Product(name, price);
}

double sum = 0.0;
for (int i = 0; i< n; i++)
{
    sum += prodvec[i].Price;
}

double avg = sum/ n;

Console.WriteLine("AVERAGE PRICE = " + avg);