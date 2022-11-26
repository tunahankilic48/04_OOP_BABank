using _04_OOP_BABankasi.Abstract;
using _04_OOP_BABankasi.Concrete;
using _04_OOP_BABankasi.Enums;

namespace _04_OOP_BABankasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTransactionType.Items.Add(TransactionType.Bireysel);
            cmbTransactionType.Items.Add(TransactionType.Gise);
        }

        private void btnCustomerCame_Click(object sender, EventArgs e)
        {
            ICustomer customer = new Customer();
            customer.TransactionType = (TransactionType)cmbTransactionType.SelectedItem;
            customer.IDNo = txtIdNo.Text;

            customer.NumaratorICame += bank.Numarator.ProduceNumber;

            foreach (IBankCounter bankCounter in bank.BankCounters)
            {
                customer.BankCounterICame += bankCounter.Control;
            }

            customer.GetNumber();

            bank.Queue.AssignNumber += customer.CheckNumber;



            // bank.Numarator.ProducedNumber += bank.Queue.TakeNumberfromNumarator;



        }

        static IBank bank;
        private void btnCreateBank_Click(object sender, EventArgs e)
        {
            bank = new Bank();

            bank.ShiftBegin(3);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}