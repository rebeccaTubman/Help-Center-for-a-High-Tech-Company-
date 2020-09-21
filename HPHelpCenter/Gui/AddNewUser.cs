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
    public partial class AddNewUser : Form
    {
        private Form parent;
        private int userID = -1;
        public AddNewUser()
        {
            InitializeComponent();
            Text = "Add New User";
            this.btAddImage.Visible = false;
        }
        public AddNewUser(Form p)
        {
            InitializeComponent();
            parent = p;
            btSave.Visible = true;
            btUpdate.Visible = false;
            btDelete.Visible = false;
            pictureBox1.Visible = false;
            Text = "Add New User";
            this.btAddImage.Visible = false;
        }
        public AddNewUser(Form p, int userId)
        {
            InitializeComponent();
            parent = p;
            this.userID = userId;
            InitializeUserData();
            btSave.Visible = false;
            btUpdate.Visible = true;
            btDelete.Visible = true;
            Text = "Update or Delete User";
            pictureBox1.Visible = true;
            this.btAddImage.Visible = false;
        }

        protected void InitializeUserData()
        {
            User user = ServiceFacade.getInstance().getUserByID(userID);
            this.tbUserName.Text = user.UserName;
            this.tbFirstName.Text = user.FirstName;
            this.tbLastName.Text = user.LastName;
            this.tbPassword.Text = user.Password;
            this.tbEmail.Text = user.Email;
            this.cbCountry.Text = user.Country.ToString();
            this.cbGender.Text = user.Gender.ToString();
            this.dtBirthday.Text = user.BirthdayDate.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            try
            {
                User user = new User(
                    tbUserName.Text.GetHashCode(),
                    tbFirstName.Text,
                    tbLastName.Text,
                    tbUserName.Text,
                    (User.UserRole)Enum.Parse(typeof(User.UserRole), cbRole.Text, true),
                    dtBirthday.Value,
                    (User.UserCountry)Enum.Parse(typeof(User.UserCountry), cbCountry.Text, true),
                    (User.UserGender)Enum.Parse(typeof(User.UserGender), cbGender.Text, true),
                    tbEmail.Text,
                    tbPassword.Text,
                    false, 0);

                ServiceFacade.getInstance().CheckSaveUser(user);
                this.Hide();
                ((Users)parent).InitializeUserData();
                parent.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                DialogResult r1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
            
            
            
        }

        private void AddNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            parent.Show();
            this.Dispose();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(
                    userID,
                    tbFirstName.Text,
                    tbLastName.Text,
                    tbUserName.Text,
                    (User.UserRole)Enum.Parse(typeof(User.UserRole), cbRole.Text, true),
                    dtBirthday.Value,
                    (User.UserCountry)Enum.Parse(typeof(User.UserCountry), cbCountry.Text, true),
                    (User.UserGender)Enum.Parse(typeof(User.UserGender), cbGender.Text, true),
                    tbEmail.Text,
                    tbPassword.Text,
                        false, 0
                    );
                ServiceFacade.getInstance().UpdateUser(user);
                this.Hide();
                ((Users)parent).InitializeUserData();
                parent.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                DialogResult r1 = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (userID == ServiceFacade.getInstance().getUserDetails().ID)
            {
                lbError.Text = "You can't delete yourself";
            }
            else
            {
                User user = new User(
                    userID,
                    tbFirstName.Text,
                    tbLastName.Text,
                      tbUserName.Text,
                    (User.UserRole)Enum.Parse(typeof(User.UserRole), cbRole.Text, true),
                     dtBirthday.Value,
                    (User.UserCountry)Enum.Parse(typeof(User.UserCountry), cbCountry.Text, true),
                    (User.UserGender)Enum.Parse(typeof(User.UserGender), cbGender.Text, true),
                    tbEmail.Text,
                    tbPassword.Text,
                   
                    true,
                    0
                  );
                ServiceFacade.getInstance().DeleteUser(user);
                this.Hide();
                ((Users)parent).InitializeUserData();
                parent.Show();
                this.Dispose();
            }
        }

        

    }
}
