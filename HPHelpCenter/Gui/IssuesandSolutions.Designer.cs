namespace HPHelpCenter.Gui
{
    partial class IssuesandSolutions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuesandSolutions));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.btAddNewIssue = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbKeyWord = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.topicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgIssues = new System.Windows.Forms.DataGridView();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tecOrProgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIssues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.shapeContainer1.Size = new System.Drawing.Size(812, 533);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -1;
            this.lineShape3.X2 = 170;
            this.lineShape3.Y1 = 642;
            this.lineShape3.Y2 = 642;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -6;
            this.lineShape2.X2 = 170;
            this.lineShape2.Y1 = 243;
            this.lineShape2.Y2 = 243;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 169;
            this.lineShape1.X2 = 170;
            this.lineShape1.Y1 = -29;
            this.lineShape1.Y2 = 764;
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(12, 13);
            this.pbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(145, 131);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 3;
            this.pbUser.TabStop = false;
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbUserName.Location = new System.Drawing.Point(12, 212);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(145, 22);
            this.tbUserName.TabIndex = 9;
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbLastName.Location = new System.Drawing.Point(12, 182);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(145, 22);
            this.tbLastName.TabIndex = 8;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbFirstName.Location = new System.Drawing.Point(12, 152);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(145, 22);
            this.tbFirstName.TabIndex = 7;
            // 
            // btAddNewIssue
            // 
            this.btAddNewIssue.BackColor = System.Drawing.Color.Lavender;
            this.btAddNewIssue.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btAddNewIssue.Location = new System.Drawing.Point(12, 461);
            this.btAddNewIssue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddNewIssue.Name = "btAddNewIssue";
            this.btAddNewIssue.Size = new System.Drawing.Size(145, 50);
            this.btAddNewIssue.TabIndex = 10;
            this.btAddNewIssue.Text = "Add New Issue";
            this.btAddNewIssue.UseVisualStyleBackColor = false;
            this.btAddNewIssue.Click += new System.EventHandler(this.btAddNewIssue_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSearch.Location = new System.Drawing.Point(50, 257);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(58, 18);
            this.lbSearch.TabIndex = 11;
            this.lbSearch.Text = "Search";
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeyWord.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbKeyWord.Location = new System.Drawing.Point(12, 297);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(145, 22);
            this.tbKeyWord.TabIndex = 12;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Lavender;
            this.btSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btSearch.Location = new System.Drawing.Point(12, 372);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(145, 50);
            this.btSearch.TabIndex = 15;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbKeyWord
            // 
            this.lbKeyWord.AutoSize = true;
            this.lbKeyWord.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbKeyWord.Location = new System.Drawing.Point(12, 281);
            this.lbKeyWord.Name = "lbKeyWord";
            this.lbKeyWord.Size = new System.Drawing.Size(66, 16);
            this.lbKeyWord.TabIndex = 16;
            this.lbKeyWord.Text = "Key Word";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSubject.Location = new System.Drawing.Point(12, 322);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(38, 16);
            this.lbSubject.TabIndex = 20;
            this.lbSubject.Text = "Topic";
            // 
            // cbSubject
            // 
            this.cbSubject.DataSource = this.topicBindingSource;
            this.cbSubject.DisplayMember = "TopicName";
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(12, 341);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(145, 24);
            this.cbSubject.TabIndex = 60;
            // 
            // topicBindingSource
            // 
            this.topicBindingSource.DataSource = typeof(HPHelpCenter.Models.Topic);
            // 
            // dgIssues
            // 
            this.dgIssues.AllowUserToAddRows = false;
            this.dgIssues.AllowUserToDeleteRows = false;
            this.dgIssues.AutoGenerateColumns = false;
            this.dgIssues.BackgroundColor = System.Drawing.Color.Snow;
            this.dgIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.subDateDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.tecOrProgDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.topicIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn1});
            this.dgIssues.DataSource = this.issueBindingSource;
            this.dgIssues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgIssues.GridColor = System.Drawing.Color.Thistle;
            this.dgIssues.Location = new System.Drawing.Point(199, 13);
            this.dgIssues.Name = "dgIssues";
            this.dgIssues.ReadOnly = true;
            this.dgIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgIssues.Size = new System.Drawing.Size(593, 498);
            this.dgIssues.TabIndex = 62;
            this.dgIssues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIssues_CellContentClick);
            this.dgIssues.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIssues_CellDoubleClick);
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataSource = typeof(HPHelpCenter.Models.Issue);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Issue";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 400;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            this.contentDataGridViewTextBoxColumn.Visible = false;
            // 
            // subDateDataGridViewTextBoxColumn
            // 
            this.subDateDataGridViewTextBoxColumn.DataPropertyName = "SubDate";
            this.subDateDataGridViewTextBoxColumn.HeaderText = "Submitting Date";
            this.subDateDataGridViewTextBoxColumn.Name = "subDateDataGridViewTextBoxColumn";
            this.subDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.subDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.Visible = false;
            // 
            // tecOrProgDataGridViewTextBoxColumn
            // 
            this.tecOrProgDataGridViewTextBoxColumn.DataPropertyName = "TecOrProg";
            this.tecOrProgDataGridViewTextBoxColumn.HeaderText = "TecOrProg";
            this.tecOrProgDataGridViewTextBoxColumn.Name = "tecOrProgDataGridViewTextBoxColumn";
            this.tecOrProgDataGridViewTextBoxColumn.ReadOnly = true;
            this.tecOrProgDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // topicIDDataGridViewTextBoxColumn
            // 
            this.topicIDDataGridViewTextBoxColumn.DataPropertyName = "TopicID";
            this.topicIDDataGridViewTextBoxColumn.HeaderText = "TopicID";
            this.topicIDDataGridViewTextBoxColumn.Name = "topicIDDataGridViewTextBoxColumn";
            this.topicIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.topicIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // IssuesandSolutions
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(812, 533);
            this.Controls.Add(this.dgIssues);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbKeyWord);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbKeyWord);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btAddNewIssue);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.shapeContainer1);
            this.MaximumSize = new System.Drawing.Size(828, 571);
            this.MinimumSize = new System.Drawing.Size(828, 571);
            this.Name = "IssuesandSolutions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issues & Solutions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IssuesandSolutions_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIssues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Button btAddNewIssue;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lbKeyWord;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.DataGridView dgIssues;
        private System.Windows.Forms.BindingSource issueBindingSource;
        private System.Windows.Forms.BindingSource topicBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecOrProgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;

    }
}