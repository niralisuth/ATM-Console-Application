using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ATMMM
{

    public class cardHolder
    {

        public string cardNum;
        public int pin;
        public string firstName;
        public string lastName;
        public double balance;

        public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;

        }
        public string getNum()
        {
            return cardNum;
        }

        public int getPin()
        {
            return pin;
        }

        public string getfirstName()
        {
            return firstName;
        }

        public string getlastName()
        {
            return lastName;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setNum(string newCardNum)
        {
            cardNum = newCardNum;
        }

        public void setPin(int newPin)
        {
            pin = newPin;
        }
        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }
        public void setLastName(string newlastName)
        {
            lastName = newlastName;
        }
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }
    }


    class program
    {
        public static void Main(string[] args)
        {

            void printOptions() {
                Console.WriteLine("Please choose from the following options: ");
                Console.WriteLine("1. Deposite");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Balance");
                Console.WriteLine("4. Exit");
            }

            void deposite(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to deposite ");
                double deposite = double.Parse(Console.ReadLine());
                currentUser.setBalance(currentUser.getBalance() + deposite);
                Console.WriteLine("Thank you for depositing. Your current balance is {0}", currentUser.getBalance());
            }

            void withdraw(cardHolder currentUser)
            {
                Console.WriteLine("How much money would you like to withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());

                // check if user has enough money to withdraw

                if (currentUser.getBalance() < withdraw)
                {
                    Console.WriteLine("Insufficient balance!!");
                }

                else
                {
                    currentUser.setBalance(currentUser.getBalance() - withdraw);
                    Console.WriteLine("Thank you for withdrawing money. You current balance is: {0}", currentUser.getBalance());
                    Console.WriteLine("Thank You");
                }
            }
            void balance(cardHolder currentUser)
            {
                Console.WriteLine("current balance: {0}", currentUser.getBalance());

            }

            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("50645978956", 1238, "Nirali", "Suthar", 2500000));
            cardHolders.Add(new cardHolder("58958965845", 5686, "Josh", "Joe", 2565.56));
            cardHolders.Add(new cardHolder("25686586482", 1565, "Jyoti", "Suthar", 486586));
            cardHolders.Add(new cardHolder("15358648652", 4585, "Rohit", "Sharma", 5000));
            cardHolders.Add(new cardHolder("25486589721", 2365, "Virat", "kohli", 56865.56));
            cardHolders.Add(new cardHolder("12589456585", 2564, "Ashwin", "sharma", 5869.56));

            //prompt user

            Console.WriteLine("Welcome to NRI ATM");
            Console.WriteLine("Please insert your debit card: ");
            string debitCardNum = "";
            cardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    //check with our db
                    currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                    if (currentUser != null) { break; }
                    else
                    {
                        Console.WriteLine("Card not recognized. Please enter the card again.");
                    }

                }
                catch
                {
                    Console.WriteLine("Card not recognized. Please enter the card again."); ;
                }
            }

            Console.WriteLine("Please enter your pin: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.getPin() == userPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect pin. Please try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect pin. Please try again");
                }

            }

            Console.WriteLine("Welcome {0} {1}.", currentUser.getfirstName(), currentUser.getlastName());
            int options = 0;
            do
            {
                printOptions();
                try
                {
                    options = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {


                }
                if (options == 1) { deposite(currentUser); }
                else if (options == 2) { withdraw(currentUser); }
                else if (options == 3) { balance(currentUser); }
                else if (options == 4) { break; }
                else { options = 0; }

            } while (options == 4);
            Console.WriteLine("Thank you for visiting NRI ATM. Have a nice day!!");

        }


    }


}







