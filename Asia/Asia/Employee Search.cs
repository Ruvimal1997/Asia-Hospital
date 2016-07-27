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
    public partial class Employee_Search : MetroForm
    {
        public Employee_Search()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void Employee_Search_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = db.GetData("select * from Employee");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            metroTextBox1.Text = metroGrid1.CurrentRow.Cells["Emp_ID"].Value.ToString();
            metroTextBox2.Text = metroGrid1.CurrentRow.Cells["First_Name"].Value.ToString();
            metroTextBox3.Text = metroGrid1.CurrentRow.Cells["Last_Name"].Value.ToString();
            metroComboBox1.Text = metroGrid1.CurrentRow.Cells["Gender"].Value.ToString();
            metroDateTime1.Text = metroGrid1.CurrentRow.Cells["Date_of_Birth"].Value.ToString();
            metroTextBox4.Text = metroGrid1.CurrentRow.Cells["Address"].Value.ToString();
            metroTextBox7.Text = metroGrid1.CurrentRow.Cells["Email"].Value.ToString();
            metroTextBox5.Text = metroGrid1.CurrentRow.Cells["Telephone"].Value.ToString();
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
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

         

                string query = " Update into Employee  SET  First_Name='" + fname + "',Last_Name='" + lname + "',Gender='" + gender + "',Date_of_Birth='" + dob + "',Address ='" + address + "',Email='" + email + "',Telephone='" + tel + "' WHERE Emp_ID = '" + empid + "'  ";     
                int line = db.Save_Del_Update(query);

                if (line == 1)
                {
                    metroGrid1.DataSource = db.GetData("select * from Employee");
                    MetroMessageBox.Show(this,"Employee updated Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Employee not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            try
            {
                int Emp_IDd = Convert.ToInt32(metroTextBox1.Text);


                string queryd = "Delete from Employee WHERE Emp_ID='" + Emp_IDd + "'";
                int line = db.Save_Del_Update(queryd);

                if (line == 1)
                {
                    metroGrid1.DataSource = db.GetData("select * from Employee");
                    MetroMessageBox.Show(this,"Employee test Deleted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Employee test not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }



        }
    }
}
