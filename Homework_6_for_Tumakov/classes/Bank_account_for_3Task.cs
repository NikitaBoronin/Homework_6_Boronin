
namespace Homework_6_for_Tumakov
{
    internal class Bank_account_for_3Task
    {
        #region Поля
        private int _id;
        private decimal _amount;
        private Account_bank _account_bank;
        #endregion

        //Добавить в класс счет в банке два метода: снять со счета и положить на
        //счет.Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
        //положительного результата изменяет баланс.

        #region Методы
        public void Deposit_account(decimal amount)
        {
            _amount += amount;
        }

        public void Withdraw(decimal amount)
        {
            ;
            if (amount <= 0)
            {
                Console.WriteLine("Ошибка! Число либо равно нулю, либо отрицательно! Снять такое невозможно!");
            }
            else if (_amount < amount)
            {
                Console.WriteLine("Недостаточно средств на счете!");
            }
            else
            {
                Console.WriteLine($"Просиходит снятие...\nНа сумму: {amount}"); 
                _amount -= amount;
            }
        }

        public void PrintAmount()
        {
            Console.WriteLine($"Текущий счет на банке: {_amount}");
        }

        #endregion

        #region Свойства
        public int Id
        { get { return _id; } set { _id = value; } }
        public decimal Amount
        { get { return _amount; } set { _amount = value; } }
        public Account_bank Account_bank { get { return _account_bank; } set { _account_bank = value; } }
        #endregion

    }
}
