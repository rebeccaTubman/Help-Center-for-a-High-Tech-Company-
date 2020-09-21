namespace HPHelpCenter
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.picHP = new System.Windows.Forms.PictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btLogIn = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHP)).BeginInit();
            this.SuspendLayout();
            // 
            // picHP
            // 
            this.picHP.Image = ((System.Drawing.Image)(resources.GetObject("picHP.Image")));
            this.picHP.Location = new System.Drawing.Point(12, 12);
            this.picHP.Name = "picHP";
            this.picHP.Size = new System.Drawing.Size(148, 146);
            this.picHP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHP.TabIndex = 0;
            this.picHP.TabStop = false;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbUserName.Location = new System.Drawing.Point(166, 19);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(86, 18);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "User Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbPassword.Location = new System.Drawing.Point(166, 50);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 18);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbUserName.Location = new System.Drawing.Point(258, 12);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(183, 25);
            this.tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPassword.Location = new System.Drawing.Point(258, 43);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(183, 25);
            this.tbPassword.TabIndex = 4;
            // 
            // btLogIn
            // 
            this.btLogIn.BackColor = System.Drawing.Color.Lavender;
            this.btLogIn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btLogIn.Location = new System.Drawing.Point(368, 121);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(73, 37);
            this.btLogIn.TabIndex = 5;
            this.btLogIn.Text = "Log In";
            this.btLogIn.UseVisualStyleBackColor = false;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbError.ForeColor = System.Drawing.Color.Maroon;
            this.lbError.Location = new System.Drawing.Point(224, 80);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(217, 17);
            this.lbError.TabIndex = 6;
            this.lbError.Text = "Wrong User Name or Password";
            this.lbError.Visible = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(453, 169);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.picHP);
            this.MaximumSize = new System.Drawing.Size(469, 208);
            this.MinimumSize = new System.Drawing.Size(469, 208);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.picHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHP;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Label lbError;
    }
}

