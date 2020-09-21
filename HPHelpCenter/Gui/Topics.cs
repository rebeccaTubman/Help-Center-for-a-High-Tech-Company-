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
    public partial class Topics : Form
    {
        private Form parent;
        public Topics()
        {
            InitializeComponent();
            InitializeUserData();
            Text = "Topic";
        }
        public Topics(Form p)
        {
            InitializeComponent();
            InitializeUserData();
            parent = p;
            Text = "Topic";
        }

        public void InitializeUserData()
        {
            User user = ServiceFacade.getInstance().getUserDetails();
            this.tbFirstName.Text = user.FirstName;
            this.tbLastName.Text = user.LastName;
            this.tbUserName.Text = user.UserName;
            List<Topic> topics = ServiceFacade.getInstance().GetTopics();
            dgTopics.DataSource = topics;
        }
        private void Topics_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
            this.Dispose();
        }

        private void btAddNewTopic_Click(object sender, EventArgs e)
        {
            AddNewTopic nextPage = new AddNewTopic(this);
            nextPage.Show();
            this.Hide();
            // כשחוזרם למסך הוא א מתעדכן עם המידע החדש
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            String keyWord = tbTopicName.Text;
            List<Topic> topics = ServiceFacade.getInstance().SearchTopics(keyWord);
            dgTopics.DataSource = topics;
        }

        private void dgTopics_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgTopics.SelectedCells.Count > 0)
            {
                var topicID = dgTopics.Rows[e.RowIndex].Cells[1].Value;
                AddNewTopic nextPage = new AddNewTopic(this, (Int32)topicID);
                nextPage.Show();
                this.Hide();
            }
        }
    }
}
