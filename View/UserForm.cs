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

namespace User
{
    
    public partial class UserForm : Form
    {
        View.MainWindow refParent;
        private DBControllerWSClient serviceDA;
        private BindingList<user> users;
        
        public UserForm()
        {
            InitializeComponent();
            //updateDataGridView();
        }
        public void SetParent(View.MainWindow form)
        {
            refParent = form;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.SetParent(this);
            addUserForm.ShowDialog();
        }

        private void bntModifyUser_Click(object sender, EventArgs e)
        {
            ModifyUserForm modifyUserForm = new ModifyUserForm();
            modifyUserForm.SetParent(this);
            modifyUserForm.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //DeleteUserForm deleteUserForm = new DeleteUserForm();
            //deleteUserForm.SetParent(this);
            //deleteUserForm.ShowDialog();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            updateDataGridView();
            /*dgvUser.Rows.Add(new String[]
            {
                "1","Usuario1","15-07-2005"
            });
            dgvUser.Rows.Add(new String[]
            {
                "2","Usuario2","13-05-2011"
            });
            dgvUser.Rows.Add(new String[]
            {
                "3","Usuario3","05-12-2016"
            });*/
        }
        void updateDataGridView()
        {
            /* Cursor.Current = Cursors.WaitCursor;
             * dgvUser.Rows.Clear();
             * serviceDA = new DBControllerWSClient();
             * users = new BindingList<user> (serviceDA.queryAllUsers());
             * for (int i = 0; i < suppliers.Count; i++)
            {
                dgvUser.Rows.Add(new String[] {
                ""+users[i].id, "NOT NAME IMPLEMENTED" ,users[i].creationDate
                });
            }
             * Cursor.Current = Cursors.Arrow;
             */
            MessageBox.Show("QueryAll not Implemented");

        }
    }
}
