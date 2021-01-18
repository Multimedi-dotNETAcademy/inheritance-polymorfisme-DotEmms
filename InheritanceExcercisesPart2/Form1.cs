using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceExcercisesPart2
{
    public partial class Form1 : Form
    {
        Account account = new Account("123-1234567-12", 100);
        SavingsAccount sa = new SavingsAccount("321-7654321-21", 200, 5);
        CurrentAccount ca = new CurrentAccount("987-3216547-78", 25);
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnAccountPlus_Click(object sender, EventArgs e)
        {
            //saldo += Convert.ToDouble(textBox1.Text);
            account.Deposit(Convert.ToDouble(textBox1.Text));
            lblAccount.Text = account.ToString();
        }

        private void btnAccountMin_Click(object sender, EventArgs e)
        {
            account.Withdraw(Convert.ToDouble(textBox1.Text));
            lblAccount.Text = account.ToString();
        }

        private void btnSavingPlus_Click(object sender, EventArgs e)
        {
            sa.Deposit(Convert.ToDouble(textBox2.Text));
            lblSavingsAccount.Text = sa.ToString();
        }

        private void btnSavingMin_Click(object sender, EventArgs e)
        {
            sa.Withdraw(Convert.ToDouble(textBox2.Text));
            lblSavingsAccount.Text = sa.ToString();
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            sa.AddInterest();
            lblSavingsAccount.Text = sa.ToString();
        }

        private void btnCurrentPlus_Click(object sender, EventArgs e)
        {
            ca.Deposit(Convert.ToDouble(textBox3.Text));
            lblCurrentAccount.Text = ca.ToString();
        }

        private void btnCurrentMin_Click(object sender, EventArgs e)
        {
            ca.Withdraw(Convert.ToDouble(textBox3.Text));
            lblCurrentAccount.Text = ca.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAccount.Text = account.ToString();
            lblSavingsAccount.Text = sa.ToString();
            lblCurrentAccount.Text = ca.ToString();
        }
    }
}
