using _04_OOP_BABankasi.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_BABankasi.Abstract
{
    internal interface IQueue
    {
        event NumberCallType AssignNumber;
        public List<INumber> VipNumberList { get; set; }
        public List<INumber> IndividualNumberList { get; set; }
        public List<INumber> BankCounterNumberList { get; set; }

        public int Counter { get; set; }

        void TakeNumberfromNumarator(INumber param);
        void SendNumbertoBankCounter(object sender);
    }
}
