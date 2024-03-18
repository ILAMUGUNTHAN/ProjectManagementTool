using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RoundedLabel: Label
    {
        public int BorderRadius { get; set; }
        public bool IsHighlighted
        {
            get
            {
                return isHighlighted;
            }
            set
            {
                if ((isHighlighted = value) == true)
                {
                    BackColor = HighlightColor;
                }
                else
                {
                    BackColor = NormalColor;
                }
            }
        }
        public Color NormalColor { get; set; }
        public Color HoverColor { get; set; }
        public Color ClickColor { get; set; }
        public Color HighlightColor {  get; set; }
        public RoundedLabel()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, BorderRadius, BorderRadius));
            AutoSize = false;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, BorderRadius, BorderRadius));
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!IsClicked && !isHighlighted)
            {
                BackColor = HoverColor;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (!IsClicked && !isHighlighted)
            {
                BackColor = NormalColor;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (ClickCount % 2 == 0)
            {
                BackColor = ClickColor;
                ForeColor = NormalColor;
                IsClicked = true;
            }
            else
            {
                BackColor = NormalColor;
                ForeColor = Color.FromArgb(82, 109, 130);
                if(isHighlighted)
                {
                    BackColor = HighlightColor;
                }
                IsClicked = false;
            }
            ClickCount++;
        }

        private bool IsClicked = false, isHighlighted = false;
        private int ClickCount = 0;
    }
}
