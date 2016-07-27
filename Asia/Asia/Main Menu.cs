
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
          
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
          
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {

        }
        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            PaientEntry pe = new PaientEntry();
            pe.Show();
            Close();
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            Close();
        }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            Colonoscopy_Test ct = new Colonoscopy_Test();
            ct.Show();
            Close();

        }

        private void metroTile4_Click_1(object sender, EventArgs e)
        {
            Gastroscopy_Test gt = new Gastroscopy_Test();
            gt.Show();
            Close();

        }

        private void metroTile5_Click_1(object sender, EventArgs e)
        {
            Patient_Prescription pp = new Patient_Prescription();
            pp.Show();
            Close();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Patient_Injectio_Entry pi = new Patient_Injectio_Entry();
            pi.Show();
            Close();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Patient_Receipt_Entry pre = new Patient_Receipt_Entry();
            pre.Show();
            Close();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            Stool_Test st = new Stool_Test();
            st.Show();
            Close();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            Urine_Test_Form utf = new Urine_Test_Form();
            utf.Show();
            Close();

        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            X_Ray xr = new X_Ray();
            xr.Show();
            Close();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Employee_Search es = new Employee_Search();
            es.Show();
            Close();
        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            Patient_Search ps = new Patient_Search();
            ps.Show();
            Close();
        }
    }
 }

