using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asia
{
    public partial class PaientEntry : MetroForm
    {
        public PaientEntry()
        {
            InitializeComponent();
        }

        int reg1;
        private void PaientEntry_Load(object sender, EventArgs e)
        {
            string query3 = "Select * from Patient_Detail_Table ";
            SqlDataReader myReader1 = db.showdata(query3);

            while (myReader1.Read())
            {
                reg1 = Convert.ToInt32((myReader1["Registration_No"].ToString()));

            }

            reg1 = reg1 + 1;
            metroTextBox1.Text = Convert.ToString(reg1);
           
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Main_Menu mn = new Main_Menu();
            mn.Show();
            Close();
        }
        int tel, age, regs, reg;
        string pname, add, mentstat, rel, fhname, city, gender, pstat, email;
        DateTime regdate;
        Database db = new Database();
        private void Add_Click(object sender, EventArgs e)
        {

            try
            {
                
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


                string query = "Insert into Patient_Detail_Table(Registration_Date,Name,Address,City,Telephone_No,Marital_Status ,Religion,Gender,Father_Husband_Name ,Status,Age,Email) values ('" + regdate + "','" + pname + "', '" + add + "' , '" + city + "', '" + tel + "', '" + mentstat + "', '" + rel + "', '" + gender + "' , '" + fhname + "' , '" + pstat + "' , '" + age + "'  ,'" + email + "')";
                int line = db.Save_Del_Update(query);

                if (line == 1)
                {
                    email = metroTextBox9.Text;
                    string messgae = "Dear Customer, Thank you for registering with us ";
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("asiahospital123@gmail.com", "asia12345");
                    MailMessage msg = new MailMessage();
                    msg.To.Add(email);
                    msg.From = new MailAddress("asiahospital123@gmail.com");
                    msg.Subject = "Re:Asia Hospital";
                    msg.Body = messgae;
                    client.Send(msg);

                    MetroMessageBox.Show(this, "Patient Entry added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroMessageBox.Show(this, "Patient Entry not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {
                MetroMessageBox.Show(this, "Exception");
            }

         }
    }
}
