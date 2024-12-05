using System;
using System.IO;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Пример работы с Auto_auction ===");
            Auto_auction autoAuction = new Auto_auction("Иван Иванов", 500, 1, 10, 5, 25000);
            autoAuction.PrintAuctionDetails();
            autoAuction.GetWinner();
            autoAuction.SetSaleprice(30000); 

            string autoAuctionFilePath = "autoAuction.txt";
            autoAuction.SaveToFile(autoAuctionFilePath);

            Console.WriteLine("\n=== Загружаем данные из файла для Auto_auction ===");
            Auto_auction loadedAutoAuction = new Auto_auction();
            loadedAutoAuction.LoadFromFile(autoAuctionFilePath);
            loadedAutoAuction.PrintAuctionDetails();

            Console.WriteLine("\n=== Пример работы с Houses_auction ===");
            Houses_auction housesAuction = new Houses_auction("Петр Петров", 1000, 101, 15, 7, 500000);
            housesAuction.PrintAuctionDetails();
            housesAuction.GetWinner();
            housesAuction.SetSaleprice(600000); 

            string housesAuctionFilePath = "housesAuction.txt";
            housesAuction.SaveToFile(housesAuctionFilePath);

            Console.WriteLine("\n=== Загружаем данные из файла для Houses_auction ===");
            Houses_auction loadedHousesAuction = new Houses_auction();
            loadedHousesAuction.LoadFromFile(housesAuctionFilePath);
            loadedHousesAuction.PrintAuctionDetails();

            Console.WriteLine("\n=== Ввод данных с клавиатуры для нового Auto_auction ===");
            Auto_auction userAutoAuction = new Auto_auction();
            try
            {
                Console.Write("Введите имя победителя: ");
                userAutoAuction.WinnerName = Console.ReadLine();

                Console.Write("Введите увеличение ставки: ");
                userAutoAuction.AmountIncrease = int.Parse(Console.ReadLine());

                Console.Write("Введите ID победившего автомобиля: ");
                userAutoAuction.IdWinnerAuto = int.Parse(Console.ReadLine());

                Console.Write("Введите количество автомобилей: ");
                userAutoAuction.NumberOfAutos = int.Parse(Console.ReadLine());

                Console.Write("Введите количество участников: ");
                userAutoAuction.Participants = int.Parse(Console.ReadLine());

                Console.Write("Введите итоговую цену: ");
                userAutoAuction.FinalPrice = double.Parse(Console.ReadLine());

                Console.Write("Установите новую цену для продажи: ");
                double newPrice = double.Parse(Console.ReadLine());
                userAutoAuction.SetSaleprice(newPrice);

                Console.WriteLine("\n=== Данные, введённые с клавиатуры ===");
                userAutoAuction.PrintAuctionDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода данных: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        
    
        }
    }
}
