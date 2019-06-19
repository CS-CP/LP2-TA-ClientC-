using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.MateWSLocal;

namespace WindowsFormsApp1
{
    public partial class SupplierForm : Form
    {
        private View.MateWSLocal.DBControllerWSClient serviceDA;
        private BindingList<supplier> suppliers;
        public SupplierForm()
        {
            InitializeComponent();
            updateDataGridView();
            //ruc, nombre, dirección, cuenta bancaria, telefono, email, estado
            /*dgvEmployee.Rows.Add("191052151", "PASTELES VERDOSOS", "AV. UNIVERSITARIA 1994", "456789123", "998877665", "pasteles@verdosos.com", "1");
            dgvEmployee.Rows.Add("156549898", "COMPANIA DE SEGUROS STACKERS", "AV. TOMAS VALLE 5104", "411523589", "999277845", "stck_cmpny@segurosstack.com", "0");
            dgvEmployee.Rows.Add("187894833", "PINTURAS MODERNAS SAC", "AV. TUPAC AMARU 1500", "411122389", "907551061", "paintings@modernas.com.pe", "1");
            dgvEmployee.Rows.Add("112987345", "JOYERIAS EL MAR SABROSO", "CALLE LAS GARDENIAS 501", "456256101", "968571163", "jewel@marsabroso.com", "1");
            dgvEmployee.Rows.Add("172849743", "GAMARRO", "CENTRO DE LIMA", "469521212", "968440660", "mercado_real@gmail.com", "1");
            dgvEmployee.Rows.Add("106454654", "OPERATIVES SAC", "JIRON DE LA UNION 336", "455691231", "903320657", "klev@ooss.com", "0");
            dgvEmployee.Rows.Add("134534567", "OPERATIVES SAA", "JIRON DE LA UNION 245", "460529630", "966599877", "qtpie@ooss.com", "1");
            dgvEmployee.Rows.Add("187634542", "COLEGIO TRILCE LOS OLIVOS", "AV. TOMAS VALLE 1869", "415975356", "987423406", "colegios_trilce@trilce.com.pe", "1");*/
            
        }
        void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvEmployee.Rows.Clear();
            serviceDA = new DBControllerWSClient();
            suppliers = new BindingList<supplier>(serviceDA.queryAllSupplier());
            for (int i = 0; i < suppliers.Count; i++)
            {
                dgvEmployee.Rows.Add(new String[] {
                ""+suppliers[i].RUC, suppliers[i].name,suppliers[i].address,suppliers[i].bankData,""+suppliers[i].contactPhone,"" + suppliers[i].contactEmail
                });
            }
            Cursor.Current = Cursors.Arrow;
        }
        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            AddSupplierForm addSupForm = new AddSupplierForm();
            addSupForm.ShowDialog();
        }

        private void BtnModifyEmployee_Click(object sender, EventArgs e)
        {
            ModifySupplierForm modifySupForm = new ModifySupplierForm();
            modifySupForm.ShowDialog();
        }

        View.MainWindow refParent;
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }
        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string searchValue = txtRUC.Text;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvEmployee.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {

                        string nombre, direccion, cuenta, telefono, email, estado;
                        nombre = row.Cells[1].Value.ToString();
                        direccion = row.Cells[2].Value.ToString();
                        cuenta = row.Cells[3].Value.ToString();
                        telefono = row.Cells[4].Value.ToString();
                        email = row.Cells[5].Value.ToString();
                        if (row.Cells[6].Value.ToString() == "0" ){
                            MessageBox.Show("El proveedor ya estaba eliminado.");
                            break;
                        }
                        estado = "0";
                        dgvEmployee.Rows.Clear();
                        dgvEmployee.Rows.Add(searchValue, nombre, direccion, cuenta, telefono, email, estado);
                        MessageBox.Show("El proveedor se eliminó satisfactoriamente.");
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se encontró el proveedor.\nEscriba un RUC apropiado.");
            }
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            string searchValue = txtRUC.Text;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvEmployee.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {

                        string nombre, direccion, cuenta, telefono, email, estado;
                        nombre = row.Cells[1].Value.ToString();
                        direccion = row.Cells[2].Value.ToString();
                        cuenta = row.Cells[3].Value.ToString();
                        telefono = row.Cells[4].Value.ToString();
                        email = row.Cells[5].Value.ToString();
                        estado = row.Cells[6].Value.ToString();
                        dgvEmployee.Rows.Clear();
                        dgvEmployee.Rows.Add(searchValue, nombre, direccion, cuenta, telefono, email, estado);
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se encontró el proveedor.\nEscriba un RUC apropiado.");
            }        
        }
    }
}
