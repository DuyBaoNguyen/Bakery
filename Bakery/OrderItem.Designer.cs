namespace Bakery
{
    partial class OrderItem
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cakeCostLb = new System.Windows.Forms.Label();
            this.imagePtb = new System.Windows.Forms.PictureBox();
            this.cakeNameLb = new System.Windows.Forms.Label();
            this.amoutCakeNud = new System.Windows.Forms.NumericUpDown();
            this.deleteBtn = new Bakery.CircularButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePtb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amoutCakeNud)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.cakeCostLb, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.imagePtb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cakeNameLb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.amoutCakeNud, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cakeCostLb
            // 
            this.cakeCostLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakeCostLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeCostLb.Location = new System.Drawing.Point(292, 0);
            this.cakeCostLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cakeCostLb.Name = "cakeCostLb";
            this.cakeCostLb.Size = new System.Drawing.Size(236, 50);
            this.cakeCostLb.TabIndex = 2;
            this.cakeCostLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imagePtb
            // 
            this.imagePtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePtb.Location = new System.Drawing.Point(2, 2);
            this.imagePtb.Margin = new System.Windows.Forms.Padding(2);
            this.imagePtb.Name = "imagePtb";
            this.imagePtb.Size = new System.Drawing.Size(46, 46);
            this.imagePtb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePtb.TabIndex = 0;
            this.imagePtb.TabStop = false;
            // 
            // cakeNameLb
            // 
            this.cakeNameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakeNameLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeNameLb.Location = new System.Drawing.Point(52, 0);
            this.cakeNameLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cakeNameLb.Name = "cakeNameLb";
            this.cakeNameLb.Size = new System.Drawing.Size(236, 50);
            this.cakeNameLb.TabIndex = 1;
            this.cakeNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amoutCakeNud
            // 
            this.amoutCakeNud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amoutCakeNud.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amoutCakeNud.Location = new System.Drawing.Point(532, 2);
            this.amoutCakeNud.Margin = new System.Windows.Forms.Padding(2);
            this.amoutCakeNud.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.amoutCakeNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amoutCakeNud.Name = "amoutCakeNud";
            this.amoutCakeNud.Size = new System.Drawing.Size(112, 30);
            this.amoutCakeNud.TabIndex = 3;
            this.amoutCakeNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BorderColor = System.Drawing.Color.Black;
            this.deleteBtn.BorderWidth = 0F;
            this.deleteBtn.CenterImage = global::Bakery.Properties.Resources.garbagebin;
            this.deleteBtn.Color = System.Drawing.Color.Transparent;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(770, 0);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.MouseEnterColor = System.Drawing.Color.Black;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(50, 50);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.deleteBtn);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(820, 50);
            this.Load += new System.EventHandler(this.OrderItem_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePtb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amoutCakeNud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CircularButton deleteBtn;
        private System.Windows.Forms.Label cakeCostLb;
        private System.Windows.Forms.PictureBox imagePtb;
        private System.Windows.Forms.Label cakeNameLb;
        private System.Windows.Forms.NumericUpDown amoutCakeNud;
    }
}
