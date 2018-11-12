using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bakery.Other
{
    public static class Support
    {
        public static void EditScreen(this FlowLayoutPanel pnl, int left_margin, int top_margin)
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

        public static void EditScreenByWidth(this FlowLayoutPanel pnl)
        {
            if (pnl.Controls.Count > 0)
            {
                pnl.AutoScroll = false;
                using (VScrollBar scrollBar = new VScrollBar())
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        ctrl.Width = pnl.Width - scrollBar.Width * 2;
                    }
                }
                pnl.AutoScroll = true;
            }
        }

        public static void AddTitle(this ContextMenuStrip cms, string title)
        {
            ToolStripLabel titleToolStripLb = new ToolStripLabel();
            titleToolStripLb.Text = title;
            titleToolStripLb.Font = cms.Items[0].Font;
            titleToolStripLb.Margin = new Padding(0, 5, 0, 0);
            cms.Items.Insert(0, titleToolStripLb);

            ToolStripSeparator line = new ToolStripSeparator();
            cms.Items.Insert(1, line);
        }

        public static void AddDaysDataSource(this ComboBox cmb)
        {
            List<string> dataSource = new List<string>();
            dataSource.Add("Ngày");
            for (int i = 1; i <= 31; i++)
            {
                dataSource.Add(i.ToString());
            }
            cmb.DataSource = dataSource;
        }

        public static void AddMonthsDataSource(this ComboBox cmb)
        {
            List<string> dataSource = new List<string>();
            dataSource.Add("Tháng");
            for (int i = 1; i <= 12; i++)
            {
                dataSource.Add(i.ToString());
            }
            cmb.DataSource = dataSource;
        }

        public static void AddYearsDataSource(this ComboBox cmb, int startYear, int endYear)
        {
            List<string> dataSource = new List<string>();
            dataSource.Add("Năm");
            for (int i = startYear; i <= endYear; i++)
            {
                dataSource.Add(i.ToString());
            }
            cmb.DataSource = dataSource;
        }

        public static void InterleaveColor(this FlowLayoutPanel pnl, Color odd, Color even)
        {
            for (int i = 0; i < pnl.Controls.Count; i++)
            {
                if (i % 2 == 0)
                {
                    pnl.Controls[i].BackColor = odd;
                }
                else
                {
                    pnl.Controls[i].BackColor = even;
                }
            }
        }

        public static string ToShortString(this string str, Font font, int width)
        {
            if (str != null)
            {
                int w = TextRenderer.MeasureText(str, font).Width;
                if (width < w)
                {
                    string str_temp = String.Empty;
                    string endString = "...";
                    int widthEndString = TextRenderer.MeasureText(endString, font).Width;
                    for (int i = 0; i < str.Length; i++)
                    {
                        str_temp += str.Substring(i, 1);
                        w = TextRenderer.MeasureText(str_temp, font).Width;
                        if (w >= width - 20)
                        {
                            str = str_temp + endString;
                            break;
                        }
                    }
                }
            }
            return str;
        }

        public static byte[] ConvertToBytes(this Image x)
        {
            if (x != null)
            {
                ImageConverter _imageConverter = new ImageConverter();
                byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
                return xByte;
            }
            return null;
        }

        public static string ConvertToMoney(this string str)
        {
            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                count++;
                if (count == 3 && i != 0)
                {
                    str = str.Insert(i, ".");
                    count = 0;
                }
            }
            return str;
        }
    }
}
