#
# This updates connection strings in appsettings.json.
#

Param(
    [string] [Parameter(Mandatory=$true)] $AppSettingsPath,
    [string] [Parameter(Mandatory=$true)] $ConnectionKey,
    [string] [Parameter(Mandatory=$true)] $SqlServerResourceName,
    [string] [Parameter(Mandatory=$true)] $SqlDatabaseName,
    [string] [Parameter(Mandatory=$true)] $SqlServerAdminUsername,
    [string] [Parameter(Mandatory=$true)] $SqlServerAdminPassword
)

$filename = "appsettings.json"
$connString = "Server=tcp:$SqlServerResourceName.database.windows.net,1433;"
$connString += "Initial Catalog=$SqlDatabaseName;Persist Security Info=False;"
$connString += "User ID=$SqlServerAdminUsername@$SqlServerResourceName;Password=$SqlServerAdminPassword;"
$connString += "MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

$appsettings = Get-Content "$AppSettingsPath\$filename" | ConvertFrom-Json
$appsettings.ConnectionStrings.$ConnectionKey = $connString

$appsettings | ConvertTo-Json | Out-File "$AppSettingsPath\$filename" -Encoding utf8
