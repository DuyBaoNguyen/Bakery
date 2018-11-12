namespace Bakery
{
    partial class ManagePanel
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
            this.statisticItemPnl = new Bakery.RoundPanel();
            this.transparentLabel7 = new Bakery.TransparentLabel();
            this.cakeItemPnl = new Bakery.RoundPanel();
            this.transparentLabel1 = new Bakery.TransparentLabel();
            this.accItemPnl = new Bakery.RoundPanel();
            this.transparentLabel5 = new Bakery.TransparentLabel();
            this.empItemPnl = new Bakery.RoundPanel();
            this.transparentLabel3 = new Bakery.TransparentLabel();
            this.salItemPnl = new Bakery.RoundPanel();
            this.transparentLabel4 = new Bakery.TransparentLabel();
            this.billItemPnl = new Bakery.RoundPanel();
            this.transparentLabel6 = new Bakery.TransparentLabel();
            this.menuPanel.SuspendLayout();
            this.statisticItemPnl.SuspendLayout();
            this.cakeItemPnl.SuspendLayout();
            this.accItemPnl.SuspendLayout();
            this.empItemPnl.SuspendLayout();
            this.salItemPnl.SuspendLayout();
            this.billItemPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuPanel.AutoSize = true;
            this.menuPanel.ColumnCount = 3;
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.menuPanel.Controls.Add(this.cakeItemPnl, 0, 0);
            this.menuPanel.Controls.Add(this.empItemPnl, 1, 0);
            this.menuPanel.Controls.Add(this.salItemPnl, 2, 0);
            this.menuPanel.Controls.Add(this.statisticItemPnl, 2, 1);
            this.menuPanel.Controls.Add(this.accItemPnl, 1, 1);
            this.menuPanel.Controls.Add(this.billItemPnl, 0, 1);
            this.menuPanel.Location = new System.Drawing.Point(206, 114);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RowCount = 2;
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuPanel.Size = new System.Drawing.Size(921, 572);
            this.menuPanel.TabIndex = 4;
            // 
            // statisticItemPnl
            // 
            this.statisticItemPnl.BorderColor = System.Drawing.Color.Black;
            this.statisticItemPnl.BorderWidth = 0F;
            this.statisticItemPnl.ClientRoundScale = 0.1F;
            this.statisticItemPnl.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.statisticItemPnl.Controls.Add(this.transparentLabel7);
            this.statisticItemPnl.Image = global::Bakery.Properties.Resources.statistic;
            this.statisticItemPnl.ImageHeight = 0;
            this.statisticItemPnl.Location = new System.Drawing.Point(634, 306);
            this.statisticItemPnl.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.statisticItemPnl.Name = "statisticItemPnl";
            this.statisticItemPnl.Size = new System.Drawing.Size(267, 246);
            this.statisticItemPnl.TabIndex = 19;
            this.statisticItemPnl.Click += new System.EventHandler(this.StatisticItemPnl_Click);
            this.statisticItemPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.statisticItemPnl.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.statisticItemPnl.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.statisticItemPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // transparentLabel7
            // 
            this.transparentLabel7.BackColor = System.Drawing.Color.Transparent;
            this.transparentLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel7.ForeColor = System.Drawing.Color.White;
            this.transparentLabel7.Location = new System.Drawing.Point(0, 0);
            this.transparentLabel7.Name = "transparentLabel7";
            this.transparentLabel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.transparentLabel7.Size = new System.Drawing.Size(267, 246);
            this.transparentLabel7.TabIndex = 1;
            this.transparentLabel7.Text = "Thống kê";
            this.transparentLabel7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cakeItemPnl
            // 
            this.cakeItemPnl.BorderColor = System.Drawing.Color.Black;
            this.cakeItemPnl.BorderWidth = 0F;
            this.cakeItemPnl.ClientRoundScale = 0.1F;
            this.cakeItemPnl.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.cakeItemPnl.Controls.Add(this.transparentLabel1);
            this.cakeItemPnl.Image = global::Bakery.Properties.Resources.cake;
            this.cakeItemPnl.ImageHeight = 0;
            this.cakeItemPnl.Location = new System.Drawing.Point(20, 20);
            this.cakeItemPnl.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.cakeItemPnl.Name = "cakeItemPnl";
            this.cakeItemPnl.Size = new System.Drawing.Size(267, 246);
            this.cakeItemPnl.TabIndex = 12;
            this.cakeItemPnl.Click += new System.EventHandler(this.CakeItemPnl_Click);
            this.cakeItemPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.cakeItemPnl.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.cakeItemPnl.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.cakeItemPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.BackColor = System.Drawing.Color.Transparent;
            this.transparentLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel1.ForeColor = System.Drawing.Color.White;
            this.transparentLabel1.Location = new System.Drawing.Point(0, 0);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.transparentLabel1.Size = new System.Drawing.Size(267, 246);
            this.transparentLabel1.TabIndex = 0;
            this.transparentLabel1.Text = "Bánh";
            this.transparentLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // accItemPnl
            // 
            this.accItemPnl.BorderColor = System.Drawing.Color.Black;
            this.accItemPnl.BorderWidth = 0F;
            this.accItemPnl.ClientRoundScale = 0.1F;
            this.accItemPnl.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.accItemPnl.Controls.Add(this.transparentLabel5);
            this.accItemPnl.Image = global::Bakery.Properties.Resources.account;
            this.accItemPnl.ImageHeight = 0;
            this.accItemPnl.Location = new System.Drawing.Point(327, 306);
            this.accItemPnl.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.accItemPnl.Name = "accItemPnl";
            this.accItemPnl.Size = new System.Drawing.Size(267, 246);
            this.accItemPnl.TabIndex = 16;
            this.accItemPnl.Click += new System.EventHandler(this.AccItemPnl_Click);
            this.accItemPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.accItemPnl.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.accItemPnl.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.accItemPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // transparentLabel5
            // 
            this.transparentLabel5.BackColor = System.Drawing.Color.Transparent;
            this.transparentLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel5.ForeColor = System.Drawing.Color.White;
            this.transparentLabel5.Location = new System.Drawing.Point(0, 0);
            this.transparentLabel5.Name = "transparentLabel5";
            this.transparentLabel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.transparentLabel5.Size = new System.Drawing.Size(267, 246);
            this.transparentLabel5.TabIndex = 1;
            this.transparentLabel5.Text = "Tài khoản";
            this.transparentLabel5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // empItemPnl
            // 
            this.empItemPnl.BorderColor = System.Drawing.Color.Black;
            this.empItemPnl.BorderWidth = 0F;
            this.empItemPnl.ClientRoundScale = 0.1F;
            this.empItemPnl.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.empItemPnl.Controls.Add(this.transparentLabel3);
            this.empItemPnl.Image = global::Bakery.Properties.Resources.employee;
            this.empItemPnl.ImageHeight = 0;
            this.empItemPnl.Location = new System.Drawing.Point(327, 20);
            this.empItemPnl.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.empItemPnl.Name = "empItemPnl";
            this.empItemPnl.Size = new System.Drawing.Size(267, 246);
            this.empItemPnl.TabIndex = 14;
            this.empItemPnl.Click += new System.EventHandler(this.EmpItemPnl_Click);
            this.empItemPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.empItemPnl.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.empItemPnl.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.empItemPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // transparentLabel3
            // 
            this.transparentLabel3.BackColor = System.Drawing.Color.Transparent;
            this.transparentLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel3.ForeColor = System.Drawing.Color.White;
            this.transparentLabel3.Location = new System.Drawing.Point(0, 0);
            this.transparentLabel3.Name = "transparentLabel3";
            this.transparentLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.transparentLabel3.Size = new System.Drawing.Size(267, 246);
            this.transparentLabel3.TabIndex = 1;
            this.transparentLabel3.Text = "Nhân viên";
            this.transparentLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // salItemPnl
            // 
            this.salItemPnl.BorderColor = System.Drawing.Color.Black;
            this.salItemPnl.BorderWidth = 0F;
            this.salItemPnl.ClientRoundScale = 0.1F;
            this.salItemPnl.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.salItemPnl.Controls.Add(this.transparentLabel4);
            this.salItemPnl.Image = global::Bakery.Properties.Resources.salary;
            this.salItemPnl.ImageHeight = 0;
            this.salItemPnl.Location = new System.Drawing.Point(634, 20);
            this.salItemPnl.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.salItemPnl.Name = "salItemPnl";
            this.salItemPnl.Size = new System.Drawing.Size(267, 246);
            this.salItemPnl.TabIndex = 15;
            this.salItemPnl.Click += new System.EventHandler(this.SalItemPnl_Click);
            this.salItemPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.salItemPnl.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.salItemPnl.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.salItemPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // transparentLabel4
            // 
            this.transparentLabel4.BackColor = System.Drawing.Color.Transparent;
            this.transparentLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel4.ForeColor = System.Drawing.Color.White;
            this.transparentLabel4.Location = new System.Drawing.Point(0, 0);
            this.transparentLabel4.Name = "transparentLabel4";
            this.transparentLabel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.transparentLabel4.Size = new System.Drawing.Size(267, 246);
            this.transparentLabel4.TabIndex = 1;
            this.transparentLabel4.Text = "Lương";
            this.transparentLabel4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // billItemPnl
            // 
            this.billItemPnl.BorderColor = System.Drawing.Color.Black;
            this.billItemPnl.BorderWidth = 0F;
            this.billItemPnl.ClientRoundScale = 0.1F;
            this.billItemPnl.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.billItemPnl.Controls.Add(this.transparentLabel6);
            this.billItemPnl.Image = global::Bakery.Properties.Resources.bill;
            this.billItemPnl.ImageHeight = 0;
            this.billItemPnl.Location = new System.Drawing.Point(20, 306);
            this.billItemPnl.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.billItemPnl.Name = "billItemPnl";
            this.billItemPnl.Size = new System.Drawing.Size(267, 246);
            this.billItemPnl.TabIndex = 18;
            this.billItemPnl.Click += new System.EventHandler(this.BillItemPnl_Click);
            this.billItemPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseDown);
            this.billItemPnl.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.billItemPnl.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.billItemPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MeneItem_MouseUp);
            // 
            // transparentLabel6
            // 
            this.transparentLabel6.BackColor = System.Drawing.Color.Transparent;
            this.transparentLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel6.ForeColor = System.Drawing.Color.White;
            this.transparentLabel6.Location = new System.Drawing.Point(0, 0);
            this.transparentLabel6.Name = "transparentLabel6";
            this.transparentLabel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.transparentLabel6.Size = new System.Drawing.Size(267, 246);
            this.transparentLabel6.TabIndex = 1;
            this.transparentLabel6.Text = "Hóa đơn";
            this.transparentLabel6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ManagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagePanel";
            this.Size = new System.Drawing.Size(1333, 800);
            this.Load += new System.EventHandler(this.ManagePanel_Load);
            this.menuPanel.ResumeLayout(false);
            this.statisticItemPnl.ResumeLayout(false);
            this.cakeItemPnl.ResumeLayout(false);
            this.accItemPnl.ResumeLayout(false);
            this.empItemPnl.ResumeLayout(false);
            this.salItemPnl.ResumeLayout(false);
            this.billItemPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private RoundPanel statisticItemPnl;
        private TransparentLabel transparentLabel7;
        private RoundPanel cakeItemPnl;
        private TransparentLabel transparentLabel1;
        private RoundPanel accItemPnl;
        private TransparentLabel transparentLabel5;
        private RoundPanel empItemPnl;
        private TransparentLabel transparentLabel3;
        private RoundPanel salItemPnl;
        private TransparentLabel transparentLabel4;
        private RoundPanel billItemPnl;
        private TransparentLabel transparentLabel6;
    }
}
