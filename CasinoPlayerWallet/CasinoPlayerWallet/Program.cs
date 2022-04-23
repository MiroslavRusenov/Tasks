using CasinoPlayerWallet;
using System.Globalization;
class Program
{
    static void Main()
    {
        Wallet wallet = new();
        Console.WriteLine("Please, submit action:");
        string? command = Console.ReadLine();

        while (command != "exit")
        {
            string[] parameters = command?.Split(" ") ?? Array.Empty<string>();
            string? operation = parameters.ElementAtOrDefault(0);
            string? value = parameters.ElementAtOrDefault(1);
            decimal amount = !string.IsNullOrWhiteSpace(value) ? decimal.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out amount) ? Math.Abs(amount) : 0 : 0;

            switch (operation)
            {
                case "deposit":
                    wallet.Deposit(amount);
                    break;
                case "withdraw":
                    wallet.Withdraw(amount);
                    break;
                case "bet":
                    wallet.Bet(amount);
                    break;
                default:
                    Console.WriteLine($"Invalid operation.\n");
                    break;
            }

            Console.WriteLine("Please, submit action:");
            command = Console.ReadLine() ?? "";
        }
        Console.WriteLine("Thank you for playing! Hope to see you again soon.");
    }
}

