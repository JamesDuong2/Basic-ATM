using System;
class program
{
    public static void Main()
    {
        
        int amount = 1000, deposit, withdraw;
        int choice, pin = 0, x = 0;
        Console.WriteLine("Enter Your Pin Number: ");
        pin = int.Parse(Console.ReadLine());
        while(true)
        {
            Console.WriteLine("Welcome to ATM Service\n");
            Console.WriteLine("Please enter your choice: \n");
            Console.WriteLine("1.Check Balance\n");
            Console.WriteLine("2.Withdraw\n");
            Console.WriteLine("3.Deposit\n");
            Console.WriteLine("4.Quit\n");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Your Balance: {0}\n", amount);
                    break;
                case 2:
                    Console.WriteLine("Enter the amount to withdraw: \n")
                    withdraw = int.Parse(Console.ReadLine());
                    if (withdraw % 100 != 0)
                    {
                        Console.WriteLine("Please enter the amount in multiples of 100\n");

                    }
                    else if (withdraw > (amount - 500))
                    {
                        Console.WriteLine("\n Insufficient balance");
                    }
                    else
                    {
                        amount = amount - withdraw;
                        Console.WriteLine("\nYour cash has been withdrawn");
                        Console.WriteLine("\nYour current balance is {0}", amount);
                    }
                    break;
                case 3:
                    Console.WriteLine("\n Enter the amount to deposit");
                    deposit = int.Parse(Console.ReadLine());
                    amount = amount + deposit;
                    Console.WriteLine("\nYour balance is {0}", amount);
                    break;
                case 4:
                    Console.WriteLine("\n Thank you for using our ATM");
                    break;


            }
        }
        Console.WriteLine("\n Thank you for using our ATM service. Have a wonderful day.");
    }
}