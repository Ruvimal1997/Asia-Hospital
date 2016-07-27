using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asia
{
    public partial class X_Ray : MetroForm
    {
        public X_Ray()
        {
            InitializeComponent();
        }

        private void X_Ray_Load(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }
        Database db = new Database();
        DateTime tdate;
        int regno, age;
        string xrayname, pname, gender, remark1, remark2, remark3, remark4, remark5, remark6, remark7, remark8, remark9, remark10, remark11, Opinion;

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string query2 = "Select * from X-Ray_Table where Registration_No='" + metroComboBox3.Text + "'";
                SqlDataReader myReader2 = db.showdata(query2);

                while (myReader2.Read())
                {
                    metroTextBox2.Text = (myReader2["Name"].ToString());
                    metroTextBox3.Text = (myReader2["Age"].ToString());
                    metroTextBox16.Text = (myReader2["Gender"].ToString());

                }
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this,"error");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                regno = Convert.ToInt32(metroComboBox3.Text);
                tdate = metroDateTime1.Value;
                pname = metroTextBox2.Text;
                age = Convert.ToInt32(metroTextBox15.Text);
                gender = metroTextBox16.Text;
                remark1 = metroTextBox3.Text;
                remark2 = metroTextBox4.Text;
                remark3 = metroTextBox6.Text;
                remark4 = metroTextBox5.Text;
                remark5 = metroTextBox8.Text;
                remark6 = metroTextBox7.Text;
                remark7 = metroTextBox14.Text;
                remark8 = metroTextBox13.Text;
                remark9 = metroTextBox12.Text;
                remark10 = metroTextBox11.Text;
                remark11 = metroTextBox9.Text;
                Opinion = metroTextBox2.Text;
                xrayname = metroTextBox1.Text;

                string query = "Insert into  X-Ray_Table values ('" + regno + "','" + tdate + "','" + xrayname + "', '" + remark1 + "' , '" + remark2 + "', '" + remark3 + "', '" + remark4 + "', '" + remark5 + "', '" + remark6 + "' , '" + remark7 + "', '" + remark8 + "', '" + remark9 + "', '" + remark10 + "', '" + remark11 + "', '" + Opinion + "')";
                int line = db.Save_Del_Update(query);

                if (line == 1)
                {
                    MetroMessageBox.Show(this, "X-Ray Details added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "X-Ray Details not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }
        }
    }
}
