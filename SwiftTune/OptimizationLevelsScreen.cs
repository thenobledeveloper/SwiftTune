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

namespace SwiftTune
{
    public partial class OptimizationLevelsScreen : Form
    {
        public OptimizationLevelsScreen()
        {
            InitializeComponent();

            // использование метода для неактивного состояния загрузки
            SetStatusInactive();
        }

        // сам метод для неактивности текущего состояния
        private void SetStatusInactive()
        {
            StatusInTimeText.Text = "Неактивний";
            StatusInTimeText.ForeColor = Color.DarkRed;
            StartOptimizationButton.Enabled = true;
            TrackerInOptimizationStart.Enabled = true;
        }

        // Событие при нажатии на кнопку
        private async void StartOptimizationButton_Click(object sender, EventArgs e)
        {
            CreateRestorePointForce_Click(sender, e);
            // блокирует кнопки и трекер чтобы не нажать много раз
            StartOptimizationButton.Enabled = false;
            TrackerInOptimizationStart.Enabled = false;

            int selectedLevel = TrackerInOptimizationStart.Value;

            // Получаем путь через новый другой класс
            string batFilePath = OptimizationManager.GetBatFilePath(selectedLevel);
            string optimizationName = Path.GetFileNameWithoutExtension(batFilePath);

            // проверка зависимостей - ДЕКОР
            StatusInTimeText.Text = "Перевірка залежностей";
            StatusInTimeText.ForeColor = Color.DarkOrange;

            // декор задержка чтобы пользователь успел заметить смену статуса
            await Task.Delay(500);

            if (string.IsNullOrEmpty(batFilePath) || !File.Exists(batFilePath))
            {
                await ShowErrorAndReset();
                return;
            }

            // проверяме логи, была ли оптимизация?
            if (OptimizationManager.WasOptimizedToday(optimizationName))
            {
                DialogResult result = MessageBox.Show(
                    $"Оптимізація '{optimizationName}' вже виконувалась сьогодні. Ви впевнені, що хочете запустити її знову?",
                    "Повторна оптимізація",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    SetStatusInactive();
                    return;
                }
            }

            // Запуск оптимизации - ДЕКОР
            StatusInTimeText.Text = "Оптимізація";
            StatusInTimeText.ForeColor = Color.DarkGreen;

            bool success = await RunBatFileAsync(batFilePath);

            if (success)
            {
                // пишем все в логи
                OptimizationManager.WriteLog(optimizationName);

                // статус оптимизации (текст) - Успех
                StatusInTimeText.Text = "Оптимізовано";
                StatusInTimeText.ForeColor = Color.LightGreen;

                await Task.Delay(5000);

                // Возвращаем в исходное состояние
                SetStatusInactive();

            }
            else
            {
                // Если пользователь отменил UAC или произошла ошибка
                await ShowErrorAndReset();
            }
        }

