namespace Bakery
{
    partial class SearchBox
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
            this.searchPnl = new Bakery.RoundPanel();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.deleteBtn = new Bakery.RoundButton();
            this.searchBtn = new Bakery.RoundButton();
            this.searchPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPnl
            // 
            this.searchPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.searchPnl.BorderWidth = 2F;
            this.searchPnl.ClientRoundScale = 1F;
            this.searchPnl.Color = System.Drawing.Color.White;
            this.searchPnl.Controls.Add(this.searchTxt);
            this.searchPnl.Controls.Add(this.deleteBtn);
            this.searchPnl.Controls.Add(this.searchBtn);
            this.searchPnl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPnl.Image = null;
            this.searchPnl.ImageHeight = 0;
            this.searchPnl.Location = new System.Drawing.Point(0, 0);
            this.searchPnl.Name = "searchPnl";
            this.searchPnl.Size = new System.Drawing.Size(320, 40);
            this.searchPnl.TabIndex = 1;
            this.searchPnl.Click += new System.EventHandler(this.SearchPnl_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(43, 10);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(2);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(234, 22);
            this.searchTxt.TabIndex = 2;
            this.searchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTxt_KeyDown);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BorderColor = System.Drawing.Color.Silver;
            this.deleteBtn.BorderWidth = 0F;
            this.deleteBtn.CenterImage = global::Bakery.Properties.Resources.exit_small;
            this.deleteBtn.ClientRoundScale = 1F;
            this.deleteBtn.Color = System.Drawing.Color.Transparent;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Location = new System.Drawing.Point(280, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(40, 40);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BorderColor = System.Drawing.Color.Silver;
            this.searchBtn.BorderWidth = 0F;
            this.searchBtn.CenterImage = global::Bakery.Properties.Resources.search;
            this.searchBtn.ClientRoundScale = 1F;
            this.searchBtn.Color = System.Drawing.Color.Transparent;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.searchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Location = new System.Drawing.Point(0, 0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(40, 40);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.searchPnl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(320, 40);
            this.searchPnl.ResumeLayout(false);
            this.searchPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel searchPnl;
        private RoundButton deleteBtn;
        private RoundButton searchBtn;
        private System.Windows.Forms.TextBox searchTxt;
    }
}
