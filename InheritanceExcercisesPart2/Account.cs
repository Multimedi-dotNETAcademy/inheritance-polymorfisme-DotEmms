using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceExcercisesPart2
{
    class Account
    {
        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < Minimum)
                {
                    MessageBox.Show($"You are not allowed to be this poor!");
                }
                else
                {
                    _saldo = value;
                }
            }
        }
        private string accountNumber;
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private double _minimum;
        public double Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }

        public Account(string accountNumber, double saldo)
        {
            AccountNumber = accountNumber;
            Saldo = saldo;
        }
        public void Withdraw(double amount)
        {
            Saldo -= amount;
            
        }
        public void Deposit(double amount)
        {
            Saldo += amount;
        }
        public override string ToString()
        {
            return $"Accountnumber {AccountNumber} with saldo €{Saldo}.";
        }
    }
}
