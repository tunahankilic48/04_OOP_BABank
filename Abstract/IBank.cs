using _04_OOP_BABankasi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_BABankasi.Abstract
{
    internal interface IBank
    {
        public List<IBankCounter> BankCounters { get; set; }
        public IQueue Queue { get; set; }
        public INumarator Numarator { get; set; }
        public ICounter Counter { get; set; }

        void ShiftBegin(int numberofBankCounter);
        void ShiftEnd();
    }
}
