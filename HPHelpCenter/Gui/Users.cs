using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPHelpCenter.Gui
{
    public partial class Users : Form
    {
        private Form parent;
        public Users()
        {
            InitializeComponent();
            InitializeUserData();
            Text = "Users";
        }
        public Users(Form p)
        {
            InitializeComponent();
            InitializeUserData();
            parent = p;
            Text = "Users";
        }

        public void InitializeUserData()
        {
            User user = ServiceFacade.getInstance().getUserDetails();
            this.tbFirstName.Text = user.FirstName;
            this.tbLastName.Text = user.LastName;
            this.tbUserName.Text = user.UserName;
            List<User> users = ServiceFacade.getInstance().AllUsers();
            dgUsers.DataSource = users;
            //this.pbUser
        }

        private void Users_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void btAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewUser nextPage = new AddNewUser(this);
            nextPage.Show();
            this.Hide();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            String userName = tbItemName.Text;
            List<User> users = ServiceFacade.getInstance().FindUsers(userName);
            dgUsers.DataSource = users;
        }

        private void dgUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgUsers.SelectedCells.Count > 0)
            {
                var userID = dgUsers.Rows[e.RowIndex].Cells[0].Value;
                AddNewUser nextPage = new AddNewUser(this, (Int32)userID);
                nextPage.Show();
                this.Hide();
            }
        }
    }
}
