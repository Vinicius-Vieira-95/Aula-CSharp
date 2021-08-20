using System;

namespace Heranca.Entities{

    class Account{

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WithDraw( double amount)
        {
            if(amount >= 0 && amount < Balance){
                Balance -= amount;
            }
        }

        public void Deposit(double amount)
        {
                if(amount > 0 ){
                     Balance += amount;
                 }
        }

    }

}