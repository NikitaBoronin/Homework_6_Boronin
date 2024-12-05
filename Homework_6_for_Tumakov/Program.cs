using Homework_6_for_Tumakov.classes;

namespace Homework_6_for_Tumakov
{
    
    internal class Program
    {
        static void PrintAccountFields(Bank_account account)
        {
            Console.WriteLine($"Номер счета: {account.Id}\nБаланс счета: {account.Amount}\nТип счета: {account.Account_bank}");

        }

        static void PrintChangedAccountFields(Changed_bank_account account)
        {
            Console.WriteLine($"Номер счета: {account.Id}\nБаланс счета: {account.Amount}\nТип счета: {account.Account_bank}");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.1");
            Console.WriteLine("\n");
            Bank_account bank_Account = new Bank_account();
            bank_Account.Id = 122333;
            bank_Account.Amount = 2302;
            bank_Account.Account_bank = Account_bank.current;
            PrintAccountFields(bank_Account);
            Console.WriteLine("\n");

            Console.WriteLine("Упражнение 7.2");
            Console.WriteLine("\n");
            Changed_bank_account bank_Account1 = new Changed_bank_account();
            Changed_bank_account bank_Account2 = new Changed_bank_account();
            Changed_bank_account bank_Account3 = new Changed_bank_account();
            bank_Account1.PrintId();
            bank_Account2.PrintId();
            bank_Account3.PrintId();
            Console.WriteLine("\n");

            Console.WriteLine("Упражнение 7.3");
            Bank_account_for_3Task bank_Account_For_3 = new Bank_account_for_3Task();
            bank_Account_For_3.Deposit_account(2000);
            bank_Account_For_3.Deposit_account(4000);
            bank_Account_For_3.PrintAmount();
            bank_Account_For_3.Withdraw(2000);
            bank_Account_For_3.PrintAmount();
            bank_Account_For_3.Withdraw(-2);
            Console.WriteLine("\n");

            Console.WriteLine("Домашнее задание 7.1");
            
            Description_the_building building = new Description_the_building();

            
            building.SetValues();

            
            building.PrintValues();

            
            try
            {
                double floorHeight = building.CalculateFloorHeight();
                Console.WriteLine($"Высота этажа: {floorHeight:F2} м");

                int apartmentsPerEntrance = building.CalculateApartmentsPerEntrance();
                Console.WriteLine($"Количество квартир в подъезде: {apartmentsPerEntrance}");

                int apartmentsPerFloor = building.CalculateApartmentsPerFloor();
                Console.WriteLine($"Количество квартир на этаже: {apartmentsPerFloor}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();





        }
    }
}
