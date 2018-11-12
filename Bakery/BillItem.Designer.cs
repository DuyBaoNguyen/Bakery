namespace Bakery
{
    partial class BillItem
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
            this.empNameLb = new Bakery.TransparentLabel();
            this.empIdLb = new Bakery.TransparentLabel();
            this.billValueLb = new Bakery.TransparentLabel();
            this.billPaymentDateLb = new Bakery.TransparentLabel();
            this.billIdLb = new Bakery.TransparentLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.empNameLb, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.empIdLb, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.billValueLb, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.billPaymentDateLb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.billIdLb, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.TableLayoutPanel1_Click);
            // 
            // empNameLb
            // 
            this.empNameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empNameLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameLb.Location = new System.Drawing.Point(696, 0);
            this.empNameLb.Margin = new System.Windows.Forms.Padding(0);
            this.empNameLb.Name = "empNameLb";
            this.empNameLb.Size = new System.Drawing.Size(175, 50);
            this.empNameLb.TabIndex = 4;
            this.empNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empIdLb
            // 
            this.empIdLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empIdLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdLb.Location = new System.Drawing.Point(522, 0);
            this.empIdLb.Margin = new System.Windows.Forms.Padding(0);
            this.empIdLb.Name = "empIdLb";
            this.empIdLb.Size = new System.Drawing.Size(174, 50);
            this.empIdLb.TabIndex = 3;
            this.empIdLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // billValueLb
            // 
            this.billValueLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billValueLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billValueLb.Location = new System.Drawing.Point(348, 0);
            this.billValueLb.Margin = new System.Windows.Forms.Padding(0);
            this.billValueLb.Name = "billValueLb";
            this.billValueLb.Size = new System.Drawing.Size(174, 50);
            this.billValueLb.TabIndex = 2;
            this.billValueLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // billPaymentDateLb
            // 
            this.billPaymentDateLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billPaymentDateLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billPaymentDateLb.Location = new System.Drawing.Point(174, 0);
            this.billPaymentDateLb.Margin = new System.Windows.Forms.Padding(0);
            this.billPaymentDateLb.Name = "billPaymentDateLb";
            this.billPaymentDateLb.Size = new System.Drawing.Size(174, 50);
            this.billPaymentDateLb.TabIndex = 1;
            this.billPaymentDateLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // billIdLb
            // 
            this.billIdLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billIdLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billIdLb.Location = new System.Drawing.Point(0, 0);
            this.billIdLb.Margin = new System.Windows.Forms.Padding(0);
            this.billIdLb.Name = "billIdLb";
            this.billIdLb.Size = new System.Drawing.Size(174, 50);
            this.billIdLb.TabIndex = 0;
            this.billIdLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BillItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "BillItem";
            this.Size = new System.Drawing.Size(871, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TransparentLabel billIdLb;
        private TransparentLabel empNameLb;
        private TransparentLabel empIdLb;
        private TransparentLabel billValueLb;
        private TransparentLabel billPaymentDateLb;
    }
}
