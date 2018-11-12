namespace Bakery
{
    partial class SalaryItem
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
            this.containerPnl = new System.Windows.Forms.TableLayoutPanel();
            this.empNameLb = new Bakery.TransparentLabel();
            this.salDateLb = new Bakery.TransparentLabel();
            this.salValueLb = new Bakery.TransparentLabel();
            this.empIdLb = new Bakery.TransparentLabel();
            this.deleteBtn = new Bakery.CircularButton();
            this.containerPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPnl
            // 
            this.containerPnl.ColumnCount = 4;
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.containerPnl.Controls.Add(this.empNameLb, 0, 0);
            this.containerPnl.Controls.Add(this.salDateLb, 2, 0);
            this.containerPnl.Controls.Add(this.salValueLb, 1, 0);
            this.containerPnl.Controls.Add(this.empIdLb, 0, 0);
            this.containerPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPnl.Location = new System.Drawing.Point(0, 0);
            this.containerPnl.Margin = new System.Windows.Forms.Padding(4);
            this.containerPnl.Name = "containerPnl";
            this.containerPnl.RowCount = 1;
            this.containerPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.containerPnl.Size = new System.Drawing.Size(705, 50);
            this.containerPnl.TabIndex = 5;
            this.containerPnl.Click += new System.EventHandler(this.ContainerPnl_Click);
            // 
            // empNameLb
            // 
            this.empNameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empNameLb.Location = new System.Drawing.Point(176, 0);
            this.empNameLb.Margin = new System.Windows.Forms.Padding(0);
            this.empNameLb.Name = "empNameLb";
            this.empNameLb.Size = new System.Drawing.Size(176, 50);
            this.empNameLb.TabIndex = 3;
            this.empNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salDateLb
            // 
            this.salDateLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salDateLb.Location = new System.Drawing.Point(528, 0);
            this.salDateLb.Margin = new System.Windows.Forms.Padding(0);
            this.salDateLb.Name = "salDateLb";
            this.salDateLb.Size = new System.Drawing.Size(177, 50);
            this.salDateLb.TabIndex = 2;
            this.salDateLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salValueLb
            // 
            this.salValueLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salValueLb.Location = new System.Drawing.Point(352, 0);
            this.salValueLb.Margin = new System.Windows.Forms.Padding(0);
            this.salValueLb.Name = "salValueLb";
            this.salValueLb.Size = new System.Drawing.Size(176, 50);
            this.salValueLb.TabIndex = 1;
            this.salValueLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empIdLb
            // 
            this.empIdLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empIdLb.Location = new System.Drawing.Point(0, 0);
            this.empIdLb.Margin = new System.Windows.Forms.Padding(0);
            this.empIdLb.Name = "empIdLb";
            this.empIdLb.Size = new System.Drawing.Size(176, 50);
            this.empIdLb.TabIndex = 0;
            this.empIdLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.deleteBtn.Location = new System.Drawing.Point(705, 0);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.MouseEnterColor = System.Drawing.Color.Black;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(50, 50);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SalaryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.containerPnl);
            this.Controls.Add(this.deleteBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "SalaryItem";
            this.Size = new System.Drawing.Size(755, 50);
            this.containerPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel containerPnl;
        private TransparentLabel empNameLb;
        private TransparentLabel salDateLb;
        private TransparentLabel salValueLb;
        private TransparentLabel empIdLb;
        private CircularButton deleteBtn;
    }
}
