using System;
namespace HPHelpCenter.Gui
{
    partial class AddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            this.btAddImage = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.userCountryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userGenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbCountry = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.userGenderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            userRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(userRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCountryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCountryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGenderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // userRoleBindingSource
            // 
            userRoleBindingSource.DataSource = new HPHelpCenter.User.UserRole[] {
        HPHelpCenter.User.UserRole.Crew,
        HPHelpCenter.User.UserRole.Technician,
        HPHelpCenter.User.UserRole.Programmer};
            userRoleBindingSource.Position = 0;

            // 
            // btAddImage
            // 
            this.btAddImage.BackColor = System.Drawing.Color.Lavender;
            this.btAddImage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btAddImage.Location = new System.Drawing.Point(256, 248);
            this.btAddImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddImage.Name = "btAddImage";
            this.btAddImage.Size = new System.Drawing.Size(216, 34);
            this.btAddImage.TabIndex = 41;
            this.btAddImage.Text = "Add Image";
            this.btAddImage.UseVisualStyleBackColor = false;
            // 
            // cbCountry
            // 
            this.cbCountry.DataSource = this.userCountryBindingSource;
            this.cbCountry.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(105, 218);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(145, 24);
            this.cbCountry.TabIndex = 40;
            // 
            // userCountryBindingSource1
            // 
            this.userCountryBindingSource1.DataSource = new HPHelpCenter.User.UserCountry[] {
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
            this.userCountryBindingSource1.Position = 0;
            this.cbCountry.DataSource = this.userCountryBindingSource1;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbCountry.Location = new System.Drawing.Point(12, 228);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(53, 16);
            this.lbCountry.TabIndex = 39;
            this.lbCountry.Text = "Country";
            // 
            // cbGender
            // 
            this.cbGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.userBindingSource, "Gender", true));
            this.cbGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(105, 190);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(145, 24);
            this.cbGender.TabIndex = 38;
            // 
            // userGenderBindingSource1
            // 
            this.userGenderBindingSource1.DataSource = new HPHelpCenter.User.UserGender[] {
        HPHelpCenter.User.UserGender.Male,
        HPHelpCenter.User.UserGender.Female};
            this.userGenderBindingSource1.Position = 0;
            this.cbGender.DataSource = this.userGenderBindingSource1;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbGender.Location = new System.Drawing.Point(12, 198);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(50, 16);
            this.lbGender.TabIndex = 37;
            this.lbGender.Text = "Gender";
            // 
            // dtBirthday
            // 
            this.dtBirthday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthday.Location = new System.Drawing.Point(105, 162);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(145, 22);
            this.dtBirthday.TabIndex = 36;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbBirthday.Location = new System.Drawing.Point(12, 168);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(87, 16);
            this.lbBirthday.TabIndex = 35;
            this.lbBirthday.Text = "Birthday Date";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(-88, 123);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 34;
            this.lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbPassword.Location = new System.Drawing.Point(12, 109);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(65, 16);
            this.lbPassword.TabIndex = 33;
            this.lbPassword.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbUserName.Location = new System.Drawing.Point(12, 79);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(73, 16);
            this.lbUserName.TabIndex = 32;
            this.lbUserName.Text = "User Name";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbLastName.Location = new System.Drawing.Point(12, 49);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(71, 16);
            this.lbLastName.TabIndex = 31;
            this.lbLastName.Text = "Last Name";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbFirstName.Location = new System.Drawing.Point(12, 19);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(72, 16);
            this.lbFirstName.TabIndex = 30;
            this.lbFirstName.Text = "First Name";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(105, 133);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(145, 22);
            this.tbEmail.TabIndex = 29;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(105, 103);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(145, 22);
            this.tbPassword.TabIndex = 28;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(105, 73);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(145, 22);
            this.tbUserName.TabIndex = 27;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(105, 43);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(145, 22);
            this.tbLastName.TabIndex = 26;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(105, 13);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(145, 22);
            this.tbFirstName.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbRole.Location = new System.Drawing.Point(12, 254);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(34, 16);
            this.lbRole.TabIndex = 43;
            this.lbRole.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Email";
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(105, 247);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(145, 24);
            this.cbRole.TabIndex = 45;
            this.cbRole.DataSource = this.userRoleBindingSource;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Lavender;
            this.btSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btSave.Location = new System.Drawing.Point(188, 311);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(111, 38);
            this.btSave.TabIndex = 46;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btUpdate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btUpdate.Location = new System.Drawing.Point(71, 311);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(111, 38);
            this.btUpdate.TabIndex = 47;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Lavender;
            this.btDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btDelete.Location = new System.Drawing.Point(305, 311);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(111, 38);
            this.btDelete.TabIndex = 48;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(12, 280);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 16);
            this.lbError.TabIndex = 49;
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.btAddImage);
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
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "AddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewUser_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(userRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCountryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCountryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGenderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddImage;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.BindingSource userGenderBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userCountryBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.BindingSource userCountryBindingSource1;
        private System.Windows.Forms.BindingSource userGenderBindingSource1;

        private System.Windows.Forms.BindingSource userRoleBindingSource;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lbError;
    }
}