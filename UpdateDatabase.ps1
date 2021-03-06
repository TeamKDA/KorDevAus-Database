#
# This updates database based on the migration snapshots.
#

Param(
    [string] [Parameter(Mandatory=$true)] $DbContextPath,
    [string] [Parameter(Mandatory=$false)] $BuildConfiguration = "Release"
)

$dir = $pwd.Path

cd $DbContextPath

dotnet ef database update --configuration $BuildConfiguration --framework netcoreapp2.1 --no-build

cd $dir
