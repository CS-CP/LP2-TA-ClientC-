using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AuthenticationForm : Form
    {
        int usuarioPermiso;
        MainWindow mainWindow;
        public AuthenticationForm(MainWindow owner)
        {
            InitializeComponent();
            mainWindow = owner;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string password = txtPassword.Text;
            if (user == "gerente" || password == "gerente") usuarioPermiso = 1;
            else if (user == "supervisor" || password == "supervisor") usuarioPermiso = 2;
            else if (user == "vendedor" || password == "vendedor") usuarioPermiso = 3;
            else
            {
                MessageBox.Show("Usuario incorrecto");
                return;
            }
            MainWindow menu = new MainWindow();
            if (usuarioPermiso == 1) menu.darPermiso(MainWindow.Permiso.Gerente);
            else if (usuarioPermiso == 2) menu.darPermiso(MainWindow.Permiso.Supervisor);
            else if (usuarioPermiso == 3) menu.darPermiso(MainWindow.Permiso.Vendedor);
            this.Hide();
            menu.Show();
            
        



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
