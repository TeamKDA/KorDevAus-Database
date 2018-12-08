using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace KorDevAus.Orm.Migrations
{
    public partial class AddInitialSeedingsOnGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = "INSERT INTO [Group] ([Id], [Name], [Description], [Slug], [CreatedBy], [UpdatedBy]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";

            migrationBuilder.Sql(string.Format(sql, Guid.NewGuid(), "Users", "This is a group for users", "users", Guid.Empty, Guid.Empty));
            migrationBuilder.Sql(string.Format(sql, Guid.NewGuid(), "Administrators", "This is a group for administrators", "administrators", Guid.Empty, Guid.Empty));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sql = "DELETE FROM [Group] WHERE [Name] = {0}";

            migrationBuilder.Sql(string.Format(sql, "Users"));
            migrationBuilder.Sql(string.Format(sql, "Administrators"));
        }
    }
}
