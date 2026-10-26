using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SwiftTune
{
    public partial class ScreenForChangeCustomLevelOptimization : Form
    {
        private bool _isSaved = false;
        private readonly OptimizationScriptBuilder _scriptBuilder;
        private readonly Form _parentForm;

        private readonly string _relativePath = Path.Combine("InProjectAllBatFiles", "InMainScreenOptimizationAllBatFiles");
        private readonly string _fileName = "CustomLevelOptimization.bat";

        public ScreenForChangeCustomLevelOptimization(Form parent)
        {
            InitializeComponent();
            _parentForm = parent;
            _scriptBuilder = new OptimizationScriptBuilder();

            ClearBatchFileOnStart();

            this.FormClosing += ScreenForChangeCustomLevelOptimization_FormClosing;
            this.FormClosed += ScreenForChangeCustomLevelOptimization_FormClosed;
        }

        private void ClearBatchFileOnStart()
        {
            try
            {
                string fullPath = GetFullPath();
                if (File.Exists(fullPath))
                {
                    File.WriteAllText(fullPath, string.Empty);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void BackToHelloMenu_Click(object sender, EventArgs e)
        {
            var checkboxStates = GetCheckboxStates();
            bool anyChecked = IsAnyCheckboxChecked(checkboxStates);

            if (!anyChecked)
            {
                var result = MessageBox.Show(
                    "Ви не обрали жодної опції. Файл налаштувань залишиться порожнім. Продовжити?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No) return;
            }

            try
            {
                string fileContent = _scriptBuilder.BuildScript(checkboxStates);
                SaveBatchFile(fileContent);

                _isSaved = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DockCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScreenForChangeCustomLevelOptimization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isSaved) return;

            bool anyChecked = IsAnyCheckboxChecked(GetCheckboxStates());

            if (anyChecked)
            {
                var result = MessageBox.Show(
                    "Ви внесли зміни, але не зберегли їх. Вийти без збереження?",
                    "Увага",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void ScreenForChangeCustomLevelOptimization_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_parentForm != null && !_parentForm.IsDisposed)
            {
                _parentForm.Show();
            }
        }

        private string GetFullPath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string directoryPath = Path.Combine(basePath, _relativePath);
            if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
            return Path.Combine(directoryPath, _fileName);
        }

        private void SaveBatchFile(string content)
        {
            string fullPath = GetFullPath();
            File.WriteAllText(fullPath, content, Encoding.ASCII);
        }

        private Dictionary<string, bool> GetCheckboxStates()
        {
            return new Dictionary<string, bool>
            {
                { "VisualEffects", IsChecked("VisualEffects") },
                { "AutoTray", IsChecked("AutoTray") },
                { "StartMenuHistory", IsChecked("StartMenuHistory") },
                { "TempClean", IsChecked("TempClean") }
            };
        }

        private bool IsChecked(string name)
        {
            var control = this.Controls.Find(name, true).FirstOrDefault();
            return (control is CheckBox cb) && cb.Checked;
        }

        private bool IsAnyCheckboxChecked(Dictionary<string, bool> states)
        {
            return states.Any(s => s.Value);
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