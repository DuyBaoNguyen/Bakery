namespace Bakery
{
    partial class ManagerPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.roundPanel8 = new Bakery.RoundPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.roundPanel7 = new Bakery.RoundPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundPanel3 = new Bakery.RoundPanel();
            this.empLb = new System.Windows.Forms.Label();
            this.roundPanel2 = new Bakery.RoundPanel();
            this.costLb = new System.Windows.Forms.Label();
            this.roundPanel1 = new Bakery.RoundPanel();
            this.cakeLb = new System.Windows.Forms.Label();
            this.roundPanel4 = new Bakery.RoundPanel();
            this.salLb = new System.Windows.Forms.Label();
            this.roundPanel5 = new Bakery.RoundPanel();
            this.accLb = new System.Windows.Forms.Label();
            this.roundPanel6 = new Bakery.RoundPanel();
            this.billLb = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.roundPanel8.SuspendLayout();
            this.roundPanel7.SuspendLayout();
            this.roundPanel3.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.roundPanel4.SuspendLayout();
            this.roundPanel5.SuspendLayout();
            this.roundPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.AutoSize = true;
            this.menuPanel.ColumnCount = 4;
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuPanel.Controls.Add(this.roundPanel8, 0, 1);
            this.menuPanel.Controls.Add(this.roundPanel7, 0, 1);
            this.menuPanel.Controls.Add(this.roundPanel3, 2, 0);
            this.menuPanel.Controls.Add(this.roundPanel2, 1, 0);
            this.menuPanel.Controls.Add(this.roundPanel1, 0, 0);
            this.menuPanel.Controls.Add(this.roundPanel4, 3, 0);
            this.menuPanel.Controls.Add(this.roundPanel5, 0, 1);
            this.menuPanel.Controls.Add(this.roundPanel6, 1, 1);
            this.menuPanel.Location = new System.Drawing.Point(20, 60);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RowCount = 2;
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuPanel.Size = new System.Drawing.Size(1160, 580);
            this.menuPanel.TabIndex = 2;
            // 
            // roundPanel8
            // 
            this.roundPanel8.BorderColor = System.Drawing.Color.Black;
            this.roundPanel8.BorderWidth = 0F;
            this.roundPanel8.ClientRoundScale = 0.1F;
            this.roundPanel8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.roundPanel8.Controls.Add(this.label2);
            this.roundPanel8.Image = global::Bakery.Properties.Resources.statistic;
            this.roundPanel8.Location = new System.Drawing.Point(600, 310);
            this.roundPanel8.Margin = new System.Windows.Forms.Padding(20);
            this.roundPanel8.Name = "roundPanel8";
            this.roundPanel8.Size = new System.Drawing.Size(250, 250);
            this.roundPanel8.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label2.Size = new System.Drawing.Size(250, 250);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thống kê";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.label2.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // roundPanel7
            // 
            this.roundPanel7.BorderColor = System.Drawing.Color.Black;
            this.roundPanel7.BorderWidth = 0F;
            this.roundPanel7.ClientRoundScale = 0.1F;
            this.roundPanel7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.roundPanel7.Controls.Add(this.label1);
            this.roundPanel7.Image = global::Bakery.Properties.Resources.bill;
            this.roundPanel7.Location = new System.Drawing.Point(310, 310);
            this.roundPanel7.Margin = new System.Windows.Forms.Padding(20);
            this.roundPanel7.Name = "roundPanel7";
            this.roundPanel7.Size = new System.Drawing.Size(250, 250);
            this.roundPanel7.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label1.Size = new System.Drawing.Size(250, 250);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.label1.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // roundPanel3
            // 
            this.roundPanel3.BorderColor = System.Drawing.Color.Black;
            this.roundPanel3.BorderWidth = 0F;
            this.roundPanel3.ClientRoundScale = 0.1F;
            this.roundPanel3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.roundPanel3.Controls.Add(this.empLb);
            this.roundPanel3.Image = global::Bakery.Properties.Resources.employee;
            this.roundPanel3.Location = new System.Drawing.Point(600, 20);
            this.roundPanel3.Margin = new System.Windows.Forms.Padding(20);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(250, 250);
            this.roundPanel3.TabIndex = 14;
            // 
            // empLb
            // 
            this.empLb.BackColor = System.Drawing.Color.Transparent;
            this.empLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empLb.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empLb.ForeColor = System.Drawing.Color.White;
            this.empLb.Location = new System.Drawing.Point(0, 0);
            this.empLb.Name = "empLb";
            this.empLb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.empLb.Size = new System.Drawing.Size(250, 250);
            this.empLb.TabIndex = 0;
            this.empLb.Text = "Nhân viên";
            this.empLb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.empLb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.empLb.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.empLb.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.empLb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // roundPanel2
            // 
            this.roundPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundPanel2.BorderWidth = 0F;
            this.roundPanel2.ClientRoundScale = 0.1F;
            this.roundPanel2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.roundPanel2.Controls.Add(this.costLb);
            this.roundPanel2.Image = global::Bakery.Properties.Resources.cost;
            this.roundPanel2.Location = new System.Drawing.Point(310, 20);
            this.roundPanel2.Margin = new System.Windows.Forms.Padding(20);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(250, 250);
            this.roundPanel2.TabIndex = 13;
            // 
            // costLb
            // 
            this.costLb.BackColor = System.Drawing.Color.Transparent;
            this.costLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.costLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costLb.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLb.ForeColor = System.Drawing.Color.White;
            this.costLb.Location = new System.Drawing.Point(0, 0);
            this.costLb.Name = "costLb";
            this.costLb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.costLb.Size = new System.Drawing.Size(250, 250);
            this.costLb.TabIndex = 0;
            this.costLb.Text = "Giá";
            this.costLb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.costLb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.costLb.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.costLb.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.costLb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundPanel1.BorderWidth = 0F;
            this.roundPanel1.ClientRoundScale = 0.1F;
            this.roundPanel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.roundPanel1.Controls.Add(this.cakeLb);
            this.roundPanel1.Image = global::Bakery.Properties.Resources.cake;
            this.roundPanel1.Location = new System.Drawing.Point(20, 20);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(20);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(250, 250);
            this.roundPanel1.TabIndex = 12;
            // 
            // cakeLb
            // 
            this.cakeLb.BackColor = System.Drawing.Color.Transparent;
            this.cakeLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cakeLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakeLb.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeLb.ForeColor = System.Drawing.Color.White;
            this.cakeLb.Location = new System.Drawing.Point(0, 0);
            this.cakeLb.Name = "cakeLb";
            this.cakeLb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.cakeLb.Size = new System.Drawing.Size(250, 250);
            this.cakeLb.TabIndex = 0;
            this.cakeLb.Text = "Bánh";
            this.cakeLb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cakeLb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.cakeLb.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.cakeLb.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.cakeLb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // roundPanel4
            // 
            this.roundPanel4.BorderColor = System.Drawing.Color.Black;
            this.roundPanel4.BorderWidth = 0F;
            this.roundPanel4.ClientRoundScale = 0.1F;
            this.roundPanel4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.roundPanel4.Controls.Add(this.salLb);
            this.roundPanel4.Image = global::Bakery.Properties.Resources.salary;
            this.roundPanel4.Location = new System.Drawing.Point(890, 20);
            this.roundPanel4.Margin = new System.Windows.Forms.Padding(20);
            this.roundPanel4.Name = "roundPanel4";
            this.roundPanel4.Size = new System.Drawing.Size(250, 250);
            this.roundPanel4.TabIndex = 15;
            // 
            // salLb
            // 
            this.salLb.BackColor = System.Drawing.Color.Transparent;
            this.salLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salLb.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salLb.ForeColor = System.Drawing.Color.White;
            this.salLb.Location = new System.Drawing.Point(0, 0);
            this.salLb.Name = "salLb";
            this.salLb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.salLb.Size = new System.Drawing.Size(250, 250);
            this.salLb.TabIndex = 0;
            this.salLb.Text = "Lương";
            this.salLb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salLb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.salLb.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.salLb.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.salLb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // roundPanel5
            // 
            this.roundPanel5.BorderColor = System.Drawing.Color.Black;
            this.roundPanel5.BorderWidth = 0F;
            this.roundPanel5.ClientRoundScale = 0.1F;
            this.roundPanel5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.roundPanel5.Controls.Add(this.accLb);
            this.roundPanel5.Image = global::Bakery.Properties.Resources.account;
            this.roundPanel5.Location = new System.Drawing.Point(20, 310);
            this.roundPanel5.Margin = new System.Windows.Forms.Padding(20);
            this.roundPanel5.Name = "roundPanel5";
            this.roundPanel5.Size = new System.Drawing.Size(250, 250);
            this.roundPanel5.TabIndex = 16;
            // 
            // accLb
            // 
            this.accLb.BackColor = System.Drawing.Color.Transparent;
            this.accLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accLb.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accLb.ForeColor = System.Drawing.Color.White;
            this.accLb.Location = new System.Drawing.Point(0, 0);
            this.accLb.Name = "accLb";
            this.accLb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.accLb.Size = new System.Drawing.Size(250, 250);
            this.accLb.TabIndex = 0;
            this.accLb.Text = "Tài khoản";
            this.accLb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accLb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.accLb.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.accLb.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.accLb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // roundPanel6
            // 
            this.roundPanel6.BorderColor = System.Drawing.Color.Black;
            this.roundPanel6.BorderWidth = 0F;
            this.roundPanel6.ClientRoundScale = 0.1F;
            this.roundPanel6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.roundPanel6.Controls.Add(this.billLb);
            this.roundPanel6.Image = global::Bakery.Properties.Resources.setting;
            this.roundPanel6.Location = new System.Drawing.Point(890, 310);
            this.roundPanel6.Margin = new System.Windows.Forms.Padding(20);
            this.roundPanel6.Name = "roundPanel6";
            this.roundPanel6.Size = new System.Drawing.Size(250, 250);
            this.roundPanel6.TabIndex = 17;
            // 
            // billLb
            // 
            this.billLb.BackColor = System.Drawing.Color.Transparent;
            this.billLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billLb.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLb.ForeColor = System.Drawing.Color.White;
            this.billLb.Location = new System.Drawing.Point(0, 0);
            this.billLb.Name = "billLb";
            this.billLb.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.billLb.Size = new System.Drawing.Size(250, 250);
            this.billLb.TabIndex = 0;
            this.billLb.Text = "Cài đặt";
            this.billLb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.billLb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.billLb.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.billLb.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.billLb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // ManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuPanel);
            this.Name = "ManagerPanel";
            this.Size = new System.Drawing.Size(1200, 700);
            this.menuPanel.ResumeLayout(false);
            this.roundPanel8.ResumeLayout(false);
            this.roundPanel7.ResumeLayout(false);
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel4.ResumeLayout(false);
            this.roundPanel5.ResumeLayout(false);
            this.roundPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private RoundPanel roundPanel4;
        private System.Windows.Forms.Label salLb;
        private RoundPanel roundPanel3;
        private System.Windows.Forms.Label empLb;
        private RoundPanel roundPanel2;
        private System.Windows.Forms.Label costLb;
        private RoundPanel roundPanel1;
        private System.Windows.Forms.Label cakeLb;
        private RoundPanel roundPanel6;
        private System.Windows.Forms.Label billLb;
        private RoundPanel roundPanel5;
        private System.Windows.Forms.Label accLb;
        private RoundPanel roundPanel7;
        private System.Windows.Forms.Label label1;
        private RoundPanel roundPanel8;
        private System.Windows.Forms.Label label2;
    }
}
