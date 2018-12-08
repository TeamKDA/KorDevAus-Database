using Microsoft.EntityFrameworkCore.Migrations;

namespace KorDevAus.Orm.Migrations
{
    public partial class UpdateTableNamesPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupUser_Group_GroupId",
                table: "GroupUser");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupUser_User_UserId",
                table: "GroupUser");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetupEvent_Event_EventId",
                table: "MeetupEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetupEvent_Meetup_MeetupId",
                table: "MeetupEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Meetup_MeetupId",
                table: "Member");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_User_UserId",
                table: "Member");

            migrationBuilder.DropForeignKey(
                name: "FK_Rsvp_Event_EventId",
                table: "Rsvp");

            migrationBuilder.DropForeignKey(
                name: "FK_Rsvp_Member_MemberId",
                table: "Rsvp");

            migrationBuilder.DropForeignKey(
                name: "FK_Waitlist_Event_EventId",
                table: "Waitlist");

            migrationBuilder.DropForeignKey(
                name: "FK_Waitlist_Member_MemberId",
                table: "Waitlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Waitlist",
                table: "Waitlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venue",
                table: "Venue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rsvp",
                table: "Rsvp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Member",
                table: "Member");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MeetupEvent",
                table: "MeetupEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meetup",
                table: "Meetup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupUser",
                table: "GroupUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.RenameTable(
                name: "Waitlist",
                newName: "Waitlists");

            migrationBuilder.RenameTable(
                name: "Venue",
                newName: "Venues");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Rsvp",
                newName: "Rsvps");

            migrationBuilder.RenameTable(
                name: "Member",
                newName: "Members");

            migrationBuilder.RenameTable(
                name: "MeetupEvent",
                newName: "MeetupEvents");

            migrationBuilder.RenameTable(
                name: "Meetup",
                newName: "Meetups");

            migrationBuilder.RenameTable(
                name: "GroupUser",
                newName: "GroupUsers");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Groups");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameIndex(
                name: "IX_Waitlist_MemberId",
                table: "Waitlists",
                newName: "IX_Waitlists_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_Waitlist_EventId",
                table: "Waitlists",
                newName: "IX_Waitlists_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Rsvp_MemberId",
                table: "Rsvps",
                newName: "IX_Rsvps_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_Rsvp_EventId",
                table: "Rsvps",
                newName: "IX_Rsvps_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Member_UserId",
                table: "Members",
                newName: "IX_Members_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Member_MeetupId",
                table: "Members",
                newName: "IX_Members_MeetupId");

            migrationBuilder.RenameIndex(
                name: "IX_MeetupEvent_MeetupId",
                table: "MeetupEvents",
                newName: "IX_MeetupEvents_MeetupId");

            migrationBuilder.RenameIndex(
                name: "IX_MeetupEvent_EventId",
                table: "MeetupEvents",
                newName: "IX_MeetupEvents_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupUser_UserId",
                table: "GroupUsers",
                newName: "IX_GroupUsers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupUser_GroupId",
                table: "GroupUsers",
                newName: "IX_GroupUsers_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_VenueId",
                table: "Events",
                newName: "IX_Events_VenueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Waitlists",
                table: "Waitlists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venues",
                table: "Venues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rsvps",
                table: "Rsvps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Members",
                table: "Members",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeetupEvents",
                table: "MeetupEvents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meetups",
                table: "Meetups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupUsers",
                table: "GroupUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupUsers_Groups_GroupId",
                table: "GroupUsers",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupUsers_Users_UserId",
                table: "GroupUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetupEvents_Events_EventId",
                table: "MeetupEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetupEvents_Meetups_MeetupId",
                table: "MeetupEvents",
                column: "MeetupId",
                principalTable: "Meetups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Meetups_MeetupId",
                table: "Members",
                column: "MeetupId",
                principalTable: "Meetups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Users_UserId",
                table: "Members",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rsvps_Events_EventId",
                table: "Rsvps",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rsvps_Members_MemberId",
                table: "Rsvps",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Waitlists_Events_EventId",
                table: "Waitlists",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Waitlists_Members_MemberId",
                table: "Waitlists",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupUsers_Groups_GroupId",
                table: "GroupUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupUsers_Users_UserId",
                table: "GroupUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetupEvents_Events_EventId",
                table: "MeetupEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetupEvents_Meetups_MeetupId",
                table: "MeetupEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Meetups_MeetupId",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Users_UserId",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Rsvps_Events_EventId",
                table: "Rsvps");

            migrationBuilder.DropForeignKey(
                name: "FK_Rsvps_Members_MemberId",
                table: "Rsvps");

            migrationBuilder.DropForeignKey(
                name: "FK_Waitlists_Events_EventId",
                table: "Waitlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Waitlists_Members_MemberId",
                table: "Waitlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Waitlists",
                table: "Waitlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venues",
                table: "Venues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rsvps",
                table: "Rsvps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Members",
                table: "Members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meetups",
                table: "Meetups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MeetupEvents",
                table: "MeetupEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupUsers",
                table: "GroupUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Waitlists",
                newName: "Waitlist");

            migrationBuilder.RenameTable(
                name: "Venues",
                newName: "Venue");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Rsvps",
                newName: "Rsvp");

            migrationBuilder.RenameTable(
                name: "Members",
                newName: "Member");

            migrationBuilder.RenameTable(
                name: "Meetups",
                newName: "Meetup");

            migrationBuilder.RenameTable(
                name: "MeetupEvents",
                newName: "MeetupEvent");

            migrationBuilder.RenameTable(
                name: "GroupUsers",
                newName: "GroupUser");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Group");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameIndex(
                name: "IX_Waitlists_MemberId",
                table: "Waitlist",
                newName: "IX_Waitlist_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_Waitlists_EventId",
                table: "Waitlist",
                newName: "IX_Waitlist_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Rsvps_MemberId",
                table: "Rsvp",
                newName: "IX_Rsvp_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_Rsvps_EventId",
                table: "Rsvp",
                newName: "IX_Rsvp_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Members_UserId",
                table: "Member",
                newName: "IX_Member_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Members_MeetupId",
                table: "Member",
                newName: "IX_Member_MeetupId");

            migrationBuilder.RenameIndex(
                name: "IX_MeetupEvents_MeetupId",
                table: "MeetupEvent",
                newName: "IX_MeetupEvent_MeetupId");

            migrationBuilder.RenameIndex(
                name: "IX_MeetupEvents_EventId",
                table: "MeetupEvent",
                newName: "IX_MeetupEvent_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupUsers_UserId",
                table: "GroupUser",
                newName: "IX_GroupUser_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupUsers_GroupId",
                table: "GroupUser",
                newName: "IX_GroupUser_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_VenueId",
                table: "Event",
                newName: "IX_Event_VenueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Waitlist",
                table: "Waitlist",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venue",
                table: "Venue",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rsvp",
                table: "Rsvp",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Member",
                table: "Member",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meetup",
                table: "Meetup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeetupEvent",
                table: "MeetupEvent",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupUser",
                table: "GroupUser",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupUser_Group_GroupId",
                table: "GroupUser",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupUser_User_UserId",
                table: "GroupUser",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetupEvent_Event_EventId",
                table: "MeetupEvent",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetupEvent_Meetup_MeetupId",
                table: "MeetupEvent",
                column: "MeetupId",
                principalTable: "Meetup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Meetup_MeetupId",
                table: "Member",
                column: "MeetupId",
                principalTable: "Meetup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_User_UserId",
                table: "Member",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rsvp_Event_EventId",
                table: "Rsvp",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rsvp_Member_MemberId",
                table: "Rsvp",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Waitlist_Event_EventId",
                table: "Waitlist",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Waitlist_Member_MemberId",
                table: "Waitlist",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
