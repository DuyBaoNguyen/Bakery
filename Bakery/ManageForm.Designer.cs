namespace Bakery
{
    partial class ManageForm
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
            this.statisticPnl = new Bakery.StatisticPanel();
            this.accPnl = new Bakery.AccountPanel();
            this.billPnl = new Bakery.BillPanel();
            this.salPnl = new Bakery.SalaryPanel();
            this.empPnl = new Bakery.EmployeePanel();
            this.managePnl = new Bakery.ManagePanel();
            this.cakePnl = new Bakery.CakePanel();
            this.SuspendLayout();
            // 
            // statisticPnl
            // 
            this.statisticPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticPnl.Location = new System.Drawing.Point(0, 0);
            this.statisticPnl.Margin = new System.Windows.Forms.Padding(2);
            this.statisticPnl.Name = "statisticPnl";
            this.statisticPnl.Size = new System.Drawing.Size(1230, 764);
            this.statisticPnl.TabIndex = 6;
            // 
            // accPnl
            // 
            this.accPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accPnl.Location = new System.Drawing.Point(0, 0);
            this.accPnl.Margin = new System.Windows.Forms.Padding(2);
            this.accPnl.Name = "accPnl";
            this.accPnl.Size = new System.Drawing.Size(1230, 764);
            this.accPnl.TabIndex = 5;
            // 
            // billPnl
            // 
            this.billPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.billPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billPnl.Location = new System.Drawing.Point(0, 0);
            this.billPnl.Margin = new System.Windows.Forms.Padding(2);
            this.billPnl.Name = "billPnl";
            this.billPnl.Size = new System.Drawing.Size(1230, 764);
            this.billPnl.TabIndex = 4;
            // 
            // salPnl
            // 
            this.salPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salPnl.Location = new System.Drawing.Point(0, 0);
            this.salPnl.Margin = new System.Windows.Forms.Padding(4);
            this.salPnl.Name = "salPnl";
            this.salPnl.Size = new System.Drawing.Size(1230, 764);
            this.salPnl.TabIndex = 3;
            // 
            // empPnl
            // 
            this.empPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empPnl.Location = new System.Drawing.Point(0, 0);
            this.empPnl.Margin = new System.Windows.Forms.Padding(4);
            this.empPnl.Name = "empPnl";
            this.empPnl.Size = new System.Drawing.Size(1230, 764);
            this.empPnl.TabIndex = 2;
            // 
            // managePnl
            // 
            this.managePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managePnl.Location = new System.Drawing.Point(0, 0);
            this.managePnl.Margin = new System.Windows.Forms.Padding(5);
            this.managePnl.Name = "managePnl";
            this.managePnl.Size = new System.Drawing.Size(1230, 764);
            this.managePnl.TabIndex = 0;
            // 
            // cakePnl
            // 
            this.cakePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakePnl.Location = new System.Drawing.Point(0, 0);
            this.cakePnl.Margin = new System.Windows.Forms.Padding(5);
            this.cakePnl.Name = "cakePnl";
            this.cakePnl.Size = new System.Drawing.Size(1230, 764);
            this.cakePnl.TabIndex = 1;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 764);
            this.Controls.Add(this.managePnl);
            this.Controls.Add(this.cakePnl);
            this.Controls.Add(this.statisticPnl);
            this.Controls.Add(this.accPnl);
            this.Controls.Add(this.billPnl);
            this.Controls.Add(this.salPnl);
            this.Controls.Add(this.empPnl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private ManagePanel managePnl;
        private CakePanel cakePnl;
        private EmployeePanel empPnl;
        private SalaryPanel salPnl;
        private BillPanel billPnl;
        private AccountPanel accPnl;
        private StatisticPanel statisticPnl;
    }
}