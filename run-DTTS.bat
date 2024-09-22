@ECHO OFF 
ECHO Please wait...
SET filedir=%~dp0
ECHO ============================
ECHO Running files in:
ECHO %filedir%
ECHO DO NOT CLOSE SERVER WINDOW!
ECHO ============================
START %filedir%DTTS\DTTS\bin\Debug\DTTS.exe
EXIT