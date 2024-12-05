
namespace Homework_6_for_Tumakov.classes
{
    internal class Changed_bank_account
    {
        #region Поля
        private int _id;
        private decimal _amount;
        private Account_bank _account_bank;
        private static int nextId = 1;
        #endregion

        #region Конструктор
        public Changed_bank_account()
        {
            GenerateId();
        }
        #endregion

        #region Методы
        private void GenerateId()
        {
            _id = nextId++; 
        }

        public void PrintId()
        {
            Console.WriteLine($"ID: {_id}");
        }

        #endregion

        #region Свойства
        public int Id
        { get { return _id; } }
        public decimal Amount
        { get { return _amount; } set { _amount = value; } }
        public Account_bank Account_bank { get { return _account_bank; } set { _account_bank = value; } }
        #endregion
    }
}
