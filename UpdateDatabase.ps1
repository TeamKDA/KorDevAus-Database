#
# This updates database based on the migration snapshots.
#

Param(
    [string] [Parameter(Mandatory=$true)] $DbContextPath
)

$dir = $pwd.Path

cd $DbContextPath

dotnet ef database update --no-build

cd $dir
