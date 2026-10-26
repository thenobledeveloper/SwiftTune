using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Доп для запуска патчей
using System.IO;
using System.Diagnostics;

namespace SwiftTune
{
    public partial class OtherControls : Form
    {
        public OtherControls()
        {
            InitializeComponent();
        }

        //      ЗАПУСК ПРОВОДНИКА ОТ ИМЕНА АДМИНА
        private void ExplorerText_Click(object sender, EventArgs e)
        {
            // Попытка запуска по имени "explorer.exe" (если он в PATH)
            string[] explorerPaths = new string[]
    {
        "explorer.exe",
        // Запаc, стандартный путь Windows (вторая попытка)
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "explorer.exe")
    };

            foreach (string path in explorerPaths)
            {
                try
                {
                    // Создаем объект ProcessStartInfo для настройки запуска процесса
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true,
                        Verb = "runas"  // для админа
                    };

                    Process.Start(psi);

                    // Если запуск успешен, выходим из метода
                    return;
                }
                catch (System.ComponentModel.Win32Exception ex) when (ex.NativeErrorCode == 1223)
                {
                    MessageBox.Show("Запуск скасован користувачем.", "Скасувати", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    // Выходим, так как пользователь принял решение
                }
                catch (Exception ex)
                {
                    // Игнорируем ошибку и переходим к следующему пути для запаса
                    if (path == explorerPaths.Last())
                    {
                        MessageBox.Show($"Не вдалося запустити провідник файлів. Помилка: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // конец кода для проводник
                }
            }
        }

        // запуск командной строки
        private void CMDLabel_Click(object sender, EventArgs e)
        {
            string[] cmdPaths = new string[]
    {
        "cmd.exe",
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "cmd.exe")
    };

            foreach (string path in cmdPaths)
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true,
                        Verb = "runas"
                    };

                    Process.Start(psi);

                    return;
                }
                catch (System.ComponentModel.Win32Exception ex) when (ex.NativeErrorCode == 1223)
                {
                    MessageBox.Show("Запуск скасовано користувачем.", "Скасування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    if (path == cmdPaths.Last())
                    {
                        MessageBox.Show($"Не вдалося запустити командний рядок. Помилка: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // завершение для командной строки
                }
            }
        }

        // Запуск редактора реестра
        private void ForRegEditText_Click(object sender, EventArgs e)
        {
            string[] regeditPaths = new string[]
    {
        "regedit.exe",
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "regedit.exe")
    };

            foreach (string path in regeditPaths)
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true,
                        Verb = "runas"
                    };

                    Process.Start(psi);

