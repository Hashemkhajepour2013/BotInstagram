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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgbFollowers = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFollowers = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgbFollowing = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFollowing = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUserFollow = new System.Windows.Forms.Button();
            this.btnUnFollow = new System.Windows.Forms.Button();
            this.txtUser_Name = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBlockedUser = new System.Windows.Forms.Button();
            this.lsbBlockUser = new System.Windows.Forms.ListBox();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnUnBlock = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbFollowers)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbFollowing)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.gbCommand.Location = new System.Drawing.Point(512, 13);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(583, 238);
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
            this.groupBox1.Location = new System.Drawing.Point(856, 269);
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
            this.btnEditPic.Location = new System.Drawing.Point(1014, 427);
            this.btnEditPic.Name = "btnEditPic";
            this.btnEditPic.Size = new System.Drawing.Size(75, 38);
            this.btnEditPic.TabIndex = 2;
            this.btnEditPic.Text = "ویرایش";
            this.btnEditPic.UseVisualStyleBackColor = true;
            this.btnEditPic.Click += new System.EventHandler(this.btnEditPic_Click);
            // 
            // btnDeletePic
            // 
            this.btnDeletePic.Location = new System.Drawing.Point(862, 427);
            this.btnDeletePic.Name = "btnDeletePic";
            this.btnDeletePic.Size = new System.Drawing.Size(146, 38);
            this.btnDeletePic.TabIndex = 6;
            this.btnDeletePic.Text = "حذف تصویر";
            this.btnDeletePic.UseVisualStyleBackColor = true;
            this.btnDeletePic.Click += new System.EventHandler(this.btnDeletePic_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgbFollowers);
            this.groupBox2.Controls.Add(this.btnFollowers);
            this.groupBox2.Location = new System.Drawing.Point(12, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 456);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "دنبال کننده ها :";
            // 
            // dgbFollowers
            // 
            this.dgbFollowers.AllowUserToAddRows = false;
            this.dgbFollowers.AllowUserToDeleteRows = false;
            this.dgbFollowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgbFollowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbFollowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.FullName});
            this.dgbFollowers.Location = new System.Drawing.Point(6, 33);
            this.dgbFollowers.Name = "dgbFollowers";
            this.dgbFollowers.ReadOnly = true;
            this.dgbFollowers.RowHeadersWidth = 51;
            this.dgbFollowers.RowTemplate.Height = 24;
            this.dgbFollowers.Size = new System.Drawing.Size(188, 373);
            this.dgbFollowers.TabIndex = 8;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "نام کاربری";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 94;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "نام";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 55;
            // 
            // btnFollowers
            // 
            this.btnFollowers.Location = new System.Drawing.Point(6, 412);
            this.btnFollowers.Name = "btnFollowers";
            this.btnFollowers.Size = new System.Drawing.Size(75, 38);
            this.btnFollowers.TabIndex = 9;
            this.btnFollowers.Text = "نمایش";
            this.btnFollowers.UseVisualStyleBackColor = true;
            this.btnFollowers.Click += new System.EventHandler(this.btnFollowers_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgbFollowing);
            this.groupBox3.Controls.Add(this.btnFollowing);
            this.groupBox3.Location = new System.Drawing.Point(238, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 456);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "دنبال شونده ها :";
            // 
            // dgbFollowing
            // 
            this.dgbFollowing.AllowUserToAddRows = false;
            this.dgbFollowing.AllowUserToDeleteRows = false;
            this.dgbFollowing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgbFollowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbFollowing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgbFollowing.Location = new System.Drawing.Point(6, 33);
            this.dgbFollowing.Name = "dgbFollowing";
            this.dgbFollowing.ReadOnly = true;
            this.dgbFollowing.RowHeadersWidth = 51;
            this.dgbFollowing.RowTemplate.Height = 24;
            this.dgbFollowing.Size = new System.Drawing.Size(188, 373);
            this.dgbFollowing.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "نام کاربری";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 94;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "نام";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // btnFollowing
            // 
            this.btnFollowing.Location = new System.Drawing.Point(6, 412);
            this.btnFollowing.Name = "btnFollowing";
            this.btnFollowing.Size = new System.Drawing.Size(75, 38);
            this.btnFollowing.TabIndex = 9;
            this.btnFollowing.Text = "نمایش";
            this.btnFollowing.UseVisualStyleBackColor = true;
            this.btnFollowing.Click += new System.EventHandler(this.btnFollowing_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBlock);
            this.groupBox4.Controls.Add(this.btnUnBlock);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnUserFollow);
            this.groupBox4.Controls.Add(this.btnUnFollow);
            this.groupBox4.Controls.Add(this.txtUser_Name);
            this.groupBox4.Location = new System.Drawing.Point(279, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 238);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "مدیریت کاربران پیچ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username :";
            // 
            // btnUserFollow
            // 
            this.btnUserFollow.Location = new System.Drawing.Point(115, 107);
            this.btnUserFollow.Name = "btnUserFollow";
            this.btnUserFollow.Size = new System.Drawing.Size(75, 38);
            this.btnUserFollow.TabIndex = 4;
            this.btnUserFollow.Text = "Follow";
            this.btnUserFollow.UseVisualStyleBackColor = true;
            this.btnUserFollow.Click += new System.EventHandler(this.btnUserFollow_Click);
            // 
            // btnUnFollow
            // 
            this.btnUnFollow.Location = new System.Drawing.Point(19, 107);
            this.btnUnFollow.Name = "btnUnFollow";
            this.btnUnFollow.Size = new System.Drawing.Size(75, 38);
            this.btnUnFollow.TabIndex = 3;
            this.btnUnFollow.Text = "UnFollow";
            this.btnUnFollow.UseVisualStyleBackColor = true;
            this.btnUnFollow.Click += new System.EventHandler(this.btnUnFollow_Click);
            // 
            // txtUser_Name
            // 
            this.txtUser_Name.Location = new System.Drawing.Point(6, 68);
            this.txtUser_Name.Name = "txtUser_Name";
            this.txtUser_Name.Size = new System.Drawing.Size(194, 28);
            this.txtUser_Name.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBlockedUser);
            this.groupBox5.Controls.Add(this.lsbBlockUser);
            this.groupBox5.Location = new System.Drawing.Point(461, 269);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(208, 456);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "نمایش کاربران بلاک شده :";
            // 
            // btnBlockedUser
            // 
            this.btnBlockedUser.Location = new System.Drawing.Point(6, 418);
            this.btnBlockedUser.Name = "btnBlockedUser";
            this.btnBlockedUser.Size = new System.Drawing.Size(75, 38);
            this.btnBlockedUser.TabIndex = 10;
            this.btnBlockedUser.Text = "نمایش";
            this.btnBlockedUser.UseVisualStyleBackColor = true;
            this.btnBlockedUser.Click += new System.EventHandler(this.btnBlockedUser_Click);
            // 
            // lsbBlockUser
            // 
            this.lsbBlockUser.FormattingEnabled = true;
            this.lsbBlockUser.ItemHeight = 21;
            this.lsbBlockUser.Location = new System.Drawing.Point(6, 27);
            this.lsbBlockUser.Name = "lsbBlockUser";
            this.lsbBlockUser.Size = new System.Drawing.Size(189, 382);
            this.lsbBlockUser.TabIndex = 0;
            this.lsbBlockUser.SelectedIndexChanged += new System.EventHandler(this.lsbBlockUser_SelectedIndexChanged);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(115, 162);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 38);
            this.btnBlock.TabIndex = 7;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnUnBlock
            // 
            this.btnUnBlock.Location = new System.Drawing.Point(19, 162);
            this.btnUnBlock.Name = "btnUnBlock";
            this.btnUnBlock.Size = new System.Drawing.Size(75, 38);
            this.btnUnBlock.TabIndex = 6;
            this.btnUnBlock.Text = "UnBlock";
            this.btnUnBlock.UseVisualStyleBackColor = true;
            this.btnUnBlock.Click += new System.EventHandler(this.btnUnBlock_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 737);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbFollowers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbFollowing)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFollowers;
        private System.Windows.Forms.DataGridView dgbFollowers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgbFollowing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnFollowing;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUserFollow;
        private System.Windows.Forms.Button btnUnFollow;
        private System.Windows.Forms.TextBox txtUser_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBlockedUser;
        private System.Windows.Forms.ListBox lsbBlockUser;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnUnBlock;
    }
}

