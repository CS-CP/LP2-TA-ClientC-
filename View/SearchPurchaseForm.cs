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

namespace View
{
    public partial class SearchPurchaseForm : Form
    {
        private DBControllerWSClient serviceDA;
        public SearchPurchaseForm()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtTransactionID.Text == "")
            {
                MessageBox.Show("Ingrese un ID");
            }
            else
            {
                //verificar fechas
                //serviceDA = new DBControllerWSClient();
                //serviceDA.queryByIDPurchase(txtTransactionID.Text);
            }
        }
    }
}
