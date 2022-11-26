using _04_OOP_BABankasi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_BABankasi.Concrete
{
    internal class Queue : IQueue
    {
        public Queue()
        {
            VipNumberList = new List<INumber>();
            IndividualNumberList = new List<INumber>();
            BankCounterNumberList= new List<INumber>();
        }
        public List<INumber> VipNumberList { get; set; }
        public List<INumber> IndividualNumberList { get; set; }
        public List<INumber> BankCounterNumberList { get; set; }
        public int Counter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event NumberCallType AssignNumber;

        public void SendNumbertoBankCounter(object sender)
        {
            IBankCounter bankCounter = sender as BankCounter;
            if (VipNumberList.Count > 0)
            {
                bankCounter.NumberinProcess = VipNumberList[0];
                VipNumberList.RemoveAt(0);
            }
            else if (Counter < 3 && BankCounterNumberList.Count > 0)
            {
                bankCounter.NumberinProcess = BankCounterNumberList[0];
                BankCounterNumberList.RemoveAt(0);
                Counter++;
            }
            else if (IndividualNumberList.Count > 0)
            {
                bankCounter.NumberinProcess = IndividualNumberList[0];
                IndividualNumberList.RemoveAt(0);
                Counter = 0;
            }
            AssignNumber(bankCounter.NumberinProcess);
        }

        public void TakeNumberfromNumarator(INumber number)
        {
            if (number is VipNumber)
                VipNumberList.Add(number);
            else if (number is IndividualNumber)
                IndividualNumberList.Add(number);
            else if (number is BankCounterNumber)
                BankCounterNumberList.Add(number);

        }
    }
}
