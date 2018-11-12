namespace Bakery
{
    partial class AccountItem
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
            this.permissionLb = new Bakery.TransparentLabel();
            this.usernameLb = new Bakery.TransparentLabel();
            this.deleteBtn = new Bakery.CircularButton();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.Controls.Add(this.empNameLb, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.empIdLb, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.permissionLb, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.usernameLb, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(872, 50);
            this.tableLayoutPanel.TabIndex = 1;
            this.tableLayoutPanel.Click += new System.EventHandler(this.TableLayoutPanel_Click);
            // 
            // empNameLb
            // 
            this.empNameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empNameLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNameLb.Location = new System.Drawing.Point(654, 0);
            this.empNameLb.Margin = new System.Windows.Forms.Padding(0);
            this.empNameLb.Name = "empNameLb";
            this.empNameLb.Size = new System.Drawing.Size(218, 50);
            this.empNameLb.TabIndex = 4;
            this.empNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // empIdLb
            // 
            this.empIdLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empIdLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdLb.Location = new System.Drawing.Point(436, 0);
            this.empIdLb.Margin = new System.Windows.Forms.Padding(0);
            this.empIdLb.Name = "empIdLb";
            this.empIdLb.Size = new System.Drawing.Size(218, 50);
            this.empIdLb.TabIndex = 3;
            this.empIdLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // permissionLb
            // 
            this.permissionLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.permissionLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionLb.Location = new System.Drawing.Point(218, 0);
            this.permissionLb.Margin = new System.Windows.Forms.Padding(0);
            this.permissionLb.Name = "permissionLb";
            this.permissionLb.Size = new System.Drawing.Size(218, 50);
            this.permissionLb.TabIndex = 2;
            this.permissionLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usernameLb
            // 
            this.usernameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLb.Location = new System.Drawing.Point(0, 0);
            this.usernameLb.Margin = new System.Windows.Forms.Padding(0);
            this.usernameLb.Name = "usernameLb";
            this.usernameLb.Size = new System.Drawing.Size(218, 50);
            this.usernameLb.TabIndex = 1;
            this.usernameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.deleteBtn.Location = new System.Drawing.Point(872, 0);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.MouseEnterColor = System.Drawing.Color.Black;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(50, 50);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AccountItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.deleteBtn);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "AccountItem";
            this.Size = new System.Drawing.Size(922, 50);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private TransparentLabel empNameLb;
        private TransparentLabel empIdLb;
        private TransparentLabel permissionLb;
        private TransparentLabel usernameLb;
        private CircularButton deleteBtn;
    }
}
