using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Houses_auction : Abstract_auction
    {
        #region Поля
        private int _idWinnerHouse;
        private int _numberOfHouses;
        private int _participants;
        private double _finalPrice;
        #endregion

        #region Свойства
        public int IdWinnerHouse
        {
            get { return _idWinnerHouse; }
            set
            {
                if (value > 0)
                    _idWinnerHouse = value;
                else
                    throw new ArgumentException("ID победившего дома должен быть положительным числом.");
            }
        }

        public int NumberOfHouses
        {
            get { return _numberOfHouses; }
            set
            {
                if (value > 0)
                    _numberOfHouses = value;
                else
                    throw new ArgumentException("Количество домов должно быть больше нуля.");
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
        #endregion

        #region Конструкторы
        public Houses_auction() : base() { }

        public Houses_auction(string winnerName, int amountIncrease, int idWinnerHouse, int numberOfHouses, int participants, double finalPrice)
            : base(winnerName, amountIncrease)
        {
            IdWinnerHouse = idWinnerHouse;
            NumberOfHouses = numberOfHouses;
            Participants = participants;
            FinalPrice = finalPrice;
        }
        #endregion

        #region Методы
        public override void GetWinner()
        {
            if (IdWinnerHouse > 0)
                Console.WriteLine($"Победителем стал участник с ID {IdWinnerHouse}, купивший дом за {FinalPrice}.");
            else
                Console.WriteLine("Победитель не определен.");
        }

        public override void PrintAuctionDetails()
        {
            base.PrintAuctionDetails();
            Console.WriteLine($"Дома на аукционе: {NumberOfHouses}");
            Console.WriteLine($"Участники: {Participants}");
            Console.WriteLine($"Итоговая цена: {FinalPrice}");
        }

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(WinnerName);
                writer.WriteLine(AmountIncrease);
                writer.WriteLine(IdWinnerHouse);
                writer.WriteLine(NumberOfHouses);
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

                int.TryParse(reader.ReadLine(), out int idWinnerHouse);
                IdWinnerHouse = idWinnerHouse;

                int.TryParse(reader.ReadLine(), out int numberOfHouses);
                NumberOfHouses = numberOfHouses;

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
            Console.WriteLine($"Итоговая цена дома установлена: {FinalPrice}");
        }
        #endregion

    }





}
