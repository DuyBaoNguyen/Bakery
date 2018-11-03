using System;
using System.Windows.Forms;

namespace Bakery.Other
{
    public class Support
    {
        public static void EditSreen(FlowLayoutPanel pnl, int left_margin, int top_margin)
        {
            if (pnl.Controls.Count > 0)
            {
                pnl.AutoScroll = false; 
                int width = pnl.Width;
                int hor_num_ctrl = (pnl.Width - left_margin * 2) / (left_margin * 2 + pnl.Controls[0].Width);
                int vel_num_ctrl = (int)Math.Ceiling(pnl.Controls.Count * 1.0 / hor_num_ctrl);

                if ((top_margin + pnl.Controls[0].Height) * vel_num_ctrl > pnl.Height)
                {
                    using (VScrollBar scrollBar = new VScrollBar())
                    {
                        width = pnl.Width - scrollBar.Width;
                    }
                }

                left_margin = (width - pnl.Controls[0].Width * hor_num_ctrl) / (2 * (hor_num_ctrl + 1));
                pnl.Padding = new Padding(left_margin, 0, 0, 0);
                for (int i = 0; i < pnl.Controls.Count; i++)
                {
                    pnl.Controls[i].Margin = new Padding(left_margin, top_margin, left_margin, top_margin);
                }
                pnl.AutoScroll = true;
            }
        }
    }
}
