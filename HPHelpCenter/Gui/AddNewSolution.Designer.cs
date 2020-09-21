using System.Windows.Forms;
namespace HPHelpCenter.Gui
{
    partial class AddNewSolution
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Submitter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isuueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbSubmitNewSolution = new System.Windows.Forms.Label();
            this.tbSolution = new System.Windows.Forms.TextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbContent
            // 
            this.tbContent.Enabled = false;
            this.tbContent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbContent.Location = new System.Drawing.Point(12, 13);
            this.tbContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(584, 119);
            this.tbContent.TabIndex = 43;
            // 
            // dtDate
            // 
            this.dtDate.Enabled = false;
            this.dtDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(602, 42);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(150, 22);
            this.dtDate.TabIndex = 45;
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbUserName.Location = new System.Drawing.Point(602, 13);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(150, 22);
            this.tbUserName.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contentDataGridViewTextBoxColumn,
            this.Submitter,
            this.subDateDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.isuueIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.solutionBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(835, 285);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(835, 285);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(835, 285);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.contentDataGridViewTextBoxColumn.FillWeight = 50F;
            this.contentDataGridViewTextBoxColumn.HeaderText = "Solution";
            this.contentDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Submitter
            // 
            this.Submitter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Submitter.DataPropertyName = "UserName";
            this.Submitter.FillWeight = 20F;
            this.Submitter.HeaderText = "Submitter";
            this.Submitter.MinimumWidth = 20;
            this.Submitter.Name = "Submitter";
            this.Submitter.ReadOnly = true;
            this.Submitter.Width = 76;
            // 
            // subDateDataGridViewTextBoxColumn
            // 
            this.subDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subDateDataGridViewTextBoxColumn.DataPropertyName = "SubDate";
            this.subDateDataGridViewTextBoxColumn.FillWeight = 20F;
            this.subDateDataGridViewTextBoxColumn.HeaderText = "Submitting Date";
            this.subDateDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.subDateDataGridViewTextBoxColumn.Name = "subDateDataGridViewTextBoxColumn";
            this.subDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.subDateDataGridViewTextBoxColumn.Width = 107;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.FillWeight = 5F;
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.Width = 50;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.FillWeight = 5F;
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            this.userIDDataGridViewTextBoxColumn.Width = 5;
            // 
            // isuueIDDataGridViewTextBoxColumn
            // 
            this.isuueIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isuueIDDataGridViewTextBoxColumn.DataPropertyName = "IsuueID";
            this.isuueIDDataGridViewTextBoxColumn.FillWeight = 5F;
            this.isuueIDDataGridViewTextBoxColumn.HeaderText = "IsuueID";
            this.isuueIDDataGridViewTextBoxColumn.Name = "isuueIDDataGridViewTextBoxColumn";
            this.isuueIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.isuueIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 5F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 5;
            // 
            // solutionBindingSource
            // 
            this.solutionBindingSource.DataSource = typeof(HPHelpCenter.Models.Solution);
            // 
            // lbSubmitNewSolution
            // 
            this.lbSubmitNewSolution.AutoSize = true;
            this.lbSubmitNewSolution.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lbSubmitNewSolution.Location = new System.Drawing.Point(12, 427);
            this.lbSubmitNewSolution.Name = "lbSubmitNewSolution";
            this.lbSubmitNewSolution.Size = new System.Drawing.Size(129, 16);
            this.lbSubmitNewSolution.TabIndex = 47;
            this.lbSubmitNewSolution.Text = "Submit New Solution";
            // 
            // tbSolution
            // 
            this.tbSolution.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbSolution.Location = new System.Drawing.Point(12, 447);
            this.tbSolution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSolution.Multiline = true;
            this.tbSolution.Name = "tbSolution";
            this.tbSolution.Size = new System.Drawing.Size(740, 99);
            this.tbSolution.TabIndex = 48;
            // 
            // btSubmit
            // 
            this.btSubmit.BackColor = System.Drawing.Color.Lavender;
            this.btSubmit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btSubmit.Location = new System.Drawing.Point(12, 554);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(111, 31);
            this.btSubmit.TabIndex = 49;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = false;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // AddNewSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(859, 688);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbSolution);
            this.Controls.Add(this.lbSubmitNewSolution);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbContent);
            this.Name = "AddNewSolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewSolution_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbSubmitNewSolution;
        private System.Windows.Forms.TextBox tbSolution;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.BindingSource solutionBindingSource;
        private DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Submitter;
        private DataGridViewTextBoxColumn subDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isuueIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}