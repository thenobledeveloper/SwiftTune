@echo off
echo Stopping UI processes...

:: килл проводника
taskkill /F /IM explorer.exe

:: килл графического интерфейса
taskkill /F /IM sihost.exe

echo Waiting for system cleanup...
timeout /t 3 /nobreak >nul

echo Starting Explorer Shell...
:: юзаем переменные окружения
start "" "%WINDIR%\explorer.exe"

exit