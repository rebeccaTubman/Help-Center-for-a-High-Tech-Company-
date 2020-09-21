namespace HPHelpCenter.Gui
{
    partial class AddNewItem
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
            this.btSave = new System.Windows.Forms.Button();
            this.lbMinAmount = new System.Windows.Forms.Label();
            this.dtReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lbReleaseDate = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbMinAmount = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Lavender;
            this.btSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btSave.Location = new System.Drawing.Point(93, 204);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(111, 31);
            this.btSave.TabIndex = 49;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Visible = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbMinAmount
            // 
            this.lbMinAmount.AutoSize = true;
            this.lbMinAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbMinAmount.Location = new System.Drawing.Point(12, 141);
            this.lbMinAmount.Name = "lbMinAmount";
            this.lbMinAmount.Size = new System.Drawing.Size(109, 16);
            this.lbMinAmount.TabIndex = 61;
            this.lbMinAmount.Text = "Minimum Amount";
            // 
            // dtReleaseDate
            // 
            this.dtReleaseDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReleaseDate.Location = new System.Drawing.Point(127, 164);
            this.dtReleaseDate.Name = "dtReleaseDate";
            this.dtReleaseDate.Size = new System.Drawing.Size(145, 22);
            this.dtReleaseDate.TabIndex = 60;
            // 
            // lbReleaseDate
            // 
            this.lbReleaseDate.AutoSize = true;
            this.lbReleaseDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbReleaseDate.Location = new System.Drawing.Point(12, 170);
            this.lbReleaseDate.Name = "lbReleaseDate";
            this.lbReleaseDate.Size = new System.Drawing.Size(86, 16);
            this.lbReleaseDate.TabIndex = 59;
            this.lbReleaseDate.Text = "Release Date";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbAmount.Location = new System.Drawing.Point(12, 111);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(53, 16);
            this.lbAmount.TabIndex = 58;
            this.lbAmount.Text = "Amount";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbType.Location = new System.Drawing.Point(12, 81);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(35, 16);
            this.lbType.TabIndex = 57;
            this.lbType.Text = "Type";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbCompany.Location = new System.Drawing.Point(12, 51);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(63, 16);
            this.lbCompany.TabIndex = 56;
            this.lbCompany.Text = "Company";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbName.Location = new System.Drawing.Point(12, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 16);
            this.lbName.TabIndex = 55;
            this.lbName.Text = "Item Name";
            // 
            // tbMinAmount
            // 
            this.tbMinAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinAmount.Location = new System.Drawing.Point(127, 135);
            this.tbMinAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMinAmount.Name = "tbMinAmount";
            this.tbMinAmount.Size = new System.Drawing.Size(145, 22);
            this.tbMinAmount.TabIndex = 54;
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(127, 105);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(145, 22);
            this.tbAmount.TabIndex = 53;
            // 
            // tbType
            // 
            this.tbType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbType.Location = new System.Drawing.Point(127, 75);
            this.tbType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(145, 22);
            this.tbType.TabIndex = 52;
            // 
            // tbCompany
            // 
            this.tbCompany.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompany.Location = new System.Drawing.Point(127, 45);
            this.tbCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(145, 22);
            this.tbCompany.TabIndex = 51;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(127, 15);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(145, 22);
            this.tbName.TabIndex = 50;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Lavender;
            this.btDelete.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btDelete.Location = new System.Drawing.Point(198, 204);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(88, 31);
            this.btDelete.TabIndex = 63;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.Lavender;
            this.btUpdate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btUpdate.Location = new System.Drawing.Point(10, 204);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(88, 31);
            this.btUpdate.TabIndex = 62;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(303, 253);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.lbMinAmount);
            this.Controls.Add(this.dtReleaseDate);
            this.Controls.Add(this.lbReleaseDate);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbMinAmount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btSave);
            this.MaximumSize = new System.Drawing.Size(319, 292);
            this.MinimumSize = new System.Drawing.Size(319, 292);
            this.Name = "AddNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbMinAmount;
        private System.Windows.Forms.DateTimePicker dtReleaseDate;
        private System.Windows.Forms.Label lbReleaseDate;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbMinAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
    }
}