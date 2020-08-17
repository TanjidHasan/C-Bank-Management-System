using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banksystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AccountCreation account = new AccountCreation();
            account.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            withdraw account = new withdraw();
            account.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deposit account = new deposit();

            account.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            transfer account = new transfer();
            account.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            review account = new review();
            account.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
