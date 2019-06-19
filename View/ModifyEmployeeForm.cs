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
    public partial class ModifyEmployeeForm : Form
    {
        EmployeeForm refParent;

        public ModifyEmployeeForm()
        {
            InitializeComponent();
        }

        public void SetParent(EmployeeForm form)
        {
            refParent = form;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El empleado se modificó satisfactoriamente");
            this.Close();
        }
    }
}
