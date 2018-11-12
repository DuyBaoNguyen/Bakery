namespace Bakery
{
    partial class CakeInfoForm
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
            this.cakeImagePnl = new Bakery.RoundPanel();
            this.editImgBtn = new Bakery.RoundButton();
            this.delImgBtn = new Bakery.RoundButton();
            this.roundPanel1 = new Bakery.RoundPanel();
            this.cakeNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roundPanel3 = new Bakery.RoundPanel();
            this.cakeCostTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new Bakery.RoundButton();
            this.cancelBtn = new Bakery.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cakeImagePnl.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.roundPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cakeImagePnl
            // 
            this.cakeImagePnl.BorderColor = System.Drawing.Color.Silver;
            this.cakeImagePnl.BorderWidth = 1F;
            this.cakeImagePnl.ClientRoundScale = 0.1F;
            this.cakeImagePnl.Color = System.Drawing.Color.White;
            this.cakeImagePnl.Controls.Add(this.editImgBtn);
            this.cakeImagePnl.Controls.Add(this.delImgBtn);
            this.cakeImagePnl.Image = null;
            this.cakeImagePnl.ImageHeight = 0;
            this.cakeImagePnl.Location = new System.Drawing.Point(15, 8);
            this.cakeImagePnl.Margin = new System.Windows.Forms.Padding(4);
            this.cakeImagePnl.Name = "cakeImagePnl";
            this.cakeImagePnl.Size = new System.Drawing.Size(300, 300);
            this.cakeImagePnl.TabIndex = 7;
            // 
            // editImgBtn
            // 
            this.editImgBtn.BackColor = System.Drawing.Color.Transparent;
            this.editImgBtn.BorderColor = System.Drawing.Color.Silver;
            this.editImgBtn.BorderWidth = 0F;
            this.editImgBtn.CenterImage = global::Bakery.Properties.Resources.edit;
            this.editImgBtn.ClientRoundScale = 1F;
            this.editImgBtn.Color = System.Drawing.Color.Transparent;
            this.editImgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editImgBtn.FlatAppearance.BorderSize = 0;
            this.editImgBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.editImgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editImgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editImgBtn.Location = new System.Drawing.Point(193, 247);
            this.editImgBtn.Name = "editImgBtn";
            this.editImgBtn.Size = new System.Drawing.Size(50, 50);
            this.editImgBtn.TabIndex = 1;
            this.editImgBtn.UseVisualStyleBackColor = false;
            this.editImgBtn.Click += new System.EventHandler(this.EditImgBtn_Click);
            // 
            // delImgBtn
            // 
            this.delImgBtn.BackColor = System.Drawing.Color.Transparent;
            this.delImgBtn.BorderColor = System.Drawing.Color.Silver;
            this.delImgBtn.BorderWidth = 0F;
            this.delImgBtn.CenterImage = global::Bakery.Properties.Resources.garbagebin;
            this.delImgBtn.ClientRoundScale = 1F;
            this.delImgBtn.Color = System.Drawing.Color.Transparent;
            this.delImgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delImgBtn.FlatAppearance.BorderSize = 0;
            this.delImgBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.delImgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.delImgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.delImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delImgBtn.Location = new System.Drawing.Point(247, 247);
            this.delImgBtn.Name = "delImgBtn";
            this.delImgBtn.Size = new System.Drawing.Size(50, 50);
            this.delImgBtn.TabIndex = 0;
            this.delImgBtn.UseVisualStyleBackColor = false;
            this.delImgBtn.Click += new System.EventHandler(this.DelImgBtn_Click);
            // 
            // roundPanel1
            // 
            this.roundPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roundPanel1.BorderWidth = 2F;
            this.roundPanel1.ClientRoundScale = 0.25F;
            this.roundPanel1.Color = System.Drawing.Color.White;
            this.roundPanel1.Controls.Add(this.cakeNameTxt);
            this.roundPanel1.Image = null;
            this.roundPanel1.ImageHeight = 0;
            this.roundPanel1.Location = new System.Drawing.Point(326, 113);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(235, 40);
            this.roundPanel1.TabIndex = 31;
            // 
            // cakeNameTxt
            // 
            this.cakeNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cakeNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cakeNameTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeNameTxt.Location = new System.Drawing.Point(5, 9);
            this.cakeNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cakeNameTxt.Name = "cakeNameTxt";
            this.cakeNameTxt.Size = new System.Drawing.Size(226, 23);
            this.cakeNameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên bánh";
            // 
            // roundPanel3
            // 
            this.roundPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.roundPanel3.BorderWidth = 2F;
            this.roundPanel3.ClientRoundScale = 0.25F;
            this.roundPanel3.Color = System.Drawing.Color.White;
            this.roundPanel3.Controls.Add(this.cakeCostTxt);
            this.roundPanel3.Image = null;
            this.roundPanel3.ImageHeight = 0;
            this.roundPanel3.Location = new System.Drawing.Point(326, 196);
            this.roundPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(235, 40);
            this.roundPanel3.TabIndex = 33;
            // 
            // cakeCostTxt
            // 
            this.cakeCostTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cakeCostTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cakeCostTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeCostTxt.Location = new System.Drawing.Point(5, 9);
            this.cakeCostTxt.Margin = new System.Windows.Forms.Padding(4);
            this.cakeCostTxt.Name = "cakeCostTxt";
            this.cakeCostTxt.Size = new System.Drawing.Size(226, 23);
            this.cakeCostTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Giá";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 321);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 55);
            this.panel1.TabIndex = 46;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BorderColor = System.Drawing.Color.Silver;
            this.saveBtn.BorderWidth = 0F;
            this.saveBtn.CenterImage = null;
            this.saveBtn.ClientRoundScale = 1F;
            this.saveBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(305, 5);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(125, 45);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BorderColor = System.Drawing.Color.Silver;
            this.cancelBtn.BorderWidth = 0F;
            this.cancelBtn.CenterImage = null;
            this.cancelBtn.ClientRoundScale = 1F;
            this.cancelBtn.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(436, 5);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(125, 45);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 320);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 1);
            this.panel2.TabIndex = 47;
            // 
            // CakeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 376);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundPanel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cakeImagePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CakeInfoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.cakeImagePnl.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundPanel cakeImagePnl;
        private RoundPanel roundPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cakeNameTxt;
        private RoundPanel roundPanel3;
        private System.Windows.Forms.TextBox cakeCostTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private RoundButton saveBtn;
        private RoundButton cancelBtn;
        private RoundButton editImgBtn;
        private RoundButton delImgBtn;
        private System.Windows.Forms.Panel panel2;
    }
}