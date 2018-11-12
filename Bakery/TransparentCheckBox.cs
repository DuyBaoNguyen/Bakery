using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class TransparentCheckBox : CheckBox
    {
        public TransparentCheckBox()
        {
            InitializeComponent();
        }

        private const int WM_NCHITTEST = 0x0084;
        private const int HTTRANSPARENT = (-1);

        /// <summary>
        /// Overrides the standard Window Procedure to ensure the
        /// window is transparent to all mouse events.
        /// </summary>
        /// <param name="m">Windows message to process.</param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTTRANSPARENT;
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
