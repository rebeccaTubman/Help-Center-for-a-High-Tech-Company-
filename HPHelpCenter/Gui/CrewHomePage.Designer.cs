using System;
namespace HPHelpCenter
{
    partial class CrewHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrewHomePage));
            this.btChangeImage = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btPersonalInfor = new System.Windows.Forms.Button();
            this.btIandS = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btUsers = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btTopics = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.userGenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGenderBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.userCountryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btChangeImage
            // 
            this.btChangeImage.BackColor = System.Drawing.Color.Lavender;
            this.btChangeImage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btChangeImage.Location = new System.Drawing.Point(635, 248);
            this.btChangeImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btChangeImage.Name = "btChangeImage";
            this.btChangeImage.Size = new System.Drawing.Size(216, 34);
            this.btChangeImage.TabIndex = 59;
            this.btChangeImage.Text = "Change Image";
            this.btChangeImage.UseVisualStyleBackColor = false;
            this.btChangeImage.Click += new System.EventHandler(this.btChangeImage_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.Enabled = false;
            this.cbCountry.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbCountry.FormattingEnabled = true;
          /*  this.cbCountry.Items.AddRange(new object[] {
            "Americas",
            "- Argentina",
            "- Bolivia ",
            "- Brazil ",
            "- Canada ",
            "- Caribbean",
            "- Chile ",
            "- Colombia ",
            "- Ecuador",
            "- Mexico ",
            "- Paraguay",
            "- Peru ",
            "- Puerto Rico ",
            "- United States ",
            "- Uruguay ",
            "- Venezuela",
            "Europe, Middle East and Africa",
            "- Albania ",
            "- Algeria ",
            "- Armenia ",
            "- Austria ",
            "- Azerbaijan ",
            "- Belarus ",
            "- Belgium ",
            "- Bosnia and Herzegovina ",
            "- Bulgaria ",
            "- Croatia ",
            "- Cyprus ",
            "- Czech Republic ",
            "- Denmark ",
            "- Estonia ",
            "- Finland ",
            "- France ",
            "- Georgia",
            "- Germany ",
            "- Greek ",
            "- Hungary ",
            "- Iceland ",
            "- Ireland ",
            "- Israel ",
            "- Italy ",
            "- Kazakhstan ",
            "- Kenya ",
            "- Kosovo ",
            "- Latvia ",
            "- Lithuania ",
            "- Luxembourg ",
            "- Macedonia ",
            "- Malta ",
            "- Moldova ",
            "- Montenegro ",
            "- Netherlands",
            "- Poland ",
            "- Portugal ",
            "- Romania ",
            "- Russia ",
            "- Serbia ",
            "- Slovak Republic ",
            "- Slovenia ",
            "- South Africa ",
            "- Spain ",
            "- Sweden ",
            "- Switzerland ",
            "- Tunisia ",
            "- Turkey ",
            "- Ukraine ",
            "- United Arab Emirates ",
            "- United Kingdom",
            "Asia and Oceania",
            "- Australia ",
            "- Bangladesh ",
            "- China ",
            "- Hong Kong ",
            "- India",
            "- Indonesia ",
            "- Japan ",
            "- Korea ",
            "- Malaysia ",
            "- New Zealand ",
            "- Pakistan",
            "- Philippines ",
            "- Singapore ",
            "- Sri Lanka ",
            "- Taiwan ",
            "- Thailand ",
            "- Vietnam"});*/
            this.cbCountry.DataSource = this.userCountryBindingSource;
            this.cbCountry.Location = new System.Drawing.Point(484, 220);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(145, 24);
            this.cbCountry.TabIndex = 58;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbCountry.Location = new System.Drawing.Point(391, 228);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(53, 16);
            this.lbCountry.TabIndex = 57;
            this.lbCountry.Text = "Country";
            // 
            // cbGender
            // 
            this.cbGender.DataSource = this.userGenderBindingSource;
            this.cbGender.Enabled = false;
            this.cbGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(484, 190);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(145, 24);
            this.cbGender.TabIndex = 56;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbGender.Location = new System.Drawing.Point(391, 198);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(50, 16);
            this.lbGender.TabIndex = 55;
            this.lbGender.Text = "Gender";
            // 
            // dtBirthday
            // 
            this.dtBirthday.Enabled = false;
            this.dtBirthday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthday.Location = new System.Drawing.Point(484, 162);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(145, 22);
            this.dtBirthday.TabIndex = 54;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbBirthday.Location = new System.Drawing.Point(391, 168);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(87, 16);
            this.lbBirthday.TabIndex = 53;
            this.lbBirthday.Text = "Birthday Date";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbEmail.Location = new System.Drawing.Point(391, 139);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 16);
            this.lbEmail.TabIndex = 52;
            this.lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbPassword.Location = new System.Drawing.Point(391, 109);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(65, 16);
            this.lbPassword.TabIndex = 51;
            this.lbPassword.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbUserName.Location = new System.Drawing.Point(391, 79);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(73, 16);
            this.lbUserName.TabIndex = 50;
            this.lbUserName.Text = "User Name";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbLastName.Location = new System.Drawing.Point(391, 49);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(71, 16);
            this.lbLastName.TabIndex = 49;
            this.lbLastName.Text = "Last Name";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbFirstName.Location = new System.Drawing.Point(390, 19);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(72, 16);
            this.lbFirstName.TabIndex = 48;
            this.lbFirstName.Text = "First Name";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbEmail.Location = new System.Drawing.Point(484, 133);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(145, 22);
            this.tbEmail.TabIndex = 47;
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPassword.Location = new System.Drawing.Point(484, 103);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(145, 22);
            this.tbPassword.TabIndex = 46;
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbUserName.Location = new System.Drawing.Point(484, 73);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(145, 22);
            this.tbUserName.TabIndex = 45;
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbLastName.Location = new System.Drawing.Point(484, 43);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(145, 22);
            this.tbLastName.TabIndex = 44;
            // 
            // tbFirstName
            // 
            this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbFirstName.Location = new System.Drawing.Point(484, 13);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(145, 22);
            this.tbFirstName.TabIndex = 43;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(HPHelpCenter.User);
            // 
            // pbUser
            // 
            this.pbUser.Enabled = false;
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(635, 13);
            this.pbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(216, 227);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 42;
            this.pbUser.TabStop = false;
            // 
            // btPersonalInfor
            // 
            this.btPersonalInfor.BackColor = System.Drawing.Color.Lavender;
            this.btPersonalInfor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btPersonalInfor.Location = new System.Drawing.Point(12, 90);
            this.btPersonalInfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btPersonalInfor.Name = "btPersonalInfor";
            this.btPersonalInfor.Size = new System.Drawing.Size(243, 70);
            this.btPersonalInfor.TabIndex = 62;
            this.btPersonalInfor.Text = "Update Personal Information\r\n";
            this.btPersonalInfor.UseVisualStyleBackColor = false;
            // 
            // btIandS
            // 
            this.btIandS.BackColor = System.Drawing.Color.Lavender;
            this.btIandS.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btIandS.Location = new System.Drawing.Point(12, 13);
            this.btIandS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btIandS.Name = "btIandS";
            this.btIandS.Size = new System.Drawing.Size(243, 70);
            this.btIandS.TabIndex = 60;
            this.btIandS.Text = "Issues and Solutions";
            this.btIandS.UseVisualStyleBackColor = false;
            this.btIandS.Click += new System.EventHandler(this.btIandS_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(12, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 70);
            this.button2.TabIndex = 62;
            this.button2.Text = "Update Personal Information\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btUsers
            // 
            this.btUsers.BackColor = System.Drawing.Color.Lavender;
            this.btUsers.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btUsers.Location = new System.Drawing.Point(12, 168);
            this.btUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(243, 70);
            this.btUsers.TabIndex = 63;
            this.btUsers.Text = "Users\r\n(Add, Update, Delete)";
            this.btUsers.UseVisualStyleBackColor = false;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Lavender;
            this.btSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btSave.Location = new System.Drawing.Point(484, 251);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(111, 31);
            this.btSave.TabIndex = 64;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Visible = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btTopics
            // 
            this.btTopics.BackColor = System.Drawing.Color.Lavender;
            this.btTopics.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btTopics.Location = new System.Drawing.Point(12, 246);
            this.btTopics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTopics.Name = "btTopics";
            this.btTopics.Size = new System.Drawing.Size(243, 70);
            this.btTopics.TabIndex = 65;
            this.btTopics.Text = "Topics";
            this.btTopics.UseVisualStyleBackColor = false;
            this.btTopics.Click += new System.EventHandler(this.btTopics_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
           // this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // userGenderBindingSource
            //this.userGenderBindingSource.DataSource = typeof(HPHelpCenter.User.UserGender);
            //this.userGenderBindingSource.DataSource = HPHelpCenter.User.UserGender.GetValues(typeof(HPHelpCenter.User.UserGender));
            // 
            this.userCountryBindingSource.DataSource = Enum.GetValues(typeof(User.UserCountry));
            this.userGenderBindingSource.DataSource = Enum.GetValues(typeof(User.UserGender));
            // 
            // CrewHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(863, 330);
            this.Controls.Add(this.btTopics);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btUsers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btPersonalInfor);
            this.Controls.Add(this.btIandS);
            this.Controls.Add(this.btChangeImage);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.pbUser);
            this.MaximumSize = new System.Drawing.Size(879, 368);
            this.MinimumSize = new System.Drawing.Size(879, 368);
            this.Name = "CrewHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrewHomePage_FormClosing);
            this.Load += new System.EventHandler(this.CrewHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGenderBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.userCountryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CrewHomePage_Load(object sender, System.EventArgs e)
        {
            InitializeUserData();
        }

        #endregion

        private System.Windows.Forms.Button btChangeImage;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Button btPersonalInfor;
        private System.Windows.Forms.Button btIandS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btUsers;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btTopics;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userCountryBindingSource;
        private System.Windows.Forms.BindingSource userGenderBindingSource;
    }
}