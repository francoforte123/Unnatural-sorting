List<int> listOfNumbersRandom = new();
Random numbersRandom= new Random();

for(int i = 0; i < 1001; i++)
{
    listOfNumbersRandom.Add(numbersRandom.Next(0, 1001));
}

Console.WriteLine("sto stampando i numeri random presenti nella lista:");
foreach (int numbers in listOfNumbersRandom)
{
    Console.WriteLine(numbers);
}

Console.WriteLine("----------------------------------------");

List<int> listOrdered= listOfNumbersRandom.OrderBy(x => x.ToString().Length).ToList();

Console.WriteLine("sto stampando i dati per lunghezza di caratteri:");
foreach (int x in listOrdered)
{
    Console.WriteLine(x);
}



