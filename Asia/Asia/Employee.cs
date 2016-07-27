using MetroFramework;
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
    public partial class Employee : MetroForm
    {
        Database db = new Database();
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

            try
            {
                int empid, tel;
                string fname, email, lname, gender, address, emptype, username, password;
                DateTime dob;

                empid = Convert.ToInt32(metroTextBox1.Text);
                fname = metroTextBox2.Text;
                lname = metroTextBox3.Text;
                gender = metroComboBox1.Text;
                dob = metroDateTime1.Value;
                address = metroTextBox4.Text;
                email = metroTextBox7.Text;
                tel = Convert.ToInt32(metroTextBox5.Text);

                emptype = metroComboBox2.Text;
                username = metroTextBox6.Text;
                password = metroTextBox8.Text;

                string query = "Insert into Employee (First_Name,Last_Name,Gender,Date_of_Birth,Address,Email,Telephone) values ('" + fname + "','" + lname + "', '" + gender + "' , '" + dob + "', '" + address + "', '" + email + "', '" + tel + "' )";
                int line = db.Save_Del_Update(query);

                if (line == 1)
                {
                    MetroMessageBox.Show(this,"Employee added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Employee not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                string query1 = "Insert into Login_Table values ('" + username + "','" + password + "','" + emptype + "')";

                int line1 = db.Save_Del_Update(query1);

                if (line1 == 1)
                {
                    MetroMessageBox.Show(this, "Employee login details added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Employee login details not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }
    }
}
