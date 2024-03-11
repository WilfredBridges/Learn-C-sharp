// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Money Maker!");

Console.WriteLine("Enter an amount to convert to coins:");
string amount = Console.ReadLine();
Console.WriteLine($"{amount} cents is equal to...");
double amountAsDouble = Convert.ToDouble(amount);

int gold = 10;
int silver = 5;


double goldCoins = Math.Floor(amountAsDouble / gold);
double remainder = amountAsDouble % gold;
double silverCoins = Math.Floor(remainder / silver);
double bronzeCoins = remainder % silver;

Console.WriteLine($"Gold coins: {goldCoins}");
Console.WriteLine($"Silver coins: {silverCoins}");
Console.WriteLine($"Bronze coins: {bronzeCoins}");
Console.WriteLine($"Total coins: {goldCoins + silverCoins + bronzeCoins}");


