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
            this.empIdLb = new System.Windows.Forms.Label();
            this.empNameLb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderValueLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.roundPanel1 = new Bakery.RoundPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelBtn = new Bakery.RoundButton();
            this.accessBtn = new Bakery.RoundButton();
            this.ordersPnl = new Bakery.FlowLayoutPanel();
            this.orderItem1 = new Bakery.OrderItem();
            this.orderItem2 = new Bakery.OrderItem();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // empIdLb
            // 
            this.empIdLb.AutoSize = true;
            this.empIdLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdLb.Location = new System.Drawing.Point(40, 178);
            this.empIdLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.empIdLb.Name = "empIdLb";
            this.empIdLb.Size = new System.Drawing.Size(0, 21);
            this.empIdLb.TabIndex = 3;
            // 
            // empNameLb
            // 
            this.empNameLb.AutoSize = true;
            this.empNameLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameLb.Location = new System.Drawing.Point(40, 196);
            this.empNameLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.empNameLb.Name = "empNameLb";
            this.empNameLb.Size = new System.Drawing.Size(0, 21);
            this.empNameLb.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(509, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 500);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 455);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 1);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.orderValueLb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(510, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 500);
            this.panel1.TabIndex = 0;
            // 
            // orderValueLb
            // 
            this.orderValueLb.AutoSize = true;
            this.orderValueLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderValueLb.ForeColor = System.Drawing.Color.Red;
            this.orderValueLb.Location = new System.Drawing.Point(118, 264);
            this.orderValueLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderValueLb.Name = "orderValueLb";
            this.orderValueLb.Size = new System.Drawing.Size(0, 21);
            this.orderValueLb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng tiền:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 262);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 1);
            this.panel6.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.roundPanel1);
            this.panel5.Controls.Add(this.empNameLb);
            this.panel5.Controls.Add(this.empIdLb);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 262);
            this.panel5.TabIndex = 5;
            // 
            // roundPanel1
            // 
            this.roundPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundPanel1.BorderColor = System.Drawing.Color.Silver;
            this.roundPanel1.BorderWidth = 1F;
            this.roundPanel1.ClientRoundScale = 1F;
            this.roundPanel1.Color = System.Drawing.Color.Transparent;
            this.roundPanel1.Image = null;
            this.roundPanel1.ImageHeight = 0;
            this.roundPanel1.Location = new System.Drawing.Point(40, 15);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(160, 160);
            this.roundPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cancelBtn);
            this.panel3.Controls.Add(this.accessBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 456);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 44);
            this.panel3.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BorderColor = System.Drawing.Color.Silver;
            this.cancelBtn.BorderWidth = 0F;
            this.cancelBtn.CenterImage = null;
            this.cancelBtn.ClientRoundScale = 0.25F;
            this.cancelBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(133, 4);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 36);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // accessBtn
            // 
            this.accessBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.accessBtn.Location = new System.Drawing.Point(26, 4);
            this.accessBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.accessBtn.Name = "accessBtn";
            this.accessBtn.Size = new System.Drawing.Size(80, 36);
            this.accessBtn.TabIndex = 5;
            this.accessBtn.Text = "Xác nhận";
            this.accessBtn.UseVisualStyleBackColor = false;
            // 
            // ordersPnl
            // 
            this.ordersPnl.AutoScroll = true;
            this.ordersPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.ordersPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ordersPnl.Location = new System.Drawing.Point(0, 0);
            this.ordersPnl.Margin = new System.Windows.Forms.Padding(2);
            this.ordersPnl.Name = "ordersPnl";
            this.ordersPnl.Size = new System.Drawing.Size(509, 500);
            this.ordersPnl.TabIndex = 2;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.ordersPnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderPanel";
            this.Size = new System.Drawing.Size(750, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundPanel roundPanel1;
        private RoundButton accessBtn;
        private RoundButton cancelBtn;
        private System.Windows.Forms.Label empIdLb;
        private System.Windows.Forms.Label empNameLb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label orderValueLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private FlowLayoutPanel ordersPnl;
        private OrderItem orderItem1;
        private OrderItem orderItem2;
    }
}
