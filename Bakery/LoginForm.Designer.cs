namespace Bakery
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginBtn = new Bakery.RoundButton();
            this.loadPtb = new System.Windows.Forms.PictureBox();
            this.serverPnl = new Bakery.RoundPanel();
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginNamePnl = new Bakery.RoundPanel();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.passwordPnl = new Bakery.RoundPanel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.functionCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.functionPnl = new Bakery.RoundPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadPtb)).BeginInit();
            this.serverPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginNamePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.passwordPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.functionPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.loadPtb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 44);
            this.panel1.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BorderColor = System.Drawing.Color.Silver;
            this.loginBtn.BorderWidth = 0F;
            this.loginBtn.CenterImage = null;
            this.loginBtn.ClientRoundScale = 1F;
            this.loginBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(229, 4);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 36);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // loadPtb
            // 
            this.loadPtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loadPtb.Image = global::Bakery.Properties.Resources.Load;
            this.loadPtb.Location = new System.Drawing.Point(9, 4);
            this.loadPtb.Margin = new System.Windows.Forms.Padding(2);
            this.loadPtb.Name = "loadPtb";
            this.loadPtb.Size = new System.Drawing.Size(216, 36);
            this.loadPtb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadPtb.TabIndex = 3;
            this.loadPtb.TabStop = false;
            this.loadPtb.Visible = false;
            // 
            // serverPnl
            // 
            this.serverPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.serverPnl.BorderWidth = 2F;
            this.serverPnl.ClientRoundScale = 0.25F;
            this.serverPnl.Color = System.Drawing.Color.White;
            this.serverPnl.Controls.Add(this.serverTxt);
            this.serverPnl.Controls.Add(this.pictureBox1);
            this.serverPnl.Image = null;
            this.serverPnl.ImageHeight = 0;
            this.serverPnl.Location = new System.Drawing.Point(9, 65);
            this.serverPnl.Margin = new System.Windows.Forms.Padding(2);
            this.serverPnl.Name = "serverPnl";
            this.serverPnl.Size = new System.Drawing.Size(320, 36);
            this.serverPnl.TabIndex = 20;
            // 
            // serverTxt
            // 
            this.serverTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.serverTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverTxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTxt.Location = new System.Drawing.Point(40, 8);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(277, 20);
            this.serverTxt.TabIndex = 2;
            this.serverTxt.Text = global::Bakery.Properties.Settings.Default.ServerName;
            this.serverTxt.TextChanged += new System.EventHandler(this.ServerTxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Bakery.Properties.Resources.Server;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginNamePnl
            // 
            this.loginNamePnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginNamePnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.loginNamePnl.BorderWidth = 2F;
            this.loginNamePnl.ClientRoundScale = 0.25F;
            this.loginNamePnl.Color = System.Drawing.Color.White;
            this.loginNamePnl.Controls.Add(this.usernameTxt);
            this.loginNamePnl.Controls.Add(this.pictureBox4);
            this.loginNamePnl.Image = null;
            this.loginNamePnl.ImageHeight = 0;
            this.loginNamePnl.Location = new System.Drawing.Point(9, 139);
            this.loginNamePnl.Margin = new System.Windows.Forms.Padding(2);
            this.loginNamePnl.Name = "loginNamePnl";
            this.loginNamePnl.Size = new System.Drawing.Size(320, 36);
            this.loginNamePnl.TabIndex = 21;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(40, 8);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(276, 20);
            this.usernameTxt.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = global::Bakery.Properties.Resources.user_small;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // passwordPnl
            // 
            this.passwordPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.passwordPnl.BorderWidth = 2F;
            this.passwordPnl.ClientRoundScale = 0.25F;
            this.passwordPnl.Color = System.Drawing.Color.White;
            this.passwordPnl.Controls.Add(this.passwordTxt);
            this.passwordPnl.Controls.Add(this.viewBtn);
            this.passwordPnl.Controls.Add(this.pictureBox2);
            this.passwordPnl.Image = null;
            this.passwordPnl.ImageHeight = 0;
            this.passwordPnl.Location = new System.Drawing.Point(9, 213);
            this.passwordPnl.Margin = new System.Windows.Forms.Padding(2);
            this.passwordPnl.Name = "passwordPnl";
            this.passwordPnl.Size = new System.Drawing.Size(320, 36);
            this.passwordPnl.TabIndex = 22;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(40, 8);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(240, 20);
            this.passwordTxt.TabIndex = 24;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewBtn.Image = global::Bakery.Properties.Resources.View;
            this.viewBtn.Location = new System.Drawing.Point(285, 0);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(35, 36);
            this.viewBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.viewBtn.TabIndex = 23;
            this.viewBtn.TabStop = false;
            this.viewBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewBtn_MouseDown);
            this.viewBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewBtn_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::Bakery.Properties.Resources.Lock;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Login name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 338);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 1);
            this.panel2.TabIndex = 4;
            // 
            // functionCmb
            // 
            this.functionCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.functionCmb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionCmb.FormattingEnabled = true;
            this.functionCmb.Items.AddRange(new object[] {
            "Bán hàng",
            "Quản lý"});
            this.functionCmb.Location = new System.Drawing.Point(5, 5);
            this.functionCmb.Name = "functionCmb";
            this.functionCmb.Size = new System.Drawing.Size(311, 27);
            this.functionCmb.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Chức năng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 37);
            this.label5.TabIndex = 29;
            this.label5.Text = "Đăng nhập";
            // 
            // functionPnl
            // 
            this.functionPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.functionPnl.BorderWidth = 2F;
            this.functionPnl.ClientRoundScale = 0.25F;
            this.functionPnl.Color = System.Drawing.Color.White;
            this.functionPnl.Controls.Add(this.functionCmb);
            this.functionPnl.Image = null;
            this.functionPnl.ImageHeight = 0;
            this.functionPnl.Location = new System.Drawing.Point(9, 284);
            this.functionPnl.Margin = new System.Windows.Forms.Padding(2);
            this.functionPnl.Name = "functionPnl";
            this.functionPnl.Size = new System.Drawing.Size(320, 36);
            this.functionPnl.TabIndex = 30;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 383);
            this.Controls.Add(this.functionPnl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordPnl);
            this.Controls.Add(this.loginNamePnl);
            this.Controls.Add(this.serverPnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConnectServerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadPtb)).EndInit();
            this.serverPnl.ResumeLayout(false);
            this.serverPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginNamePnl.ResumeLayout(false);
            this.loginNamePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.passwordPnl.ResumeLayout(false);
            this.passwordPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.functionPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox loadPtb;
        private RoundPanel serverPnl;
        private RoundPanel loginNamePnl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private RoundPanel passwordPnl;
        private System.Windows.Forms.PictureBox viewBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RoundButton loginBtn;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox functionCmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RoundPanel functionPnl;
    }
}

