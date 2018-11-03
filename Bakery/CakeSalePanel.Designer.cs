namespace Bakery
{
    partial class CakeSalePanel
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchCakeSb = new Bakery.SearchBox();
            this.sortBtn = new Bakery.RoundButton();
            this.sortCakeCms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshBtn = new Bakery.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loadPtb = new System.Windows.Forms.PictureBox();
            this.cakePnl = new Bakery.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.sortCakeCms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadPtb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.searchCakeSb);
            this.panel1.Controls.Add(this.sortBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 50);
            this.panel1.TabIndex = 0;
            // 
            // searchCakeSb
            // 
            this.searchCakeSb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchCakeSb.Location = new System.Drawing.Point(4, 5);
            this.searchCakeSb.Margin = new System.Windows.Forms.Padding(2);
            this.searchCakeSb.Name = "searchCakeSb";
            this.searchCakeSb.Size = new System.Drawing.Size(300, 41);
            this.searchCakeSb.TabIndex = 6;
            this.searchCakeSb.Search += new Bakery.SearchBox.SearchHandler(this.SearchCakeSb_Search);
            // 
            // sortBtn
            // 
            this.sortBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sortBtn.BackColor = System.Drawing.Color.Transparent;
            this.sortBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sortBtn.BorderWidth = 2F;
            this.sortBtn.CenterImage = global::Bakery.Properties.Resources.down;
            this.sortBtn.ClientRoundScale = 1F;
            this.sortBtn.Color = System.Drawing.Color.Transparent;
            this.sortBtn.ContextMenuStrip = this.sortCakeCms;
            this.sortBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortBtn.FlatAppearance.BorderSize = 0;
            this.sortBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.sortBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sortBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.Location = new System.Drawing.Point(355, 5);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(40, 40);
            this.sortBtn.TabIndex = 5;
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // sortCakeCms
            // 
            this.sortCakeCms.BackColor = System.Drawing.Color.White;
            this.sortCakeCms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortCakeCms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sortCakeCms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.sortCakeCms.Name = "sortCakeCms";
            this.sortCakeCms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.sortCakeCms.Size = new System.Drawing.Size(135, 62);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.toolStripMenuItem1.Text = "Tên bánh";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.SortProToolStrip_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 24);
            this.toolStripMenuItem2.Text = "Giá";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.SortProToolStrip_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.refreshBtn.BorderWidth = 2F;
            this.refreshBtn.CenterImage = global::Bakery.Properties.Resources.refresh;
            this.refreshBtn.ClientRoundScale = 1F;
            this.refreshBtn.Color = System.Drawing.Color.Transparent;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Location = new System.Drawing.Point(309, 5);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(40, 40);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 1);
            this.panel2.TabIndex = 1;
            // 
            // loadPtb
            // 
            this.loadPtb.BackColor = System.Drawing.Color.White;
            this.loadPtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadPtb.Enabled = false;
            this.loadPtb.Image = global::Bakery.Properties.Resources.Load;
            this.loadPtb.Location = new System.Drawing.Point(0, 51);
            this.loadPtb.Margin = new System.Windows.Forms.Padding(2);
            this.loadPtb.Name = "loadPtb";
            this.loadPtb.Size = new System.Drawing.Size(786, 458);
            this.loadPtb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadPtb.TabIndex = 0;
            this.loadPtb.TabStop = false;
            // 
            // cakePnl
            // 
            this.cakePnl.AutoScroll = true;
            this.cakePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.cakePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakePnl.Location = new System.Drawing.Point(0, 51);
            this.cakePnl.Name = "cakePnl";
            this.cakePnl.Size = new System.Drawing.Size(786, 458);
            this.cakePnl.TabIndex = 2;
            this.cakePnl.SizeChanged += new System.EventHandler(this.CakePnl_SizeChanged);
            // 
            // CakeSalePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.cakePnl);
            this.Controls.Add(this.loadPtb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CakeSalePanel";
            this.Size = new System.Drawing.Size(786, 509);
            this.panel1.ResumeLayout(false);
            this.sortCakeCms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadPtb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RoundButton refreshBtn;
        private FlowLayoutPanel cakePnl;
        private RoundButton sortBtn;
        private System.Windows.Forms.PictureBox loadPtb;
        private System.Windows.Forms.ContextMenuStrip sortCakeCms;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private SearchBox searchCakeSb;
    }
}
