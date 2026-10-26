using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// Вспомогательный класс "Configuration.txt
public static class ConfigurationManager
{
    // имя файла который будет использован для конфигурации
    private static readonly string ConfigFileName = "Configuration.txt";

    // свойство, определение пути к конфигу
    public static string ConfigFilePath
    {
        get
        {
            // получаем доступ к папке exe полного проекта
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            // Объединяем путь папки и имя кфг
            return Path.Combine(appPath, ConfigFileName);
        }
    }

    // проверяем наличие конфига, и если нету то создаем
    public static void EnsureConfigExists()
    {
        if (!File.Exists(ConfigFilePath))
        {
            // начальная настройка, в конфиг летит
            string initialContent = "ShowHelloScreen=True" + Environment.NewLine;

            try
            {
                // записываем это в файл текста
                File.WriteAllText(ConfigFilePath, initialContent);
            }
            catch (Exception ex)
            {
                // При ошибке и тд
                MessageBox.Show($"Помилка під час створення файлу конфігурації: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Метод для чтения файла, чтение его точной настройки
    public static string ReadSetting(string settingName)
    {
        // проверка что файл существует, чтобы избежать ошибок при чтении
        if (!File.Exists(ConfigFilePath))
        {
            EnsureConfigExists();
        }

        try
        {
            // читаем все строки в конфиге
            var lines = File.ReadAllLines(ConfigFilePath);
            // ищем параметр по первой строке и равно
            var line = lines.FirstOrDefault(l => l.StartsWith(settingName + "="));

            if (line != null)
            {
                // если строка есть, возвращаем только значение
                return line.Substring(line.IndexOf('=') + 1).Trim();
            }
        }
        catch (Exception ex)
        {
            // для ошибок и тд
            MessageBox.Show($"Помилка під час читання файлу конфігурації: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // если строки нету или ошибка, то возвращаем ноль
        return null;
    }

    // вспомогательный метод для обновления значения
    public static void UpdateHelloScreenSetting(bool show)
    {
        // конверт в значение тру или фолс и вызываем основной метод
        UpdateSetting("ShowHelloScreen", show.ToString());
    }

    // основной метод
    public static void UpdateSetting(string settingName, string newValue)
    {
        // проверяем есть ли файл
        if (!File.Exists(ConfigFilePath))
        {
            EnsureConfigExists();
        }

        try
        {
            // считываем все строки
            var lines = File.ReadAllLines(ConfigFilePath).ToList();
            bool updated = false;
            string targetLineStart = settingName + "=";

            // Перебираем все строки для поиска существующей настройки
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(targetLineStart))
                {
                    // Если строка найдена, обновляем ее новым значением
                    lines[i] = targetLineStart + newValue;
                    updated = true;
                    break;
                }
            }

            // Если настройка не найдена, добавляем ее как новую строку в конец
            if (!updated)
            {
                lines.Add(targetLineStart + newValue);
            }

            // Перезаписываем весь файл обновками
            File.WriteAllLines(ConfigFilePath, lines);
        }
        catch (Exception ex)
        {
            // Для ошибок
            MessageBox.Show($"Помилка під час записування в файл конфігурації: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}