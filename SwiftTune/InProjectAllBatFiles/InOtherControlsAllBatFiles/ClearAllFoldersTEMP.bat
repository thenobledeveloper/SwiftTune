@echo off
echo Cleaning Temp directories
if not "%TEMP%"=="" (
    del /f /s /q "%TEMP%\*"
    rd /s /q "%TEMP%"
    mkdir "%TEMP%"
)
if not "%TMP%"=="" (
    del /f /s /q "%TMP%\*"
    rd /s /q "%TMP%"
    mkdir "%TMP%"
)
if exist "C:\Windows\Temp" (
    del /f /s /q "C:\Windows\Temp\*"
    rd /s /q "C:\Windows\Temp"
    mkdir "C:\Windows\Temp"
)