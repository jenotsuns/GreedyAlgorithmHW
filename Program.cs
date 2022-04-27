
class Program
{
    static void Main(string[] args)
    {
        double[] coinsForChange = { 2, 1, 0.5, 0.1, 0.05, 0.02, 0.01 };
        double price;
        double moneyGiven;
        int coinCount;

        Console.Write("Enter the cost of the product: ");
        price = double.Parse(Console.ReadLine());
        Console.WriteLine("><><><><><><><><><><><><");
        //var priceInCoins = (price * 100);

        Console.Write("Enter the amount you you gave: ");
        moneyGiven = double.Parse(Console.ReadLine());
        Console.WriteLine("<><><><><><><><><><><><><>");

        double change = moneyGiven - price;
        Console.WriteLine($"Amount of change is {change}\n");

        if (change <= 0)
        {
            Console.WriteLine($"Sneaky. Maybe pay next time.");
        }
        else 
            { 
            for (int i = 0; i < coinsForChange.Length; i++)
            {
            coinCount = (int)(change / coinsForChange[i]);

            
                if (coinCount != 0) { 
                    if (coinsForChange[i] == 1 || coinsForChange[i] == 2)
                        {
                         Console.WriteLine($"Amount of {0} euro(s): {1}", coinsForChange[i], coinCount);
                        }
                    else
                        {
                         Console.WriteLine($"Amount of {0} cent(s): {1}", coinsForChange[i]*100, coinCount);
                         change %= coinsForChange[i];
                        }
                    }
                }
             }
      // Console.ReadLine();
        }

    }