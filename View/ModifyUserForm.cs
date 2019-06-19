using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User
{
    public partial class ModifyUserForm : Form
    {
        UserForm refParent;
        public ModifyUserForm()
        {
            InitializeComponent();
        }

        private void btnModifySearchUser_Click(object sender, EventArgs e)
        {

        }

        public void SetParent(UserForm form)
        {
            refParent = form;
        }

        private void btnModifySaveUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario se modificó satisfactoriamente");
            this.Close();
        }

        private void ModifyUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
