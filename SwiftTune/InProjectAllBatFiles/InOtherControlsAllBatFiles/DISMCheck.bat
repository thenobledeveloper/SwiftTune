@echo off
echo Starting DISM...
echo.

:: 1. Check health of the Windows image
echo Running DISM CheckHealth...
Dism /Online /Cleanup-Image /CheckHealth
echo.

:: 2. Scan health of the Windows image (more detailed check)
echo Running DISM ScanHealth... This may take a few minutes.
Dism /Online /Cleanup-Image /ScanHealth
echo.

:: 3. Restore health of the Windows image (if issues found)
echo Running DISM RestoreHealth... This may take a long time.
echo NOTE: An active internet connection may be required.
Dism /Online /Cleanup-Image /RestoreHealth
echo.

echo All scans and repairs are complete.
pause