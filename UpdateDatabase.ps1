#
# This updates database based on the migration snapshots.
#

Param(
    [string] [Parameter(Mandatory=$true)] $DbContextPath
)

$dir = $pwd.Path

dotnet restore
dotnet build

cd $DbContextPath

dotnet ef database update

cd $dir
