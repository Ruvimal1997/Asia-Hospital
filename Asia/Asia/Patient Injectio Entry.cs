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
    public partial class Patient_Injectio_Entry : MetroForm
    {
        public Patient_Injectio_Entry()
        {
            InitializeComponent();
        }

        private void Patient_Injectio_Entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Patient_Detail_Table' table. You can move, or remove it, as needed.
            this.patient_Detail_TableTableAdapter.Fill(this.dataSet1.Patient_Detail_Table);

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }
        int diagno;
        DateTime diagdate, injectdate;
        string status;
        Database db = new Database();

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string query2 = "Select * from Patient_Detail_Table where Registration_No='" + metroComboBox2.Text + "'";
                SqlDataReader myReader2 = db.showdata(query2);

                while (myReader2.Read())
                {
                    metroTextBox2.Text = (myReader2["Name"].ToString());
                    metroTextBox3.Text = (myReader2["Age"].ToString());
                    metroTextBox1.Text = (myReader2["Gender"].ToString());

                }
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "error");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                diagno = Convert.ToInt32(metroComboBox2.Text);
                diagdate = DateTime.Now;
                injectdate = metroDateTime2.Value;
                status = metroComboBox1.Text;


                string queryi = "Insert into Patient_Injection_Dates_Table values ('" + diagno + "','" + diagdate + "','" + metroDateTime2.Value + "', '" + status + "')";
                int line = db.Save_Del_Update(queryi);

                if (line == 1)
                {
                    MetroMessageBox.Show(this,"Pateint Injection added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Pateint Injection not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }
        }
    }
}
