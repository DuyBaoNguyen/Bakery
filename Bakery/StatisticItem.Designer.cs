namespace Bakery
{
    partial class StatisticItem
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
            this.cakeAmountLb = new System.Windows.Forms.Label();
            this.cakeNameLb = new System.Windows.Forms.Label();
            this.cakeIdLb = new System.Windows.Forms.Label();
            this.cakeImgPnl = new Bakery.RoundPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Controls.Add(this.cakeAmountLb, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.cakeNameLb, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.cakeIdLb, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.cakeImgPnl, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(745, 90);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel_Paint);
            // 
            // cakeAmountLb
            // 
            this.cakeAmountLb.BackColor = System.Drawing.Color.Transparent;
            this.cakeAmountLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakeAmountLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeAmountLb.Location = new System.Drawing.Point(529, 0);
            this.cakeAmountLb.Name = "cakeAmountLb";
            this.cakeAmountLb.Size = new System.Drawing.Size(213, 90);
            this.cakeAmountLb.TabIndex = 3;
            this.cakeAmountLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cakeNameLb
            // 
            this.cakeNameLb.BackColor = System.Drawing.Color.Transparent;
            this.cakeNameLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakeNameLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeNameLb.Location = new System.Drawing.Point(311, 0);
            this.cakeNameLb.Name = "cakeNameLb";
            this.cakeNameLb.Size = new System.Drawing.Size(212, 90);
            this.cakeNameLb.TabIndex = 2;
            this.cakeNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cakeIdLb
            // 
            this.cakeIdLb.BackColor = System.Drawing.Color.Transparent;
            this.cakeIdLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cakeIdLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cakeIdLb.Location = new System.Drawing.Point(93, 0);
            this.cakeIdLb.Name = "cakeIdLb";
            this.cakeIdLb.Size = new System.Drawing.Size(212, 90);
            this.cakeIdLb.TabIndex = 0;
            this.cakeIdLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cakeImgPnl
            // 
            this.cakeImgPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cakeImgPnl.BorderWidth = 1F;
            this.cakeImgPnl.ClientRoundScale = 1F;
            this.cakeImgPnl.Color = System.Drawing.Color.White;
            this.cakeImgPnl.Image = null;
            this.cakeImgPnl.ImageHeight = 0;
            this.cakeImgPnl.Location = new System.Drawing.Point(5, 5);
            this.cakeImgPnl.Margin = new System.Windows.Forms.Padding(5);
            this.cakeImgPnl.Name = "cakeImgPnl";
            this.cakeImgPnl.Size = new System.Drawing.Size(80, 80);
            this.cakeImgPnl.TabIndex = 4;
            // 
            // StatisticItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "StatisticItem";
            this.Size = new System.Drawing.Size(745, 90);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label cakeAmountLb;
        private System.Windows.Forms.Label cakeNameLb;
        private System.Windows.Forms.Label cakeIdLb;
        private RoundPanel cakeImgPnl;
    }
}
