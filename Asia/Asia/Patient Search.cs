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
    public partial class Patient_Search : MetroForm
    {
        public Patient_Search()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void Patient_Search_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = db.GetData("select * from Patient_Detail_Table");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(metroTextBox1.Text);


                string queryd = "Delete from Patient_Detail_Table WHERE Registration_No='" + pid + "'";
                int line = db.Save_Del_Update(queryd);

                if (line == 1)
                {
                    metroGrid1.DataSource = db.GetData("select * from Patient_Detail_Table");
                    MetroMessageBox.Show(this, "Patient record Deleted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Patient record not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {
                MetroMessageBox.Show(this, "PLease enter the fiels properly");
            }

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            metroTextBox1.Text = metroGrid1.CurrentRow.Cells["Registration_No"].Value.ToString();
            metroTextBox5.Text = metroGrid1.CurrentRow.Cells["Registration_Date"].Value.ToString();
            metroTextBox2.Text = metroGrid1.CurrentRow.Cells["Name"].Value.ToString();
            metroTextBox3.Text = metroGrid1.CurrentRow.Cells["Address"].Value.ToString();
            metroTextBox6.Text = metroGrid1.CurrentRow.Cells["City"].Value.ToString();
            metroTextBox7.Text = metroGrid1.CurrentRow.Cells["Telephone_No"].Value.ToString();
            metroComboBox1.Text = metroGrid1.CurrentRow.Cells["Marital_Status"].Value.ToString();
            metroComboBox2.Text = metroGrid1.CurrentRow.Cells["Religion"].Value.ToString();
            metroComboBox3.Text = metroGrid1.CurrentRow.Cells["Gender"].Value.ToString();
            metroTextBox4.Text = metroGrid1.CurrentRow.Cells["Father_Husband_Name"].Value.ToString();
            metroComboBox4.Text = metroGrid1.CurrentRow.Cells["Status"].Value.ToString();
            metroTextBox8.Text = metroGrid1.CurrentRow.Cells["Age"].Value.ToString();
            metroTextBox9.Text = metroGrid1.CurrentRow.Cells["Email"].Value.ToString();
         
        }
        int tel, age, regs, reg;
        string pname, add, mentstat, rel, fhname, city, gender, pstat, email;

        private void Exit_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }

        DateTime regdate;
        int pid;
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                pid = Convert.ToInt32(metroTextBox1.Text);
                pname = metroTextBox2.Text;
                add = metroTextBox3.Text;
                mentstat = metroComboBox1.Text;
                rel = metroComboBox2.Text;
                fhname = metroTextBox4.Text;
                regdate = DateTime.Now;
                city = metroTextBox6.Text;
                gender = metroComboBox3.Text;
                tel = Convert.ToInt32(metroTextBox7.Text);
                age = Convert.ToInt32(metroTextBox8.Text);
                pstat = metroComboBox4.Text;
                email = metroTextBox9.Text;



                string query = " Update Patient_Detail_Table  SET  Name='" + pname + "',Address='" + add + "',City='" + city + "',Telephone_No='" + tel + "',Marital_Status ='" + mentstat + "',Religion='" + rel + "',Gender='" + gender + "',Father_Husband_Name='"+fhname+"',Status='"+ pstat + "',Age='"+ age + "',Email='"+email+"' WHERE Registration_No = '" + pid + "'  ";
                int line = db.Save_Del_Update(query);

                if (line == 1)
                {
                    metroGrid1.DataSource = db.GetData("select * from Employee");
                    MetroMessageBox.Show(this, "Patient Record updated Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Patient Record not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }
        }
    }
}
