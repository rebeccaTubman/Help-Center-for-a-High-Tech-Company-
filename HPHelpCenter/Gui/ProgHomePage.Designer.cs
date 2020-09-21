using System;
namespace HPHelpCenter
{
    partial class ProgHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgHomePage));
            this.btIandS = new System.Windows.Forms.Button();
            this.btTechnicalProblems = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btPersonalInfor = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.userGenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbCountry = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.userCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btChangeImage = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCountryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btIandS
            // 
            this.btIandS.BackColor = System.Drawing.Color.Lavender;
            this.btIandS.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btIandS.Location = new System.Drawing.Point(12, 13);
            this.btIandS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btIandS.Name = "btIandS";
            this.btIandS.Size = new System.Drawing.Size(243, 70);
            this.btIandS.TabIndex = 0;
            this.btIandS.Text = "Issues and Solutions";
            this.btIandS.UseVisualStyleBackColor = false;
            this.btIandS.Click += new System.EventHandler(this.btIandS_Click);
            // 
            // btTechnicalProblems
            // 
            this.btTechnicalProblems.BackColor = System.Drawing.Color.Lavender;
            this.btTechnicalProblems.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btTechnicalProblems.Location = new System.Drawing.Point(12, 91);
            this.btTechnicalProblems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTechnicalProblems.Name = "btTechnicalProblems";
            this.btTechnicalProblems.Size = new System.Drawing.Size(243, 70);
            this.btTechnicalProblems.TabIndex = 1;
            this.btTechnicalProblems.Text = "Technical Problems";
            this.btTechnicalProblems.UseVisualStyleBackColor = false;
            this.btTechnicalProblems.Click += new System.EventHandler(this.btTechnicalProblems_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(635, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btPersonalInfor
            // 
            this.btPersonalInfor.BackColor = System.Drawing.Color.Lavender;
            this.btPersonalInfor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btPersonalInfor.Location = new System.Drawing.Point(12, 169);
            this.btPersonalInfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btPersonalInfor.Name = "btPersonalInfor";
            this.btPersonalInfor.Size = new System.Drawing.Size(243, 70);
            this.btPersonalInfor.TabIndex = 3;
            this.btPersonalInfor.Text = "Update Personal Information\r\n";
            this.btPersonalInfor.UseVisualStyleBackColor = false;
            this.btPersonalInfor.Click += new System.EventHandler(this.btPersonalInfor_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbFirstName.Location = new System.Drawing.Point(484, 13);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(145, 22);
            this.tbFirstName.TabIndex = 4;
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbLastName.Location = new System.Drawing.Point(484, 43);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(145, 22);
            this.tbLastName.TabIndex = 5;
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbUserName.Location = new System.Drawing.Point(484, 73);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(145, 22);
            this.tbUserName.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPassword.Location = new System.Drawing.Point(484, 103);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(145, 22);
            this.tbPassword.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbEmail.Location = new System.Drawing.Point(484, 133);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(145, 22);
            this.tbEmail.TabIndex = 8;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(391, 19);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(72, 16);
            this.lbFirstName.TabIndex = 12;
            this.lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(391, 49);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(71, 16);
            this.lbLastName.TabIndex = 13;
            this.lbLastName.Text = "Last Name";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(391, 79);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(73, 16);
            this.lbUserName.TabIndex = 14;
            this.lbUserName.Text = "User Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(391, 109);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(65, 16);
            this.lbPassword.TabIndex = 15;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(391, 139);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 16);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "Email";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(391, 168);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(87, 16);
            this.lbBirthday.TabIndex = 17;
            this.lbBirthday.Text = "Birthday Date";
            // 
            // dtBirthday
            // 
            this.dtBirthday.Enabled = false;
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthday.Location = new System.Drawing.Point(484, 162);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(145, 22);
            this.dtBirthday.TabIndex = 18;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(391, 198);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(50, 16);
            this.lbGender.TabIndex = 19;
            this.lbGender.Text = "Gender";
            // 
            // cbGender
            // 
            this.cbGender.DataSource = this.userGenderBindingSource;
            this.cbGender.Enabled = false;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            HPHelpCenter.User.UserGender.Male,
            HPHelpCenter.User.UserGender.Female});
            this.cbGender.Location = new System.Drawing.Point(484, 190);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(145, 24);
            this.cbGender.TabIndex = 20;
            // 
            // userGenderBindingSource
            // 
            this.userGenderBindingSource.DataSource = new HPHelpCenter.User.UserGender[] {
        HPHelpCenter.User.UserGender.Male,
        HPHelpCenter.User.UserGender.Female};
            this.userGenderBindingSource.Position = 0;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(391, 228);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(53, 16);
            this.lbCountry.TabIndex = 21;
            this.lbCountry.Text = "Country";
            // 
            // cbCountry
            // 
            this.cbCountry.DataSource = this.userCountryBindingSource;
            this.cbCountry.Enabled = false;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            HPHelpCenter.User.UserCountry.Albania,
            HPHelpCenter.User.UserCountry.America,
            HPHelpCenter.User.UserCountry.Andorra,
            HPHelpCenter.User.UserCountry.Argentina,
            HPHelpCenter.User.UserCountry.Australia,
            HPHelpCenter.User.UserCountry.Austria,
            HPHelpCenter.User.UserCountry.Barbados,
            HPHelpCenter.User.UserCountry.Belarus,
            HPHelpCenter.User.UserCountry.Belgium,
            HPHelpCenter.User.UserCountry.Bolivia,
            HPHelpCenter.User.UserCountry.Brazil,
            HPHelpCenter.User.UserCountry.Bulgaria,
            HPHelpCenter.User.UserCountry.Canada,
            HPHelpCenter.User.UserCountry.Chile,
            HPHelpCenter.User.UserCountry.China,
            HPHelpCenter.User.UserCountry.Colombia,
            HPHelpCenter.User.UserCountry.Croatia,
            HPHelpCenter.User.UserCountry.Cuba,
            HPHelpCenter.User.UserCountry.Cyprus,
            HPHelpCenter.User.UserCountry.Denmark,
            HPHelpCenter.User.UserCountry.Ecuador,
            HPHelpCenter.User.UserCountry.Egypt,
            HPHelpCenter.User.UserCountry.Estonia,
            HPHelpCenter.User.UserCountry.Fiji,
            HPHelpCenter.User.UserCountry.Finland,
            HPHelpCenter.User.UserCountry.France,
            HPHelpCenter.User.UserCountry.Georgia,
            HPHelpCenter.User.UserCountry.Germany,
            HPHelpCenter.User.UserCountry.Ghana,
            HPHelpCenter.User.UserCountry.Greece,
            HPHelpCenter.User.UserCountry.Guatemala,
            HPHelpCenter.User.UserCountry.Hungary,
            HPHelpCenter.User.UserCountry.Iceland,
            HPHelpCenter.User.UserCountry.India,
            HPHelpCenter.User.UserCountry.Ireland,
            HPHelpCenter.User.UserCountry.Israel,
            HPHelpCenter.User.UserCountry.Italy,
            HPHelpCenter.User.UserCountry.Japan,
            HPHelpCenter.User.UserCountry.Latvia,
            HPHelpCenter.User.UserCountry.Liechtenstein,
            HPHelpCenter.User.UserCountry.Luxembourg,
            HPHelpCenter.User.UserCountry.Macedonia,
            HPHelpCenter.User.UserCountry.Mexico,
            HPHelpCenter.User.UserCountry.Moldova,
            HPHelpCenter.User.UserCountry.Monaco,
            HPHelpCenter.User.UserCountry.Montenegro,
            HPHelpCenter.User.UserCountry.Netherlands,
            HPHelpCenter.User.UserCountry.Norway,
            HPHelpCenter.User.UserCountry.Paraguay,
            HPHelpCenter.User.UserCountry.Peru,
            HPHelpCenter.User.UserCountry.Poland,
            HPHelpCenter.User.UserCountry.Portugal,
            HPHelpCenter.User.UserCountry.Romania,
            HPHelpCenter.User.UserCountry.Russia,
            HPHelpCenter.User.UserCountry.Serbia,
            HPHelpCenter.User.UserCountry.Singapore,
            HPHelpCenter.User.UserCountry.Slovakia,
            HPHelpCenter.User.UserCountry.Slovenia,
            HPHelpCenter.User.UserCountry.Spain,
            HPHelpCenter.User.UserCountry.Sweden,
            HPHelpCenter.User.UserCountry.Switzerland,
            HPHelpCenter.User.UserCountry.Ukraine,
            HPHelpCenter.User.UserCountry.UK});
            this.cbCountry.Location = new System.Drawing.Point(484, 220);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(145, 24);
            this.cbCountry.TabIndex = 22;
            // 
            // userCountryBindingSource
            // 
            this.userCountryBindingSource.DataSource = new HPHelpCenter.User.UserCountry[] {
        HPHelpCenter.User.UserCountry.Albania,
        HPHelpCenter.User.UserCountry.America,
        HPHelpCenter.User.UserCountry.Andorra,
        HPHelpCenter.User.UserCountry.Argentina,
        HPHelpCenter.User.UserCountry.Australia,
        HPHelpCenter.User.UserCountry.Austria,
        HPHelpCenter.User.UserCountry.Barbados,
        HPHelpCenter.User.UserCountry.Belarus,
        HPHelpCenter.User.UserCountry.Belgium,
        HPHelpCenter.User.UserCountry.Bolivia,
        HPHelpCenter.User.UserCountry.Brazil,
        HPHelpCenter.User.UserCountry.Bulgaria,
        HPHelpCenter.User.UserCountry.Canada,
        HPHelpCenter.User.UserCountry.Chile,
        HPHelpCenter.User.UserCountry.China,
        HPHelpCenter.User.UserCountry.Colombia,
        HPHelpCenter.User.UserCountry.Croatia,
        HPHelpCenter.User.UserCountry.Cuba,
        HPHelpCenter.User.UserCountry.Cyprus,
        HPHelpCenter.User.UserCountry.Denmark,
        HPHelpCenter.User.UserCountry.Ecuador,
        HPHelpCenter.User.UserCountry.Egypt,
        HPHelpCenter.User.UserCountry.Estonia,
        HPHelpCenter.User.UserCountry.Fiji,
        HPHelpCenter.User.UserCountry.Finland,
        HPHelpCenter.User.UserCountry.France,
        HPHelpCenter.User.UserCountry.Georgia,
        HPHelpCenter.User.UserCountry.Germany,
        HPHelpCenter.User.UserCountry.Ghana,
        HPHelpCenter.User.UserCountry.Greece,
        HPHelpCenter.User.UserCountry.Guatemala,
        HPHelpCenter.User.UserCountry.Hungary,
        HPHelpCenter.User.UserCountry.Iceland,
        HPHelpCenter.User.UserCountry.India,
        HPHelpCenter.User.UserCountry.Ireland,
        HPHelpCenter.User.UserCountry.Israel,
        HPHelpCenter.User.UserCountry.Italy,
        HPHelpCenter.User.UserCountry.Japan,
        HPHelpCenter.User.UserCountry.Latvia,
        HPHelpCenter.User.UserCountry.Liechtenstein,
        HPHelpCenter.User.UserCountry.Luxembourg,
        HPHelpCenter.User.UserCountry.Macedonia,
        HPHelpCenter.User.UserCountry.Mexico,
        HPHelpCenter.User.UserCountry.Moldova,
        HPHelpCenter.User.UserCountry.Monaco,
        HPHelpCenter.User.UserCountry.Montenegro,
        HPHelpCenter.User.UserCountry.Netherlands,
        HPHelpCenter.User.UserCountry.Norway,
        HPHelpCenter.User.UserCountry.Paraguay,
        HPHelpCenter.User.UserCountry.Peru,
        HPHelpCenter.User.UserCountry.Poland,
        HPHelpCenter.User.UserCountry.Portugal,
        HPHelpCenter.User.UserCountry.Romania,
        HPHelpCenter.User.UserCountry.Russia,
        HPHelpCenter.User.UserCountry.Serbia,
        HPHelpCenter.User.UserCountry.Singapore,
        HPHelpCenter.User.UserCountry.Slovakia,
        HPHelpCenter.User.UserCountry.Slovenia,
        HPHelpCenter.User.UserCountry.Spain,
        HPHelpCenter.User.UserCountry.Sweden,
        HPHelpCenter.User.UserCountry.Switzerland,
        HPHelpCenter.User.UserCountry.Ukraine,
        HPHelpCenter.User.UserCountry.UK};
            this.userCountryBindingSource.Position = 0;
            // 
            // btChangeImage
            // 
            this.btChangeImage.BackColor = System.Drawing.Color.Lavender;
            this.btChangeImage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btChangeImage.Location = new System.Drawing.Point(635, 248);
            this.btChangeImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btChangeImage.Name = "btChangeImage";
            this.btChangeImage.Size = new System.Drawing.Size(216, 34);
            this.btChangeImage.TabIndex = 23;
            this.btChangeImage.Text = "Change Image";
            this.btChangeImage.UseVisualStyleBackColor = false;
            this.btChangeImage.Click += new System.EventHandler(this.btChangeImage_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Lavender;
            this.btSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btSave.Location = new System.Drawing.Point(484, 251);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(111, 31);
            this.btSave.TabIndex = 47;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Visible = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProgHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(863, 296);
            this.Controls.Add(this.btSave);
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
            this.Controls.Add(this.btPersonalInfor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btTechnicalProblems);
            this.Controls.Add(this.btIandS);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(879, 334);
            this.MinimumSize = new System.Drawing.Size(879, 334);
            this.Name = "ProgHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgHomePage_FormClosing);
            this.Load += new System.EventHandler(this.ProgHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCountryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIandS;
        private System.Windows.Forms.Button btTechnicalProblems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btPersonalInfor;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button btChangeImage;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource userCountryBindingSource;
        private System.Windows.Forms.BindingSource userGenderBindingSource;
        
    }
}