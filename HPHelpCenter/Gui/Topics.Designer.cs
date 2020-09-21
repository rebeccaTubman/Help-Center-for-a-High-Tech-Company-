namespace HPHelpCenter.Gui
{
    partial class Topics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topics));
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbTopicName = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btAddNewTopic = new System.Windows.Forms.Button();
            this.dgTopics = new System.Windows.Forms.DataGridView();
            this.topicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topicNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTopics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).BeginInit();
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
            this.tbUserName.TabIndex = 36;
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbLastName.Location = new System.Drawing.Point(12, 182);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(145, 22);
            this.tbLastName.TabIndex = 35;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbFirstName.Location = new System.Drawing.Point(12, 152);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(145, 22);
            this.tbFirstName.TabIndex = 34;
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(12, 13);
            this.pbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(145, 131);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 33;
            this.pbUser.TabStop = false;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbUserName.Location = new System.Drawing.Point(12, 293);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(76, 16);
            this.lbUserName.TabIndex = 45;
            this.lbUserName.Text = "Topic Name";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Lavender;
            this.btSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btSearch.Location = new System.Drawing.Point(12, 341);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(145, 50);
            this.btSearch.TabIndex = 44;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbTopicName
            // 
            this.tbTopicName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTopicName.Location = new System.Drawing.Point(12, 312);
            this.tbTopicName.Name = "tbTopicName";
            this.tbTopicName.Size = new System.Drawing.Size(145, 22);
            this.tbTopicName.TabIndex = 43;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSearch.Location = new System.Drawing.Point(50, 263);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(58, 18);
            this.lbSearch.TabIndex = 42;
            this.lbSearch.Text = "Search";
            // 
            // btAddNewTopic
            // 
            this.btAddNewTopic.BackColor = System.Drawing.Color.Lavender;
            this.btAddNewTopic.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btAddNewTopic.Location = new System.Drawing.Point(12, 436);
            this.btAddNewTopic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddNewTopic.Name = "btAddNewTopic";
            this.btAddNewTopic.Size = new System.Drawing.Size(145, 50);
            this.btAddNewTopic.TabIndex = 41;
            this.btAddNewTopic.Text = "Add New Topic";
            this.btAddNewTopic.UseVisualStyleBackColor = false;
            this.btAddNewTopic.Click += new System.EventHandler(this.btAddNewTopic_Click);
            // 
            // dgTopics
            // 
            this.dgTopics.AllowUserToAddRows = false;
            this.dgTopics.AllowUserToDeleteRows = false;
            this.dgTopics.AutoGenerateColumns = false;
            this.dgTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTopics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topicNameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dgTopics.DataSource = this.topicBindingSource;
            this.dgTopics.Location = new System.Drawing.Point(180, 12);
            this.dgTopics.Name = "dgTopics";
            this.dgTopics.ReadOnly = true;
            this.dgTopics.Size = new System.Drawing.Size(304, 474);
            this.dgTopics.TabIndex = 46;
            this.dgTopics.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTopics_CellDoubleClick);
            // 
            // topicBindingSource
            // 
            this.topicBindingSource.DataSource = typeof(HPHelpCenter.Models.Topic);
            // 
            // topicNameDataGridViewTextBoxColumn
            // 
            this.topicNameDataGridViewTextBoxColumn.DataPropertyName = "TopicName";
            this.topicNameDataGridViewTextBoxColumn.HeaderText = "Topic";
            this.topicNameDataGridViewTextBoxColumn.Name = "topicNameDataGridViewTextBoxColumn";
            this.topicNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.topicNameDataGridViewTextBoxColumn.Width = 260;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Topics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(502, 500);
            this.Controls.Add(this.dgTopics);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbTopicName);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btAddNewTopic);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.pbUser);
            this.MaximumSize = new System.Drawing.Size(518, 538);
            this.MinimumSize = new System.Drawing.Size(518, 538);
            this.Name = "Topics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Topics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Topics_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTopics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbTopicName;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btAddNewTopic;
        private System.Windows.Forms.DataGridView dgTopics;
        private System.Windows.Forms.BindingSource topicBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}