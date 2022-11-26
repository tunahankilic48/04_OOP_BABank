using _04_OOP_BABankasi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_BABankasi.Abstract
{
    public interface INumarator
    {
        void ProduceNumber(object sender);
        public int VipSequenceCounter { get; set; }
        public int BankCounterSequenceCounter { get; set; }
        public int IndividualSequenceCounter { get; set; }

        event NumberCallType ProducedNumber;
    }
}
