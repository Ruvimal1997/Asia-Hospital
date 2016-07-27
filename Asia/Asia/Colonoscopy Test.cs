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
    public partial class Colonoscopy_Test : MetroForm
    {
        public Colonoscopy_Test()
        {
            InitializeComponent();
        }
        int Reg_No, Age;
        string Patient_Name, Gender, Anal_Canal, Rectum, Sigmoid_Colon, Descending_Colon, Splenic_Flexure, Transverse_Colon, Hepatic_Flexure, Ascending_Colon, Caecum, Terminal_Ileum, Biopsy, Opinion;

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Reg_No = Convert.ToInt32(metroComboBox2.Text);
                tdate = DateTime.Now;
                Anal_Canal = metroTextBox3.Text;
                Rectum = metroTextBox4.Text;
                Sigmoid_Colon = metroTextBox15.Text;
                Descending_Colon = metroTextBox6.Text;
                Splenic_Flexure = metroTextBox7.Text;
                Transverse_Colon = metroTextBox8.Text;
                Hepatic_Flexure = metroTextBox9.Text;
                Ascending_Colon = metroTextBox10.Text;
                Caecum = metroTextBox13.Text;
                Terminal_Ileum = metroTextBox12.Text;
                Biopsy = metroTextBox11.Text;
                Opinion = metroTextBox10.Text;


                string queryi = "Insert into Colonoscopy_Test_Table values ('" + Reg_No + "','" + tdate + "','" + Anal_Canal + "', '" + Rectum + "' , '" + Sigmoid_Colon + "', '" + Descending_Colon + "', '" + Splenic_Flexure + "', '" + Transverse_Colon + "', '" + Hepatic_Flexure + "' , '" + Ascending_Colon + "' , '" + Caecum + "' , '" + Terminal_Ileum + "'  , '" + Biopsy + "', '" + Opinion + "')";
                int line = db.Save_Del_Update(queryi);

                if (line == 1)
                {
                    MetroMessageBox.Show(this, "Colonoscopy test added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Colonoscopy test not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception)
            {
                MetroMessageBox.Show(this,"Eception");

            }
        }

        Database db = new Database();
        DateTime tdate;
        private void Colonoscopy_Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Patient_Detail_Table' table. You can move, or remove it, as needed.
            this.patient_Detail_TableTableAdapter.Fill(this.dataSet1.Patient_Detail_Table);

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string query2 = "Select * from Patient_Detail_Table where Registration_No='" + metroComboBox2.Text + "'";
                SqlDataReader myReader2 = db.showdata(query2);

                while (myReader2.Read())
                {
                    metroTextBox2.Text = (myReader2["Name"].ToString());
                    metroTextBox15.Text = (myReader2["Age"].ToString());
                    metroTextBox16.Text = (myReader2["Gender"].ToString());

                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this,"Exception");
            }
        }
    }
}
