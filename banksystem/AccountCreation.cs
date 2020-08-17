using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace banksystem
{
    public partial class AccountCreation : Form
    {
        public AccountCreation()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=abc");


        public void custid()
        {
            con.Open();
            string query = "select max(custid) from customer ";
            MySqlCommand cmd = new MySqlCommand(query, con);

            MySqlDataReader dr;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    label14.Text = "10000";
                }
                else
                {
                    int a;
                    a = int.Parse(dr[0].ToString());
                    a = a + 1;
                    label14.Text = a.ToString();
                }
                con.Close();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AccountCreation_Load(object sender, EventArgs e)
        {
            custid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
              tabControl1.SelectedTab = tabPage1;
              button3.BackColor = ColorTranslator.FromHtml("#d90a0a");
              button4.BackColor = ColorTranslator.FromHtml("#12b4cc");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            button4.BackColor = ColorTranslator.FromHtml("#12b4cc");
            button3.BackColor = ColorTranslator.FromHtml("#d90a0a");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cid, lname, fname, street, city, state, phone, date, email, acno, acctype, des, bal;


            cid = label14.Text;
            lname = txtlname.Text;
            fname = txtfname.Text;
            street = txtstreet.Text;
            city = txtcity.Text;
            state = txtstate.Text;
            phone = txtphone.Text;
            date = txtdate.Text;
            email = txtemail.Text;


            acno = txtacc.Text;
            acctype = txtacctype.Text;
            des = txtdes.Text;
            bal = txtbal.Text;



            con.Open();
                MySqlCommand cmd = new MySqlCommand();
                MySqlTransaction transaction; 
            
           transaction = con.BeginTransaction();

            cmd.Connection = con;
            cmd.Transaction = transaction; ;

            try
            {

                cmd.CommandText = "insert into customer(custid,lastname,firstname,street,city,state,phone,date,email) values('" + cid + "','" + lname + "','" + fname + "',   '" + street + "',   '" + city + "',  '" + state + "',  '" + phone + "' '" + date + "', '" + email + "')";
                cmd.ExecuteNonQuery();

              


                cmd.CommandText = "insert into account(accid,custid,acctype,description,balance) values( '" + acno + "','" + cid + "', '" + acctype + "','" + des + "','" + bal + "')";
                cmd.ExecuteNonQuery();




               transaction.Commit();
                MessageBox.Show(" record added .........");



            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                con.Close();
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
