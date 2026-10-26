using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SwiftTune
{
    public partial class FirstHelloScreen : Form
    {
        public FirstHelloScreen()
        {
            InitializeComponent();
            // Отключаю кнопку продолжить при запуске программы
            NextToMenuButton.Enabled = false;
        }

        private void LogoPicture_Click(object sender, EventArgs e)
        {

        }

        private void LogoPicture_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBoxLicense_CheckedChanged(object sender, EventArgs e)
        {
            // Проверка чек боксов true - активно, false - неактивно
            if (checkBoxLicense.Checked && checkBoxRecommendations.Checked)
            {
                NextToMenuButton.Enabled = true;
            }
            else
            {
                NextToMenuButton.Enabled = false;
            }
        }

        private void LicenseClickText_Click(object sender, EventArgs e)
        {
            LicenseForm licenseForm = new LicenseForm();
            licenseForm.ShowDialog();
        }

        // кнопка перехода (+создание точки восстановления)
        private void NextToMenuButton_Click(object sender, EventArgs e)
        {
            string basePath = Application.StartupPath;

            string batFilePath = Path.Combine(basePath, "InProjectAllBatFiles", "InFirstHelloScreenBatFile", "CreateRestorePoint.bat");

            try
            {
                if (File.Exists(batFilePath))
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = batFilePath;
                    psi.Verb = "runas";
                    psi.UseShellExecute = true;
                    psi.WindowStyle = ProcessWindowStyle.Hidden;

                    Process.Start(psi);
                }
            }
            catch (Exception)
            {

            }

            ConfigurationManager.UpdateHelloScreenSetting(false);

            OptimizationLevelsScreen obrMenuToLevelsScreen = new OptimizationLevelsScreen();
            obrMenuToLevelsScreen.Show();
            this.Hide();
        }
        // (+end)

        private void DockCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DockHideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RecommendationsClickText_Click(object sender, EventArgs e)
        {
            UserAgreement usernexttoagreement = new UserAgreement();
            usernexttoagreement.ShowDialog();
        }

        Point lastPoint;
        private void DockNameText_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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
