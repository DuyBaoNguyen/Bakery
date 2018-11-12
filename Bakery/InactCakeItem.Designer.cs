namespace Bakery
{
    partial class InactCakeItem
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
            this.container = new Bakery.RoundPanel();
            this.restoreBtn = new Bakery.TransparentRoundButton();
            this.cakeCostLb = new Bakery.TransparentLabel();
            this.cakeNameLb = new Bakery.TransparentLabel();
            this.maskLb = new Bakery.TransparentLabel();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.container.BorderColor = System.Drawing.Color.Silver;
            this.container.BorderWidth = 1F;
            this.container.ClientRoundScale = 0.05F;
            this.container.Color = System.Drawing.Color.White;
            this.container.Controls.Add(this.restoreBtn);
            this.container.Controls.Add(this.cakeCostLb);
            this.container.Controls.Add(this.cakeNameLb);
            this.container.Controls.Add(this.maskLb);
            this.container.Cursor = System.Windows.Forms.Cursors.Hand;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Image = null;
            this.container.ImageHeight = 250;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(250, 338);
            this.container.TabIndex = 2;
            this.container.SizeChanged += new System.EventHandler(this.Container_SizeChanged);
            this.container.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Container_MouseDown);
            this.container.MouseEnter += new System.EventHandler(this.Container_MouseEnter);
            this.container.MouseLeave += new System.EventHandler(this.Container_MouseLeave);
            this.container.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Container_MouseUp);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.restoreBtn.BorderColor = System.Drawing.Color.Silver;
            this.restoreBtn.BorderWidth = 0F;
            this.restoreBtn.CenterImage = global::Bakery.Properties.Resources.refresh;
            this.restoreBtn.ClientRoundScale = 1F;
            this.restoreBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.restoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreBtn.FlatAppearance.BorderSize = 0;
            this.restoreBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.restoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.restoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreBtn.Location = new System.Drawing.Point(190, 278);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(50, 50);
            this.restoreBtn.TabIndex = 3;
            this.restoreBtn.UseVisualStyleBackColor = false;
            this.restoreBtn.Visible = false;
            // 
            // cakeCostLb
            // 
            this.cakeCostLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakeCostLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeCostLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.cakeCostLb.Location = new System.Drawing.Point(0, 294);
            this.cakeCostLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cakeCostLb.Name = "cakeCostLb";
            this.cakeCostLb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cakeCostLb.Size = new System.Drawing.Size(250, 44);
            this.cakeCostLb.TabIndex = 0;
            // 
            // cakeNameLb
            // 
            this.cakeNameLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.cakeNameLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeNameLb.ForeColor = System.Drawing.Color.Red;
            this.cakeNameLb.Location = new System.Drawing.Point(0, 250);
            this.cakeNameLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cakeNameLb.Name = "cakeNameLb";
            this.cakeNameLb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cakeNameLb.Size = new System.Drawing.Size(250, 44);
            this.cakeNameLb.TabIndex = 1;
            this.cakeNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskLb
            // 
            this.maskLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.maskLb.Location = new System.Drawing.Point(0, 0);
            this.maskLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maskLb.Name = "maskLb";
            this.maskLb.Size = new System.Drawing.Size(250, 250);
            this.maskLb.TabIndex = 2;
            // 
            // InactCakeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.container);
            this.Name = "InactCakeItem";
            this.Size = new System.Drawing.Size(250, 338);
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel container;
        private TransparentLabel cakeCostLb;
        private TransparentLabel cakeNameLb;
        private TransparentLabel maskLb;
        private TransparentRoundButton restoreBtn;
    }
}
