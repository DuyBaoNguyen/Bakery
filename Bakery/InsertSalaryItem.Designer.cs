namespace Bakery
{
    partial class InsertSalaryItem
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
            this.roundPanel1 = new Bakery.RoundPanel();
            this.salValueTxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.empNameLb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.empIdLb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.roundPanel1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 50);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // empNameLb
            // 
            this.empNameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empNameLb.Location = new System.Drawing.Point(265, 0);
            this.empNameLb.Margin = new System.Windows.Forms.Padding(0);
            this.empNameLb.Name = "empNameLb";
            this.empNameLb.Size = new System.Drawing.Size(265, 50);
            this.empNameLb.TabIndex = 2;
            this.empNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empIdLb
            // 
            this.empIdLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empIdLb.Location = new System.Drawing.Point(0, 0);
            this.empIdLb.Margin = new System.Windows.Forms.Padding(0);
            this.empIdLb.Name = "empIdLb";
            this.empIdLb.Size = new System.Drawing.Size(265, 50);
            this.empIdLb.TabIndex = 1;
            this.empIdLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundPanel1
            // 
            this.roundPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.roundPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roundPanel1.BorderWidth = 2F;
            this.roundPanel1.ClientRoundScale = 0.25F;
            this.roundPanel1.Color = System.Drawing.Color.White;
            this.roundPanel1.Controls.Add(this.salValueTxt);
            this.roundPanel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundPanel1.Image = null;
            this.roundPanel1.ImageHeight = 0;
            this.roundPanel1.Location = new System.Drawing.Point(535, 5);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(255, 40);
            this.roundPanel1.TabIndex = 30;
            // 
            // salValueTxt
            // 
            this.salValueTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.salValueTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salValueTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salValueTxt.Location = new System.Drawing.Point(5, 9);
            this.salValueTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salValueTxt.Name = "salValueTxt";
            this.salValueTxt.Size = new System.Drawing.Size(248, 23);
            this.salValueTxt.TabIndex = 0;
            // 
            // InsertSalaryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "InsertSalaryItem";
            this.Size = new System.Drawing.Size(797, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TransparentLabel empNameLb;
        private TransparentLabel empIdLb;
        private RoundPanel roundPanel1;
        private System.Windows.Forms.TextBox salValueTxt;
    }
}
