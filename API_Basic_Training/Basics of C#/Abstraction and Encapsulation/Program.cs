using System;

namespace Abstraction_and_Encapsulation
{

    class Account
    {
        //encapsulation
        #region Private Members
        private int balance = 0;
        protected string branchId = "1563";
        #endregion

        #region Public Methods
        /// <summary>
        /// Added new money to current balance
        /// </summary>
        /// <param name="newMoney"></param>
        public void DepositMoney(int newMoney)
        {
            balance += newMoney;
            Console.WriteLine($"{newMoney} is deposited");
        }

        /// <summary>
        /// Returns balance after deducting fees
        /// </summary>
        /// <returns>balance</returns>
        public int GetBalance()
        {
            DeductFee();
            return balance;
        }
        #endregion

        #region Private Methods
        private void DeductFee()
        {
            balance -= 10;
        }
        #endregion
    }
    class Locker : Account
    {
        #region public Methods
        /// <summary>
        /// Displays last 2 characters of branch id
        /// </summary>
        public void ShowBranchId()
        {
            Console.WriteLine($"Branch id ends with **{branchId.Substring(2)}");
        }
        #endregion
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Account rajAccount = new Account();
            rajAccount.DepositMoney(2000);
            //Console.WriteLine(rajAccount.balance); //Private field cannot be accessed
            Console.WriteLine($"Current Balance: {rajAccount.GetBalance()}");

            Locker rajLocker = new Locker();
            rajLocker.ShowBranchId();
        }
    }
}
