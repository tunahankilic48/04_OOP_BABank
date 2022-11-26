using _04_OOP_BABankasi.Concrete;
using _04_OOP_BABankasi.Enums;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_BABankasi.Abstract
{
    internal interface ICustomer
    {
        public string IDNo { get; set; }
        TransactionType TransactionType { get; set; }
        public INumber Number { get; set; }

        void GetNumber();
        void CheckNumber(INumber number);


        event BankCallType NumaratorICame;
        event BankCallType BankCounterICame;
        
    }
}
