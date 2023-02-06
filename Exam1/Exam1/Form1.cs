using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    public partial class Form1 : Form
    {
        List<SavingsAccount> sList = null;
        public Form1()
        {
            InitializeComponent();
        }
        //Form2 f2 = new Form2();
        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SavingsAccount A1 = new SavingsAccount();
            A1.AccountNumber = Convert.ToInt32(textBox1.Text);
            A1.Balance = Convert.ToInt32(textBox2.Text);
            A1.interestRate = Convert.ToInt32(textBox3.Text);
            A1.savingPeriod = Convert.ToInt32(textBox4.Text);
            A1.MakeDeposit = Convert.ToInt32(textBox5.Text);
            A1.MakeWithdrawal = Convert.ToInt32(textBox6.Text);

            sList = new List<SavingsAccount>();
            sList.Add(A1);


            //A1.Balance = double.Parse(textBox2.Text);
            //A1.AccountNumber = int.Parse(textBox1.Text);
            //A1.interestRate = double.Parse(textBox3.Text);
            //A1.savingPeriod = int.Parse(textBox4.Text);
            //A1.MakeDeposit = double.Parse(textBox5.Text);
            //A1.MakeWithdrawal = double.Parse(textBox6.Text);
            //listBox1.Items.Add(A1.AccountNumber.ToString() + " " + A1.Balance.ToString() + " " + A1.interestRate.ToString() + " " + A1.MakeDeposit.ToString() + " " + A1.MakeWithdrawal.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(sList);
            f.Show();
            //f2.ShowDialog();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
