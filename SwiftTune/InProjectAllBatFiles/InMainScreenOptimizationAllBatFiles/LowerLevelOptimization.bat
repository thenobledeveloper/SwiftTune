@echo off
if defined TEMP (
    del /f /s /q "%TEMP%\*.*" >nul 2>&1
    for /d %%i in ("%TEMP%\*") do rd /s /q "%%i" >nul 2>&1
)
if defined WINDIR (
    del /f /s /q "%WINDIR%\Temp\*.*" >nul 2>&1
    del /f /s /q "%WINDIR%\Prefetch\*.*" >nul 2>&1
)