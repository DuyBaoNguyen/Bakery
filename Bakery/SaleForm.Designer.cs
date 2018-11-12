namespace Bakery
{
    partial class SaleForm
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
            this.cakePnl = new Bakery.SalePanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartMenuItemRbn = new System.Windows.Forms.RadioButton();
            this.cakeMenuItemRbn = new System.Windows.Forms.RadioButton();
            this.orderPnl = new Bakery.OrderPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cakePnl
            // 
            this.cakePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cakePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakePnl.Location = new System.Drawing.Point(181, 0);
            this.cakePnl.Margin = new System.Windows.Forms.Padding(4);
            this.cakePnl.Name = "cakePnl";
            this.cakePnl.Size = new System.Drawing.Size(803, 611);
            this.cakePnl.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cartMenuItemRbn);
            this.panel1.Controls.Add(this.cakeMenuItemRbn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 611);
            this.panel1.TabIndex = 3;
            // 
            // cartMenuItemRbn
            // 
            this.cartMenuItemRbn.Appearance = System.Windows.Forms.Appearance.Button;
            this.cartMenuItemRbn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cartMenuItemRbn.FlatAppearance.BorderSize = 0;
            this.cartMenuItemRbn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.cartMenuItemRbn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.cartMenuItemRbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartMenuItemRbn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartMenuItemRbn.ForeColor = System.Drawing.Color.Black;
            this.cartMenuItemRbn.Image = global::Bakery.Properties.Resources.cart_small;
            this.cartMenuItemRbn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cartMenuItemRbn.Location = new System.Drawing.Point(0, 36);
            this.cartMenuItemRbn.Margin = new System.Windows.Forms.Padding(2);
            this.cartMenuItemRbn.Name = "cartMenuItemRbn";
            this.cartMenuItemRbn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cartMenuItemRbn.Size = new System.Drawing.Size(181, 36);
            this.cartMenuItemRbn.TabIndex = 1;
            this.cartMenuItemRbn.TabStop = true;
            this.cartMenuItemRbn.Text = "  Giỏ hàng";
            this.cartMenuItemRbn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cartMenuItemRbn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cartMenuItemRbn.UseVisualStyleBackColor = true;
            this.cartMenuItemRbn.CheckedChanged += new System.EventHandler(this.CartMenuItemRbn_CheckedChanged);
            this.cartMenuItemRbn.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuItem_Paint);
            // 
            // cakeMenuItemRbn
            // 
            this.cakeMenuItemRbn.Appearance = System.Windows.Forms.Appearance.Button;
            this.cakeMenuItemRbn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cakeMenuItemRbn.FlatAppearance.BorderSize = 0;
            this.cakeMenuItemRbn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.cakeMenuItemRbn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.cakeMenuItemRbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cakeMenuItemRbn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeMenuItemRbn.ForeColor = System.Drawing.Color.Black;
            this.cakeMenuItemRbn.Image = global::Bakery.Properties.Resources.cake_small;
            this.cakeMenuItemRbn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cakeMenuItemRbn.Location = new System.Drawing.Point(0, 0);
            this.cakeMenuItemRbn.Margin = new System.Windows.Forms.Padding(2);
            this.cakeMenuItemRbn.Name = "cakeMenuItemRbn";
            this.cakeMenuItemRbn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cakeMenuItemRbn.Size = new System.Drawing.Size(181, 36);
            this.cakeMenuItemRbn.TabIndex = 0;
            this.cakeMenuItemRbn.TabStop = true;
            this.cakeMenuItemRbn.Text = "  Bánh";
            this.cakeMenuItemRbn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cakeMenuItemRbn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cakeMenuItemRbn.UseVisualStyleBackColor = true;
            this.cakeMenuItemRbn.CheckedChanged += new System.EventHandler(this.CakeMenuItemRbn_CheckedChanged);
            this.cakeMenuItemRbn.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuItem_Paint);
            // 
            // orderPnl
            // 
            this.orderPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.orderPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPnl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderPnl.Location = new System.Drawing.Point(0, 0);
            this.orderPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderPnl.Name = "orderPnl";
            this.orderPnl.Size = new System.Drawing.Size(984, 611);
            this.orderPnl.TabIndex = 5;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.cakePnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderPnl);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "SaleForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SalePanel cakePnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton cartMenuItemRbn;
        private System.Windows.Forms.RadioButton cakeMenuItemRbn;
        private OrderPanel orderPnl;
    }
}