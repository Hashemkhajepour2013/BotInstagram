namespace BotInstagram
{
    partial class frmMain
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.btnEditPic = new System.Windows.Forms.Button();
            this.btnDeletePic = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.txtUserName);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Location = new System.Drawing.Point(12, 13);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLogin.Size = new System.Drawing.Size(261, 238);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "حساب کاربری :";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(19, 193);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 38);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(19, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(234, 28);
            this.txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(19, 68);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(234, 28);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username or Email :";
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.btnEditProfile);
            this.gbCommand.Enabled = false;
            this.gbCommand.Location = new System.Drawing.Point(279, 13);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(579, 238);
            this.gbCommand.TabIndex = 1;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = " دستورات :";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(438, 27);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(123, 38);
            this.btnEditProfile.TabIndex = 4;
            this.btnEditProfile.Text = "ویرایش پروفایل";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcImage);
            this.groupBox1.Location = new System.Drawing.Point(619, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تصویر پروفایل :";
            // 
            // pcImage
            // 
            this.pcImage.Location = new System.Drawing.Point(6, 27);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(227, 110);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImage.TabIndex = 0;
            this.pcImage.TabStop = false;
            // 
            // btnEditPic
            // 
            this.btnEditPic.Location = new System.Drawing.Point(777, 418);
            this.btnEditPic.Name = "btnEditPic";
            this.btnEditPic.Size = new System.Drawing.Size(75, 38);
            this.btnEditPic.TabIndex = 2;
            this.btnEditPic.Text = "ویرایش";
            this.btnEditPic.UseVisualStyleBackColor = true;
            this.btnEditPic.Click += new System.EventHandler(this.btnEditPic_Click);
            // 
            // btnDeletePic
            // 
            this.btnDeletePic.Location = new System.Drawing.Point(625, 418);
            this.btnDeletePic.Name = "btnDeletePic";
            this.btnDeletePic.Size = new System.Drawing.Size(146, 38);
            this.btnDeletePic.TabIndex = 6;
            this.btnDeletePic.Text = "حذف تصویر";
            this.btnDeletePic.UseVisualStyleBackColor = true;
            this.btnDeletePic.Click += new System.EventHandler(this.btnDeletePic_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 737);
            this.Controls.Add(this.btnDeletePic);
            this.Controls.Add(this.btnEditPic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.gbLogin);
            this.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ربات هوشمند";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbCommand.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcImage;
        private System.Windows.Forms.Button btnEditPic;
        private System.Windows.Forms.Button btnDeletePic;
    }
}

