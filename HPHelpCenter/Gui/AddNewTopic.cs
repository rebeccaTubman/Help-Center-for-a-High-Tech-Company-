using HPHelpCenter.Models;
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
    public partial class AddNewTopic : Form
    {
        private Form parent;
        private int topicID = -1;
        public AddNewTopic()
        {
            InitializeComponent();
            Text = "Add New Topic";
        }
        
        public AddNewTopic(Form p)
        {
            InitializeComponent();
            InitializeUserData();
            parent = p;
            btSave.Visible = true;
            btDelete.Visible = false;
            btUpdate.Visible = false;
            Text = "Add New Topic";
        }

        public AddNewTopic(Form p, int topicID)
        {
            InitializeComponent();
            InitializeUserData();
            parent = p;
            this.topicID = topicID;
            btSave.Visible = false;
            btDelete.Visible = true;
            btUpdate.Visible = true;
            Text = "Update or Delete Topic";
            tbTopicName.Text = ServiceFacade.getInstance().GetTopics(this.topicID).TopicName;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.TopicName = tbTopicName.Text;
            ServiceFacade.getInstance().AddTopic(topic);
            this.Hide();
            this.Dispose();
            ((Topics)parent).InitializeUserData();
            parent.Show();
        }
        
        protected void InitializeUserData()
        {
            User user = ServiceFacade.getInstance().getUserDetails();
            this.tbUserName.Text = user.UserName;
            //this.pbUser
        }

        private void AddNewTopic_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic(
                this.topicID,
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
        }
    }
}
