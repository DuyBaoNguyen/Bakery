namespace Bakery
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.managerPnl = new Bakery.ManagerPanel();
            this.circularButton1 = new Bakery.CircularButton();
            this.salePnl = new Bakery.SalePanel();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.circularButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 60);
            this.panel1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 94);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 32);
            this.toolStripMenuItem1.Text = "Tên hiển thị";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(250, 32);
            this.toolStripMenuItem2.Text = "Đăng xuất";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Bakery.Properties.Resources.bakery;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // managerPnl
            // 
            this.managerPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerPnl.Location = new System.Drawing.Point(0, 60);
            this.managerPnl.Name = "managerPnl";
            this.managerPnl.Size = new System.Drawing.Size(1344, 710);
            this.managerPnl.TabIndex = 2;
            // 
            // circularButton1
            // 
            this.circularButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.circularButton1.BackColor = System.Drawing.Color.Transparent;
            this.circularButton1.BorderColor = System.Drawing.Color.Black;
            this.circularButton1.BorderWidth = 0F;
            this.circularButton1.CenterImage = null;
            this.circularButton1.Color = System.Drawing.Color.White;
            this.circularButton1.ContextMenuStrip = this.contextMenuStrip1;
            this.circularButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.circularButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.circularButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Location = new System.Drawing.Point(1288, 8);
            this.circularButton1.MouseEnterColor = System.Drawing.Color.Black;
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(44, 44);
            this.circularButton1.TabIndex = 6;
            this.circularButton1.UseVisualStyleBackColor = false;
            // 
            // salePnl
            // 
            this.salePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salePnl.Location = new System.Drawing.Point(0, 60);
            this.salePnl.Name = "salePnl";
            this.salePnl.Size = new System.Drawing.Size(1344, 710);
            this.salePnl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 770);
            this.Controls.Add(this.salePnl);
            this.Controls.Add(this.managerPnl);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CircularButton circularButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button button1;
        private ManagerPanel managerPnl;
        private SalePanel salePnl;
    }
}