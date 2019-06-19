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
    public partial class SaleForm : Form
    {
        int type;

        public int Type { get => type; set => type = value; }

        public SaleForm()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        View.MainWindow refParent;
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductSale_Click(object sender, EventArgs e)
        {
            AddProductSale agregarProducto = new AddProductSale();
            agregarProducto.SetParent(this);
            agregarProducto.Show();
        }

        internal void AddProductToSale(DataGridViewRow row)
        {
            if (row != null) {
                dgvSaleDetails.Rows.Add(new String[]
                {
                    ""+row.Cells[0].Value.ToString(),""+row.Cells[1].Value.ToString(), ""+row.Cells[2].Value.ToString(), ""+1,""+(1*Double.Parse(row.Cells[2].Value.ToString()))
                });
                    }
        }

        internal void RefreshTotal()
        {
            double total = 0;
            for (int i = 0; i < dgvSaleDetails.RowCount - 1; i++)
            {
                total += Double.Parse(dgvSaleDetails.Rows[i].Cells[4].Value.ToString());
            }
            txtTotal.Text = "" + total;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha generado correctamente");
            this.Close();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //look for transaction
            SearchSaleTransaction searchTransaction = new SearchSaleTransaction();
            if (this.Type == 1)//compras
            {
                searchTransaction.IsRefund = false;
                searchTransaction.Text = "Buscar compra";
            }
            else
            {
                searchTransaction.IsRefund = true;
                searchTransaction.Text = "Buscar venta";
            }
            //searchTransaction.Parent = this;
            searchTransaction.Show();
        }

       
        private void DevolucionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SearchSaleTransaction searchTransaction = new SearchSaleTransaction();
            searchTransaction.Text = "Buscar venta";
            searchTransaction.IsRefund = true;
            searchTransaction.Show();
        }
    }
}
