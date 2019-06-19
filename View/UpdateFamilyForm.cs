using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto
{
    public enum StateFM
    {
        Start, Save, Update
    }
    public partial class UpdateFamilyForm : Form
    {
        public UpdateFamilyForm()
        {
            InitializeComponent();

            componentsState(StateFM.Start);
        }

        public void componentsState(StateFM s)
        {
            switch (s)
            {
                case StateFM.Start:
                    gbGeneralInformation.Enabled = false;
                    btnSave.Enabled = false;
                    break;
                case StateFM.Save:
                    gbGeneralInformation.Enabled = false;
                    btnSave.Enabled = false;
                    break;
                case StateFM.Update:
                    gbGeneralInformation.Enabled = true;
                    btnSave.Enabled = true;
                    break;

            }
        }

        public void CompleteForm()
        {
            //se llena la infromación de los recuadros con la infromación del producto seleccionado
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            componentsState(StateFM.Update);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            componentsState(StateFM.Save);
            try
            {
                String name = txtName.Text;
                String code = txtFamilyCode.Text;
                String description = txtDescription.Text;
                int state;
                if (cbActive.Checked == true) state = 1;
                else state = 0;

                //se cambian los atributos de familia y se modifica en la tabla

                MessageBox.Show("Se modificó satisfactoriamente la familia.");
            }
            catch
            {
                MessageBox.Show("No se pudo modificar la familia.");
            }


        }
    }
}
