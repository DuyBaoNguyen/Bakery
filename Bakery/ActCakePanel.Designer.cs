namespace Bakery
{
    partial class ActCakePanel
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.sortCakeCms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.actCakesPnl = new Bakery.FlowLayoutPanel();
            this.addCakeBtn = new Bakery.RoundButton();
            this.searchSb = new Bakery.SearchBox();
            this.sortBtn = new Bakery.RoundButton();
            this.refreshBtn = new Bakery.RoundButton();
            this.panel1.SuspendLayout();
            this.sortCakeCms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addCakeBtn);
            this.panel1.Controls.Add(this.searchSb);
            this.panel1.Controls.Add(this.sortBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 62);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 1);
            this.panel2.TabIndex = 3;
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
            this.sortCakeCms.Size = new System.Drawing.Size(151, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 28);
            this.toolStripMenuItem1.Text = "Tên bánh";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.SortProToolStrip_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 28);
            this.toolStripMenuItem2.Text = "Giá";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.SortProToolStrip_Click);
            // 
            // actCakesPnl
            // 
            this.actCakesPnl.AutoScroll = true;
            this.actCakesPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.actCakesPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actCakesPnl.Location = new System.Drawing.Point(0, 63);
            this.actCakesPnl.Margin = new System.Windows.Forms.Padding(4);
            this.actCakesPnl.Name = "actCakesPnl";
            this.actCakesPnl.Size = new System.Drawing.Size(850, 543);
            this.actCakesPnl.TabIndex = 5;
            this.actCakesPnl.SizeChanged += new System.EventHandler(this.CakePnl_SizeChanged);
            // 
            // addCakeBtn
            // 
            this.addCakeBtn.BackColor = System.Drawing.Color.Transparent;
            this.addCakeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.addCakeBtn.BorderWidth = 2F;
            this.addCakeBtn.CenterImage = global::Bakery.Properties.Resources.Add;
            this.addCakeBtn.ClientRoundScale = 1F;
            this.addCakeBtn.Color = System.Drawing.Color.Transparent;
            this.addCakeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCakeBtn.FlatAppearance.BorderSize = 0;
            this.addCakeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.addCakeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addCakeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addCakeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCakeBtn.Location = new System.Drawing.Point(503, 6);
            this.addCakeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addCakeBtn.Name = "addCakeBtn";
            this.addCakeBtn.Size = new System.Drawing.Size(50, 50);
            this.addCakeBtn.TabIndex = 12;
            this.addCakeBtn.UseVisualStyleBackColor = false;
            this.addCakeBtn.Click += new System.EventHandler(this.AddCakeBtn_Click);
            // 
            // searchSb
            // 
            this.searchSb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchSb.Location = new System.Drawing.Point(6, 6);
            this.searchSb.Margin = new System.Windows.Forms.Padding(2);
            this.searchSb.Name = "searchSb";
            this.searchSb.Size = new System.Drawing.Size(375, 50);
            this.searchSb.TabIndex = 6;
            this.searchSb.Search += new Bakery.SearchBox.SearchHandler(this.SearchCakeSb_Search);
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
            this.sortBtn.Location = new System.Drawing.Point(445, 6);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(50, 50);
            this.sortBtn.TabIndex = 5;
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.SortBtn_Click);
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
            this.refreshBtn.Location = new System.Drawing.Point(388, 6);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(50, 50);
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ActCakePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.actCakesPnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ActCakePanel";
            this.Size = new System.Drawing.Size(850, 606);
            this.Load += new System.EventHandler(this.SalePanel_Load);
            this.panel1.ResumeLayout(false);
            this.sortCakeCms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private SearchBox searchSb;
        private RoundButton sortBtn;
        private RoundButton refreshBtn;
        private System.Windows.Forms.Panel panel2;
        private FlowLayoutPanel actCakesPnl;
        private System.Windows.Forms.ContextMenuStrip sortCakeCms;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private RoundButton addCakeBtn;
    }
}
