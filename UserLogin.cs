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

namespace Parbon
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection DBconnect1 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            DBconnect1.Open();
            MySqlCommand command1 = new MySqlCommand("select * from project_parbon.user where NIDnumber='" + this.textBox1.Text + "' and Password= '" + this.textBox2.Text + "';", DBconnect1);
            MySqlDataReader myreader1;
            MessageBox.Show("a");
            myreader1 = command1.ExecuteReader();
            MessageBox.Show("a");
            int counter = 0;//User theke derect nile Loop e dhoke na. ar manually phpmy admin-e jeye input diye ashle tokhon loop kaj kore
            MessageBox.Show("");
            while (myreader1.Read())
            {
                MessageBox.Show(counter.ToString());
                counter = counter + 1;
                MessageBox.Show(counter.ToString());
            }

            MessageBox.Show("a");
            if (counter == 1)
            {
                MessageBox.Show("Correct");
            }
            else if (counter > 1)
            {
                MessageBox.Show("Duplicate");
            }
            else
            {
                MessageBox.Show(counter.ToString());
            }
        }
    }
}
