@echo off
echo Resetting Winsock and network stack...
echo.

netsh winsock reset

echo.
echo Winsock successfully reset.

netsh int ip reset

echo.
echo TCP/IP protocol successfully reset.
echo.

echo A computer restart is required to complete the restoration.
pause