        // метод для запуска проекта асинхронности
        private async Task<bool> RunBatFileAsync(string path)
        {
            // Запускаем задачу в фоне
            return await Task.Run(() =>
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = path;
                    psi.UseShellExecute = true;
                    psi.Verb = "runas";
                    psi.WindowStyle = ProcessWindowStyle.Normal;

                    // пробуем запустить процесс
                    using (Process process = Process.Start(psi))
                    {
                        // если процесс запущен, ждем его закрытия
                        if (process != null)
                        {
                            process.WaitForExit();
                            return true; // файл успешно выполнен
                        }
                        return false; // произошла ошибка
                    }
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    // если не дали ЮАК разрешение
                    return false;
                }
                catch (Exception)
                {
                    // любая другая ошибка, связанная со сторонними программами на стороне пользователя
                    return false;
                }
            });
        }

        // Метод для отображения ошибки
        private async Task ShowErrorAndReset()
        {
            StatusInTimeText.Text = "Помилка";
            StatusInTimeText.ForeColor = Color.Red;

            await Task.Delay(5000); // Ждем 5 секунд

            SetStatusInactive();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OtherControls usernexttolevelsscreen = new OtherControls();
            usernexttolevelsscreen.ShowDialog();
        }

        private void DockCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DockHideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void LowerLevelOptimizationText_MouseEnter(object sender, EventArgs e)
        {
            LowerLevelOptimizationText.ForeColor = Color.DarkGreen;
        }

        private void LowerLevelOptimizationText_MouseLeave(object sender, EventArgs e)
        {
            LowerLevelOptimizationText.ForeColor = Color.Green;
        }

        private void HigherLevelOptimizationText_MouseEnter(object sender, EventArgs e)
        {
            HigherLevelOptimizationText.ForeColor = Color.DarkRed;
        }

        private void HigherLevelOptimizationText_MouseLeave(object sender, EventArgs e)
        {
            HigherLevelOptimizationText.ForeColor = Color.Red;
        }

        private void CustomLevelOptimizationText_MouseEnter(object sender, EventArgs e)
        {
            CustomLevelOptimizationText.ForeColor = Color.Silver;
        }

        private void CustomLevelOptimizationText_MouseLeave(object sender, EventArgs e)
        {
            CustomLevelOptimizationText.ForeColor = Color.White;
        }

        private void LowerLevelOptimizationText_Click(object sender, EventArgs e)
        {
            LowerLevelOptimizationDetails nexttodetailsoflower = new LowerLevelOptimizationDetails();
            nexttodetailsoflower.ShowDialog();
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

        private void HigherLevelOptimizationText_Click(object sender, EventArgs e)
        {
            HigherLevelOptimizationDetail nexttohigherlevelscreen = new HigherLevelOptimizationDetail();
            nexttohigherlevelscreen.ShowDialog();
        }

        private void CustomLevelOptimizationText_Click(object sender, EventArgs e)
        {
            CustomLevelOptimizationDetail nextocustomdetail = new CustomLevelOptimizationDetail();
            nextocustomdetail.ShowDialog();
        }

        private void ForSettingsCustomLevelOptimizationIcon_Click(object sender, EventArgs e)
        {
            ScreenForChangeCustomLevelOptimization customScreen = new ScreenForChangeCustomLevelOptimization(this);
            customScreen.Show();
            this.Hide();
        }

        private void CreateRestorePointForce_Click(object sender, EventArgs e)
        {
            string baseDirectory = Application.StartupPath;
            string batFilePath = Path.Combine(baseDirectory, "InProjectAllBatFiles", "InFirstHelloScreenBatFile", "CreateRestorePoint.bat");

            if (File.Exists(batFilePath))
            {
                try
                {
                    ProcessStartInfo processInfo = new ProcessStartInfo();
                    processInfo.FileName = batFilePath;
                    processInfo.Verb = "runas";
                    processInfo.UseShellExecute = true;
                    processInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    Process.Start(processInfo);
                }
                catch (Exception)
                {

                }
            }
        }

        private void AllRestoreToDefault_Click(object sender, EventArgs e)
        {
            string batPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                  "InProjectAllBatFiles",
                                  "InMainScreenOptimizationAllBatFiles",
                                  "RestoreRegistryToDefault.bat");

            if (!File.Exists(batPath))
            {
                MessageBox.Show("Файл не знайдено:\n" + batPath, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = batPath;
            psi.Verb = "runas";
            psi.UseShellExecute = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;

            try
            {
                Process.Start(psi);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Запуск скасовано користувачем.", "Скасування", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonToOpenExplorerForFileConfiguration_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configuration.txt");

            if (File.Exists(filePath))
            {
                Process.Start("explorer.exe", "/select,\"" + filePath + "\"");
            }
            else
            {
                Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserAgreement usernexttoagreement = new UserAgreement();
            usernexttoagreement.ShowDialog();
        }
    }
}
