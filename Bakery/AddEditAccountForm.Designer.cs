namespace Bakery
{
    partial class AddEditAccountForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new Bakery.RoundButton();
            this.cancelBtn = new Bakery.RoundButton();
            this.empContainer = new System.Windows.Forms.Panel();
            this.empsPnl = new Bakery.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchSb = new Bakery.SearchBox();
            this.searchEmpCms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshBtn = new Bakery.RoundButton();
            this.accInfoPnl = new System.Windows.Forms.Panel();
            this.roundPanel2 = new Bakery.RoundPanel();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newPasswordPnl = new Bakery.RoundPanel();
            this.viewBtn = new Bakery.RoundButton();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.newPasswordLb = new System.Windows.Forms.Label();
            this.empNamePnl = new Bakery.RoundPanel();
            this.empNameLb = new Bakery.TransparentLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.empIdPnl = new Bakery.RoundPanel();
            this.empIdLb = new Bakery.TransparentLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.accEmpPermissionRbn = new System.Windows.Forms.RadioButton();
            this.accAdPermissionRbn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.changePasswordBtn = new Bakery.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.empContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.searchEmpCms.SuspendLayout();
            this.accInfoPnl.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.newPasswordPnl.SuspendLayout();
            this.empNamePnl.SuspendLayout();
            this.empIdPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 55);
            this.panel1.TabIndex = 47;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BorderColor = System.Drawing.Color.Silver;
            this.saveBtn.BorderWidth = 0F;
            this.saveBtn.CenterImage = null;
            this.saveBtn.ClientRoundScale = 1F;
            this.saveBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(492, 5);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(125, 45);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BorderColor = System.Drawing.Color.Silver;
            this.cancelBtn.BorderWidth = 0F;
            this.cancelBtn.CenterImage = null;
            this.cancelBtn.ClientRoundScale = 1F;
            this.cancelBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(625, 5);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(125, 45);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // empContainer
            // 
            this.empContainer.Controls.Add(this.empsPnl);
            this.empContainer.Controls.Add(this.panel3);
            this.empContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.empContainer.Location = new System.Drawing.Point(320, 0);
            this.empContainer.Name = "empContainer";
            this.empContainer.Size = new System.Drawing.Size(445, 461);
            this.empContainer.TabIndex = 48;
            // 
            // empsPnl
            // 
            this.empsPnl.AutoScroll = true;
            this.empsPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.empsPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empsPnl.Location = new System.Drawing.Point(0, 112);
            this.empsPnl.Margin = new System.Windows.Forms.Padding(4);
            this.empsPnl.Name = "empsPnl";
            this.empsPnl.Size = new System.Drawing.Size(445, 349);
            this.empsPnl.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.searchSb);
            this.panel3.Controls.Add(this.refreshBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 112);
            this.panel3.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 50);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(222, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 50);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên nhân viên";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã nhân viên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseMnemonic = false;
            // 
            // searchSb
            // 
            this.searchSb.ContextMenuStrip = this.searchEmpCms;
            this.searchSb.Location = new System.Drawing.Point(0, 6);
            this.searchSb.Margin = new System.Windows.Forms.Padding(2);
            this.searchSb.Name = "searchSb";
            this.searchSb.Size = new System.Drawing.Size(375, 50);
            this.searchSb.TabIndex = 10;
            this.searchSb.Search += new Bakery.SearchBox.SearchHandler(this.SearchSb_Search);
            // 
            // searchEmpCms
            // 
            this.searchEmpCms.BackColor = System.Drawing.Color.White;
            this.searchEmpCms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmpCms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.searchEmpCms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.searchEmpCms.Name = "sortCakeCms";
            this.searchEmpCms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.searchEmpCms.Size = new System.Drawing.Size(187, 65);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Checked = true;
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 28);
            this.toolStripMenuItem2.Text = "Mã nhân viên";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.SearchProToolStrip_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(186, 28);
            this.toolStripMenuItem3.Text = "Tên nhân viên";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.SearchProToolStrip_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.refreshBtn.BorderWidth = 2F;
            this.refreshBtn.CenterImage = global::Bakery.Properties.Resources.refresh;
            this.refreshBtn.ClientRoundScale = 1F;
            this.refreshBtn.Color = System.Drawing.Color.Transparent;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Location = new System.Drawing.Point(381, 6);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(50, 50);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // accInfoPnl
            // 
            this.accInfoPnl.Controls.Add(this.roundPanel2);
            this.accInfoPnl.Controls.Add(this.label1);
            this.accInfoPnl.Controls.Add(this.newPasswordPnl);
            this.accInfoPnl.Controls.Add(this.newPasswordLb);
            this.accInfoPnl.Controls.Add(this.empNamePnl);
            this.accInfoPnl.Controls.Add(this.label4);
            this.accInfoPnl.Controls.Add(this.empIdPnl);
            this.accInfoPnl.Controls.Add(this.label3);
            this.accInfoPnl.Controls.Add(this.accEmpPermissionRbn);
            this.accInfoPnl.Controls.Add(this.accAdPermissionRbn);
            this.accInfoPnl.Controls.Add(this.label2);
            this.accInfoPnl.Controls.Add(this.changePasswordBtn);
            this.accInfoPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accInfoPnl.Location = new System.Drawing.Point(0, 0);
            this.accInfoPnl.Name = "accInfoPnl";
            this.accInfoPnl.Size = new System.Drawing.Size(320, 461);
            this.accInfoPnl.TabIndex = 49;
            // 
            // roundPanel2
            // 
            this.roundPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roundPanel2.BorderWidth = 2F;
            this.roundPanel2.ClientRoundScale = 0.25F;
            this.roundPanel2.Color = System.Drawing.Color.White;
            this.roundPanel2.Controls.Add(this.usernameTxt);
            this.roundPanel2.Image = null;
            this.roundPanel2.ImageHeight = 0;
            this.roundPanel2.Location = new System.Drawing.Point(22, 281);
            this.roundPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(280, 40);
            this.roundPanel2.TabIndex = 48;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTxt.BackColor = System.Drawing.Color.White;
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxt.Location = new System.Drawing.Point(7, 9);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(270, 23);
            this.usernameTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Username";
            // 
            // newPasswordPnl
            // 
            this.newPasswordPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPasswordPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.newPasswordPnl.BorderWidth = 2F;
            this.newPasswordPnl.ClientRoundScale = 0.25F;
            this.newPasswordPnl.Color = System.Drawing.Color.White;
            this.newPasswordPnl.Controls.Add(this.viewBtn);
            this.newPasswordPnl.Controls.Add(this.passwordTxt);
            this.newPasswordPnl.Image = null;
            this.newPasswordPnl.ImageHeight = 0;
            this.newPasswordPnl.Location = new System.Drawing.Point(22, 364);
            this.newPasswordPnl.Margin = new System.Windows.Forms.Padding(4);
            this.newPasswordPnl.Name = "newPasswordPnl";
            this.newPasswordPnl.Size = new System.Drawing.Size(280, 40);
            this.newPasswordPnl.TabIndex = 58;
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewBtn.BorderColor = System.Drawing.Color.Silver;
            this.viewBtn.BorderWidth = 0F;
            this.viewBtn.CenterImage = global::Bakery.Properties.Resources.View;
            this.viewBtn.ClientRoundScale = 0.25F;
            this.viewBtn.Color = System.Drawing.Color.Transparent;
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewBtn.FlatAppearance.BorderSize = 0;
            this.viewBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.viewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.viewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Location = new System.Drawing.Point(240, 0);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(40, 40);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewBtn_MouseDown);
            this.viewBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewBtn_MouseUp);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTxt.BackColor = System.Drawing.Color.White;
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Location = new System.Drawing.Point(7, 9);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(227, 23);
            this.passwordTxt.TabIndex = 0;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // newPasswordLb
            // 
            this.newPasswordLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPasswordLb.AutoSize = true;
            this.newPasswordLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLb.Location = new System.Drawing.Point(18, 337);
            this.newPasswordLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPasswordLb.Name = "newPasswordLb";
            this.newPasswordLb.Size = new System.Drawing.Size(116, 23);
            this.newPasswordLb.TabIndex = 57;
            this.newPasswordLb.Text = "Mật khẩu mới";
            // 
            // empNamePnl
            // 
            this.empNamePnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empNamePnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.empNamePnl.BorderWidth = 2F;
            this.empNamePnl.ClientRoundScale = 0.25F;
            this.empNamePnl.Color = System.Drawing.Color.White;
            this.empNamePnl.Controls.Add(this.empNameLb);
            this.empNamePnl.Image = null;
            this.empNamePnl.ImageHeight = 0;
            this.empNamePnl.Location = new System.Drawing.Point(22, 129);
            this.empNamePnl.Margin = new System.Windows.Forms.Padding(4);
            this.empNamePnl.Name = "empNamePnl";
            this.empNamePnl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.empNamePnl.Size = new System.Drawing.Size(280, 40);
            this.empNamePnl.TabIndex = 56;
            // 
            // empNameLb
            // 
            this.empNameLb.BackColor = System.Drawing.Color.Transparent;
            this.empNameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empNameLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameLb.Location = new System.Drawing.Point(3, 0);
            this.empNameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empNameLb.Name = "empNameLb";
            this.empNameLb.Size = new System.Drawing.Size(274, 40);
            this.empNameLb.TabIndex = 0;
            this.empNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tên nhân viên";
            // 
            // empIdPnl
            // 
            this.empIdPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empIdPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.empIdPnl.BorderWidth = 2F;
            this.empIdPnl.ClientRoundScale = 0.25F;
            this.empIdPnl.Color = System.Drawing.Color.White;
            this.empIdPnl.Controls.Add(this.empIdLb);
            this.empIdPnl.Image = null;
            this.empIdPnl.ImageHeight = 0;
            this.empIdPnl.Location = new System.Drawing.Point(22, 46);
            this.empIdPnl.Margin = new System.Windows.Forms.Padding(4);
            this.empIdPnl.Name = "empIdPnl";
            this.empIdPnl.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.empIdPnl.Size = new System.Drawing.Size(280, 40);
            this.empIdPnl.TabIndex = 54;
            // 
            // empIdLb
            // 
            this.empIdLb.BackColor = System.Drawing.Color.Transparent;
            this.empIdLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empIdLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdLb.Location = new System.Drawing.Point(3, 0);
            this.empIdLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empIdLb.Name = "empIdLb";
            this.empIdLb.Size = new System.Drawing.Size(274, 40);
            this.empIdLb.TabIndex = 0;
            this.empIdLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mã nhân viên";
            // 
            // accEmpPermissionRbn
            // 
            this.accEmpPermissionRbn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accEmpPermissionRbn.AutoSize = true;
            this.accEmpPermissionRbn.Checked = true;
            this.accEmpPermissionRbn.Location = new System.Drawing.Point(109, 211);
            this.accEmpPermissionRbn.Name = "accEmpPermissionRbn";
            this.accEmpPermissionRbn.Size = new System.Drawing.Size(109, 27);
            this.accEmpPermissionRbn.TabIndex = 52;
            this.accEmpPermissionRbn.TabStop = true;
            this.accEmpPermissionRbn.Text = "Nhân viên";
            this.accEmpPermissionRbn.UseVisualStyleBackColor = true;
            // 
            // accAdPermissionRbn
            // 
            this.accAdPermissionRbn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accAdPermissionRbn.AutoSize = true;
            this.accAdPermissionRbn.Location = new System.Drawing.Point(22, 211);
            this.accAdPermissionRbn.Name = "accAdPermissionRbn";
            this.accAdPermissionRbn.Size = new System.Drawing.Size(81, 27);
            this.accAdPermissionRbn.TabIndex = 51;
            this.accAdPermissionRbn.Text = "Admin";
            this.accAdPermissionRbn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = "Quyền hạn";
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changePasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.changePasswordBtn.BorderColor = System.Drawing.Color.Silver;
            this.changePasswordBtn.BorderWidth = 0F;
            this.changePasswordBtn.CenterImage = null;
            this.changePasswordBtn.ClientRoundScale = 1F;
            this.changePasswordBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.changePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordBtn.FlatAppearance.BorderSize = 0;
            this.changePasswordBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.changePasswordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changePasswordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.ForeColor = System.Drawing.Color.White;
            this.changePasswordBtn.Location = new System.Drawing.Point(22, 337);
            this.changePasswordBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(280, 45);
            this.changePasswordBtn.TabIndex = 49;
            this.changePasswordBtn.Text = "Thay đổi mật khẩu";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Visible = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 461);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 1);
            this.panel2.TabIndex = 7;
            // 
            // AddEditAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 517);
            this.Controls.Add(this.accInfoPnl);
            this.Controls.Add(this.empContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditAccountForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddEditAccountForm_Load);
            this.panel1.ResumeLayout(false);
            this.empContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.searchEmpCms.ResumeLayout(false);
            this.accInfoPnl.ResumeLayout(false);
            this.accInfoPnl.PerformLayout();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.newPasswordPnl.ResumeLayout(false);
            this.newPasswordPnl.PerformLayout();
            this.empNamePnl.ResumeLayout(false);
            this.empIdPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private RoundButton saveBtn;
        private RoundButton cancelBtn;
        private System.Windows.Forms.Panel empContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private SearchBox searchSb;
        private RoundButton refreshBtn;
        private FlowLayoutPanel empsPnl;
        private System.Windows.Forms.Panel accInfoPnl;
        private RoundPanel newPasswordPnl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label newPasswordLb;
        private RoundPanel empNamePnl;
        private TransparentLabel empNameLb;
        private System.Windows.Forms.Label label4;
        private RoundPanel empIdPnl;
        private TransparentLabel empIdLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton accEmpPermissionRbn;
        private System.Windows.Forms.RadioButton accAdPermissionRbn;
        private System.Windows.Forms.Label label2;
        private RoundButton changePasswordBtn;
        private RoundPanel roundPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip searchEmpCms;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TextBox usernameTxt;
        private RoundButton viewBtn;
        private System.Windows.Forms.Panel panel2;
    }
}