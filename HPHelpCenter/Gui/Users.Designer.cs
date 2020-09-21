namespace HPHelpCenter.Gui
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btAddNewUser = new System.Windows.Forms.Button();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbUserName.Location = new System.Drawing.Point(12, 212);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(145, 22);
            this.tbUserName.TabIndex = 32;
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbLastName.Location = new System.Drawing.Point(12, 182);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(145, 22);
            this.tbLastName.TabIndex = 31;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbFirstName.Location = new System.Drawing.Point(12, 152);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(145, 22);
            this.tbFirstName.TabIndex = 30;
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(12, 13);
            this.pbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(145, 131);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 29;
            this.pbUser.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 175;
            this.lineShape1.X2 = 173;
            this.lineShape1.Y1 = -56;
            this.lineShape1.Y2 = 618;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(683, 491);
            this.shapeContainer1.TabIndex = 33;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -7;
            this.lineShape3.X2 = 174;
            this.lineShape3.Y1 = 477;
            this.lineShape3.Y2 = 478;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -7;
            this.lineShape2.X2 = 174;
            this.lineShape2.Y1 = 247;
            this.lineShape2.Y2 = 248;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbUserName.Location = new System.Drawing.Point(12, 290);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(132, 16);
            this.lbUserName.TabIndex = 40;
            this.lbUserName.Text = "First/Last/User Name";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Lavender;
            this.btSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btSearch.Location = new System.Drawing.Point(12, 338);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(145, 50);
            this.btSearch.TabIndex = 39;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemName.Location = new System.Drawing.Point(12, 309);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(145, 22);
            this.tbItemName.TabIndex = 38;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSearch.Location = new System.Drawing.Point(50, 260);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(58, 18);
            this.lbSearch.TabIndex = 37;
            this.lbSearch.Text = "Search";
            // 
            // btAddNewUser
            // 
            this.btAddNewUser.BackColor = System.Drawing.Color.Lavender;
            this.btAddNewUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btAddNewUser.Location = new System.Drawing.Point(12, 424);
            this.btAddNewUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddNewUser.Name = "btAddNewUser";
            this.btAddNewUser.Size = new System.Drawing.Size(145, 50);
            this.btAddNewUser.TabIndex = 36;
            this.btAddNewUser.Text = "Add New User";
            this.btAddNewUser.UseVisualStyleBackColor = false;
            this.btAddNewUser.Click += new System.EventHandler(this.btAddNewItem_Click);
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.AutoGenerateColumns = false;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.userNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Role});
            this.dgUsers.DataSource = this.userBindingSource1;
            this.dgUsers.Location = new System.Drawing.Point(184, 13);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.Size = new System.Drawing.Size(484, 461);
            this.dgUsers.TabIndex = 45;
            this.dgUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsers_CellDoubleClick);
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(HPHelpCenter.User);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(HPHelpCenter.User);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 110;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(683, 491);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btAddNewUser);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.shapeContainer1);
            this.MaximumSize = new System.Drawing.Size(699, 529);
            this.MinimumSize = new System.Drawing.Size(699, 529);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Users_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.PictureBox pbUser;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btAddNewUser;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}