using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Auto_auction : Abstract_auction
    {
        #region Поля
        private int _idWinnerAuto;
        private int _numberOfAutos;
        private int _participants;
        private double _finalPrice;
        #endregion

        #region Свойства
        public int IdWinnerAuto
        {
            get { return _idWinnerAuto; }
            set
            {
                if (value > 0)
                    _idWinnerAuto = value;
                else
                    throw new ArgumentException("ID победившего автомобиля должен быть положительным числом.");
            }
        }

        public double FinalPrice
        {
            get { return _finalPrice; }
            set
            {
                if (value >= 0)
                    _finalPrice = value;
                else
                    throw new ArgumentException("Итоговая цена должна быть неотрицательной.");
            }
        }

        public int Participants
        {
            get { return _participants; }
            set
            {
                if (value > 0)
                    _participants = value;
                else
                    throw new ArgumentException("Количество участников должно быть положительным числом.");
            }
        }

        public int NumberOfAutos
        {
            get { return _numberOfAutos; }
            set
            {
                if (value > 0)
                    _numberOfAutos = value;
                else
                    throw new ArgumentException("Количество автомобилей должно быть положительным числом.");
            }
        }
        #endregion

        #region Конструкторы
        public Auto_auction() : base() { }

        public Auto_auction(string winnerName, int amountIncrease, int idWinnerAuto, int numberOfAutos, int participants, double finalPrice)
            : base(winnerName, amountIncrease)
        {
            IdWinnerAuto = idWinnerAuto;
            NumberOfAutos = numberOfAutos;
            Participants = participants;
            FinalPrice = finalPrice;
        }
        #endregion

        #region Методы
        public override void GetWinner()
        {
            if (IdWinnerAuto > 0)
                Console.WriteLine($"Победитель: Участник выиграл автомобиль с ID {IdWinnerAuto} за {FinalPrice}.");
            else
                Console.WriteLine("Победитель еще не определен.");
        }

        public override void PrintAuctionDetails()
        {
            base.PrintAuctionDetails();
            Console.WriteLine($"Автомобили на аукционе: {NumberOfAutos}");
            Console.WriteLine($"Участники: {Participants}");
            Console.WriteLine($"Итоговая цена: {FinalPrice}");
        }

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(WinnerName);
                writer.WriteLine(AmountIncrease);
                writer.WriteLine(IdWinnerAuto);
                writer.WriteLine(NumberOfAutos);
                writer.WriteLine(Participants);
                writer.WriteLine(FinalPrice);
            }
            Console.WriteLine($"Данные сохранены в файл: {filePath}");
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл {filePath} не найден.");
                return;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                WinnerName = reader.ReadLine();
                int.TryParse(reader.ReadLine(), out int amountIncrease);
                AmountIncrease = amountIncrease;

                int.TryParse(reader.ReadLine(), out int idWinnerAuto);
                IdWinnerAuto = idWinnerAuto;

                int.TryParse(reader.ReadLine(), out int numberOfAutos);
                NumberOfAutos = numberOfAutos;

                int.TryParse(reader.ReadLine(), out int participants);
                Participants = participants;

                double.TryParse(reader.ReadLine(), out double finalPrice);
                FinalPrice = finalPrice;
            }
            Console.WriteLine($"Данные загружены из файла: {filePath}");
        }

        public override void SetSaleprice(double price)
        {
            FinalPrice = price;
            Console.WriteLine($"Итоговая цена автомобиля установлена: {FinalPrice}");
        }
        #endregion

    }


}
