using _04_OOP_BABankasi.Abstract;
using _04_OOP_BABankasi.Concrete;
using _04_OOP_BABankasi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_BABankasi.Concrete
{
    internal class Numarator : INumarator
    {
        int _individualSequenceCounter;
        int _bankCounterSequenceCounter;
        int _vipSequenceCounter;
        
        public Numarator()
        {
            IndividualSequenceCounter = 1000;
            BankCounterSequenceCounter = 2000;
            VipSequenceCounter = 3000;
        }
        
        public int IndividualSequenceCounter
        {
            get { return _individualSequenceCounter; }
            set
            {
                if (value > 999 && value < 2000)
                    _individualSequenceCounter = value;
            }
        }
        public int BankCounterSequenceCounter
        {
            get { return _bankCounterSequenceCounter; }
            set
            {
                if (value > 1999 && value < 3000)
                    _bankCounterSequenceCounter = value;
            }
        }
        public int VipSequenceCounter
        {
            get { return _vipSequenceCounter; }
            set
            {
                if (value > 2999 && value < 4000)
                    _vipSequenceCounter = value;
            }
        }

        public event NumberCallType ProducedNumber;

        public void ProduceNumber(object sender)
        {
            INumber number = null;
            ICustomer customer = sender as ICustomer; // (IMusteri)sender
            if (customer.TransactionType == TransactionType.Bireysel)
            {
                number = new IndividualNumber();
                number.SequenceCounter = IndividualSequenceCounter;
                IndividualSequenceCounter++;
            }
            else if (customer.TransactionType == TransactionType.Gise)
            {
                number = new BankCounterNumber();
                number.SequenceCounter = BankCounterSequenceCounter;
                BankCounterSequenceCounter++;
            }
            // To Do: Vip eklenecek
            customer.Number = number;

            ProducedNumber(number);
        }
    }
}
