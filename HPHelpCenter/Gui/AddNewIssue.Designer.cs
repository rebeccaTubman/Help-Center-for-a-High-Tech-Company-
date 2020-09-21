namespace HPHelpCenter.Gui
{
    partial class AddNewIssue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewIssue));
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTopic = new System.Windows.Forms.Label();
            this.lbIssueName = new System.Windows.Forms.Label();
            this.tbIssueName = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.cbTopic1 = new System.Windows.Forms.ComboBox();
            this.topicBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbUserName.Location = new System.Drawing.Point(103, 19);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(73, 16);
            this.lbUserName.TabIndex = 35;
            this.lbUserName.Text = "User Name";
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbUserName.Location = new System.Drawing.Point(182, 13);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(145, 22);
            this.tbUserName.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbDate.Location = new System.Drawing.Point(103, 49);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(35, 16);
            this.lbDate.TabIndex = 37;
            this.lbDate.Text = "Date";
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbTopic.Location = new System.Drawing.Point(103, 78);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(38, 16);
            this.lbTopic.TabIndex = 39;
            this.lbTopic.Text = "Topic";
            // 
            // lbIssueName
            // 
            this.lbIssueName.AutoSize = true;
            this.lbIssueName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbIssueName.Location = new System.Drawing.Point(12, 125);
            this.lbIssueName.Name = "lbIssueName";
            this.lbIssueName.Size = new System.Drawing.Size(77, 16);
            this.lbIssueName.TabIndex = 41;
            this.lbIssueName.Text = "Issue Name";
            // 
            // tbIssueName
            // 
            this.tbIssueName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbIssueName.Location = new System.Drawing.Point(95, 119);
            this.tbIssueName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbIssueName.Name = "tbIssueName";
            this.tbIssueName.Size = new System.Drawing.Size(415, 22);
            this.tbIssueName.TabIndex = 40;
            // 
            // tbContent
            // 
            this.tbContent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbContent.Location = new System.Drawing.Point(15, 149);
            this.tbContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(495, 242);
            this.tbContent.TabIndex = 42;
            // 
            // dtDate
            // 
            this.dtDate.Enabled = false;
            this.dtDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(182, 42);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(145, 22);
            this.dtDate.TabIndex = 43;
            // 
            // cbTopic1
            // 
            this.cbTopic1.BackColor = System.Drawing.SystemColors.Window;
            this.cbTopic1.DataSource = this.topicBindingSource1;
            this.cbTopic1.DisplayMember = "TopicName";
            this.cbTopic1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTopic1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbTopic1.Location = new System.Drawing.Point(182, 70);
            this.cbTopic1.Name = "cbTopic1";
            this.cbTopic1.Size = new System.Drawing.Size(145, 24);
            this.cbTopic1.TabIndex = 44;
            // 
            // topicBindingSource1
            // 
            this.topicBindingSource1.DataSource = typeof(HPHelpCenter.Models.Topic);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Lavender;
            this.btSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btSave.Location = new System.Drawing.Point(182, 403);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(111, 31);
            this.btSave.TabIndex = 48;
            this.btSave.Text = "Submit";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(630, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 51;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(602, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 22);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(523, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(523, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "User Name";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(602, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 53;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(753, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(526, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(312, 272);
            this.dataGridView1.TabIndex = 59;
            // 
            // AddNewIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(850, 447);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.cbTopic1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lbIssueName);
            this.Controls.Add(this.tbIssueName);
            this.Controls.Add(this.lbTopic);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(866, 486);
            this.Name = "AddNewIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Issue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewIssue_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.Label lbIssueName;
        private System.Windows.Forms.TextBox tbIssueName;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.ComboBox cbTopic1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.BindingSource topicBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}