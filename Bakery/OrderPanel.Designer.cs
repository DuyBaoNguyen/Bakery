namespace Bakery
{
    partial class OrderPanel
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundPanel4 = new Bakery.RoundPanel();
            this.valueCartLb = new Bakery.TransparentLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundPanel3 = new Bakery.RoundPanel();
            this.empNameLb = new Bakery.TransparentLabel();
            this.roundPanel2 = new Bakery.RoundPanel();
            this.empIdLb = new Bakery.TransparentLabel();
            this.roundPanel1 = new Bakery.RoundPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelBtn = new Bakery.RoundButton();
            this.accessBtn = new Bakery.RoundButton();
            this.ordersPnl = new Bakery.FlowLayoutPanel();
            this.orderItem1 = new Bakery.OrderItem();
            this.orderItem2 = new Bakery.OrderItem();
            this.panel1.SuspendLayout();
            this.roundPanel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.roundPanel3.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 569);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 1);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.roundPanel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(638, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 625);
            this.panel1.TabIndex = 0;
            // 
            // roundPanel4
            // 
            this.roundPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roundPanel4.BorderWidth = 2F;
            this.roundPanel4.ClientRoundScale = 0.25F;
            this.roundPanel4.Color = System.Drawing.Color.White;
            this.roundPanel4.Controls.Add(this.valueCartLb);
            this.roundPanel4.Image = null;
            this.roundPanel4.ImageHeight = 0;
            this.roundPanel4.Location = new System.Drawing.Point(13, 478);
            this.roundPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.roundPanel4.Name = "roundPanel4";
            this.roundPanel4.Size = new System.Drawing.Size(275, 50);
            this.roundPanel4.TabIndex = 8;
            // 
            // valueCartLb
            // 
            this.valueCartLb.BackColor = System.Drawing.Color.Transparent;
            this.valueCartLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueCartLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueCartLb.ForeColor = System.Drawing.Color.Red;
            this.valueCartLb.Location = new System.Drawing.Point(0, 0);
            this.valueCartLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueCartLb.Name = "valueCartLb";
            this.valueCartLb.Size = new System.Drawing.Size(275, 50);
            this.valueCartLb.TabIndex = 0;
            this.valueCartLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 446);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng tiền:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 431);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 1);
            this.panel6.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.roundPanel3);
            this.panel5.Controls.Add(this.roundPanel2);
            this.panel5.Controls.Add(this.roundPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 431);
            this.panel5.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã nhân viên";
            // 
            // roundPanel3
            // 
            this.roundPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roundPanel3.BorderWidth = 2F;
            this.roundPanel3.ClientRoundScale = 0.25F;
            this.roundPanel3.Color = System.Drawing.Color.White;
            this.roundPanel3.Controls.Add(this.empNameLb);
            this.roundPanel3.Image = null;
            this.roundPanel3.ImageHeight = 0;
            this.roundPanel3.Location = new System.Drawing.Point(13, 368);
            this.roundPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(275, 50);
            this.roundPanel3.TabIndex = 6;
            // 
            // empNameLb
            // 
            this.empNameLb.BackColor = System.Drawing.Color.Transparent;
            this.empNameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empNameLb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameLb.Location = new System.Drawing.Point(0, 0);
            this.empNameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empNameLb.Name = "empNameLb";
            this.empNameLb.Size = new System.Drawing.Size(275, 50);
            this.empNameLb.TabIndex = 0;
            this.empNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundPanel2
            // 
            this.roundPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roundPanel2.BorderWidth = 2F;
            this.roundPanel2.ClientRoundScale = 0.25F;
            this.roundPanel2.Color = System.Drawing.Color.White;
            this.roundPanel2.Controls.Add(this.empIdLb);
            this.roundPanel2.Image = null;
            this.roundPanel2.ImageHeight = 0;
            this.roundPanel2.Location = new System.Drawing.Point(13, 270);
            this.roundPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(275, 50);
            this.roundPanel2.TabIndex = 5;
            // 
            // empIdLb
            // 
            this.empIdLb.BackColor = System.Drawing.Color.Transparent;
            this.empIdLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empIdLb.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdLb.Location = new System.Drawing.Point(0, 0);
            this.empIdLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.empIdLb.Name = "empIdLb";
            this.empIdLb.Size = new System.Drawing.Size(275, 50);
            this.empIdLb.TabIndex = 0;
            this.empIdLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundPanel1
            // 
            this.roundPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundPanel1.BorderColor = System.Drawing.Color.Silver;
            this.roundPanel1.BorderWidth = 1F;
            this.roundPanel1.ClientRoundScale = 1F;
            this.roundPanel1.Color = System.Drawing.Color.Transparent;
            this.roundPanel1.Image = global::Bakery.Properties.Resources.User;
            this.roundPanel1.ImageHeight = 0;
            this.roundPanel1.Location = new System.Drawing.Point(50, 19);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(200, 200);
            this.roundPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cancelBtn);
            this.panel3.Controls.Add(this.accessBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 570);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 55);
            this.panel3.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cancelBtn.Location = new System.Drawing.Point(162, 5);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(125, 45);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // accessBtn
            // 
            this.accessBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accessBtn.BackColor = System.Drawing.Color.Transparent;
            this.accessBtn.BorderColor = System.Drawing.Color.Silver;
            this.accessBtn.BorderWidth = 0F;
            this.accessBtn.CenterImage = null;
            this.accessBtn.ClientRoundScale = 1F;
            this.accessBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.accessBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accessBtn.FlatAppearance.BorderSize = 0;
            this.accessBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.accessBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.accessBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.accessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accessBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessBtn.ForeColor = System.Drawing.Color.White;
            this.accessBtn.Location = new System.Drawing.Point(12, 5);
            this.accessBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.accessBtn.Name = "accessBtn";
            this.accessBtn.Size = new System.Drawing.Size(125, 45);
            this.accessBtn.TabIndex = 5;
            this.accessBtn.Text = "Xác nhận";
            this.accessBtn.UseVisualStyleBackColor = false;
            this.accessBtn.Click += new System.EventHandler(this.AccessBtn_Click);
            // 
            // ordersPnl
            // 
            this.ordersPnl.AutoScroll = true;
            this.ordersPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ordersPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ordersPnl.Location = new System.Drawing.Point(0, 0);
            this.ordersPnl.Margin = new System.Windows.Forms.Padding(2);
            this.ordersPnl.Name = "ordersPnl";
            this.ordersPnl.Size = new System.Drawing.Size(638, 625);
            this.ordersPnl.TabIndex = 2;
            this.ordersPnl.SizeChanged += new System.EventHandler(this.OrdersPnl_SizeChanged);
            // 
            // orderItem1
            // 
            this.orderItem1.BackColor = System.Drawing.Color.White;
            this.orderItem1.Data = null;
            this.orderItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItem1.Location = new System.Drawing.Point(0, 241);
            this.orderItem1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.orderItem1.Name = "orderItem1";
            this.orderItem1.Size = new System.Drawing.Size(509, 39);
            this.orderItem1.TabIndex = 0;
            // 
            // orderItem2
            // 
            this.orderItem2.BackColor = System.Drawing.Color.White;
            this.orderItem2.Data = null;
            this.orderItem2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItem2.Location = new System.Drawing.Point(0, 1);
            this.orderItem2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.orderItem2.Name = "orderItem2";
            this.orderItem2.Size = new System.Drawing.Size(509, 39);
            this.orderItem2.TabIndex = 1;
            // 
            // OrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.ordersPnl);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderPanel";
            this.Size = new System.Drawing.Size(938, 625);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.roundPanel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundPanel roundPanel1;
        private RoundButton accessBtn;
        private RoundButton cancelBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private FlowLayoutPanel ordersPnl;
        private OrderItem orderItem1;
        private OrderItem orderItem2;
        private RoundPanel roundPanel2;
        private RoundPanel roundPanel4;
        private TransparentLabel valueCartLb;
        private RoundPanel roundPanel3;
        private TransparentLabel empNameLb;
        private TransparentLabel empIdLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
