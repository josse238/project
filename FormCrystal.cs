using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class FormCrystal : Form
    {
        public FormCrystal()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 repo = new CrystalReport1();
            repo.SetDatabaseLogon("root", "", "localhost", "pad2024");
            crystalReportViewer1.ReportSource = repo;
        }

        private void FormCrystal_Load(object sender, EventArgs e)
        {

        }
    }
}
