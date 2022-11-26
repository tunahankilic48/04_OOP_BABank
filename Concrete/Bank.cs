using _04_OOP_BABankasi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_BABankasi.Concrete
{
    // public delegate 
    public delegate void BankCallType(object sender);
    public delegate void NumberCallType(INumber param);
    internal class Bank : IBank
    {
        public Bank()
        {
            BankCounters = new List<IBankCounter>();
        }

        public List<IBankCounter> BankCounters { get; set; }
        public IQueue Queue { get; set; }
        public INumarator Numarator { get; set; }
        public ICounter Counter { get; set; }

        public void ShiftBegin(int numberofBankCounter)
        {
            Queue = new Queue();

            Counter = new Counter();

            Numarator = new Numarator();

            for (int i = 0; i < numberofBankCounter; i++)
            {
                IBankCounter bankCounter = new BankCounter();
                bankCounter.IamAvailableQueue += Queue.SendNumbertoBankCounter;
                // To do: bankCounter.


                BankCounters.Add(bankCounter);
            }

            Numarator.ProducedNumber += Queue.TakeNumberfromNumarator;
        }

        public void ShiftEnd()
        {
           
        }
    }
}
