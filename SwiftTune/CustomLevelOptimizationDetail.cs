using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftTune
{
    public partial class CustomLevelOptimizationDetail : Form
    {
        public CustomLevelOptimizationDetail()
        {
            InitializeComponent();
        }

        private void DockCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackToHelloMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void DockNameText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void DockNameText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = e.Location;
            }
        }
    }
}
