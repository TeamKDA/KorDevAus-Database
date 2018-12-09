using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace KorDevAus.Orm.Migrations
{
    public partial class AddInitialSeedingsOnMeetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = "INSERT INTO [Meetup] ([Id], [Name], [Description], [Slug], [CreatedBy], [UpdatedBy]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";

            migrationBuilder.Sql(string.Format(sql, Guid.NewGuid(), "Melbourne Korean Developers", "This is a Korean developers meetup in Melbourne", "melbourne", Guid.Empty, Guid.Empty));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sql = "DELETE FROM [Meetup] WHERE [Name] = {0}";

            migrationBuilder.Sql(string.Format(sql, "Melbourne Korean Developers"));
        }
    }
}
