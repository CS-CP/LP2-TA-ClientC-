using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ModifySupplierForm : Form
    {
        public ModifySupplierForm()
        {
            InitializeComponent();
            //cbActive.Checked = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string ruc, nombre, direccion, cuenta, telefono, email, estado;
            /*
            nombre = txtNombreM.Text.ToString();
            ruc = txtRucM.Text.ToString();
            direccion = txtDireccionM.Text.ToString();
            cuenta = txtCuentaM.Text.ToString();
            telefono = txtTelefonoM.Text.ToString();
            email = txtEmailM.Text.ToString();
            //estado = txtEstadoM.Text.ToString();
            //dgvEmployee.Rows.Add(ruc, nombre, direccion, cuenta, telefono, email, estado);            
            txtNombreM.Text = "";
            txtRucM.Text = "";
            txtDireccionM.Text = "";
            txtCuentaM.Text = "";
            txtTelefonoM.Text = "";
            txtEmailM.Text = "";
            //txtEstadoM.Text = "";*/
            MessageBox.Show("La información fue actualizada.");
            this.Close();
        }
    }
}
