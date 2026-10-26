using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwiftTune
{
    public static class OptimizationManager
    {
        // Путь к файлу логов рядом с готовой прогой (проектом)
        private static string LogFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

        // получаем полный путь к батнику файла
        public static string GetBatFilePath(int level)
        {
            string fileName = "";
            switch (level)
            {
                case 1:
                    fileName = "LowerLevelOptimization.bat";
                    break;
                case 2:
                    fileName = "HigherLevelOptimization.bat";
                    break;
                case 3:
                    fileName = "CustomLevelOptimization.bat";
                    break;
                default:
                    return null;
            }

            // Строим путь
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "InProjectAllBatFiles",
                "InMainScreenOptimizationAllBatFiles",
                fileName
            );

            return path;
        }

        // Запись в лог
        public static void WriteLog(string optimizationName)
        {
            try
            {
                string logEntry = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] Виконана оптимізація: {optimizationName}";
                File.AppendAllText(LogFilePath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка запису логу: " + ex.Message);
            }
        }

        // Проверка, была ли такая оптимизация сегодня
        public static bool WasOptimizedToday(string optimizationName)
        {
            if (!File.Exists(LogFilePath))
            {
                // Если файла нет, создаем пустой и возвращаем false
                File.Create(LogFilePath).Close();
                return false;
            }

            try
            {
                var lines = File.ReadAllLines(LogFilePath);
                string todayDate = DateTime.Now.ToString("dd.MM.yyyy");

                // поиск строки с датой и именем оптимизации
                return lines.Any(line => line.Contains(todayDate) && line.Contains(optimizationName));
            }
            catch
            {
                return false;
            }
        }
    }
}
