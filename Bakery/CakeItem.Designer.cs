namespace Bakery
{
    partial class CakeItem
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
            this.container.Controls.Add(this.cakeCostLb);
            this.container.Controls.Add(this.cakeNameLb);
            this.container.Controls.Add(this.maskLb);
            this.container.Cursor = System.Windows.Forms.Cursors.Hand;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Image = null;
            this.container.ImageHeight = 200;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(200, 270);
            this.container.TabIndex = 0;
            this.container.SizeChanged += new System.EventHandler(this.Container_SizeChanged);
            this.container.Click += new System.EventHandler(this.Container_Click);
            this.container.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Container_MouseDown);
            this.container.MouseEnter += new System.EventHandler(this.Container_MouseEnter);
            this.container.MouseLeave += new System.EventHandler(this.Container_MouseLeave);
            this.container.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Container_MouseUp);
            // 
            // cakeCostLb
            // 
            this.cakeCostLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakeCostLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeCostLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.cakeCostLb.Location = new System.Drawing.Point(0, 235);
            this.cakeCostLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cakeCostLb.Name = "cakeCostLb";
            this.cakeCostLb.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cakeCostLb.Size = new System.Drawing.Size(200, 35);
            this.cakeCostLb.TabIndex = 0;
            // 
            // cakeNameLb
            // 
            this.cakeNameLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.cakeNameLb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeNameLb.ForeColor = System.Drawing.Color.Red;
            this.cakeNameLb.Location = new System.Drawing.Point(0, 200);
            this.cakeNameLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cakeNameLb.Name = "cakeNameLb";
            this.cakeNameLb.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cakeNameLb.Size = new System.Drawing.Size(200, 35);
            this.cakeNameLb.TabIndex = 1;
            this.cakeNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskLb
            // 
            this.maskLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.maskLb.Location = new System.Drawing.Point(0, 0);
            this.maskLb.Name = "maskLb";
            this.maskLb.Size = new System.Drawing.Size(200, 200);
            this.maskLb.TabIndex = 2;
            // 
            // CakeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.container);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CakeItem";
            this.Size = new System.Drawing.Size(200, 270);
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundPanel container;
        private TransparentLabel cakeNameLb;
        private TransparentLabel cakeCostLb;
        private TransparentLabel maskLb;
    }
}
