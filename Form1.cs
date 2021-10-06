using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[proj]
           ([First Name]
           ,[Last Nmae]
           ,[DOB]
           ,[Gender]
           ,[Email]
           ,[Phone])
     VALUES
            ('" + Tfn.Text + "', '" + Tln.Text + "', '" + Tbd.Text + "', '" + Tgen.Text + "', '" + Tml.Text + "', '" + Tphno.Text + "')", con.active());
            cmd.ExecuteNonQuery();
            //cmd.EndExecuteNonQuery();
            MessageBox.Show("Successfully Created", "CREATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[proj] WHERE [First Name] = '" + Tfn.Text + "'", con.active());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[proj]
    SET [First Name] = '" + Tfn.Text + "',[Last Nmae] = '" + Tln.Text + "',[Gender] = '" + Tgen.Text + "',[Email] = '" + Tml.Text + "' WHERE [Phone] = '" + Tphno.Text +"'", con.active());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
