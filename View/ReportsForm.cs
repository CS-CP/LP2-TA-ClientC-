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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        View.MainWindow refParent;
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //checkBox1.Checked = false;
            //checkBox2.Checked = false;
            //checkBox3.Checked = false;
            //checkBox4.Checked = false;
            //checkBox5.Checked = false;
            //checkBox6.Checked = false;
            //checkBox7.Checked = false;
            /*checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;*/
            SupplierRepForm supForm = new SupplierRepForm();
            //supForm.MdiParent = this;
            supForm.Show();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha generado el reporte correctamente");
            /*checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox21.Checked = false;*/
            //EmployeeRepForm empForm = new EmployeeRepForm();
            //empForm.MdiParent = this;
            //empForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*checkBox19.Checked = false;
            checkBox25.Checked = false;
            checkBox24.Checked = false;
            checkBox20.Checked = false;
            checkBox27.Checked = false;
            checkBox26.Checked = false;
            checkBox23.Checked = false;
            checkBox22.Checked = false;*/

            CustomerRepFrom custForm = new CustomerRepFrom();
            //custForm.MdiParent = this;
            custForm.Show();
        }

        private void CheckBox25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha generado el reporte correctamente");
        }
    }
}
