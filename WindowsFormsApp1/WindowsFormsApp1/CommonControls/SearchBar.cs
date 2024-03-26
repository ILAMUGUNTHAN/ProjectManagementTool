using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.CommonControls
{
    public partial class SearchBar : UserControl
    {
        public Color SearchBackColor
        {
            set
            {
                int R, G, B;
                R = (value.R - 10 >= 0) ? value.R - 10 : value.R;
                G = (value.G - 10 >= 0) ? value.G - 10 : value.G;
                B = (value.B - 10 >= 0) ? value.B - 10 : value.B;
                textBox1.BackColor = Color.FromArgb(R, G, B);
            }
        }

        public event EventHandler<string> SearchTextChange;

        public SearchBar()
        {
            InitializeComponent();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            SearchTextChange?.Invoke(this, textBox1.Text);
        }
    }
}
