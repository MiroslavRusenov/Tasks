namespace CasinoPlayerWallet
{
    public class Wallet
    {
        private decimal balance;

        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine(FormattableString.Invariant($"Your deposit of ${amount:0.00} was successful. Your current balance is: ${balance:0.00}\n"));
                return true;
            }
            Console.WriteLine(FormattableString.Invariant($"Your deposit of ${amount:0.00} was not successful. Your current balance is: ${balance:0.00}\n"));
            return false;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine(FormattableString.Invariant($"Your withdrawal of ${amount:0.00} was successful. Your current balance is: ${balance:0.00}\n"));
                return true;
            }
            Console.WriteLine(FormattableString.Invariant($"Your withdrawal of ${amount:0.00} was not successful. Your current balance is: ${balance:0.00}\n"));
            return false;
        }

        public bool Bet(decimal amount)
        {
            if (amount >= 1 && amount <= 10)
            {
                if (amount <= balance)
                {
                    Random random = new();
                    int chance = random.Next(0, 100);
                    if (chance <= 50)
                    {
                        balance -= amount;
                        Console.WriteLine(FormattableString.Invariant($"No luck this time! Your current balance is: ${balance:0.00}\n"));
                        return true;
                    }
                    else
                    {
                        decimal winnings = Convert.ToDecimal(amount + (amount * random.Next(1, 100) / 100m * (chance <= 90 ? random.Next(1, 2) : random.Next(2, 8))));
                        balance += winnings;
                        balance -= amount;
                        Console.WriteLine(FormattableString.Invariant($"Congrats - you won ${winnings:0.00}! Your current balance is: ${balance:0.00}\n"));
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine($"Insufficient funds.\n");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"Please, insert value between 1$ and 10$\n");
                return false;
            }
        }
    }
}
