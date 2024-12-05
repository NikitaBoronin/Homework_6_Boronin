using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal abstract class Abstract_auction
    {
        #region Свойства
        public string WinnerName { get; set; }
        public int AmountIncrease { get; set; }
        #endregion

        #region Конструкторы
        public Abstract_auction() { }

        public Abstract_auction(string winnerName, int amountIncrease)
        {
            if (amountIncrease < 0)
                throw new ArgumentException("Увеличение ставки не может быть отрицательным.");
            WinnerName = winnerName;
            AmountIncrease = amountIncrease;
        }
        #endregion

        #region Методы
        public virtual void PrintAuctionDetails()
        {
            Console.WriteLine($"Победитель: {WinnerName}");
            Console.WriteLine($"Увеличение ставки: {AmountIncrease}");
        }

        public abstract void GetWinner();
        public abstract void SetSaleprice(double price);
        #endregion

    }

}
