namespace _06._Money_Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bankAccountsInput = Console.ReadLine().Split(',');
            Dictionary<int, double> bankAccounts = new();
            foreach (string bankAccount in bankAccountsInput) 
            {
                string[] split = bankAccount.Split("-");
                int accountId = int.Parse(split[0]);
                double accountBalance = double.Parse(split[1]);
                bankAccounts.Add(accountId, accountBalance);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split();
                try
                {
                    if (command[0] == "Deposit")
                    {
                        int accountNumber = int.Parse(command[1]);
                        double sum = double.Parse(command[2]);
                        bankAccounts[accountNumber] += sum;
                    }
                    else if (command[0] == "Withdraw")
                    {
                        int accountNumber = int.Parse(command[1]);
                        double sum = double.Parse(command[2]);
                        if (bankAccounts[accountNumber] < sum)
                        {
                            throw new InvalidOperationException();
                        }
                        bankAccounts[accountNumber] -= sum;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                    Console.WriteLine($"Account {command[1]} has new balance: {bankAccounts[int.Parse(command[1])]:f2}");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid command!");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Insufficient balance!");
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Invalid account!");
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }
    }
}
