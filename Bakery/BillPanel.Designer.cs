namespace Bakery
{
    partial class BillPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadDataBtn = new Bakery.RoundButton();
            this.roundPanel1 = new Bakery.RoundPanel();
            this.yearCmb = new System.Windows.Forms.ComboBox();
            this.monthCmb = new System.Windows.Forms.ComboBox();
            this.dayCmb = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.homeBtn = new Bakery.RoundButton();
            this.billsPnl = new Bakery.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.loadDataBtn);
            this.panel1.Controls.Add(this.roundPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 112);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1192, 50);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(941, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 50);
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
            this.label6.Location = new System.Drawing.Point(711, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã nhân viên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(481, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 50);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá trị";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(251, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày thanh toán";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            // 
            // loadDataBtn
            // 
            this.loadDataBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loadDataBtn.BackColor = System.Drawing.Color.Transparent;
            this.loadDataBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.loadDataBtn.BorderWidth = 2F;
            this.loadDataBtn.CenterImage = global::Bakery.Properties.Resources.Right;
            this.loadDataBtn.ClientRoundScale = 1F;
            this.loadDataBtn.Color = System.Drawing.Color.Transparent;
            this.loadDataBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadDataBtn.FlatAppearance.BorderSize = 0;
            this.loadDataBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.loadDataBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loadDataBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loadDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadDataBtn.Location = new System.Drawing.Point(442, 6);
            this.loadDataBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(50, 50);
            this.loadDataBtn.TabIndex = 8;
            this.loadDataBtn.UseVisualStyleBackColor = false;
            this.loadDataBtn.Click += new System.EventHandler(this.LoadDataBtn_Click);
            // 
            // roundPanel1
            // 
            this.roundPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roundPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roundPanel1.BorderWidth = 2F;
            this.roundPanel1.ClientRoundScale = 0.25F;
            this.roundPanel1.Color = System.Drawing.Color.White;
            this.roundPanel1.Controls.Add(this.yearCmb);
            this.roundPanel1.Controls.Add(this.monthCmb);
            this.roundPanel1.Controls.Add(this.dayCmb);
            this.roundPanel1.Image = null;
            this.roundPanel1.ImageHeight = 0;
            this.roundPanel1.Location = new System.Drawing.Point(6, 6);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(430, 50);
            this.roundPanel1.TabIndex = 18;
            // 
            // yearCmb
            // 
            this.yearCmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yearCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCmb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearCmb.FormattingEnabled = true;
            this.yearCmb.Location = new System.Drawing.Point(289, 9);
            this.yearCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearCmb.Name = "yearCmb";
            this.yearCmb.Size = new System.Drawing.Size(132, 31);
            this.yearCmb.TabIndex = 16;
            // 
            // monthCmb
            // 
            this.monthCmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.monthCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthCmb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCmb.FormattingEnabled = true;
            this.monthCmb.Location = new System.Drawing.Point(149, 9);
            this.monthCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monthCmb.Name = "monthCmb";
            this.monthCmb.Size = new System.Drawing.Size(132, 31);
            this.monthCmb.TabIndex = 14;
            // 
            // dayCmb
            // 
            this.dayCmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dayCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayCmb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayCmb.FormattingEnabled = true;
            this.dayCmb.Location = new System.Drawing.Point(9, 9);
            this.dayCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dayCmb.Name = "dayCmb";
            this.dayCmb.Size = new System.Drawing.Size(132, 31);
            this.dayCmb.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 174);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.homeBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1192, 62);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(541, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hóa đơn";
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.homeBtn.BorderWidth = 0F;
            this.homeBtn.CenterImage = global::Bakery.Properties.Resources.Left;
            this.homeBtn.ClientRoundScale = 1F;
            this.homeBtn.Color = System.Drawing.Color.Transparent;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Location = new System.Drawing.Point(6, 6);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(50, 50);
            this.homeBtn.TabIndex = 7;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // billsPnl
            // 
            this.billsPnl.AutoScroll = true;
            this.billsPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.billsPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billsPnl.Location = new System.Drawing.Point(0, 175);
            this.billsPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.billsPnl.Name = "billsPnl";
            this.billsPnl.Size = new System.Drawing.Size(1192, 545);
            this.billsPnl.TabIndex = 8;
            this.billsPnl.SizeChanged += new System.EventHandler(this.BillsPnl_SizeChanged);
            // 
            // BillPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.billsPnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BillPanel";
            this.Size = new System.Drawing.Size(1192, 720);
            this.Load += new System.EventHandler(this.BillPanel_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel billsPnl;
        private System.Windows.Forms.Panel panel1;
        private RoundButton loadDataBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox yearCmb;
        private System.Windows.Forms.ComboBox monthCmb;
        private System.Windows.Forms.ComboBox dayCmb;
        private RoundPanel roundPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private RoundButton homeBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
