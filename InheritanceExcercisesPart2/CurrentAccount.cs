using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExcercisesPart2
{
    class CurrentAccount : Account
    {
        public CurrentAccount(string accountNumber, double saldo)
            :base(accountNumber, saldo)
        {
            Minimum = -100;
        }


    }
}
