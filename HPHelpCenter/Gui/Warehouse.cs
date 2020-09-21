using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HPHelpCenter.Models;

namespace HPHelpCenter.Gui
{
    public partial class Warehouse : Form
    {
        private Form parent;
        public Warehouse()
        {
            InitializeComponent();
        }

        public Warehouse(Form p)
        {
            InitializeComponent();
            parent = p;
        }

        protected void InitializeUserData()
        {
            User user = ServiceFacade.getInstance().getUserDetails();
            this.tbFirstName.Text = user.FirstName;
            this.tbLastName.Text = user.LastName;
            this.tbUserName.Text = user.UserName;
            //this.pbUser
            List<Item> items = new List<Item>();
            items.Add(new Item(0, "name", "company", "type", 0, 0, new DateTime()));
            items.Add(new Item(0, "name1", "company1", "type1", 0, 0, new DateTime()));
            this.lbItems.DataSource = items;
           
        }

        private void btAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewItem nextPage = new AddNewItem(this);
            nextPage.Show();
            this.Hide();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
        }

        private void Warehouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
