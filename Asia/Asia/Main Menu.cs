
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
    public partial class Main_Menu : MetroForm
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            PaientEntry pe = new PaientEntry();
            pe.Show();
            Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Patient_Diagnosis_Entry_Form pdef = new Patient_Diagnosis_Entry_Form();
            pdef.Show();
            Close();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Patient_Receipt_Entry pref = new Patient_Receipt_Entry();
            pref.Show();
            Close();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Urine_Test_Form utf = new Urine_Test_Form();
            utf.Show();
            Close();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            Close();
        }
    }
}
