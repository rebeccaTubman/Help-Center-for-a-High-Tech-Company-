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
    public partial class AddNewSolution : Form
    {
        private Form parent;
        private Int32 issueId;
        public AddNewSolution()
        {
            InitializeComponent();
            Text = "Add New Solution";
        }
        public AddNewSolution(Form p, Int32 issueId)
        {

            InitializeComponent();
            this.issueId = issueId;
            parent = p;
            FillData(issueId);
            Text = "Add New Solution";
        }

        private void FillData(Int32 issueId)
        {
            if (ServiceFacade.getInstance().isProg())
            {
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[1].Width = 101;
                dataGridView1.Columns[2].Width = 132;
            }
            else
            {
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[1].Width = 76;
                dataGridView1.Columns[2].Width = 107;
            }
            Issue issue = ServiceFacade.getInstance().GetIssue(issueId);
            this.Text = issue.Title;
            tbContent.Text = issue.Content;
            int issueID = issue.ID;
            List<Solution> solutions = ServiceFacade.getInstance().GetSolutions(issueID);
            foreach (Solution solution in solutions)
            {
                User user1 = ServiceFacade.getInstance().getUserByID(solution.UserID);
                solution.UserName = user1.UserName;

            }
            this.solutionBindingSource.DataSource = solutions;
            
            dtDate.Value = issue.SubDate;
            User user = ServiceFacade.getInstance().getUserByID(issue.UserID);
            tbUserName.Text = user.UserName;
        }

        public void InitiGrid()
        {
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if ((Boolean)row.Cells[3].FormattedValue)
                {
                    row.DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Snow;
                }
            }
        }


        private void AddNewSolution_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            parent.Show();
            this.Dispose();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (!ServiceFacade.getInstance().IsLegalName(tbSolution.Text, 2))
            {
                DialogResult r1 = MessageBox.Show("The Solution has to be only in English", "Solution Choosed", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                Solution solution = new Solution();
                solution.Content = tbSolution.Text;
                solution.IsuueID = issueId;
                ServiceFacade.getInstance().AddSolution(solution);
                FillData(issueId);
                tbSolution.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                bool isChecked = (Boolean)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue;
                isChecked = !isChecked;
                DialogResult r1;
                if (isChecked)
                {
                    r1 = MessageBox.Show("Are you sure this is a good solution?", "Solution Choosed", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                }
                else
                {
                    r1 = MessageBox.Show("Are you sure you want to unmark this solution?", "Solution Choosed", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                }
                if (r1 == DialogResult.Yes)
                {
                    //  show dialog . ask "Are u sure... ?"
                    Solution solution = (Solution)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    solution.Status = isChecked;
                    ServiceFacade.getInstance().UpdateSolution(solution);
                    if (isChecked)
                    {
                         dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Snow;
                    }
                }

            }
        }
    }
}
