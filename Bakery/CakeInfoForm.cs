using Bakery.HandleData;
using Bakery.MappingModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bakery
{
    public partial class CakeInfoForm : Form
    {
        Cake data;
        bool add;

        public Cake Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                if (data != null)
                {
                    cakeImagePnl.Image = data.Image;
                    cakeNameTxt.Text = data.Name;
                    cakeCostTxt.Text = data.Cost.ToString();
                }
                else
                {
                    cakeImagePnl.Image = null;
                    cakeNameTxt.Text = "";
                    cakeCostTxt.Text = "";
                }
            }
        }
        
        public CakeInfoForm(bool add)
        {
            InitializeComponent();
            this.add = add;
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            bool flag;
            Cake cake = new Cake();
            cake.Name = cakeNameTxt.Text;
            cake.Image = cakeImagePnl.Image;
            if (int.TryParse(cakeCostTxt.Text, out int cost))
            {
                cake.Cost = cost;
            }
            else
            {
                cake.Cost = -1;
            }
            cake.Active = true;

            if (add)
            {
                flag = CakeData.Instance.AddCake(cake, ref error);
            }
            else
            {
                cake.Id = data.Id;
                flag = CakeData.Instance.EditCake(cake, ref error);
            }

            if (!flag)
            {
                MessageBox.Show(error, "Thông báo");
            }
            else
            {
                this.Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "All Image files | *.png; *.bmp; *.jpg";
            string filter = openDlg.Filter;
            openDlg.Title = "Open a Image File";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                cakeImagePnl.Image = Image.FromFile(openDlg.FileName);
            }
            openDlg.Dispose();
        }

        private void DelImgBtn_Click(object sender, EventArgs e)
        {
            cakeImagePnl.Image = null;
        }
    }
}
