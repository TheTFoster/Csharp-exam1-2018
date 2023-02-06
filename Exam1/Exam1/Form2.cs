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
    public partial class Form2 : Form
    {
        List<SavingsAccount> mList = new List<SavingsAccount>();

        public Form2(List<SavingsAccount> sList)
        {
            InitializeComponent();
            mList = sList;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            MessageBox.Show(mList[index].ToString());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (SavingsAccount item in mList)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