                    return;
                }
                catch (System.ComponentModel.Win32Exception ex) when (ex.NativeErrorCode == 1223)
                {
                    MessageBox.Show("Запуск скасовано користувачем.", "Скасування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    if (path == regeditPaths.Last())
                    {
                        MessageBox.Show($"Не вдалося запустити редактор реєстру. Помилка: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // конец запуска для редактора реестра
                }
            }
        }

        // Запуск панели управления
        private void ControlText_Click(object sender, EventArgs e)
        {
            string[] controlPaths = new string[]
    {
        "control.exe",
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "control.exe")
    };

            foreach (string path in controlPaths)
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true,
                        Verb = "runas"
                    };

                    Process.Start(psi);

                    return;
                }
                catch (System.ComponentModel.Win32Exception ex) when (ex.NativeErrorCode == 1223)
                {
                    MessageBox.Show("Запуск скасовано користувачем.", "Скасування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    if (path == controlPaths.Last())
                    {
                        MessageBox.Show($"Не вдалося запустити Панель керування. Помилка: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Завершение для панели управления
                }
            }
        }

        // Управление компьютером
        private void CompManagerLabel_Click(object sender, EventArgs e)
        {
            string[] compmgmtPaths = new string[]
    {
        "compmgmt.msc",
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "compmgmt.msc")
    };

            foreach (string path in compmgmtPaths)
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true,
                        Verb = "runas"
                    };

                    Process.Start(psi);

                    return;
                }
                catch (System.ComponentModel.Win32Exception ex) when (ex.NativeErrorCode == 1223)
                {
                    MessageBox.Show("Запуск скасовано користувачем.", "Скасування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    if (path == compmgmtPaths.Last())
                    {
                        MessageBox.Show($"Не вдалося запустити Керування комп'ютером. Помилка: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Завершение управление компьютером
                }
            }
        }

        // Диспетчер устройств
        private void DeviceControlLabel_Click(object sender, EventArgs e)
        {
            string[] devmgmtPaths = new string[]
    {
        "devmgmt.msc",
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "devmgmt.msc")
    };

            foreach (string path in devmgmtPaths)
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true,
                        Verb = "runas"
                    };

                    Process.Start(psi);

                    return;
                }
                catch (System.ComponentModel.Win32Exception ex) when (ex.NativeErrorCode == 1223)
                {
                    MessageBox.Show("Запуск скасовано користувачем.", "Скасування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    if (path == devmgmtPaths.Last())
                    {
                        MessageBox.Show($"Не вдалося запустити Диспетчер пристроїв. Помилка: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // конец для диспетчера устройств
                }
            }
        }

        // Task Manager
        private void TaskManagerLabel_Click(object sender, EventArgs e)
        {
            string[] taskmgrPaths = new string[]
    {
        "Taskmgr.exe",
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "Taskmgr.exe")
    };

            foreach (string path in taskmgrPaths)
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true,
                        Verb = "runas"
                    };

                    Process.Start(psi);

                    return;
                }
                catch (System.ComponentModel.Win32Exception ex) when (ex.NativeErrorCode == 1223)
                {
                    MessageBox.Show("Запуск скасовано користувачем.", "Скасування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    if (path == taskmgrPaths.Last())
                    {
                        MessageBox.Show($"Не вдалося запустити Диспетчер завдань. Помилка: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Конец для таск менедежера
                }
            }
        }

        // services.msc
        private void ServicesMSCLabel_Click(object sender, EventArgs e)
        {
            string[] servicesPaths = new string[]
    {
        "services.msc",
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "services.msc")
    };

            foreach (string path in servicesPaths)
            {
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true,
                        Verb = "runas"
                    };

                    Process.Start(psi);

                    return;
                }
                catch (System.ComponentModel.Win32Exception ex) when (ex.NativeErrorCode == 1223)
                {
                    MessageBox.Show("Запуск скасовано користувачем.", "Скасування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    if (path == servicesPaths.Last())
                    {
                        MessageBox.Show($"Не вдалося запустити Служби. Помилка: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // конец для services.msc
                }
            }
        }

        // перезапуск проводника файлов
        private void RestartText_Click(object sender, EventArgs e)
        {
            string relativeFolderPath = @"InProjectAllBatFiles\InOtherControlsAllBatFiles";
            string fileName = "RestartExplorer.bat";

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string fullPath = Path.Combine(appDirectory, relativeFolderPath, fileName);

            string simplePath = Path.Combine(appDirectory, fileName);

            string pathToExecute = null;

            if (File.Exists(fullPath))
            {
                pathToExecute = fullPath;
            }
            else if (File.Exists(simplePath))
            {
                pathToExecute = simplePath;
            }

            if (pathToExecute != null)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pathToExecute;
                    startInfo.UseShellExecute = true;
                    // Запит прав адміністратора
                    startInfo.Verb = "runas";

                    System.Diagnostics.Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при запуску скрипту: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Скрипт **{fileName}** не знайдено за жодним зі шляхів:\n1. {fullPath}\n2. {simplePath}", "Файл не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // завершение перезапуска проводника
        }

        // sfc scan now
        private void SFCSCANText_Click(object sender, EventArgs e)
        {
            string relativeFolderPath = @"InProjectAllBatFiles\InOtherControlsAllBatFiles";
            string fileName = "ForSFCscannow.bat";

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string fullPath = Path.Combine(appDirectory, relativeFolderPath, fileName);

            string simplePath = Path.Combine(appDirectory, fileName);

            string pathToExecute = null;

            if (File.Exists(fullPath))
            {
                pathToExecute = fullPath;
            }
            else if (File.Exists(simplePath))
            {
                pathToExecute = simplePath;
            }

            if (pathToExecute != null)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pathToExecute;
                    startInfo.UseShellExecute = true;
                    // Запит прав адміністратора
                    startInfo.Verb = "runas";

                    System.Diagnostics.Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при запуску скрипту: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Скрипт **{fileName}** не знайдено за жодним зі шляхів:\n1. {fullPath}\n2. {simplePath}", "Файл не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // sfc scan now end
        }

        // clear temp
        private void ClearTEMPText_Click(object sender, EventArgs e)
        {
            string relativeFolderPath = @"InProjectAllBatFiles\InOtherControlsAllBatFiles";
            string fileName = "ClearAllFoldersTEMP.bat";

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string fullPath = Path.Combine(appDirectory, relativeFolderPath, fileName);

            string simplePath = Path.Combine(appDirectory, fileName);

            string pathToExecute = null;

            if (File.Exists(fullPath))
            {
                pathToExecute = fullPath;
            }
            else if (File.Exists(simplePath))
            {
                pathToExecute = simplePath;
            }

            if (pathToExecute != null)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pathToExecute;
                    startInfo.UseShellExecute = true;
                    // Запит прав адміністратора
                    startInfo.Verb = "runas";

                    System.Diagnostics.Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при запуску скрипту: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Скрипт **{fileName}** не знайдено за жодним зі шляхів:\n1. {fullPath}\n2. {simplePath}", "Файл не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // end clear temp
        }

        // restart services
        private void RestartServicesLabel_Click(object sender, EventArgs e)
        {
            string relativeFolderPath = @"InProjectAllBatFiles\InOtherControlsAllBatFiles";
            string fileName = "RestartServicesInWindows.bat";

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string fullPath = Path.Combine(appDirectory, relativeFolderPath, fileName);

            string simplePath = Path.Combine(appDirectory, fileName);

            string pathToExecute = null;

            if (File.Exists(fullPath))
            {
                pathToExecute = fullPath;
            }
            else if (File.Exists(simplePath))
            {
                pathToExecute = simplePath;
            }

            if (pathToExecute != null)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pathToExecute;
                    startInfo.UseShellExecute = true;
                    // Запит прав адміністратора
                    startInfo.Verb = "runas";

                    System.Diagnostics.Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при запуску скрипту: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Скрипт **{fileName}** не знайдено за жодним зі шляхів:\n1. {fullPath}\n2. {simplePath}", "Файл не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // end restart services
        }

        // clear cache dns
        private void ClearCacheDNSLabel_Click(object sender, EventArgs e)
        {
            string relativeFolderPath = @"InProjectAllBatFiles\InOtherControlsAllBatFiles";
            string fileName = "ClearDNSCache.bat";

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string fullPath = Path.Combine(appDirectory, relativeFolderPath, fileName);

            string simplePath = Path.Combine(appDirectory, fileName);

            string pathToExecute = null;

            if (File.Exists(fullPath))
            {
                pathToExecute = fullPath;
            }
            else if (File.Exists(simplePath))
            {
                pathToExecute = simplePath;
            }

            if (pathToExecute != null)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pathToExecute;
                    startInfo.UseShellExecute = true;
                    // Запит прав адміністратора
                    startInfo.Verb = "runas";

                    System.Diagnostics.Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при запуску скрипту: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Скрипт **{fileName}** не знайдено за жодним зі шляхів:\n1. {fullPath}\n2. {simplePath}", "Файл не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // end clear cache dns
        }

        // restore winsock
        private void RestoreWinsockLabel_Click(object sender, EventArgs e)
        {
            string relativeFolderPath = @"InProjectAllBatFiles\InOtherControlsAllBatFiles";
            string fileName = "RestoreWinsock.bat";

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string fullPath = Path.Combine(appDirectory, relativeFolderPath, fileName);

            string simplePath = Path.Combine(appDirectory, fileName);

            string pathToExecute = null;

            if (File.Exists(fullPath))
            {
                pathToExecute = fullPath;
            }
            else if (File.Exists(simplePath))
            {
                pathToExecute = simplePath;
            }

            if (pathToExecute != null)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pathToExecute;
                    startInfo.UseShellExecute = true;
                    // Запит прав адміністратора
                    startInfo.Verb = "runas";

                    System.Diagnostics.Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при запуску скрипту: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Скрипт **{fileName}** не знайдено за жодним зі шляхів:\n1. {fullPath}\n2. {simplePath}", "Файл не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // restor winsock end
        }

        // check dism
        private void CheckDISMLabel_Click(object sender, EventArgs e)
        {
            string relativeFolderPath = @"InProjectAllBatFiles\InOtherControlsAllBatFiles";
            string fileName = "DISMCheck.bat";

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string fullPath = Path.Combine(appDirectory, relativeFolderPath, fileName);

            string simplePath = Path.Combine(appDirectory, fileName);

            string pathToExecute = null;

            if (File.Exists(fullPath))
            {
                pathToExecute = fullPath;
            }
            else if (File.Exists(simplePath))
            {
                pathToExecute = simplePath;
            }

            if (pathToExecute != null)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pathToExecute;
                    startInfo.UseShellExecute = true;
                    // Запит прав адміністратора
                    startInfo.Verb = "runas";

                    System.Diagnostics.Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при запуску скрипту: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Скрипт **{fileName}** не знайдено за жодним зі шляхів:\n1. {fullPath}\n2. {simplePath}", "Файл не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // check dism end
        }

        // open startup in task manager
        private void StartupLabel_Click(object sender, EventArgs e)
        {
            string relativeFolderPath = @"InProjectAllBatFiles\InOtherControlsAllBatFiles";
            string fileName = "OpenStartupInFileManager.bat";

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string fullPath = Path.Combine(appDirectory, relativeFolderPath, fileName);

            string simplePath = Path.Combine(appDirectory, fileName);

            string pathToExecute = null;

            if (File.Exists(fullPath))
            {
                pathToExecute = fullPath;
            }
            else if (File.Exists(simplePath))
            {
                pathToExecute = simplePath;
            }

            if (pathToExecute != null)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = pathToExecute;
                    startInfo.UseShellExecute = true;
                    // Запит прав адміністратора
                    startInfo.Verb = "runas";

                    System.Diagnostics.Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при запуску скрипту: {ex.Message}", "Помилка запуску", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Скрипт **{fileName}** не знайдено за жодним зі шляхів:\n1. {fullPath}\n2. {simplePath}", "Файл не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // end open startup
        }

        private void DockCloseButton_Click(object sender, EventArgs e)
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
