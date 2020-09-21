namespace HPHelpCenter.Gui
{
    partial class TechnicalProblems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicalProblems));
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAddNewProblem = new System.Windows.Forms.Button();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tecOrProgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
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
            this.tbUserName.TabIndex = 13;
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbLastName.Location = new System.Drawing.Point(12, 182);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(145, 22);
            this.tbLastName.TabIndex = 12;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbFirstName.Location = new System.Drawing.Point(12, 152);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(145, 22);
            this.tbFirstName.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btAddNewProblem
            // 
            this.btAddNewProblem.BackColor = System.Drawing.Color.Lavender;
            this.btAddNewProblem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btAddNewProblem.Location = new System.Drawing.Point(12, 283);
            this.btAddNewProblem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddNewProblem.Name = "btAddNewProblem";
            this.btAddNewProblem.Size = new System.Drawing.Size(145, 50);
            this.btAddNewProblem.TabIndex = 14;
            this.btAddNewProblem.Text = "Add New Problem";
            this.btAddNewProblem.UseVisualStyleBackColor = false;
            this.btAddNewProblem.Click += new System.EventHandler(this.btAddNewProblem_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 170;
            this.lineShape1.X2 = 171;
            this.lineShape1.Y1 = -25;
            this.lineShape1.Y2 = 364;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(584, 363);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -1;
            this.lineShape3.X2 = 170;
            this.lineShape3.Y1 = 253;
            this.lineShape3.Y2 = 253;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isDeletedDataGridViewCheckBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.subDateDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.tecOrProgDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.topicIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.issueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(191, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(381, 338);
            this.dataGridView1.TabIndex = 45;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            this.isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            this.isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDeletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 238;
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
            this.subDateDataGridViewTextBoxColumn.HeaderText = "SubDate";
            this.subDateDataGridViewTextBoxColumn.Name = "subDateDataGridViewTextBoxColumn";
            this.subDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataSource = typeof(HPHelpCenter.Models.Issue);
            // 
            // TechnicalProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(584, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btAddNewProblem);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.MaximumSize = new System.Drawing.Size(600, 401);
            this.MinimumSize = new System.Drawing.Size(600, 401);
            this.Name = "TechnicalProblems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technical Problems";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TechnicalProblems_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAddNewProblem;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecOrProgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource issueBindingSource;
    }
}