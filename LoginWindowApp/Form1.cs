using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Bring in SQL 

namespace LoginWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Connecting the database
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\camer\OneDrive\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            //COnnecting the textboxUser and textBoxPassword fields to the database
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + textBoxUserName.Text + "' and Password='" + textBoxPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            this.Hide();

            Main ss = new Main();
            ss.Show();
        }
    }
}
