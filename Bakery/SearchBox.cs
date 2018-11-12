using System;
using System.Windows.Forms;

namespace Bakery
{
    public partial class SearchBox : UserControl
    {
        public delegate void SearchHandler(object sender, EventArgs e);
        public event SearchHandler Search;

        public override string Text
        {
            get
            {
                return searchTxt.Text;
            }
        }

        public SearchBox()
        {
            InitializeComponent();
        }

        protected virtual void OnSearch(EventArgs e)
        {
            if (Search != null)
            {
                Search(this, e);
            }
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                deleteBtn.Visible = true;
            }
            else
            {
                deleteBtn.Visible = false;
            }
        }

        private void SearchPnl_Click(object sender, EventArgs e)
        {
            searchTxt.Focus();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            OnSearch(null);
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OnSearch(null);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            searchTxt.Text = "";
        }
    }
}
