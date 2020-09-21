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
    public partial class IssuesandSolutions : Form
    {
        private Form parent;

        public IssuesandSolutions()
        {
            InitializeComponent();
            InitializeUserData();
            Text = "Issues and Solutions";
        }

        public IssuesandSolutions(Form p)
        {
            InitializeComponent();
            InitializeUserData();
            parent = p;
            Text = "Issues and Solutions";
        }

        public void InitializeUserData()
        {
            User user = ServiceFacade.getInstance().getUserDetails();
            this.tbFirstName.Text = user.FirstName;
            this.tbLastName.Text = user.LastName;
            this.tbUserName.Text = user.UserName;
            List<Topic> topics = new List<Topic>();
            topics.Add(new Topic(-1, "All", false));
            topics.AddRange(ServiceFacade.getInstance().GetTopics());
            this.topicBindingSource.DataSource = topics;
            if (ServiceFacade.getInstance().isCrew())
            {
                List<Issue> issues = ServiceFacade.getInstance().GetIssues(false);
                dgIssues.DataSource = issues;
            }
            else
            {
                List<Issue> issues = ServiceFacade.getInstance().GetIssuesByUser(user.ID, false);
                dgIssues.DataSource = issues;
            }
        
        }

        private void IssuesandSolutions_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
            this.Hide();
            this.Dispose();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            String keyWord = tbKeyWord.Text;
            Topic topic = (Topic)cbSubject.SelectedValue;
            List<Issue> issues;
            if (topic.ID == -1)
            {
                issues = ServiceFacade.getInstance().SearchIssue(keyWord);
            }
            else
            {
                issues = ServiceFacade.getInstance().SearchIssue(keyWord, topic.ID);
            }
            dgIssues.DataSource = issues;
        }

        private void btAddNewIssue_Click(object sender, EventArgs e)
        {
            AddNewIssue nextPage = new AddNewIssue(this, 0);
            nextPage.Show();
            this.Hide();
        }

        private void dgIssues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var databaseRecordId = dgIssues.Rows[e.RowIndex].Cells[7].Value;
            AddNewSolution nextPage = new AddNewSolution(this, (Int32)databaseRecordId);
            nextPage.Show();
            nextPage.InitiGrid();
            this.Hide();
        }

        private void dgIssues_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var databaseRecordId = dgIssues.Rows[e.RowIndex].Cells[7].Value;
            AddNewSolution nextPage = new AddNewSolution(this, (Int32)databaseRecordId);
            nextPage.Show();
            nextPage.InitiGrid();
            this.Hide();
        }
        

    
    }
}
