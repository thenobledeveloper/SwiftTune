@echo off
echo Restarting important Windows services

echo.
echo Restarting Windows Update service (wuauserv)...
net stop wuauserv
net start wuauserv

echo.
echo Restarting Print Spooler service (Spooler)...
net stop Spooler
net start Spooler

echo.
echo Restarting Background Intelligent Transfer Service (BITS)...
net stop BITS
net start BITS

echo.
echo Restarting Windows Audio service (Audiosrv)...
net stop Audiosrv
net start Audiosrv

echo.
echo Restarting Windows Audio Endpoint Builder service (AudioClient)...
net stop AudioClient
net start AudioClient

echo.
echo Service restart complete.
pause