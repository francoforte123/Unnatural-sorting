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

List<int> listOrdered= listOfNumbersRandom.OrderBy(x => x.ToString().Length).ToList();

listOrdered.ForEach(Console.WriteLine);



