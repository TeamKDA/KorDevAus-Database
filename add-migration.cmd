@echo off

rem USAGE add-migration.bat <MIGRATION_NAME>

SET DIR=%~dp0%

IF "%1"=="" (
    SET MIGRATION_NAME=SomeMigrationName
) ELSE (
    SET MIGRATION_NAME=%1%
)

dotnet restore
dotnet build

cd src\KorDevAus.Orm

dotnet ef migrations add %MIGRATION_NAME% --framework netcoreapp2.1

goto finish

:finish

cd %DIR%

exit /B %errorlevel%
