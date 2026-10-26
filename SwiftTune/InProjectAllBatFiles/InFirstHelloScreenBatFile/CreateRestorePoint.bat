@echo off
set "RestorePointName=Restore_Point_in_WMIC_from_%date%_%time%"
wmic.exe /Namespace:\\root\default Path SystemRestore Call CreateRestorePoint "%RestorePointName%", 100, 7

set "RegBackupDir=%USERPROFILE%\Desktop\RegistryEditorBackup"

if not exist "%RegBackupDir%" mkdir "%RegBackupDir%"

if not exist "%RegBackupDir%\HKCU_User.reg" reg export HKCU "%RegBackupDir%\HKCU_User.reg" /y
if not exist "%RegBackupDir%\HKLM_System.reg" reg export HKLM "%RegBackupDir%\HKLM_System.reg" /y
if not exist "%RegBackupDir%\HKCR_Classes.reg" reg export HKCR "%RegBackupDir%\HKCR_Classes.reg" /y
if not exist "%RegBackupDir%\HKU_Users.reg" reg export HKU "%RegBackupDir%\HKU_Users.reg" /y
if not exist "%RegBackupDir%\HKCC_Config.reg" reg export HKCC "%RegBackupDir%\HKCC_Config.reg" /y

exit