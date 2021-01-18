using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExcercisesPart2
{
    class SavingsAccount : Account
    {
        private double _percentage;

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        public SavingsAccount(string accountNumber, double saldo, double percentage)
            :base(accountNumber, saldo)
        {
            Percentage = percentage;
        }
        
        public void AddInterest()
        {
            Saldo += (Saldo / 100) * Percentage;
        }
        public override string ToString()
        {
            return base.ToString() + $" ( {Percentage}%)";
        }
    }
}
