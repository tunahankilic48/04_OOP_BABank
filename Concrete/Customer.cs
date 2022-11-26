using _04_OOP_BABankasi.Abstract;
using _04_OOP_BABankasi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_BABankasi.Concrete
{
    internal class Customer : ICustomer
    {
        public string IDNo { get; set ; }
        public TransactionType TransactionType { get; set; }
        public INumber Number { get; set; }

        public event BankCallType NumaratorICame;
        public event BankCallType BankCounterICame;

        public void CheckNumber(INumber number)
        {
            if (number == Number)
                BankCounterICame(this);
        }

        public void GetNumber()
        {
            if (IDNo != null)
            {
                NumaratorICame(this);
            }
        }
    }
}
