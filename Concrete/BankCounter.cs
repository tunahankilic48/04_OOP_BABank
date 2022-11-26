using _04_OOP_BABankasi.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_OOP_BABankasi.Abstract;

namespace _04_OOP_BABankasi.Concrete
{
    internal class BankCounter : IBankCounter
    {
        public INumber NumberinProcess { get; set; }

        public event BankCallType IamAvailableQueue;
        public event NumberCallType IamDoneCounter;

        public void Control(object sender)
        {
            ICustomer customer = (ICustomer)sender;
            if (customer.Number == NumberinProcess)
                Process();
        }

        public void Process()
        {
            IamDoneCounter(NumberinProcess);
            IamAvailableQueue(this);
        }
    }
}
