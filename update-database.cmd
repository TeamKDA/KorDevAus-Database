@echo off

rem USAGE database-update-sqlserver.bat

SET DIR=%~dp0%

dotnet restore
dotnet build

cd src/KorDevAus.Orm

dotnet ef database update

goto finish

:finish

cd %DIR%

exit /B %errorlevel%
