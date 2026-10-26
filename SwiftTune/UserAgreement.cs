using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftTune
{
    public partial class UserAgreement : Form
    {
        public UserAgreement()
        {
            InitializeComponent();
        }

        private void UserAgreementTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserAgreementTextBox_Click(object sender, EventArgs e)
        {

        }

        private void UserAgreementTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                Process.Start(e.LinkText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося відкрити посилання: {e.LinkText}\nПомилка: {ex.Message}");
            }
        }

        private void BackToHelloMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DockCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DockNameText_Click(object sender, EventArgs e)
        {

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
