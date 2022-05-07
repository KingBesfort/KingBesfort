using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PostOfficeManagement.BLL;



namespace PostOfficeManagement
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Login()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-NL0J09G;Initial Catalog=PostOfficeManagement;Persist Security Info=True;User ID=post;Password=123";
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeni i sigurt se deshironi te largoheni?", "Dalja nga programi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Login";
            SqlDataReader dr = com.ExecuteReader();
            if(dr.Read())
            {
                if(txtUsername.Text.Equals(dr["Name"]) && txtPassword.Text.Equals(dr["Password"].ToString()))
                {             
                    MessageBox.Show("Login Successfully", "Urime", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Menu b = new Menu();
                    b.Show();
                }
                else
                {
                    MessageBox.Show("Shko nkar", "Ku kari je nnis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            con.Close();
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NL0J09G;Initial Catalog=PostOfficeManagement;Persist Security Info=True;User ID=post;Password=123");
            //SqlCommand cmd = new SqlCommand("", con);
            //SqlDataAdapter sqa = new SqlDataAdapter("Select * from Login where Name ='" + txtUsername + "' and Password ='" + txtPassword + "'", con);
            //DataTable dt = new DataTable();
            //sqa.Fill(dt);

            //if (dt.Rows.Count > 0)
            //{
            //    this.Hide();
            //    Ballina bl = new Ballina();
            //    bl.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Username/Password wrong!");
            //}
        }

        private void TextUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void TextUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@""))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(@"Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(@""))
            {
                txtPassword.Text = "Password";
            }
        }
    }
}
