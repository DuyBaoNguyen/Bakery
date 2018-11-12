namespace Bakery
{
    partial class BillDetailItem
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
            this.cakeAmountLb = new System.Windows.Forms.Label();
            this.cakeCostLb = new System.Windows.Forms.Label();
            this.cakeNameLb = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.cakeAmountLb, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cakeCostLb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cakeNameLb, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cakeAmountLb
            // 
            this.cakeAmountLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakeAmountLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeAmountLb.Location = new System.Drawing.Point(536, 0);
            this.cakeAmountLb.Margin = new System.Windows.Forms.Padding(0);
            this.cakeAmountLb.Name = "cakeAmountLb";
            this.cakeAmountLb.Size = new System.Drawing.Size(269, 50);
            this.cakeAmountLb.TabIndex = 4;
            this.cakeAmountLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cakeAmountLb.UseMnemonic = false;
            // 
            // cakeCostLb
            // 
            this.cakeCostLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakeCostLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeCostLb.Location = new System.Drawing.Point(268, 0);
            this.cakeCostLb.Margin = new System.Windows.Forms.Padding(0);
            this.cakeCostLb.Name = "cakeCostLb";
            this.cakeCostLb.Size = new System.Drawing.Size(268, 50);
            this.cakeCostLb.TabIndex = 3;
            this.cakeCostLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cakeCostLb.UseMnemonic = false;
            // 
            // cakeNameLb
            // 
            this.cakeNameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakeNameLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeNameLb.Location = new System.Drawing.Point(0, 0);
            this.cakeNameLb.Margin = new System.Windows.Forms.Padding(0);
            this.cakeNameLb.Name = "cakeNameLb";
            this.cakeNameLb.Size = new System.Drawing.Size(268, 50);
            this.cakeNameLb.TabIndex = 2;
            this.cakeNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cakeNameLb.UseMnemonic = false;
            // 
            // BillDetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "BillDetailItem";
            this.Size = new System.Drawing.Size(805, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cakeAmountLb;
        private System.Windows.Forms.Label cakeCostLb;
        private System.Windows.Forms.Label cakeNameLb;
    }
}
