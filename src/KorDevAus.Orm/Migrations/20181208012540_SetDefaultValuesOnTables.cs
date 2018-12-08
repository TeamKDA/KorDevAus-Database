using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KorDevAus.Orm.Migrations
{
    public partial class SetDefaultValuesOnTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Waitlist",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Waitlist",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Venue",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Venue",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "User",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "User",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Rsvp",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Rsvp",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Member",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateJoined",
                table: "Member",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Member",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "MeetupEvent",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "MeetupEvent",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Meetup",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Meetup",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "GroupUser",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateJoined",
                table: "GroupUser",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "GroupUser",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Group",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Group",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Event",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Event",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTimeOffset));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Waitlist",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Waitlist",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Venue",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Venue",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "User",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "User",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Rsvp",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Rsvp",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Member",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateJoined",
                table: "Member",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Member",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "MeetupEvent",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "MeetupEvent",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Meetup",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Meetup",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "GroupUser",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateJoined",
                table: "GroupUser",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "GroupUser",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Group",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Group",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "Event",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Event",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
