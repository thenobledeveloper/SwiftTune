@echo off
set "RegBackupDir=%USERPROFILE%\Desktop\RegistryEditorBackup"

if exist "%RegBackupDir%" (
    for %%f in ("%RegBackupDir%\*.reg") do regedit /s "%%f"
)