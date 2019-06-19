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
    public partial class SearchSaleTransaction : Form
    {
        SaleForm parent;
        bool isRefund = false;

        public bool IsRefund { get => isRefund; set => isRefund = value; }
        public SearchSaleTransaction()
        {
            InitializeComponent();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String idTrasaction = this.txtTransactionID.Text;
            if (idTrasaction == "")
            {
                DialogResult dialogo = MessageBox.Show("Ingresa un ID","Aviso", MessageBoxButtons.OK);
                
            }
            else
            {
                dgvTransactions.Rows.Add(new String[]{
                ""+idTrasaction,""+toDatePicker.Value.ToString(),""+fromDatePicker.Value.ToString(),""+123
                });
            }
            
            //this.Close();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                if (this.isRefund == true)
                { 
                    DialogResult dialogo = MessageBox.Show("¿Está seguro que desea devolver esta venta?", "Aviso", MessageBoxButtons.YesNo);
                    if (dialogo == DialogResult.Yes)
                    {
                        this.Close();
                        DialogResult dialogo2 = MessageBox.Show("Se guardaron los cambios con éxito", "Éxito", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    this.Close();
                }
                
                
            }
        }
    }
}
