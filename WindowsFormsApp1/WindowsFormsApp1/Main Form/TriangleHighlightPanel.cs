using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class TriangleHighlightPanel:Panel
    {
        public bool IsHighlighted 
        { 
            set
            {
                isHighlighted = value;
                this.Invalidate();
            } 
        }
        public Color HighlightColor { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            base.OnPaint(e);
            if(isHighlighted)
            {
                Brush brush = new SolidBrush(HighlightColor);
                e.Graphics.FillPolygon(brush, new Point[]
                {
                    new Point(Width, 0),
                    new Point(0, Height/2),
                    new Point(Width, Height)
                });

                brush.Dispose();
            }
        }

        private bool isHighlighted = false;
    }
}
