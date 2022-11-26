using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_OOP_BABankasi.Concrete;
using _04_OOP_BABankasi.Enums;

namespace _04_OOP_BABankasi.Abstract
{
    internal interface IBankCounter
    {
        // Class Members
        // Fields
        // Properties
        // Merhods
        // Constructor Methods
        // Contants
        // Events

        // event Delegeİsmi eventİsmi
        event BankCallType IamAvailableQueue;
        event NumberCallType IamDoneCounter;

        // ToDo: Numara
        public INumber NumberinProcess { get; set; }

        void Process();

        void Control(object sender);
    }
}
