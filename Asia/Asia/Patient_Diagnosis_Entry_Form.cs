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
    public partial class Patient_Diagnosis_Entry_Form : MetroForm
    {
        string Name, Provisional_Diagnosis, blood, urine, Biochemistry, Stool, Colonscopy, Gastroscopy, X_Ray, Sonography, ECG, Other_Test, Remarks, Reconsultation_Week, Final_Diagnosis, Diet_Advice, Status, Medicine_Name, Precautions;
        DateTime recondate, injectiondate, diagdate;
        int No_of_Doses;

        public Patient_Diagnosis_Entry_Form()
        {
            InitializeComponent();
        }

        private void Patient_Diagnosis_Entry_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }
        Database db = new Database();

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int regno = Convert.ToInt32(metroComboBox3.Text);
                Other_Test = metroTextBox4.Text;
                Remarks = metroTextBox5.Text;
                recondate = metroDateTime1.Value;
                Reconsultation_Week = metroTextBox6.Text;
                Final_Diagnosis = metroTextBox7.Text;
                Diet_Advice = metroTextBox9.Text;
                injectiondate = metroDateTime2.Value;
                Status = metroComboBox2.Text;
                Medicine_Name = metroTextBox13.Text;
                Precautions = metroTextBox14.Text;
                No_of_Doses = Convert.ToInt32(metroTextBox15.Text);
                diagdate = metroDateTime3.Value;
                Provisional_Diagnosis = metroTextBox3.Text;


                string Patient_Medicine_Table = "Insert into Patient_Medicine_Table (Registration_No,Medicine_Name,Precaution,No_of_Doses) values ('" + regno + "','" + Medicine_Name + "','" + Precautions + "', '" + No_of_Doses + "')";
                int line = db.Save_Del_Update(Patient_Medicine_Table);

                string Patient_Injection_Dates_Table = "Insert into Patient_Injection_Dates_Table (Registration_No,Dignosis_Date,Injection_Date,Status) values ('" + regno + "','" + diagdate + "','" + injectiondate + "', '" + Status + "')";
                int line1 = db.Save_Del_Update(Patient_Injection_Dates_Table);

                string Patient_Diet_Advice_Table = "Insert into Patient_Diet_Advice_Table (Registration_No,Diet_Advice) values ('" + regno + "','" + Diet_Advice + "')";
                int line2 = db.Save_Del_Update(Patient_Diet_Advice_Table);

                string Patient_Diagnosis_Table = "Insert into Patient_Diagnosis_Table (Registration_No,Dignosis_Date,Provisional_Dignosis,Remark,BioChemistry,Stool,Blood,Colonoscopy,Gastroscopy,Urine,XRay,SONOGRAPHY,Others,Reconsultation_Advice_Week,Reconsultation_Advice_Date,FINAL_Diagnosis,ECG) values ('" + regno + "','" + diagdate + "','" + Provisional_Diagnosis + "','" + Remarks + "','" + Biochemistry + "','" + Stool + "','" + blood + "','" + Colonscopy + "','" + Gastroscopy + "','" + urine + "','" + X_Ray + "','" + Sonography + "','" + Other_Test + "','" + Reconsultation_Week + "','" + recondate + "','" + Final_Diagnosis + "','" + ECG + "')";
                int line3 = db.Save_Del_Update(Patient_Diagnosis_Table);

                if (line == 1 && line1 == 1 && line2 == 1 && line3 == 1)
                {
                    MetroMessageBox.Show(this,"Record added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                   MetroMessageBox.Show(this,"Record not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Exception");
            }
        }
    }
}
