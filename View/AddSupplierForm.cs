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
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
            cbActive.Checked = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string ruc, nombre, direccion, cuenta, telefono, email, estado;

            nombre = txtRuc.Text.ToString();
            ruc = txtNombre.Text.ToString();
            direccion = txtDireccion.Text.ToString();
            cuenta = txtCuenta.Text.ToString();
            telefono = txtTelefono.Text.ToString();
            email = txtEmail.Text.ToString();
            //estado = txtEstadoAdd.Text.ToString();
            //dgvEmployee.Rows.Add(ruc, nombre, direccion, cuenta, telefono, email, estado);
            txtRuc.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtCuenta.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            //txtEstadoAdd.Text = "";
            MessageBox.Show("El proveedor fue agregado.");
            this.Close();

        }

        private void cbActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCuentaAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
