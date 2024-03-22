using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.BarChart
{
    public partial class UCBarChart : UserControl
    {
        public UCBarChart()
        {
            InitializeComponent();
            StatusValues = new int[4] {10,44,20,30};
            MaxHeights = new double[4];
            SetBarHeightToZero();
        }

       
        //statusValues order = done, InProgress, struck, Not started
        public int[] StatusValues { get; set; }
        public Employee EmpDetails { get; set; }
        public Color BarColor { get; set; }

        private double[] MaxHeights;

        //private int TaskCount { get; set; }
        private int MaxStatusValue = 0;
        private double OnePercentValue = 0;

        Timer timer;

        private void OnLoadUc(object sender, EventArgs e)
        {
            SetMaxStatusVal();
            if(MaxStatusValue==0)
            {
                return;
            }

            SetBarColor();

            int diff = (int) Math.Ceiling(MaxStatusValue / 5.0);
            Label1thValue.Text = diff+"";
            Label2ndValue.Text = diff * 2 + "";
            Label3rdValue.Text = diff * 3 + "";
            Label4thValue.Text = diff * 4 + "";
            Label5thValue.Text = diff * 5 + "";

            OnePercentValue = ((Label0thValue.Height) * 5) / MaxStatusValue;

            SetMaxHeight();


            timer = new Timer();
            timer.Interval = 5;
            timer.Tick += OnTick;
            timer.Start();

            
        }

        private void SetBarColor()
        {
            BtnDone.BackColor = BtnInProgress.BackColor = BtnNotStarted.BackColor = BtnStruck.BackColor = BarColor;
        }

        private void OnTick(object sender, EventArgs e)
        {
            if(BtnDone.Height >= (int) MaxHeights[0])
            {
                timer.Stop();
                SetFinalHeight();
                return;
            }
            BtnDone.Height += (int)MaxHeights[0]/20;
            BtnInProgress.Height += (int)MaxHeights[1]/20;
            BtnStruck.Height += (int)MaxHeights[2]/20;
            BtnNotStarted.Height += (int)MaxHeights[3]/20;
        }

        private void SetMaxStatusVal()
        {
            foreach(int i in StatusValues)
            {
                MaxStatusValue = Math.Max(MaxStatusValue, i);
            }
        }


        private void SetBarHeightToZero()
        {
            BtnDone.Height = BtnInProgress.Height = BtnNotStarted.Height = BtnStruck.Height = 0;
        }

        private void SetMaxHeight()
        {
            for(int ind=0;ind<MaxHeights.Length;ind++)
            {
                MaxHeights[ind] = OnePercentValue * StatusValues[ind];

            }

        }

        private void SetFinalHeight()
        {
            BtnDone.Height = (int)MaxHeights[0];
            BtnInProgress.Height = (int)MaxHeights[1];
            BtnStruck.Height = (int)MaxHeights[2];
            BtnNotStarted.Height = (int)MaxHeights[3];
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int cellWidth = tableLayoutPanel1.GetColumnWidths()[0];
            int cellHeight = tableLayoutPanel1.GetRowHeights()[0];

            g.DrawLine(new Pen(Color.Black,2), cellWidth, 0, cellWidth, cellHeight);
            g.DrawLine(new Pen(Color.Black,2),Label0thValue.Width,LabelDone.Location.Y,this.Width,LabelDone.Location.Y);
        }
    }
}
