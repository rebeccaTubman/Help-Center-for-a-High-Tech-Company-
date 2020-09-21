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
    public partial class AddNewItem : Form
    {
        private Form parent;
        private int itemID = -1;
        public AddNewItem()
        {
            InitializeComponent();
            Text = "Add New Item";
        }

        public AddNewItem(Form p)
        {
            parent = p;
            Text = "Add New Item";
            btSave.Visible = true;
            btDelete.Visible = false;
            btUpdate.Visible = false;
        }

        public AddNewItem(Form p, int itemID)
        {
            InitializeComponent();
            parent = p;
            this.itemID = itemID;
            btSave.Visible = false;
            btDelete.Visible = true;
            btUpdate.Visible = true;
            Text = "Update or Delete Item";
            tbName.Text = ServiceFacade.getInstance().GetItem(this.itemID); //
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Amount = Int32.Parse(tbAmount.Text);
            item.Company = tbCompany.Text;
            item.ItemName = tbName.Text;
            item.MinAmount = Int32.Parse(tbMinAmount.Text);
            item.Type = tbType.Text;
            item.ReleaseDate = dtReleaseDate.Value;
            ServiceFacade.getInstance().AddItem(item);
            this.Hide();
            //((Warehouse)parent).InitializeUserData();
            parent.Show();
            this.Dispose();
        }

        private void AddNewItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            parent.Show();
            this.Dispose();
        }

        /*

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Item item = new item(
                this.itemID,
                tbTopicName.Text,
                false);
            ServiceFacade.getInstance().UpdateTopic(topic);
            this.Hide();
            ((Topics)parent).InitializeUserData();
            parent.Show();
            this.Dispose();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic(
                this.topicID,
                tbTopicName.Text,
                true);
            ServiceFacade.getInstance().DeleteTopic(topic);
            this.Hide();
            ((Topics)parent).InitializeUserData();
            parent.Show();
            this.Dispose();
        }*/
    }
}
