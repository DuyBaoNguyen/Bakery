namespace Bakery
{
    partial class CakePanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inactiveCakeBtn = new Bakery.RoundButton();
            this.homeBtn = new Bakery.RoundButton();
            this.activeCakeBtn = new Bakery.RoundButton();
            this.actCakePnl = new Bakery.ActCakePanel();
            this.inactCakePnl = new Bakery.InactCakePanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inactiveCakeBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.activeCakeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 62);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(590, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bánh";
            // 
            // inactiveCakeBtn
            // 
            this.inactiveCakeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inactiveCakeBtn.BackColor = System.Drawing.Color.Transparent;
            this.inactiveCakeBtn.BorderColor = System.Drawing.Color.Silver;
            this.inactiveCakeBtn.BorderWidth = 0F;
            this.inactiveCakeBtn.CenterImage = null;
            this.inactiveCakeBtn.ClientRoundScale = 1F;
            this.inactiveCakeBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.inactiveCakeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inactiveCakeBtn.FlatAppearance.BorderSize = 0;
            this.inactiveCakeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.inactiveCakeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inactiveCakeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.inactiveCakeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inactiveCakeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactiveCakeBtn.ForeColor = System.Drawing.Color.White;
            this.inactiveCakeBtn.Location = new System.Drawing.Point(191, 9);
            this.inactiveCakeBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.inactiveCakeBtn.Name = "inactiveCakeBtn";
            this.inactiveCakeBtn.Size = new System.Drawing.Size(182, 45);
            this.inactiveCakeBtn.TabIndex = 7;
            this.inactiveCakeBtn.Text = "Ngừng kinh doanh";
            this.inactiveCakeBtn.UseVisualStyleBackColor = false;
            this.inactiveCakeBtn.Click += new System.EventHandler(this.InactiveCakeBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.homeBtn.BorderWidth = 0F;
            this.homeBtn.CenterImage = global::Bakery.Properties.Resources.Left;
            this.homeBtn.ClientRoundScale = 1F;
            this.homeBtn.Color = System.Drawing.Color.Transparent;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Location = new System.Drawing.Point(6, 6);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(50, 50);
            this.homeBtn.TabIndex = 7;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // activeCakeBtn
            // 
            this.activeCakeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.activeCakeBtn.BackColor = System.Drawing.Color.Transparent;
            this.activeCakeBtn.BorderColor = System.Drawing.Color.Silver;
            this.activeCakeBtn.BorderWidth = 0F;
            this.activeCakeBtn.CenterImage = null;
            this.activeCakeBtn.ClientRoundScale = 1F;
            this.activeCakeBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.activeCakeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activeCakeBtn.FlatAppearance.BorderSize = 0;
            this.activeCakeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.activeCakeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.activeCakeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.activeCakeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activeCakeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCakeBtn.ForeColor = System.Drawing.Color.White;
            this.activeCakeBtn.Location = new System.Drawing.Point(62, 9);
            this.activeCakeBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.activeCakeBtn.Name = "activeCakeBtn";
            this.activeCakeBtn.Size = new System.Drawing.Size(125, 45);
            this.activeCakeBtn.TabIndex = 6;
            this.activeCakeBtn.Text = "Hoạt động";
            this.activeCakeBtn.UseVisualStyleBackColor = false;
            this.activeCakeBtn.Click += new System.EventHandler(this.ActiveCakeBtn_Click);
            // 
            // actCakePnl
            // 
            this.actCakePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actCakePnl.Location = new System.Drawing.Point(0, 62);
            this.actCakePnl.Margin = new System.Windows.Forms.Padding(4);
            this.actCakePnl.Name = "actCakePnl";
            this.actCakePnl.Size = new System.Drawing.Size(1250, 750);
            this.actCakePnl.TabIndex = 2;
            // 
            // inactCakePnl
            // 
            this.inactCakePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inactCakePnl.Location = new System.Drawing.Point(0, 0);
            this.inactCakePnl.Margin = new System.Windows.Forms.Padding(4);
            this.inactCakePnl.Name = "inactCakePnl";
            this.inactCakePnl.Size = new System.Drawing.Size(1250, 812);
            this.inactCakePnl.TabIndex = 3;
            // 
            // CakePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.actCakePnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inactCakePnl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CakePanel";
            this.Size = new System.Drawing.Size(1250, 812);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundButton homeBtn;
        private RoundButton inactiveCakeBtn;
        private RoundButton activeCakeBtn;
        private System.Windows.Forms.Label label1;
        private ActCakePanel actCakePnl;
        private InactCakePanel inactCakePnl;
    }
}
