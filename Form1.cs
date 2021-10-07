using System;
using System.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.ComponentModel;
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
            if (validate())
            {
             
                DateTime oDate = DateTime.Parse(Tbd.Text);
                string db = oDate.ToString("yyyy-MM-dd");

                connection con = new connection();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[project]
           ([First Name]
           ,[Last Name]
           ,[DOB]
           ,[Gender]
           ,[Email]
           ,[Phone])
     VALUES
            ('" + Tfn.Text + "', '" + Tln.Text + "', '" + db + "', '" + Tgen.Text + "', '" + Tml.Text + "', '" + Tphno.Text + "')", con.active());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Created", "CREATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "CREATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool validate()
        {
            bool returnval = true;
            if (Tfn.Text.Length == 0 || Tfn.Text.Length >= 20)
            {
                returnval = false;
            }
            if (Tln.Text.Length == 0 || Tln.Text.Length >= 20)
            {
                returnval = false;
            }
            DateTime dob = Convert.ToDateTime(Tbd.Text);
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;

            if (dob > today.AddYears(-age))
                age--;
            if (age < 0)
            {
                returnval = false;
            }
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(Tml.Text))
            {
                returnval = false;
            }
            if (Tphno.Text.Length > 10 || Tphno.Text.Length < 10)
            {
                returnval = false;
            }

            return returnval;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[project] WHERE [First Name] = '" + Tfn.Text + "'", con.active());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[project]
            SET [First Name] = '" + Tfn.Text + "',[Last Nmae] = '" + Tln.Text + "',[Gender] = '" + Tgen.Text + "',[Email] = '" + Tml.Text + "' WHERE [Phone] = '" + Tphno.Text +"'", con.active());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void GridView()
        {
            connection con = new connection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from project", con.active());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach(DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["First Name"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Last Name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["DOB"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Gender"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Email"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Phone"].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tbd_Leave(object sender, EventArgs e)
        {
            DateTime dob = Convert.ToDateTime(Tbd.Text);
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;

            if (dob > today.AddYears(-age)) 
                age--;

           Tage.Text = age.ToString();


        }
    }
}
