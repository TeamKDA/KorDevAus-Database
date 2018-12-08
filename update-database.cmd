@echo off

rem USAGE update-database.cmd

SET DIR=%~dp0%

dotnet restore
dotnet build

cd src/KorDevAus.Orm

dotnet ef database update --framework netcoreapp2.1

goto finish

:finish

cd %DIR%

exit /B %errorlevel%
