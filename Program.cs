using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationUni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void printOptions()
            {
                Console.WriteLine("Choose from following opt");
                Console.WriteLine("1: Deposit");
                Console.WriteLine("2: Widraw");
                Console.WriteLine("3: Show Balance");
                Console.WriteLine("4: Exit");
                
            }

            void deposit(AtmCard CurrentUser)
            {
                Console.WriteLine("How much $$ you like to deposit");

                 double deposite = Double.Parse(Console.ReadLine());
                 CurrentUser.setbalance(deposite);      
                Console.WriteLine("Thankyou for your $$ and your new balance is: " +CurrentUser.getbalance());
            
            }
            void widRaw(AtmCard CurrentUser)
            {
                Console.WriteLine("How much you want to  $$ widraw:");
                double widraw = double.Parse(Console.ReadLine());
                if(CurrentUser.getbalance() > widraw)
                {
                    Console.WriteLine("Infuccient balance");
                }
                else
                {
                    
                    CurrentUser.setbalance(CurrentUser.getbalance() - widraw);
                    Console.WriteLine("Thank You.");

                }

            }
            void balance(AtmCard CurrentUser)
            {
                Console.WriteLine("Current balance: " + CurrentUser.getbalance());
            }
            
            List<AtmCard> Atm = new List<AtmCard>();

            Atm.Add(new AtmCard("Hasnain", "Khan" , 1300.84, 123, "739152463078300"));
            Atm.Add(new AtmCard("Akash", "Kumar", 190.90, 1234, "8021477820025780"));
            Atm.Add(new AtmCard("adan", "Shakir", 140000.30, 12345, "7302155726877208"));
            Atm.Add(new AtmCard("Umair", "Iqbal", 15000.20, 123456, "2013659547220902"));
            Atm.Add(new AtmCard("amber", "Javed", 1450.10, 1234567, "9361650016348907"));

            Console.WriteLine("Welcome to fake bank");
            Console.WriteLine("Enter your debit card numb:");

            String debitcardnum = "";
            AtmCard currentUser;

            int userPin = 0;

            
            while(true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());


                    if (currentUser.getpin() == userPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect pin");
                    }


                }
                catch
                {

                    Console.WriteLine("Pin is invalid");

                }
                Console.WriteLine("Welcome" + currentUser.getfirstname() + ":)");
                int option = 0;
                do
                {
                    printOptions();
                    try
                    {
                        option = int.Parse(Console.ReadLine()); 

                    }
                    catch { 
                    
                    
                    }
                    if(option == 1)
                    {
                        deposit(currentUser);
                    }
                    else if(option == 2)
                    {
                        widRaw(currentUser);
                    }
                    else if (option == 3)
                    {
                        balance(currentUser);
                    }
                    else if (option == 4)
                    {
                        break;
                    }
                    else
                    {
                        option = 0;
                    }
                }
                while(option != 4);
                {
                    Console.WriteLine("ThankYou ! Have a nice day Dear Customer :)");
                }
            
            
            }    
        }
    }
}
