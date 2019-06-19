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
    public enum State2
    {
        Start, Save, New
    }

    public partial class AddProductForm : Form
    {
        private DBControllerWSClient serviceDA;
        private BindingList<brand> brands;
        private BindingList<family> families;
        private BindingList<discount> discounts;
        public class Product { }
        private Product p;

        

        public AddProductForm()
        {
            InitializeComponent();
            p = new Product();
            //componentsState(State2.Start);
            
            cbActive.Checked = true;
        }
        public Product P { get => p; set => p = value; }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            serviceDA = new DBControllerWSClient();
            brands = new BindingList<brand>(serviceDA.queryAllBrand());
            for(int i=0 ; i<brands.Count; i++)
            {
                cboBrand.Items.Add("" + brands[i].name);
            }
            
            //cboBrand.DataSource = brands;
            families = new BindingList<family>(serviceDA.queryAllFamily());
            for (int i = 0; i < families.Count; i++)
            {
                cboFamily.Items.Add("" + families[i].name);
            }

            discounts = new BindingList<discount>(serviceDA.queryAllDiscount());
            for (int i = 0; i < discounts.Count; i++)
            {
                cboDiscount.Items.Add("" + discounts[i].description);
            }

            //cboFamily.DataSource = families;
        }

        public void componentsState(State2 s)
        {
            switch (s)
            {
                case State2.Start:
                    gbGeneralInformation.Enabled = false;
                    gbTransactionInformation.Enabled = false;
                    txtStock.Enabled = false;
                    cleanForm();
                    btnSave.Enabled = false;
                    break;
                case State2.Save:
                    gbGeneralInformation.Enabled = false;
                    gbTransactionInformation.Enabled = false;
                    txtStock.Enabled = false;
                    btnSave.Enabled = false;
                    cleanForm();
                    break;
                case State2.New:
                    gbGeneralInformation.Enabled = true;
                    gbTransactionInformation.Enabled = true;
                    txtStock.Enabled = false;
                    btnSave.Enabled = true;
                    cleanForm();
                    break;

            }
        }

        public void cleanForm()
        {

            txtCareDescription.Text = "";
            txtDescription.Text = "";
            txtIGV.Text = " ";
            txtName.Text = "";
            txtPurchasePrice.Text = "";
            txtSalePrice.Text = "";
            txtSKUCode.Text = "";

            cboBrand.SelectedIndex = -1;
            cboFamily.SelectedIndex = -1;
            cbActive.Checked = false;
            cbAvailability.Checked = false;
            cboDiscount.SelectedIndex = -1;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //componentsState(State2.Save);
            if (!filledValues())
            {

            }
            else
            {
                String name = txtName.Text;
                String codeSKU = txtSKUCode.Text;
                String description = txtDescription.Text;
                String caredescription = txtCareDescription.Text;

                //se crea el nuevo producto y se inserta en la tabla

                MessageBox.Show("Se guardo satisfactoriamente el producto.");
                this.Close();
            }
        }
        private bool filledValues()
        {
            if (txtSKUCode.Text == "")
            {
                MessageBox.Show("Ingrese el código SKU del producto");
                return false;
            }
            else if (txtName.Text =="")
            {
                MessageBox.Show("Ingrese el nombre del producto");
                return false;
            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Ingrese la descripción del producto");
                return false;
            }
            else if (txtCareDescription.Text == "")
            {
                MessageBox.Show("Ingrese la descripción del cuidado del producto");
                return false;
            }
            else if (txtSalePrice.Text == "")
            {
                MessageBox.Show("Ingrese el precio de venta");
                return false;
            }
            else if (txtPurchasePrice.Text == "")
            {
                MessageBox.Show("Ingrese el precio de compra");
                return false;
            }
            else if (txtIGV.Text == "")
            {
                MessageBox.Show("Ingrese el IGV");
                return false;
            }
            else if (txtStock.Text == "")
            {
                MessageBox.Show("Ingrese el stock");
                return false;
            }
            else if (cboBrand.Text == "--Seleccione--")
            {
                MessageBox.Show("Seleccione la marca");
                return false;
            }
            else if (cboFamily.Text == "--Seleccione--")
            {
                MessageBox.Show("Seleccione la familia");
                return false;
            }
            else if (cboDiscount.Text == "--Seleccione--")
            {
                MessageBox.Show("Seleccione el descuento");
                return false;
            }
            return true;
        }

        private void gbGeneralInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}
