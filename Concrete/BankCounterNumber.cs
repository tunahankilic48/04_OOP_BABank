using _04_OOP_BABankasi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_BABankasi.Concrete
{
    internal class BankCounterNumber : INumber
    {
        public int SequenceCounter { get; set; }
    }
}
