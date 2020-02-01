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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void tblStudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStudentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dMUBoxDataSet);

        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMUBoxDataSet.tblOrder' table. You can move, or remove it, as needed.
            this.tblOrderTableAdapter.Fill(this.dMUBoxDataSet.tblOrder);
            // TODO: This line of code loads data into the 'dMUBoxDataSet.tblHall' table. You can move, or remove it, as needed.
            this.tblHallTableAdapter.Fill(this.dMUBoxDataSet.tblHall);
            // TODO: This line of code loads data into the 'dMUBoxDataSet.tblStudent' table. You can move, or remove it, as needed.
            this.tblStudentTableAdapter.Fill(this.dMUBoxDataSet.tblStudent);

        }

        private void btnClose3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
