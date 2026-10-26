using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftTune
{
    public class OptimizationScriptBuilder
    {
        private readonly Dictionary<string, string> _commands;

        public OptimizationScriptBuilder()
        {
            _commands = new Dictionary<string, string>
            {
                {
                    "VisualEffects",
                    "reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\VisualEffects\" /v VisualFXSetting /t REG_DWORD /d 3 /f\r\n" +
                    "reg add \"HKCU\\Control Panel\\Desktop\\WindowMetrics\" /v MinAnimate /t REG_SZ /d 0 /f\r\n" +
                    "reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v TaskbarAnimations /t REG_DWORD /d 0 /f\r\n" +
                    "reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v ListviewAlphaSelect /t REG_DWORD /d 0 /f\r\n" +
                    "reg add \"HKCU\\Software\\Microsoft\\Windows\\DWM\" /v EnableAeroPeek /t REG_DWORD /d 0 /f\r\n" +
                    "reg add \"HKCU\\Control Panel\\Desktop\" /v MenuShowDelay /t REG_SZ /d 0 /f\r\n" +
                    "reg add \"HKCU\\Control Panel\\Desktop\" /v FontSmoothing /t REG_SZ /d 2 /f\r\n" +
                    "reg add \"HKCU\\Control Panel\\Desktop\" /v FontSmoothingType /t REG_DWORD /d 2 /f\r\n" +
                    "reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v IconsOnly /t REG_DWORD /d 1 /f\r\n"
                },
                {
                    "AutoTray",
                    "reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\" /v EnableAutoTray /t REG_DWORD /d 0 /f\r\n"
                },
                {
                    "StartMenuHistory",
                    "REG ADD \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"Start_ShowRecentlyAddedApps\" /t REG_DWORD /d 0 /f\r\n" +
                    "REG ADD \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"Start_TrackProgs\" /t REG_DWORD /d 0 /f\r\n" +
                    "REG ADD \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"Start_TrackDocs\" /t REG_DWORD /d 0 /f\r\n" +
                    "REG ADD \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v \"Start_ShowRecentWebSites\" /t REG_DWORD /d 0 /f\r\n"
                },
                {
                    "TempClean",
                    "cd /d \"%TEMP%\"\r\n" +
                    "del /q /f /s *.*\r\n"
                }
            };
        }

        public string BuildScript(Dictionary<string, bool> selectedOptions)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("@echo off");
            sb.AppendLine();

            foreach (var option in selectedOptions)
            {
                if (option.Value && _commands.ContainsKey(option.Key))
                {
                    sb.AppendLine(_commands[option.Key]);
                }
            }

            return sb.ToString();
        }
    }
}