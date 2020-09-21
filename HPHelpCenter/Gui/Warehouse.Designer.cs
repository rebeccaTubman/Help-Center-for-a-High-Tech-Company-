namespace HPHelpCenter.Gui
{
    partial class Warehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse));
            this.lbItemCode = new System.Windows.Forms.Label();
            this.tbItemCode = new System.Windows.Forms.TextBox();
            this.lbItemName = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btAddNewItem = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lbItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbItemCode
            // 
            this.lbItemCode.AutoSize = true;
            this.lbItemCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbItemCode.Location = new System.Drawing.Point(12, 339);
            this.lbItemCode.Name = "lbItemCode";
            this.lbItemCode.Size = new System.Drawing.Size(67, 16);
            this.lbItemCode.TabIndex = 35;
            this.lbItemCode.Text = "Item Code";
            // 
            // tbItemCode
            // 
            this.tbItemCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemCode.Location = new System.Drawing.Point(12, 358);
            this.tbItemCode.Name = "tbItemCode";
            this.tbItemCode.Size = new System.Drawing.Size(145, 22);
            this.tbItemCode.TabIndex = 34;
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbItemName.Location = new System.Drawing.Point(12, 290);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(71, 16);
            this.lbItemName.TabIndex = 33;
            this.lbItemName.Text = "Item Name";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Lavender;
            this.btSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btSearch.Location = new System.Drawing.Point(12, 405);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(145, 50);
            this.btSearch.TabIndex = 32;
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
            this.tbItemName.TabIndex = 31;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbSearch.Location = new System.Drawing.Point(50, 260);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(58, 18);
            this.lbSearch.TabIndex = 30;
            this.lbSearch.Text = "Search";
            // 
            // btAddNewItem
            // 
            this.btAddNewItem.BackColor = System.Drawing.Color.Lavender;
            this.btAddNewItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btAddNewItem.Location = new System.Drawing.Point(12, 499);
            this.btAddNewItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAddNewItem.Name = "btAddNewItem";
            this.btAddNewItem.Size = new System.Drawing.Size(145, 50);
            this.btAddNewItem.TabIndex = 29;
            this.btAddNewItem.Text = "Add New Item";
            this.btAddNewItem.UseVisualStyleBackColor = false;
            this.btAddNewItem.Click += new System.EventHandler(this.btAddNewItem_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbUserName.Location = new System.Drawing.Point(12, 212);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(145, 22);
            this.tbUserName.TabIndex = 28;
            // 
            // tbLastName
            // 
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbLastName.Location = new System.Drawing.Point(12, 182);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(145, 22);
            this.tbLastName.TabIndex = 27;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbFirstName.Location = new System.Drawing.Point(12, 152);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(145, 22);
            this.tbFirstName.TabIndex = 26;
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(12, 13);
            this.pbUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(145, 131);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 25;
            this.pbUser.TabStop = false;
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
            this.shapeContainer1.Size = new System.Drawing.Size(584, 562);
            this.shapeContainer1.TabIndex = 36;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -2;
            this.lineShape3.X2 = 180;
            this.lineShape3.Y1 = 477;
            this.lineShape3.Y2 = 477;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 0;
            this.lineShape2.X2 = 181;
            this.lineShape2.Y1 = 249;
            this.lineShape2.Y2 = 250;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 181;
            this.lineShape1.X2 = 179;
            this.lineShape1.Y1 = -9;
            this.lineShape1.Y2 = 665;
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(179, 2);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(405, 550);
            this.lbItems.TabIndex = 37;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.lbItemCode);
            this.Controls.Add(this.tbItemCode);
            this.Controls.Add(this.lbItemName);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btAddNewItem);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Warehouse_FormClosing);
            this.Load += new System.EventHandler(this.Warehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbItemCode;
        private System.Windows.Forms.TextBox tbItemCode;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btAddNewItem;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.PictureBox pbUser;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ListBox lbItems;
    }
}