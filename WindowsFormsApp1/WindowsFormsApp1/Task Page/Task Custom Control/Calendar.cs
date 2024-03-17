using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Calendar : Form
    {
        public Task CalendarTask { get; set; }
        public Calendar()
        {
            InitializeComponent();
            startDateText.GotFocus += RemoveStartDateText;
            startDateText.LostFocus += AddStartDateText;
            endDateText.GotFocus += RemoveEndDateText;
            endDateText.LostFocus += AddEndDateText;
        }

        private const int CSDropShadow = 0x00020000;

        public void RemoveStartDateText(object sender, EventArgs e)
        {
            if (startDateText.Text == "Start Date    (dd/mm/yy)")
            {
                startDateText.Text = "";
            }
            b1 = new SolidBrush(Color.FromArgb(201, 210, 217));
            startDateText.BackColor = Color.FromArgb(201, 210, 217);
            this.Invalidate();
        }

        public void AddStartDateText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(startDateText.Text))
                startDateText.Text = "Start Date    (dd/mm/yy)";

            b1 = new SolidBrush(Color.FromArgb(221, 230, 237));
            startDateText.BackColor = Color.FromArgb(221, 230, 237);
            this.Invalidate();
        }

        public void RemoveEndDateText(object sender, EventArgs e)
        {
            if (endDateText.Text == "End Date    (dd/mm/yy)")
            {
                endDateText.Text = "";
            }
            b2 = new SolidBrush(Color.FromArgb(201, 210, 217));
            endDateText.BackColor = Color.FromArgb(201, 210, 217);
            this.Invalidate();
        }

        public void AddEndDateText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(endDateText.Text))
                endDateText.Text = "End Date    (dd/mm/yy)";
            b2 = new SolidBrush(Color.FromArgb(221, 230, 237));
            endDateText.BackColor = Color.FromArgb(221, 230, 237);
            this.Invalidate();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
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

        private void OnCalendarLoad(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            left = new Rectangle(0, 0, Width / 2, 50);
            right = new Rectangle(Width / 2, 0, Width / 2, 50);
            SetTaskDate();
            SetTablePanel();
        }

        private void OnHighlightMouseEnter(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.FromArgb(201, 210, 217));
            (sender as PictureBox).Parent.Invalidate();
        }

        private void OnHighlightMouseLeave(object sender, EventArgs e)
        {
            brush = new SolidBrush(Color.FromArgb(221, 230, 237));
            (sender as PictureBox).Parent.Invalidate();
        }

        private void OnHighlightPaint(object sender, PaintEventArgs e)
        {
            int width = (sender as Panel).Width;
            int height = (sender as Panel).Height;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(brush, 0, 0, width, height, 10);
        }
        private void OnTablePanelPaint5(object sender, PaintEventArgs e)
        {
            int width = (sender as TableLayoutPanel).Width;
            int height = (sender as TableLayoutPanel).Height;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(b2, 0, 0, width, height, 5);
        }

        private void OnTablePanelPaint4(object sender, PaintEventArgs e)
        {
            int width = (sender as TableLayoutPanel).Width;
            int height = (sender as TableLayoutPanel).Height;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(b1, 0, 0, width, height, 5);
            g.DrawLine(new Pen(Color.Gray), new Point(width - 1, 0), new Point(width - 1, height));
        }

        private void OnCalendarPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 50, 170, 450);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(82, 109, 130)), rec);
            e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(0, 50), new Point(750, 50));

            e.Graphics.FillRectangle(b1, left);
            e.Graphics.FillRectangle(b2, right);
        }

        Rectangle left, right;
        Brush brush = new SolidBrush(Color.FromArgb(221, 230, 237));
        Brush b1 = new SolidBrush(Color.FromArgb(221, 230, 237));
        Brush b2 = new SolidBrush(Color.FromArgb(221, 230, 237));

        private void SetTaskDate()
        {
            if(CalendarTask==null)
            {
                currentMonth = DateTime.Today.Month;
                currentYear = DateTime.Today.Year;
                newDate = new DateTime(currentYear, currentMonth, 1);
                startCol = (int)newDate.DayOfWeek;
            }
            else
            {
                currentMonth = CalendarTask.StartDate.Month;
                currentYear = CalendarTask.StartDate.Year;
                newDate = new DateTime(currentYear, currentMonth, 1);
                startCol = (int)newDate.DayOfWeek;
            }

            MonthDetails = new List<string>()
            {
                "Jan", "Feb", "Mar", "Apr", "May", "Jun", "July", "Aug", "Sept", "Oct", "Nov", "Dec"
            };
            monthYearLabel.Text = MonthDetails[currentMonth - 1] + " " + currentYear;
        }

        private void SetTablePanel()
        {
            if (currentMonth-1 == 2 && currentYear % 4 == 0)
            {
                dayCounter = 29;
            }

            if (currentMonth - 1 == 2 && currentYear % 4 != 0)
            {
                dayCounter = 28;
            }

            if (currentMonth - 1 == 1 || currentMonth - 1 == 3 || currentMonth - 1 == 5 || currentMonth - 1 == 7 || currentMonth - 1 == 8 || currentMonth - 1 == 10 || currentMonth - 1 == 0) 
            {
                dayCounter = 31;
            }

            if (currentMonth - 1 == 4 || currentMonth - 1 == 6 || currentMonth - 1 == 9 || currentMonth - 1 == 11) 
            {
                dayCounter = 30;
            }

            for (int ctr=startCol-1;ctr>=0; ctr--)
            {
                dayTablePanel.GetControlFromPosition(ctr, 0).Text = dayCounter.ToString();
                dayCounter--;
            }

            dayCounter = 1;
            for(int row=0; row<6; row++)
            {
                for(int col = startCol; col<7; col++)
                {
                    dayTablePanel.GetControlFromPosition(col, row).Text = dayCounter.ToString();

                    if(dayCounter == DateTime.Today.Day && currentMonth == DateTime.Today.Month && currentYear == DateTime.Today.Year)
                    {
                        (dayTablePanel.GetControlFromPosition(col, row) as RoundedLabel).IsHighlighted = true;
                    }
                    else
                    {
                        (dayTablePanel.GetControlFromPosition(col, row) as RoundedLabel).IsHighlighted = false;
                    }
                    dayTablePanel.GetControlFromPosition(col, row).Invalidate();
                    dayCounter++;
                    ResetDayCounter();
                }
                startCol = 0;
            }
        }

        private void ResetDayCounter()
        {

            if (currentMonth == 2 && ((currentYear % 4 == 0 && dayCounter == 30) || currentYear % 4 != 0 && dayCounter == 29))
            {
                dayCounter = 1;
            }

            if((currentMonth == 1 || currentMonth == 3 || currentMonth==5 || currentMonth==7 ||currentMonth==8 ||currentMonth==10 || currentMonth == 12) && (dayCounter==32))
            {
                dayCounter = 1;
            }

            if ((currentMonth == 4 || currentMonth == 6 || currentMonth == 9 || currentMonth == 11) && (dayCounter == 31))
            {
                dayCounter = 1;
            }
        }

        int currentMonth = 0, currentYear = 0, startCol = 0, dayCounter = 1;
        private void OnForwardMonthClick(object sender, EventArgs e)
        {
            if (currentMonth == 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            else
            {
                currentMonth++;
            }
            monthYearLabel.Text = MonthDetails[currentMonth - 1] + " " + currentYear;
            newDate = new DateTime(currentYear, currentMonth, 1);
            startCol = (int)newDate.DayOfWeek;
            SetTablePanel();
        }

        private void OnDayClicked(object sender, EventArgs e)
        {
            if (!isStartHighlighted)
            {
                //CalendarTask.StartDate = new DateTime(currentYear, currentMonth, Convert.ToInt32((sender as RoundedLabel).Text));
                startDateText.Text = (sender as RoundedLabel).Text + "/" + currentMonth + "/" + currentYear;
                isStartHighlighted = true;
            }
            else if (!isEndHighlighted)
            {
                endDateText.Text = (sender as RoundedLabel).Text + "/" + currentMonth + "/" + currentYear;
                isEndHighlighted = true;
            }
        }

        private void OnMonthBackwardClick(object sender, EventArgs e)
        {
            if(currentMonth == 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            else
            {
                currentMonth--;
            }
            monthYearLabel.Text = MonthDetails[currentMonth - 1] + " " + currentYear;
            newDate = new DateTime(currentYear, currentMonth, 1);
            startCol = (int)newDate.DayOfWeek;
            SetTablePanel();
        }

        
        private bool isStartHighlighted, isEndHighlighted;
        List<string> MonthDetails;
        DateTime newDate;
    }
}
