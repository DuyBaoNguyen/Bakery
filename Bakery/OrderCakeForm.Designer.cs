namespace Bakery
{
    partial class OrderCakeForm
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
            this.imagePnl = new Bakery.RoundPanel();
            this.cakeNameLb = new System.Windows.Forms.Label();
            this.cakeCostLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accessBtn = new Bakery.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.amountCakeNud = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountCakeNud)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePnl
            // 
            this.imagePnl.BorderColor = System.Drawing.Color.Silver;
            this.imagePnl.BorderWidth = 1F;
            this.imagePnl.ClientRoundScale = 0.1F;
            this.imagePnl.Color = System.Drawing.Color.White;
            this.imagePnl.Image = null;
            this.imagePnl.ImageHeight = 0;
            this.imagePnl.Location = new System.Drawing.Point(15, 15);
            this.imagePnl.Margin = new System.Windows.Forms.Padding(4);
            this.imagePnl.Name = "imagePnl";
            this.imagePnl.Size = new System.Drawing.Size(300, 300);
            this.imagePnl.TabIndex = 0;
            // 
            // cakeNameLb
            // 
            this.cakeNameLb.AutoSize = true;
            this.cakeNameLb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeNameLb.ForeColor = System.Drawing.Color.Red;
            this.cakeNameLb.Location = new System.Drawing.Point(335, 15);
            this.cakeNameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cakeNameLb.Name = "cakeNameLb";
            this.cakeNameLb.Size = new System.Drawing.Size(0, 28);
            this.cakeNameLb.TabIndex = 1;
            // 
            // cakeCostLb
            // 
            this.cakeCostLb.AutoSize = true;
            this.cakeCostLb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeCostLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.cakeCostLb.Location = new System.Drawing.Point(335, 50);
            this.cakeCostLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cakeCostLb.Name = "cakeCostLb";
            this.cakeCostLb.Size = new System.Drawing.Size(0, 28);
            this.cakeCostLb.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.accessBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 332);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 55);
            this.panel1.TabIndex = 5;
            // 
            // accessBtn
            // 
            this.accessBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.accessBtn.Location = new System.Drawing.Point(396, 5);
            this.accessBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.accessBtn.Name = "accessBtn";
            this.accessBtn.Size = new System.Drawing.Size(125, 45);
            this.accessBtn.TabIndex = 5;
            this.accessBtn.Text = "Xác nhận";
            this.accessBtn.UseVisualStyleBackColor = false;
            this.accessBtn.Click += new System.EventHandler(this.AccessBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 331);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 1);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // amountCakeNud
            // 
            this.amountCakeNud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountCakeNud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountCakeNud.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountCakeNud.Location = new System.Drawing.Point(340, 285);
            this.amountCakeNud.Margin = new System.Windows.Forms.Padding(4);
            this.amountCakeNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountCakeNud.Name = "amountCakeNud";
            this.amountCakeNud.Size = new System.Drawing.Size(181, 30);
            this.amountCakeNud.TabIndex = 4;
            this.amountCakeNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OrderCakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 387);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.amountCakeNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cakeCostLb);
            this.Controls.Add(this.cakeNameLb);
            this.Controls.Add(this.imagePnl);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderCakeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amountCakeNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundPanel imagePnl;
        private System.Windows.Forms.Label cakeNameLb;
        private System.Windows.Forms.Label cakeCostLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RoundButton accessBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown amountCakeNud;
    }
}