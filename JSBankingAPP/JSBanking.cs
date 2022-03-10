using System;

namespace JSBanking
{
    class JSBanking
    {
        static void Main(string[] args)
        {
            #region "Account Objects"
                Accounts accountObject1 = new Accounts()
                {
                    accountNumber = 0,
                    accountName = "tbd",
                    accountBalance = 0,
                    accountType = "tbd",
                    accountActive = false
                };
                Accounts accountObject2 = new Accounts()
                {
                    accountNumber = 008,
                    accountName = "Wolfram",
                    accountBalance = 8000,
                    accountType = "Checking",
                    accountActive = true
                };
            #endregion

            #region menu
                BankMenu();
            #endregion

            bool continueBanking = true;

            #region menu loop
                while(continueBanking)
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    string cont = "";
                    switch(choice)
                    {      
                        #region 1.createaccount
                        case 1:
                            accountObject1.accountNumber = 007;
                            Console.WriteLine("Okay, let's setup your new account. Please enter the following details: ");
                            Console.WriteLine("Account name: "); accountObject1.accountName = Console.ReadLine();
                            Console.WriteLine("Account Type: "); accountObject1.accountType = Console.ReadLine();
                            Console.WriteLine("Account Balance: 0"); accountObject1.accountBalance = 0;
                            Console.WriteLine("Account Email: "); accountObject1.accountEmail = Console.ReadLine();
                            accountObject1.accountActive = true;
                            accountObject2.accountActive = false;
                            Console.WriteLine("Would you like to perform another operation? (Y/N): ");
                            cont = Console.ReadLine();
                            if(cont == "y" || cont == "Y") 
                                { 
                                    Console.WriteLine("Please choose a new option from the menu: ");
                                    BankMenu();
                                    continueBanking = true; 
                                }
                            else if(cont == "n" || cont == "N") 
                                { 
                                    Console.WriteLine("Thank you, and please visit again!");
                                    continueBanking = false; 
                                }
                            else
                                {
                                    Console.WriteLine("Sorry, that wasn't a valid choice. Please try again later!");
                                    continueBanking = false;
                                }
                            break;

                    #endregion

                        #region 2.checkbalance
                    case 2:
                        Console.Write("Your current balance is: " /*+ accountObject2.CheckBalance()*/);
                        BalCheck(accountObject1, accountObject2);
                        Console.WriteLine("Would you like to perform another operation? (Y/N): ");
                        cont = Console.ReadLine();
                        if (cont == "y" || cont == "Y")
                        {
                            Console.WriteLine("Please choose a new option from the menu: ");
                            BankMenu();
                            continueBanking = true;
                        }
                        else if (cont == "n" || cont == "N")
                        {
                            Console.WriteLine("Thank you, and please visit again!");
                            continueBanking = false;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that wasn't a valid choice. Please try again later!");
                            continueBanking = false;
                        }
                        break;
                    #endregion

                        #region 3.withdrawal
                    case 3:
                            Console.WriteLine("Your balance before withdrawal is: "/* + accountObject2.accountBalance*/);
                            BalCheck(accountObject1, accountObject2);
                            Console.WriteLine("Please enter the amount you wish to withdraw: ");
                            int w_amount = Convert.ToInt32(Console.ReadLine());
                            WithdrawFrom(accountObject1, accountObject2, w_amount);
                            Console.WriteLine("Your new balance is: "/* + accountObject2.accountBalance*/);                            
                            BalCheck(accountObject1, accountObject2);
                            Console.WriteLine("Would you like to perform another operation? (Y/N): ");
                            cont = Console.ReadLine();
                            if(cont == "y" || cont == "Y") 
                                { 
                                    Console.WriteLine("Please choose a new option from the menu: ");
                                    BankMenu();
                                    continueBanking = true; 
                                }
                            else if(cont == "n" || cont == "N") 
                                { 
                                    Console.WriteLine("Thank you, and please visit again!");
                                    continueBanking = false; 
                                }
                            else
                                {
                                    Console.WriteLine("Sorry, that wasn't a valid choice. Please try again later!");
                                    continueBanking = false;
                                }
                            break;
                        #endregion

                        #region 4.deposit
                        case 4:
                            Console.WriteLine("Your current balance is: "/* + accountObject2.accountBalance*/);
                            BalCheck(accountObject1, accountObject2);
                            Console.WriteLine("Please enter how much you wish to deposit: ");
                            int d_amount = Convert.ToInt32(Console.ReadLine());
                            DepositTo(accountObject1, accountObject2, d_amount);
                            Console.WriteLine("Thank you. Your new balance is: "/* + accountObject2.accountBalance*/);
                            BalCheck(accountObject1, accountObject2);
                            Console.WriteLine("Would you like to perform another operation? (Y/N): ");
                            cont = Console.ReadLine();
                            if(cont == "y" || cont == "Y") 
                                { 
                                    Console.WriteLine("Please choose a new option from the menu: ");
                                    BankMenu();
                                    continueBanking = true; 
                                }
                            else if(cont == "n" || cont == "N") 
                                { 
                                    Console.WriteLine("Thank you, and please visit again!");
                                    continueBanking = false; 
                                }
                            else
                                {
                                    Console.WriteLine("Sorry, that wasn't a valid choice. Please try again later!");
                                    continueBanking = false;
                                }
                            break;
                        #endregion
                        
                        #region 5.get details
                        case 5:
                            Console.WriteLine("Okay, here are the details of your account: ");
                            getAccountDetails(accountObject1, accountObject2);
                            Console.WriteLine("Would you like to perform another operation? (Y/N): ");
                            cont = Console.ReadLine();
                            if(cont == "y" || cont == "Y") 
                                { 
                                    Console.WriteLine("Please choose a new option from the menu: ");
                                    BankMenu();
                                    continueBanking = true; 
                                }
                            else if(cont == "n" || cont == "N") 
                                { 
                                    Console.WriteLine("Thank you, and please visit again!");
                                    continueBanking = false; 
                                }
                            else
                                {
                                    Console.WriteLine("Sorry, that wasn't a valid choice. Please try again later!");
                                    continueBanking = false;
                                }
                            break;
                        #endregion

                        #region 6.exit
                        case 6:
                            Console.WriteLine("Thank you, and come back soon!");
                            continueBanking = false;
                            break;
                        #endregion
                        
                        #region default and exit
                        default:
                            Console.WriteLine("That's an invalid choice. Please try again later.");
                            continueBanking = false;
                            break;
                        #endregion
                    }
                }
            #endregion

        }
        #region accountchecks
        private static void BalCheck(Accounts accountObject1, Accounts accountObject2)
        {
            if (accountObject2.accountActive == false)
            {
                Console.WriteLine(accountObject1.CheckBalance());
            }
            else
            {
                Console.WriteLine(accountObject2.CheckBalance());
            }
        }
        private static void WithdrawFrom(Accounts accountObject1, Accounts accountObject2, int amount)
        {
            if (accountObject2.accountActive == false)
            {
                accountObject1.Withdraw(amount);
            }
            else
            {
                accountObject2.Withdraw(amount);
            }
        }       
        private static void DepositTo(Accounts accountObject1, Accounts accountObject2, int amount)
        {
            if (accountObject2.accountActive == false)
            {
                accountObject1.Deposit(amount);
            }
            else
            {
                accountObject2.Deposit(amount);
            }
        }
        private static void getAccountDetails(Accounts accountObject1, Accounts accountObject2)
        {
            if (accountObject2.accountActive == false)
            {
                Console.WriteLine("Account Number: " + accountObject1.accountNumber);
                Console.WriteLine("Name on Account: " + accountObject1.accountName);
                Console.WriteLine("Account Type: " + accountObject1.accountType);
                Console.WriteLine("Available Balance: " + accountObject1.accountBalance);
                Console.WriteLine("Account Email: " + accountObject1.accountEmail);
            }
            else
            {
                Console.WriteLine("Account Number: " + accountObject2.accountNumber);
                Console.WriteLine("Name on Account: " + accountObject2.accountName);
                Console.WriteLine("Account Type: " + accountObject2.accountType);
                Console.WriteLine("Available Balance: " + accountObject2.accountBalance);
                Console.WriteLine("Account Email: " + accountObject2.accountEmail);
            }
            
        }

        public static void BankMenu()
        {
                Console.WriteLine("~~~~~ Please Choose an Option ~~~~~");
                Console.WriteLine("1. Create New Account");
                Console.WriteLine("2. Check Balance");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Deposit");
                Console.WriteLine("5. Get Details");
                Console.WriteLine("6. Exit");
        }
        #endregion
    }

}