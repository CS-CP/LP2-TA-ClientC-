using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entregable
{
    public partial class AddEmployeeForm : Form
    {
        EmployeeForm refParent;
        public AddEmployeeForm()
        {
            InitializeComponent();
            cbActive.Checked = true;
        }

        public void SetParent(EmployeeForm form)
        {
            refParent = form;
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El empleado se agregó satisfactoriamente.");
            this.Close();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
