using Bank.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
                throw new LimitException("Saque maior que saldo");
            if (amount > WithdrawLimit)
                throw new LimitOfRangeException("saque excede o limite permitido.");
                Balance -= amount;
        }

        public override string ToString()
        {
            return "Name: "+ Holder+ "\nNew balance: "+Balance;
        }
    }
}
