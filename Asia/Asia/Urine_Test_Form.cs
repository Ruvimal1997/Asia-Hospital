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
    public partial class Urine_Test_Form : MetroForm
    {
        public Urine_Test_Form()
        {
            InitializeComponent();
        }

        private void Urine_Test_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asiaHospitalManagementSystemDataSet.Patient_Detail_Table' table. You can move, or remove it, as needed.
            this.patient_Detail_TableTableAdapter.Fill(this.asiaHospitalManagementSystemDataSet.Patient_Detail_Table);

            try
            {

                string query2 = "Select * from Patient_Detail_Table where Registration_No='" + metroComboBox3.Text + "'";
                SqlDataReader myReader2 = db.showdata(query2);

                while (myReader2.Read())
                {
                    metroTextBox2.Text = (myReader2["Name"].ToString());
                    metroTextBox3.Text = (myReader2["Age"].ToString());
                    metroTextBox30.Text = (myReader2["Gender"].ToString());

                }
            }

            catch (Exception)
            {
                MetroMessageBox.Show(this,"Exception");
            }


        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }
        int Registration_Number, Age;
        string BILE_SALT, BILE_PIGMENT, UROBILINOGEN_HPF, PORPHOBILINOGEN, ACETONE, OCCULT_BLOOD, PKU, BECE_JONES_PROTEINS, AMINO_ACID, tw_URINARY_PROTEIN, twHRS_URINARY_17_KETOSTERIOD, twhrs_URINVARY_VMA, TOTAL_VALUE, PREGNANCY_TEST;
        Database db = new Database();
        DateTime tdate;
        string name, Gender, Appearance, Sp_Gravity, Reaction, Alburnin, Sugar, RBCs_HPE, WBCs_HPF, EPITH_Cells_HPF, Crystails, Cast_HPF, Amorphous_Sediments, Spermatozoa, Others;


        private void metroButton2_Click(object sender, EventArgs e)
        {

            try
            {
                Registration_Number = Convert.ToInt32(metroComboBox3.Text);
                tdate = DateTime.Now;
                name = metroTextBox2.Text;
                Gender = metroTextBox30.Text;
                Age = Convert.ToInt32(metroTextBox3.Text);
                Appearance = metroTextBox4.Text;
                Sp_Gravity = metroTextBox5.Text;
                Reaction = metroTextBox6.Text;
                Alburnin = metroTextBox7.Text;
                Sugar = metroTextBox8.Text;
                RBCs_HPE = metroTextBox13.Text;
                WBCs_HPF = metroTextBox12.Text;
                EPITH_Cells_HPF = metroTextBox11.Text;
                Crystails = metroTextBox10.Text;
                Cast_HPF = metroTextBox18.Text;
                Amorphous_Sediments = metroTextBox17.Text;
                Spermatozoa = metroTextBox16.Text;
                Others = metroTextBox15.Text;

                BILE_SALT = metroTextBox1.Text;
                BILE_PIGMENT = metroTextBox14.Text;
                UROBILINOGEN_HPF = metroTextBox19.Text;
                PORPHOBILINOGEN = metroTextBox20.Text;
                ACETONE = metroTextBox21.Text;
                OCCULT_BLOOD = metroTextBox22.Text;
                PKU = metroTextBox23.Text;
                BECE_JONES_PROTEINS = metroTextBox9.Text;
                AMINO_ACID = metroTextBox24.Text;
                tw_URINARY_PROTEIN = metroTextBox25.Text;
                twHRS_URINARY_17_KETOSTERIOD = metroTextBox26.Text;
                twhrs_URINVARY_VMA = metroTextBox27.Text;
                TOTAL_VALUE = metroTextBox28.Text;
                PREGNANCY_TEST = metroTextBox29.Text;




                string queryi = "Insert into Urine_Table  values ('" + Registration_Number + "','" + tdate + "','" + Appearance + "', '" + Sp_Gravity + "' , '" + Reaction + "', '" + Alburnin + "', '" + Sugar + "', '" + RBCs_HPE + "', '" + WBCs_HPF + "' , '" + EPITH_Cells_HPF + "' , '" + Crystails + "' , '" + Cast_HPF + "'  , '" + Amorphous_Sediments + "', '" + Spermatozoa + "', '" + Others + "', '" + BILE_SALT + "', '" + BILE_PIGMENT + "', '" + UROBILINOGEN_HPF + "', '" + PORPHOBILINOGEN + "', '" + ACETONE + "', '" + OCCULT_BLOOD + "', '" + PKU + "', '" + BECE_JONES_PROTEINS + "', '" + AMINO_ACID + "', '" + tw_URINARY_PROTEIN + "', '" + twHRS_URINARY_17_KETOSTERIOD + "', '" + twhrs_URINVARY_VMA + "', '" + TOTAL_VALUE + "', '" + PREGNANCY_TEST + "')";
                int line = db.Save_Del_Update(queryi);

                if (line == 1)
                {
                    MessageBox.Show("Urine Test added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Urine Test not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }
        }
    }
}
