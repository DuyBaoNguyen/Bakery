namespace Bakery
{
    partial class ConnectServerForm
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
            this.accessBtn = new Bakery.RoundButton();
            this.loadPtb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundPanel1 = new Bakery.RoundPanel();
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.roundPanel2 = new Bakery.RoundPanel();
            this.loginNameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.roundPanel3 = new Bakery.RoundPanel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadPtb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundPanel1.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.roundPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.accessBtn);
            this.panel1.Controls.Add(this.loadPtb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 54);
            this.panel1.TabIndex = 3;
            // 
            // accessBtn
            // 
            this.accessBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.accessBtn.BackColor = System.Drawing.Color.Transparent;
            this.accessBtn.BorderColor = System.Drawing.Color.Silver;
            this.accessBtn.BorderWidth = 0F;
            this.accessBtn.CenterImage = null;
            this.accessBtn.ClientRoundScale = 0.25F;
            this.accessBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.accessBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accessBtn.FlatAppearance.BorderSize = 0;
            this.accessBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.accessBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.accessBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.accessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accessBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessBtn.ForeColor = System.Drawing.Color.White;
            this.accessBtn.Location = new System.Drawing.Point(332, 5);
            this.accessBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accessBtn.Name = "accessBtn";
            this.accessBtn.Size = new System.Drawing.Size(107, 44);
            this.accessBtn.TabIndex = 4;
            this.accessBtn.Text = "Xác nhận";
            this.accessBtn.UseVisualStyleBackColor = false;
            this.accessBtn.Click += new System.EventHandler(this.AccessBtn_Click);
            // 
            // loadPtb
            // 
            this.loadPtb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loadPtb.Image = global::Bakery.Properties.Resources.Load;
            this.loadPtb.Location = new System.Drawing.Point(279, 5);
            this.loadPtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadPtb.Name = "loadPtb";
            this.loadPtb.Size = new System.Drawing.Size(48, 44);
            this.loadPtb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadPtb.TabIndex = 3;
            this.loadPtb.TabStop = false;
            this.loadPtb.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Bakery.Properties.Resources.Server;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // roundPanel1
            // 
            this.roundPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel1.BorderColor = System.Drawing.Color.Silver;
            this.roundPanel1.BorderWidth = 2F;
            this.roundPanel1.ClientRoundScale = 0.25F;
            this.roundPanel1.Color = System.Drawing.Color.White;
            this.roundPanel1.Controls.Add(this.serverTxt);
            this.roundPanel1.Controls.Add(this.pictureBox1);
            this.roundPanel1.Image = null;
            this.roundPanel1.Location = new System.Drawing.Point(12, 28);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(427, 44);
            this.roundPanel1.TabIndex = 20;
            // 
            // serverTxt
            // 
            this.serverTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.serverTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTxt.Location = new System.Drawing.Point(53, 9);
            this.serverTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(368, 27);
            this.serverTxt.TabIndex = 2;
            this.serverTxt.Text = global::Bakery.Properties.Settings.Default.ServerName;
            this.serverTxt.TextChanged += new System.EventHandler(this.ServerTxt_TextChanged);
            // 
            // roundPanel2
            // 
            this.roundPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel2.BorderColor = System.Drawing.Color.Silver;
            this.roundPanel2.BorderWidth = 2F;
            this.roundPanel2.ClientRoundScale = 0.25F;
            this.roundPanel2.Color = System.Drawing.Color.White;
            this.roundPanel2.Controls.Add(this.loginNameTxt);
            this.roundPanel2.Controls.Add(this.pictureBox4);
            this.roundPanel2.Image = null;
            this.roundPanel2.Location = new System.Drawing.Point(12, 119);
            this.roundPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(427, 44);
            this.roundPanel2.TabIndex = 21;
            // 
            // loginNameTxt
            // 
            this.loginNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginNameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNameTxt.Location = new System.Drawing.Point(53, 9);
            this.loginNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginNameTxt.Name = "loginNameTxt";
            this.loginNameTxt.Size = new System.Drawing.Size(368, 27);
            this.loginNameTxt.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = global::Bakery.Properties.Resources.User;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // roundPanel3
            // 
            this.roundPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel3.BorderColor = System.Drawing.Color.Silver;
            this.roundPanel3.BorderWidth = 2F;
            this.roundPanel3.ClientRoundScale = 0.25F;
            this.roundPanel3.Color = System.Drawing.Color.White;
            this.roundPanel3.Controls.Add(this.passwordTxt);
            this.roundPanel3.Controls.Add(this.viewBtn);
            this.roundPanel3.Controls.Add(this.pictureBox2);
            this.roundPanel3.Image = null;
            this.roundPanel3.Location = new System.Drawing.Point(12, 210);
            this.roundPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(427, 44);
            this.roundPanel3.TabIndex = 22;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(53, 9);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(320, 27);
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
            this.viewBtn.Location = new System.Drawing.Point(380, 0);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(47, 44);
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
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Login name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 277);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 1);
            this.panel2.TabIndex = 4;
            // 
            // ConnectServerForm
            // 
            this.AcceptButton = this.accessBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundPanel3);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectServerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConnectServerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadPtb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox loadPtb;
        private RoundPanel roundPanel1;
        private RoundPanel roundPanel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private RoundPanel roundPanel3;
        private System.Windows.Forms.PictureBox viewBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RoundButton accessBtn;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.TextBox loginNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}

