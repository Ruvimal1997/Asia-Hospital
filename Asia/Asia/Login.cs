using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asia
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        public object MetroMessageBox { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Database db = new Database();
        string username, password;
        private void metroButton1_Click(object sender, EventArgs e)
        {

            try
            {

                if (Txt_Uname.Text.Length > 0)
                {
                    errorProvider1.Clear();
                    username = Txt_Uname.Text;
                }
                else
                {
                    errorProvider1.SetError(Txt_Uname, "Username is required");
                }


                if (Txt_Pname.Text.Length > 3)
                {
                    errorProvider2.Clear();
                    password = Txt_Pname.Text;
                }
                else if (Txt_Pname.Text.Length == 0)
                {
                    errorProvider2.SetError(Txt_Pname, "Password is required");
                }
                //else if (metroTextBox4.Text.Length < 7)
                //{
                //    errorProvider2.SetError(metroTextBox4, "Password must contain more than 7 characters");
                //}
                //username = metroTextBox3.Text;
                //password = metroTextBox4.Text;
                String query1 = ("select * from Login_Table where User_Name='" + username + "'and Password='" + password + "'");
                DataTable dt = db.GetData(query1);


                if (dt.Rows.Count > 0)
                {
                    Main_Menu mn = new Main_Menu();
                    mn.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login please check your username and password");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Exception");
            }

        }
    }
}
