namespace Bakery
{
    partial class EmployeeItem
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
            this.empDateOfJoinLb = new Bakery.TransparentLabel();
            this.empIdCodeLb = new Bakery.TransparentLabel();
            this.empNumberPhoneLb = new Bakery.TransparentLabel();
            this.empAddressLb = new Bakery.TransparentLabel();
            this.empBirthdayLb = new Bakery.TransparentLabel();
            this.empNameLb = new Bakery.TransparentLabel();
            this.empIdlb = new Bakery.TransparentLabel();
            this.empSexCkb = new Bakery.TransparentCheckBox();
            this.deleteBtn = new Bakery.CircularButton();
            this.containerPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPnl
            // 
            this.containerPnl.ColumnCount = 8;
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50328F));
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.containerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.containerPnl.Controls.Add(this.empDateOfJoinLb, 7, 0);
            this.containerPnl.Controls.Add(this.empIdCodeLb, 6, 0);
            this.containerPnl.Controls.Add(this.empNumberPhoneLb, 5, 0);
            this.containerPnl.Controls.Add(this.empAddressLb, 4, 0);
            this.containerPnl.Controls.Add(this.empBirthdayLb, 3, 0);
            this.containerPnl.Controls.Add(this.empNameLb, 1, 0);
            this.containerPnl.Controls.Add(this.empIdlb, 0, 0);
            this.containerPnl.Controls.Add(this.empSexCkb, 2, 0);
            this.containerPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPnl.Location = new System.Drawing.Point(0, 0);
            this.containerPnl.Margin = new System.Windows.Forms.Padding(4);
            this.containerPnl.Name = "containerPnl";
            this.containerPnl.RowCount = 1;
            this.containerPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerPnl.Size = new System.Drawing.Size(662, 50);
            this.containerPnl.TabIndex = 3;
            this.containerPnl.Click += new System.EventHandler(this.ContainerPnl_Click);
            // 
            // empDateOfJoinLb
            // 
            this.empDateOfJoinLb.AutoSize = true;
            this.empDateOfJoinLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empDateOfJoinLb.Location = new System.Drawing.Point(574, 0);
            this.empDateOfJoinLb.Margin = new System.Windows.Forms.Padding(0);
            this.empDateOfJoinLb.Name = "empDateOfJoinLb";
            this.empDateOfJoinLb.Size = new System.Drawing.Size(88, 50);
            this.empDateOfJoinLb.TabIndex = 7;
            this.empDateOfJoinLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empIdCodeLb
            // 
            this.empIdCodeLb.AutoSize = true;
            this.empIdCodeLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empIdCodeLb.Location = new System.Drawing.Point(492, 0);
            this.empIdCodeLb.Margin = new System.Windows.Forms.Padding(0);
            this.empIdCodeLb.Name = "empIdCodeLb";
            this.empIdCodeLb.Size = new System.Drawing.Size(82, 50);
            this.empIdCodeLb.TabIndex = 6;
            this.empIdCodeLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empNumberPhoneLb
            // 
            this.empNumberPhoneLb.AutoSize = true;
            this.empNumberPhoneLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empNumberPhoneLb.Location = new System.Drawing.Point(410, 0);
            this.empNumberPhoneLb.Margin = new System.Windows.Forms.Padding(0);
            this.empNumberPhoneLb.Name = "empNumberPhoneLb";
            this.empNumberPhoneLb.Size = new System.Drawing.Size(82, 50);
            this.empNumberPhoneLb.TabIndex = 5;
            this.empNumberPhoneLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empAddressLb
            // 
            this.empAddressLb.AutoSize = true;
            this.empAddressLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empAddressLb.Location = new System.Drawing.Point(328, 0);
            this.empAddressLb.Margin = new System.Windows.Forms.Padding(0);
            this.empAddressLb.Name = "empAddressLb";
            this.empAddressLb.Size = new System.Drawing.Size(82, 50);
            this.empAddressLb.TabIndex = 4;
            this.empAddressLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empBirthdayLb
            // 
            this.empBirthdayLb.AutoSize = true;
            this.empBirthdayLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empBirthdayLb.Location = new System.Drawing.Point(246, 0);
            this.empBirthdayLb.Margin = new System.Windows.Forms.Padding(0);
            this.empBirthdayLb.Name = "empBirthdayLb";
            this.empBirthdayLb.Size = new System.Drawing.Size(82, 50);
            this.empBirthdayLb.TabIndex = 3;
            this.empBirthdayLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empNameLb
            // 
            this.empNameLb.AutoSize = true;
            this.empNameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empNameLb.Location = new System.Drawing.Point(82, 0);
            this.empNameLb.Margin = new System.Windows.Forms.Padding(0);
            this.empNameLb.Name = "empNameLb";
            this.empNameLb.Size = new System.Drawing.Size(82, 50);
            this.empNameLb.TabIndex = 1;
            this.empNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empIdlb
            // 
            this.empIdlb.AutoSize = true;
            this.empIdlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empIdlb.Location = new System.Drawing.Point(0, 0);
            this.empIdlb.Margin = new System.Windows.Forms.Padding(0);
            this.empIdlb.Name = "empIdlb";
            this.empIdlb.Size = new System.Drawing.Size(82, 50);
            this.empIdlb.TabIndex = 0;
            this.empIdlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empSexCkb
            // 
            this.empSexCkb.AutoSize = true;
            this.empSexCkb.Location = new System.Drawing.Point(171, 4);
            this.empSexCkb.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.empSexCkb.Name = "empSexCkb";
            this.empSexCkb.Size = new System.Drawing.Size(18, 17);
            this.empSexCkb.TabIndex = 8;
            this.empSexCkb.UseVisualStyleBackColor = true;
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
            this.deleteBtn.Location = new System.Drawing.Point(662, 0);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.MouseEnterColor = System.Drawing.Color.Black;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(50, 50);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EmployeeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.containerPnl);
            this.Controls.Add(this.deleteBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "EmployeeItem";
            this.Size = new System.Drawing.Size(712, 50);
            this.Load += new System.EventHandler(this.EmployeeItem_Load);
            this.SizeChanged += new System.EventHandler(this.EmployeeItem_SizeChanged);
            this.containerPnl.ResumeLayout(false);
            this.containerPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CircularButton deleteBtn;
        private System.Windows.Forms.TableLayoutPanel containerPnl;
        private TransparentLabel empDateOfJoinLb;
        private TransparentLabel empIdCodeLb;
        private TransparentLabel empNumberPhoneLb;
        private TransparentLabel empAddressLb;
        private TransparentLabel empBirthdayLb;
        private TransparentLabel empNameLb;
        private TransparentLabel empIdlb;
        private TransparentCheckBox empSexCkb;
    }
}
