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
    public partial class Patient_Receipt_Entry : MetroForm
    {
        int Registration_No, Reciept_No, Age;
        Database db = new Database();

        DateTime rdate;
        double DIagnosis_Fees, Indoor_Injection_Fees, Gastroscopy_Fees, ECG_Fees, Lab_Test_Fees, X_Ray_Fees, Colonoscopy_Fees, USG_Fees, Totol_Fee;

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            try
            {
                Registration_No = Convert.ToInt32(metroComboBox3.Text);
                rdate = DateTime.Now;
                DIagnosis_Fees = Convert.ToDouble(metroTextBox4.Text);
                Indoor_Injection_Fees = Convert.ToDouble(metroTextBox6.Text);
                Gastroscopy_Fees = Convert.ToDouble(metroTextBox8.Text);
                ECG_Fees = Convert.ToDouble(metroTextBox10.Text);
                Lab_Test_Fees = Convert.ToDouble(metroTextBox5.Text);
                X_Ray_Fees = Convert.ToDouble(metroTextBox7.Text);
                Colonoscopy_Fees = Convert.ToDouble(metroTextBox9.Text);
                USG_Fees = Convert.ToDouble(metroTextBox11.Text);
                Totol_Fee = Convert.ToDouble(metroTextBox12.Text);

                string queryi = "Insert into Patient_Fee_Table (Registartion_No,Receipt_Date,Dignosios_Fees,XRay_Fees,ECG_Fees,Lab_Test_Fees,Gastroscopy_Fees,USG_Fees,Indoor_Injection_Fees,Colonoscopy_Fees,Total_Cost) values ('" + Registration_No + "','" + rdate + "','" + DIagnosis_Fees + "', '" + X_Ray_Fees + "' , '" + ECG_Fees + "', '" + Lab_Test_Fees + "', '" + Gastroscopy_Fees + "', '" + USG_Fees + "', '" + Indoor_Injection_Fees + "' , '" + Colonoscopy_Fees + "','" + Totol_Fee + "')";
                int line = db.Save_Del_Update(queryi);

                if (line == 1)
                {
                    MetroMessageBox.Show(this,"Patient Reciept added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Patient Reciept not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }

        }

        public Patient_Receipt_Entry()
        {
            InitializeComponent();
        }
        int a;
        private void Patient_Receipt_Entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Patient_Detail_Table' table. You can move, or remove it, as needed.
            this.patient_Detail_TableTableAdapter.Fill(this.dataSet1.Patient_Detail_Table);
            try
            {

                string query2 = "Select * from Patient_Fee_Table";
                SqlDataReader myReader2 = db.showdata(query2);

                while (myReader2.Read())
                {
                    a = Convert.ToInt32(myReader2["Receipt_No"].ToString());

                }
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "error");
            }
            a = a + 1;
            metroTextBox13.Text = Convert.ToString(a);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            DIagnosis_Fees = Convert.ToDouble(metroTextBox4.Text);
            Indoor_Injection_Fees = Convert.ToDouble(metroTextBox6.Text);
            Gastroscopy_Fees = Convert.ToDouble(metroTextBox8.Text);
            ECG_Fees = Convert.ToDouble(metroTextBox10.Text);
            Lab_Test_Fees = Convert.ToDouble(metroTextBox5.Text);
            X_Ray_Fees = Convert.ToDouble(metroTextBox7.Text);
            Colonoscopy_Fees = Convert.ToDouble(metroTextBox9.Text);
            USG_Fees = Convert.ToDouble(metroTextBox11.Text);
            Totol_Fee = DIagnosis_Fees + Indoor_Injection_Fees + Gastroscopy_Fees + ECG_Fees + Lab_Test_Fees + X_Ray_Fees + Colonoscopy_Fees + USG_Fees;
            metroTextBox12.Text = Convert.ToString(Totol_Fee);
        }
    }
}
