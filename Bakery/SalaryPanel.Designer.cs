namespace Bakery
{
    partial class SalaryPanel
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadDataBtn = new Bakery.RoundButton();
            this.roundPanel1 = new Bakery.RoundPanel();
            this.yearCmb = new System.Windows.Forms.ComboBox();
            this.monthCmb = new System.Windows.Forms.ComboBox();
            this.addSalBtn = new Bakery.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.homeBtn = new Bakery.RoundButton();
            this.salPnl = new Bakery.FlowLayoutPanel();
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
            this.panel1.Controls.Add(this.addSalBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 112);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 50);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(606, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày nhận lương";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(411, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 50);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lương";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(216, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ tên";
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
            this.label1.Size = new System.Drawing.Size(195, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            // 
            // loadDataBtn
            // 
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
            this.loadDataBtn.Location = new System.Drawing.Point(306, 6);
            this.loadDataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(50, 50);
            this.loadDataBtn.TabIndex = 12;
            this.loadDataBtn.UseVisualStyleBackColor = false;
            this.loadDataBtn.Click += new System.EventHandler(this.LoadDataBtn_Click);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roundPanel1.BorderWidth = 2F;
            this.roundPanel1.ClientRoundScale = 0.25F;
            this.roundPanel1.Color = System.Drawing.Color.White;
            this.roundPanel1.Controls.Add(this.yearCmb);
            this.roundPanel1.Controls.Add(this.monthCmb);
            this.roundPanel1.Image = null;
            this.roundPanel1.ImageHeight = 0;
            this.roundPanel1.Location = new System.Drawing.Point(6, 6);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(292, 50);
            this.roundPanel1.TabIndex = 12;
            // 
            // yearCmb
            // 
            this.yearCmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yearCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCmb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearCmb.FormattingEnabled = true;
            this.yearCmb.Location = new System.Drawing.Point(150, 10);
            this.yearCmb.Margin = new System.Windows.Forms.Padding(4);
            this.yearCmb.Name = "yearCmb";
            this.yearCmb.Size = new System.Drawing.Size(132, 31);
            this.yearCmb.TabIndex = 14;
            // 
            // monthCmb
            // 
            this.monthCmb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.monthCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthCmb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCmb.FormattingEnabled = true;
            this.monthCmb.Location = new System.Drawing.Point(10, 10);
            this.monthCmb.Margin = new System.Windows.Forms.Padding(4);
            this.monthCmb.Name = "monthCmb";
            this.monthCmb.Size = new System.Drawing.Size(132, 31);
            this.monthCmb.TabIndex = 13;
            // 
            // addSalBtn
            // 
            this.addSalBtn.BackColor = System.Drawing.Color.Transparent;
            this.addSalBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.addSalBtn.BorderWidth = 2F;
            this.addSalBtn.CenterImage = global::Bakery.Properties.Resources.Add;
            this.addSalBtn.ClientRoundScale = 1F;
            this.addSalBtn.Color = System.Drawing.Color.Transparent;
            this.addSalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSalBtn.FlatAppearance.BorderSize = 0;
            this.addSalBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.addSalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addSalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addSalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSalBtn.Location = new System.Drawing.Point(364, 6);
            this.addSalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addSalBtn.Name = "addSalBtn";
            this.addSalBtn.Size = new System.Drawing.Size(50, 50);
            this.addSalBtn.TabIndex = 11;
            this.addSalBtn.UseVisualStyleBackColor = false;
            this.addSalBtn.Click += new System.EventHandler(this.AddSalBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 174);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 1);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.homeBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 62);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(395, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lương";
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
            this.homeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(50, 50);
            this.homeBtn.TabIndex = 7;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // salPnl
            // 
            this.salPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.salPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salPnl.Location = new System.Drawing.Point(0, 175);
            this.salPnl.Margin = new System.Windows.Forms.Padding(4);
            this.salPnl.Name = "salPnl";
            this.salPnl.Size = new System.Drawing.Size(875, 386);
            this.salPnl.TabIndex = 6;
            // 
            // SalaryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.salPnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalaryPanel";
            this.Size = new System.Drawing.Size(875, 561);
            this.Load += new System.EventHandler(this.SalaryPanel_Load);
            this.SizeChanged += new System.EventHandler(this.SalaryPanel_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundButton addSalBtn;
        private RoundPanel roundPanel1;
        private RoundButton loadDataBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox yearCmb;
        private System.Windows.Forms.ComboBox monthCmb;
        private FlowLayoutPanel salPnl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private RoundButton homeBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
