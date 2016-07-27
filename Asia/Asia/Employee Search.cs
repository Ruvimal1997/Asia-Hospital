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
    public partial class Employee_Search : MetroForm
    {
        public Employee_Search()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void Employee_Search_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = db.GetData("select * from Employee");
        }
    }
}
