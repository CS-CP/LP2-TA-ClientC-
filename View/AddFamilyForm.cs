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
    public enum StateP
    {
        Start, Save, New
    }
    public partial class AddFamilyForm : Form
    {
        public class Family
        {
            
        }
        private Family f;

        public Family F { get => f; set => f = value; }

        public void componentsState(StateP s)
        {
            switch (s)
            {
                case StateP.Start:
                    gbGeneralInformation.Enabled = false;
                    cleanForm();
                    btnSave.Enabled = false;
                    break;
                case StateP.Save:
                    gbGeneralInformation.Enabled = false;
                    cleanForm();
                    btnSave.Enabled = false;
                    break;
                case StateP.New:
                    gbGeneralInformation.Enabled = true;
                    cleanForm();
                    btnSave.Enabled = true;
                    break;

            }
        }

        public void cleanForm()
        {
           
            txtFamilyCode.Text = "";
            txtDescription.Text = "";
            txtName.Text = "";
            cbActive.Checked = false;
         }

        public AddFamilyForm()
        {
            InitializeComponent();
            f = new Family();
            cbActive.Checked = true;
            //componentsState(StateP.Start);
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            componentsState(StateP.New);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //componentsState(StateP.Save);
            try
            {
                String name = txtName.Text;
                String code = txtFamilyCode.Text;
                String description = txtDescription.Text;
                int state;
                if (cbActive.Checked == true) state = 1;
                else state = 0;

                //se crea la nueva familia y se inserta en la tabla

                MessageBox.Show("Se guardó satisfactoriamente la familia.");
                this.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo guardar la familia.");
            }
        }
    }
}
