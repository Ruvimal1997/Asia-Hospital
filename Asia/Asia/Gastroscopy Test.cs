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
    public partial class Gastroscopy_Test : MetroForm
    {
        public Gastroscopy_Test()
        {
            InitializeComponent();
        }

        private void Gastroscopy_Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Patient_Detail_Table' table. You can move, or remove it, as needed.
            this.patient_Detail_TableTableAdapter.Fill(this.dataSet1.Patient_Detail_Table);
            metroTextBox17.Text = DateTime.Now.ToString();
        }
        int Reg_No, Age;
        string Patient_Name, Gender, Esophagus, Fundus, Corpus, Antrum, Bulb, First_Part, Second_Part, Biopsy, First_Opinion, Pylorospusm, Biliary_Reflux, Gut_Hypomotility, Second_Opinion;

        private void metroButton1_Click(object sender, EventArgs e)
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
                Esophagus = metroTextBox4.Text;
                Fundus = metroTextBox5.Text;
                Corpus = metroTextBox6.Text;
                Antrum = metroTextBox7.Text;
                Bulb = metroTextBox8.Text;
                First_Part = metroTextBox9.Text;
                Second_Part = metroTextBox10.Text;
                Biopsy = metroTextBox11.Text;
                First_Opinion = metroTextBox12.Text;
                Pylorospusm = metroTextBox13.Text;
                Biliary_Reflux = metroTextBox14.Text;
                Gut_Hypomotility = metroTextBox15.Text;
                Second_Opinion = metroTextBox16.Text;

                string queryi = "Insert into Gastroscopy_Test_Table values ('" + Reg_No + "','" + tdate + "','" + Esophagus + "', '" + Fundus + "' , '" + Corpus + "', '" + Antrum + "', '" + Bulb + "', '" + First_Part + "', '" + Second_Part + "' , '" + Biopsy + "' , '" + First_Opinion + "' , '" + Pylorospusm + "'  , '" + Biliary_Reflux + "', '" + Gut_Hypomotility + "', '" + Second_Opinion + "')";
                int line = db.Save_Del_Update(queryi);

                if (line == 1)
                {
                    MetroMessageBox.Show(this, "Gastroscopy test added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Gastroscopy test not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");

            }
        }

        Database db = new Database();
        DateTime tdate;
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
                MetroMessageBox.Show(this,"Exception");
            }
        }
    }
}
