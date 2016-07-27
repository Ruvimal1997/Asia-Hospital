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
    public partial class Stool_Test : MetroForm
    {
        public Stool_Test()
        {
            InitializeComponent();
        }

        private void Stool_Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Patient_Detail_Table' table. You can move, or remove it, as needed.
            this.patient_Detail_TableTableAdapter.Fill(this.dataSet1.Patient_Detail_Table);

        }
        int Registration_No, Age;
        Database db = new Database();
        DateTime tdate;
        string name, Gender, Color, Consistency, Mucus, Blood, WBCs_HPF, RBCs_HPF, Mecrophages, Trophozoite, P_Ova, P_Cyst, C_Ova, C_Cyst, Occult_Blood, RH, Red_Sub;

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
                    metroTextBox19.Text = (myReader2["Gender"].ToString());

                }
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "error");
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            try
            {
                Registration_No = Convert.ToInt32(metroComboBox2.Text);
                tdate = DateTime.Now;


                Color = metroTextBox4.Text;
                Consistency = metroTextBox5.Text;
                Mucus = metroTextBox6.Text;
                Blood = metroTextBox7.Text;
                WBCs_HPF = metroTextBox11.Text;
                RBCs_HPF = metroTextBox10.Text;
                Mecrophages = metroTextBox9.Text;
                Trophozoite = metroTextBox14.Text;
                P_Ova = metroTextBox13.Text;
                P_Cyst = metroTextBox12.Text;
                C_Ova = metroTextBox8.Text;
                C_Cyst = metroTextBox15.Text;
                Occult_Blood = metroTextBox16.Text;
                RH = metroTextBox17.Text;
                Red_Sub = metroTextBox18.Text;

                string query = "Insert into Stool_Test_Table  values ('" + Registration_No + "','" + tdate + "','" + Color + "', '" + Consistency + "' , '" + Mucus + "', '" + Blood + "', '" + WBCs_HPF + "', '" + RBCs_HPF + "', '" + Mecrophages + "' , '" + Trophozoite + "' , '" + P_Ova + "' , '" + P_Cyst + "'  , '" + C_Ova + "', '" + C_Cyst + "', '" + Occult_Blood + "', '" + RH + "', '" + Red_Sub + "')";
                int line = db.Save_Del_Update(query);

                if (line == 1)
                {
                    MetroMessageBox.Show(this,"Stool Test added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this,"Stool Test not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception)
            {
                MetroMessageBox.Show(this,"Exception");
            }
        }
    }
}
