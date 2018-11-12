namespace Bakery
{
    partial class EmployeeShortItem
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.empNameLb = new Bakery.TransparentLabel();
            this.empIdLb = new Bakery.TransparentLabel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.empNameLb, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.empIdLb, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(528, 50);
            this.tableLayoutPanel.TabIndex = 1;
            this.tableLayoutPanel.Click += new System.EventHandler(this.TableLayoutPanel_Click);
            // 
            // empNameLb
            // 
            this.empNameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empNameLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameLb.Location = new System.Drawing.Point(264, 0);
            this.empNameLb.Margin = new System.Windows.Forms.Padding(0);
            this.empNameLb.Name = "empNameLb";
            this.empNameLb.Size = new System.Drawing.Size(264, 50);
            this.empNameLb.TabIndex = 4;
            this.empNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empIdLb
            // 
            this.empIdLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empIdLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdLb.Location = new System.Drawing.Point(0, 0);
            this.empIdLb.Margin = new System.Windows.Forms.Padding(0);
            this.empIdLb.Name = "empIdLb";
            this.empIdLb.Size = new System.Drawing.Size(264, 50);
            this.empIdLb.TabIndex = 3;
            this.empIdLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmployeeShortItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "EmployeeShortItem";
            this.Size = new System.Drawing.Size(528, 50);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private TransparentLabel empNameLb;
        private TransparentLabel empIdLb;
    }
}
