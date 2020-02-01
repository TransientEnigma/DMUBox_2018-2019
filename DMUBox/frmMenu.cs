using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMUBox
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            //create and instance of frmBox
            frmBox myBoxForm = new frmBox();
            myBoxForm.Show();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            frmFindStudent findStudent = new frmFindStudent();
            findStudent.Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmStudent studentSearch = new frmStudent();
            studentSearch.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmStudentReport studentSearch = new frmStudentReport();
            studentSearch.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHallStudentsReport newReport = new frmHallStudentsReport();
            newReport.Show();
        }
    }
}
