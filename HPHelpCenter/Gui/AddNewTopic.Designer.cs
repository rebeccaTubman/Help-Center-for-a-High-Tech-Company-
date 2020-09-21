namespace HPHelpCenter.Gui
{
    partial class AddNewTopic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTopic));
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTopicName = new System.Windows.Forms.Label();
            this.tbTopicName = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbUserName.Location = new System.Drawing.Point(103, 13);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(73, 16);
            this.lbUserName.TabIndex = 47;
            this.lbUserName.Text = "User Name";
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbUserName.Location = new System.Drawing.Point(103, 33);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(145, 22);
            this.tbUserName.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // lbTopicName
            // 
            this.lbTopicName.AutoSize = true;
            this.lbTopicName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbTopicName.Location = new System.Drawing.Point(103, 59);
            this.lbTopicName.Name = "lbTopicName";
            this.lbTopicName.Size = new System.Drawing.Size(76, 16);
            this.lbTopicName.TabIndex = 53;
            this.lbTopicName.Text = "Topic Name";
            // 
            // tbTopicName
            // 
            this.tbTopicName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbTopicName.Location = new System.Drawing.Point(103, 79);
            this.tbTopicName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTopicName.Name = "tbTopicName";
            this.tbTopicName.Size = new System.Drawing.Size(232, 22);
            this.tbTopicName.TabIndex = 52;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Lavender;
            this.btSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btSave.Location = new System.Drawing.Point(106, 117);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(88, 31);
            this.btSave.TabIndex = 54;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btUpdate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btUpdate.Location = new System.Drawing.Point(12, 117);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(88, 31);
            this.btUpdate.TabIndex = 55;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Lavender;
            this.btDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btDelete.Location = new System.Drawing.Point(200, 117);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(88, 31);
            this.btDelete.TabIndex = 56;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // AddNewTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(347, 161);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbTopicName);
            this.Controls.Add(this.tbTopicName);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(363, 199);
            this.MinimumSize = new System.Drawing.Size(363, 199);
            this.Name = "AddNewTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewTopic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewTopic_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTopicName;
        private System.Windows.Forms.TextBox tbTopicName;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
    }
}