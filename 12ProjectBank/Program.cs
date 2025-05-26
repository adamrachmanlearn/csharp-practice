using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBank
{
    class BankAccount
    {
        private string username;
        private string password;
        private double balance;

        public string Username
        {
            get => username;
            set => username = value;
        }
        public string Password
        {
            get => password;
            set => password = value;
        }
        public double Balance
        {
            get => balance;
            set => balance = value;
        }

        public BankAccount(string username, string password, double balance)
        {
            Username = username;
            Password = password;
            Balance = balance;
        }
        public void Deposit(double money)
        {
            if (money <= 0)
            {
                Console.WriteLine(">>> Cant deposit zero or a negative amount\n");
                return;
            }
            Balance += money;
            Console.WriteLine($">>> {money} has successfully deposited\n");
        }
        public void Withdraw(double money)
        {
            if (money > 0)
            {
                if (Balance - money < 0)
                {
                    Console.WriteLine(">>> Cant withdraw exceeding balance\n");
                    return;
                }
                Balance -= money;
                Console.WriteLine($">>> {money} has successfully withdrawn\n");
            }
            else
            {
                Console.WriteLine(">>> Cant withdraw zero or a negative amount\n");
            }
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }

    class Program
    {
        static string ReadString(string message)
        {
            string username = "";
            bool loop = true;
            while (loop)
            {
                Console.Write($"{message}: ");
                username = Console.ReadLine();
                if (!string.IsNullOrEmpty(username))
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine(">>> Field cant be empty\n");
                }
            }
            return username;
        }

        static int ReadInt(string message)
        {
            int number = 0;
            bool loop = true;
            while (loop)
            {
                Console.Write($"{message}: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine(">>> Please enter a number\n");
                }
            }
            return number;
        }
        static double ReadDouble(string message)
        {
            double number = 0;
            bool loop = true;
            while (loop)
            {
                Console.Write($"{message}: ");
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine(">>> Please enter a number\n");
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            BankAccount currentAccount = default;
            BankAccount dummyAcc1 = new BankAccount("carmen", "carmen", 50000);
            BankAccount dummyAcc2 = new BankAccount("yuha", "yuha", 70000);
            BankAccount dummyAcc3 = new BankAccount("yeon", "yeon", 14000);
            accounts.Add(dummyAcc1);
            accounts.Add(dummyAcc2);
            accounts.Add(dummyAcc3);

            bool entryLoop = true;
            bool skip = false;
            while (entryLoop)
            {
                Console.WriteLine(">>> Welcome to Bank Program");
                Console.WriteLine("1. Create new account");
                Console.WriteLine("2. Log into an existing account");
                Console.WriteLine("0. Exit program");
                int choice = ReadInt("Select the option");
                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine(">>> Exiting program...");
                        entryLoop = false;
                        skip = true;
                        break;
                    case 1:
                        {
                            Console.Clear();
                            string username = ReadString("Enter a username");
                            bool passwordLoop = true;
                            string password = "";
                            while (passwordLoop)
                            {
                                password = ReadString("Enter a password");
                                string confirmation = ReadString("Confirm the password");
                                if (password.Equals(confirmation))
                                {
                                    passwordLoop = false;
                                }
                                else
                                {
                                    Console.WriteLine(">>> Passwords do not match\n");
                                }
                            }
                            bool balanceLoop = true;
                            double balance = 0;
                            while (balanceLoop)
                            {
                                balance = ReadDouble("Enter balance");
                                if (balance < 0)
                                {
                                    Console.WriteLine(">>> Balance cant be negative amount\n");
                                }
                                else if (balance > int.MaxValue)
                                {
                                    Console.WriteLine($">>> Balance cant exceed {int.MaxValue}\n");
                                }
                                else
                                {
                                    balanceLoop = false;
                                }
                            }
                            BankAccount newAccount = new BankAccount(username, password, balance);
                            accounts.Add(newAccount);
                            currentAccount = newAccount;
                            entryLoop = false;
                            Console.Clear();
                            Console.WriteLine(">>> Account created successfully\n");
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            string username = ReadString("Enter a username");
                            bool accountFound = false;
                            int index = 0;
                            for (int i = 0; i < accounts.Count; i++)
                            {
                                if (accounts[i].Username.Equals(username))
                                {
                                    accountFound = true;
                                    index = i;
                                }
                            }
                            if (accountFound)
                            {
                                currentAccount = accounts[index];
                                entryLoop = false;
                            }
                            else
                            {
                                Console.WriteLine(">>> Account not found\n");
                            }
                            bool passwordLoop = true;
                            while (passwordLoop)
                            {
                                string password = ReadString("Enter the password");
                                if (password.Equals(currentAccount.Password))
                                {
                                    Console.Clear();
                                    Console.WriteLine($">>> Logged in as {currentAccount.Username}\n");
                                    passwordLoop = false;
                                }
                                else
                                {
                                    Console.WriteLine(">>> Wrong password\n");
                                }
                            }
                        }
                        break;
                    default:
                        Console.WriteLine(">>> Please enter 0 - 2\n");
                        break;
                }
            }

            bool mainLoop = true;
            if (skip.Equals(true)) mainLoop = false;
            while (mainLoop)
            {
                Console.WriteLine(">>> Menu");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Account Info");
                Console.WriteLine("0. Exit");
                int choice = ReadInt("Select the option");
                switch (choice)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine(">>> Exiting program...");
                        mainLoop = false;
                        break;
                    case 1:
                        {
                            Console.Clear();
                            double money = ReadDouble("Enter amount to deposit");
                            currentAccount.Deposit(money);
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            double money = ReadDouble("Enter amount to withdraw");
                            currentAccount.Withdraw(money);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        currentAccount.DisplayAccountInfo();
                        Console.WriteLine("Press any key to return...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine(">>> Please choose between 0 - 3\n");
                        break;
                }
            }
            System.Threading.Thread.Sleep(1000);
        }
    }
}