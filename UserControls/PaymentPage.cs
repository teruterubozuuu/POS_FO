using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_FO.UserControls
{
    public partial class PaymentPage : UserControl
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreditDebit creditdebit = new CreditDebit();
            creditdebit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cash cash = new Cash();
            cash.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MobileWallet mobileWallet = new MobileWallet();
            mobileWallet.Show();
        }
    }
}
