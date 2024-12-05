
namespace Homework_6_for_Tumakov
{
    //Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
    //банковского счета(использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
    //доступа к данным – заполнения и чтения.Создать объект класса, заполнить его поля и
    //вывести информацию об объекте класса на печать.
    enum Account_bank
    {
        current = 1,
        savings = 2
    }

    internal class Bank_account
    {
        #region Поля
        private int _id;
        private decimal _amount;
        private Account_bank _account_bank;
        #endregion

        #region Свойства
        public int Id
        { get { return _id; } set { _id = value; } }
        public decimal Amount
        { get { return _amount; } set { _amount = value; } }
        public Account_bank Account_bank { get { return _account_bank;  } set { _account_bank = value; } }
        #endregion


    }
}
