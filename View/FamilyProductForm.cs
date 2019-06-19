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

namespace Producto
{
    public enum StateF
    {
        Start, SelectedRow
    }
    public partial class FamilyProductForm : Form
    {

        public class Family { }
        private Family f;
        private View.MateWSLocal.DBControllerWSClient serviceDA;
        private BindingList<View.MateWSLocal.family> families;
        public FamilyProductForm()
        {
            InitializeComponent();
            componentsState(StateF.Start);
            updateDataGridView();
            f = new Family();            
            dgvFamilies.AutoGenerateColumns = false;
            //dgvFamilies.DataSource = families;
        }
        View.MainWindow refParent;
        void updateDataGridView()
        {
            Cursor.Current = Cursors.WaitCursor;
            dgvFamilies.Rows.Clear();
            serviceDA = new View.MateWSLocal.DBControllerWSClient();
            families = new BindingList<View.MateWSLocal.family>(serviceDA.queryAllFamily());
            for (int i = 0; i < families.Count; i++)
            {
                dgvFamilies.Rows.Add(new String[] {
                ""+families[i].idFamily, families[i].name,families[i].description
                });
            }
            Cursor.Current = Cursors.Arrow;
        }
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }
        public void componentsState(StateF s)
        {
            switch (s)
            {
                case StateF.Start:
                    txtFamily.Enabled = true;
                    btnSearch.Enabled = true;
                    btnAddFamily.Enabled = true;
                    btnUpdateFamily.Enabled = false;
                    btnDeleteFamily.Enabled = false;
                    dgvFamilies.Enabled = true;
                    cleanForm();
                    break;
                case StateF.SelectedRow:
                    txtFamily.Enabled = true;
                    btnSearch.Enabled = true;
                    btnAddFamily.Enabled = true;
                    btnUpdateFamily.Enabled = true;
                    btnDeleteFamily.Enabled = true;
                    dgvFamilies.Enabled = true;
                    break;

            }
        }

        public void cleanForm()
        {
            txtFamily.Text = "";
        }


        private void btnAddFamily_Click(object sender, EventArgs e)
        {
            AddFamilyForm addForm = new AddFamilyForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {


            }
            componentsState(StateF.Start);

        }

        private void btnUpdateFamily_Click(object sender, EventArgs e)
        {
            UpdateFamilyForm updateForm = new UpdateFamilyForm();
            if (updateForm.ShowDialog() == DialogResult.OK)
            {


            }
            componentsState(StateF.Start);
        }

        private void btnDeleteFamily_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha eliminado la familia seleccionada");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String familyCode = txtFamily.Text;
                //Selecciona la fila del dgv donde se encuentra la familia
            }
            catch
            {
                MessageBox.Show("La información no es correcta");
            }
        }

        private void doubleClickDgvFamilies(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            if (dgv.CurrentRow.Selected)
            {
                componentsState(StateF.SelectedRow);
                f = (Family)dgvFamilies.CurrentRow.DataBoundItem;
            }
        }
    }
}
