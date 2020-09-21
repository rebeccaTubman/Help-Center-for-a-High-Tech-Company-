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
    public partial class AddNewIssue : Form
    {
        private Form parent;
        private int i;
        public AddNewIssue()
        {
            InitializeComponent();
        }
        public AddNewIssue(Form p, int i)
        {
            this.i = i;
            InitializeComponent(); 
            parent = p;
            if (i == 0)
            {
                Text = "Add New Issue";
                this.Width = 535;
                this.Height = 486;
                lbTopic.Visible = true;
                cbTopic1.Visible = true;
                btSave.Visible = true;
                tbIssueName.Visible = true;
                lbIssueName.Visible = true;
                InitializeUserData(true);
                tbContent.Enabled = true;
            }
            else
            {
                tbIssueName.Visible = false;
                lbIssueName.Visible = false;
                lbTopic.Visible = false;
                cbTopic1.Visible = false;
                if (ServiceFacade.getInstance().isProg())
                {
                    Text = "Add New Problem";
                    this.Width = 535;
                    this.Height = 486;
                    btSave.Visible = true;
                    InitializeUserData(true);
                    tbContent.Enabled = true;
                }
                else
                {
                    Text = "Problem By"; //add the user name of the person that submited the problem
                    this.Width = 866;
                    this.Height = 486;
                    btSave.Visible = false;
                    InitializeUserData(false);
                    tbContent.Enabled = false;
                }
            }
        }

        private void InitializeUserData(bool b)
        {
            if (b)
            {
                DateTime now = DateTime.Now;
                User user = ServiceFacade.getInstance().getUserDetails();
                this.tbUserName.Text = user.UserName;
                dtDate.Value = now;
                List<Topic> topics = ServiceFacade.getInstance().GetTopics();
                this.topicBindingSource1.DataSource = topics;
            }
            else
            {
                DateTime now = DateTime.Now;
                User user = ServiceFacade.getInstance().getUserDetails();
                this.textBox1.Text = user.UserName;
                dateTimePicker1.Value = now;
                //by the problem 
            }
        }
 
        private void btSave_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Issue issue = new Issue();
                issue.Title = tbIssueName.Text;
                issue.Content = tbContent.Text;
                issue.SubDate = dtDate.Value;
                issue.UserID = ServiceFacade.getInstance().getUserDetails().ID;
                Topic topic = (Topic)cbTopic1.SelectedValue;
                issue.TopicID = topic.ID;
                issue.TecOrProg = Issue.IssueType.Programing;
                issue.Status = false;
                ServiceFacade.getInstance().AddIssue(issue);
                ((IssuesandSolutions)parent).InitializeUserData();
                parent.Show();
                this.Hide();
                this.Dispose();
            }
            // else Save as a problem
            else
            {
                ((IssuesandSolutions)parent).InitializeUserData();
                parent.Show();
                this.Hide();
                this.Dispose();
            }
        }
        private void AddNewIssue_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            parent.Show();
            this.Dispose();
        }
    }
}
