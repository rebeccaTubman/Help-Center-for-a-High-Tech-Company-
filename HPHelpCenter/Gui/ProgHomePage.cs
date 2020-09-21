using HPHelpCenter.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPHelpCenter
{
    public partial class ProgHomePage : Form
    {
        public ProgHomePage()
        {
            InitializeComponent();
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            Text = "Programmer Home Page";
        }

        private void btIandS_Click(object sender, EventArgs e)
        {
            IssuesandSolutions nextPage = new IssuesandSolutions(this);
            nextPage.Show();
            this.Hide();
        }

        protected void InitializeUserData()
        {
            User user = ServiceFacade.getInstance().getUserDetails();
            this.tbUserName.Text = user.UserName;
            this.tbFirstName.Text = user.FirstName;
            this.tbLastName.Text = user.LastName;
            this.tbPassword.Text = user.Password;
            this.tbEmail.Text = user.Email;
            this.cbCountry.Text = user.Country.ToString();
            this.cbGender.Text = user.Gender.ToString();
            this.dtBirthday.Text = user.BirthdayDate.ToString();
            //this.pbUser
        }

        private void btTechnicalProblems_Click(object sender, EventArgs e)
        {
            TechnicalProblems nextPage = new TechnicalProblems();
            nextPage.Show();
            this.Hide();
        }

        private void btPersonalInfor_Click(object sender, EventArgs e)
        {
            tbEmail.Enabled = true;
            tbFirstName.Enabled = true;
            tbLastName.Enabled = true;
            tbPassword.Enabled = true;
            tbUserName.Enabled = true;
            cbCountry.Enabled = true;
            cbGender.Enabled = true;
            dtBirthday.Enabled = true;
            btSave.Visible = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User(
                    ServiceFacade.getInstance().getUserDetails().ID,
                    tbFirstName.Text,
                    tbLastName.Text,
                    tbUserName.Text,
                    ServiceFacade.getInstance().getUserDetails().Role,
                    DateTime.Parse(dtBirthday.Text),
                    (User.UserCountry)Enum.Parse(typeof(User.UserCountry), cbCountry.Text, true),
                    (User.UserGender)Enum.Parse(typeof(User.UserGender), cbGender.Text, true),
                    tbEmail.Text,
                    tbPassword.Text,
                    ServiceFacade.getInstance().getUserDetails().IsDeleted, 0);

                ServiceFacade.getInstance().SaveUser(u);
                tbEmail.Enabled = false;
                tbFirstName.Enabled = false;
                tbLastName.Enabled = false;
                tbPassword.Enabled = false;
                tbUserName.Enabled = false;
                cbCountry.Enabled = false;
                cbGender.Enabled = false;
                dtBirthday.Enabled = false;
                btSave.Visible = false;
            }
            catch (Exception ex)
            {
                DialogResult r1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }

        private void btChangeImage_Click(object sender, EventArgs e)
        {
            // Change picture
        }

        private void ProgHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ProgHomePage_Load(object sender, EventArgs e)
        {
            InitializeUserData();
        }

    }
}
