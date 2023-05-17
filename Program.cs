using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            // ATM Interface
            Console.WriteLine("Welcome to My ATM");
            Console.Write("Please Enter Your PIN: ");
            string pin = Console.ReadLine();

            // Validate PIN
            if (pin != "1234")
            {
                Console.WriteLine("Invalid PIN. Please try again.");
                Console.ReadLine();
                return;
            }

            // Display Menu
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Balance Inquiry");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Deposit");

            // Prompt for Selection
            Console.Write("\nEnter Selection: ");
            int selection = int.Parse(Console.ReadLine());

            // Process Selection
            switch (selection)
            {
                case 1:
                    Console.WriteLine("\nYour Balance is ₹1000");
                    break;
                case 2:
                    Console.Write("\nEnter Amount to Withdraw: ");
                    int withdraw = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nDispensing ₹" + withdraw);
                    Console.WriteLine("Your Balance is ₹1000 - ₹" + withdraw + " = ₹" + (1000 - withdraw));
                    break;
                case 3:
                    Console.Write("\nEnter Amount to Deposit: ");
                    int deposit = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nDepositing ₹" + deposit);
                    Console.WriteLine("Your Balance is ₹1000 + ₹" + deposit + " = ₹" + (1000 + deposit));
                    break;
                default:
                    Console.WriteLine("\nInvalid Selection. Please try again.");
                    break;
            }

            // Pause Console
            Console.ReadLine();
        }
    }
}
