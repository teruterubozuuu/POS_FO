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
    public partial class Categories : UserControl
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            dairy.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            drinks.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fruits fruits = new Fruits();
            fruits.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Meat meat = new Meat();
            meat.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Snacks snacks = new Snacks();
            snacks.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vegetables vegetables = new Vegetables();
            vegetables.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Seafood seafood = new Seafood();
            seafood.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Condiments condiments = new Condiments();
            condiments.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Oil oil = new Oil();
            oil.Show();
        }
    }
}
