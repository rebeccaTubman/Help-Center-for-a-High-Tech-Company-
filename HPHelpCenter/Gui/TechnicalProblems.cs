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
    public partial class TechnicalProblems : Form
    {
        private Form parent;
        public TechnicalProblems()
        {
            InitializeComponent();
            InitializeUserData();
            Text = "Technical Problems";
        }

        public TechnicalProblems(Form p)
        {
            InitializeComponent();
            InitializeUserData();
            parent = p;
            Text = "Technical Problems";
        }

        protected void InitializeUserData()
        {
            User user = ServiceFacade.getInstance().getUserDetails();
            this.tbFirstName.Text = user.FirstName;
            this.tbLastName.Text = user.LastName;
            this.tbUserName.Text = user.UserName;
            if (ServiceFacade.getInstance().isProg())
            {
                List<Issue> issues = ServiceFacade.getInstance().GetIssuesByUser(user.ID, true);
                dataGridView1.DataSource = issues;
                btAddNewProblem.Visible = true;
            }
            else
            {
                List<Issue> issues = ServiceFacade.getInstance().GetIssues(true); //GetIssuesByCountry to complete and switch
                dataGridView1.DataSource = issues;
                btAddNewProblem.Visible = false;
            }
        }

        private void btAddNewProblem_Click(object sender, EventArgs e)
        {
            AddNewIssue nextPage = new AddNewIssue(this, 1);
            nextPage.Show();
            this.Hide();
        }

        private void dgIssues_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Change AddNewSolutio to AddNewIssue with update and delete
            var databaseRecordId = dataGridView1.Rows[e.RowIndex].Cells[8].Value;
            AddNewSolution nextPage = new AddNewSolution(this, (Int32)databaseRecordId);
            nextPage.Show();
            nextPage.InitiGrid();
            this.Hide();
        }

        private void TechnicalProblems_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
            this.Hide();
            this.Dispose();
        }

    }
}
