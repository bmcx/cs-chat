using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OwnerId = table.Column<long>(nullable: false),
                    FriendId = table.Column<long>(nullable: false),
                    LastMessage = table.Column<string>(nullable: true),
                    LastMessageBy = table.Column<short>(nullable: false),
                    LastMessageType = table.Column<short>(nullable: false),
                    LastMessageAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChatId = table.Column<long>(nullable: false),
                    SenderId = table.Column<long>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    imagePath = table.Column<string>(nullable: true),
                    Type = table.Column<short>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Chat",
                columns: new[] { "Id", "FriendId", "LastMessage", "LastMessageAt", "LastMessageBy", "LastMessageType", "OwnerId" },
                values: new object[] { 1L, 2L, "hello", new DateTime(2020, 8, 7, 3, 18, 3, 223, DateTimeKind.Local).AddTicks(7305), (short)1, (short)1, 1L });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "Id", "Body", "ChatId", "SenderId", "TimeStamp", "Type", "imagePath" },
                values: new object[] { 1L, "hello", 1L, 1L, new DateTime(2020, 8, 7, 3, 18, 3, 222, DateTimeKind.Local).AddTicks(5833), (short)1, null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "Image", "LastName", "Password", "Phone" },
                values: new object[] { 1L, "jdoe123@gmail.com", "John", "https://randomuser.me/api/portraits/men/72.jpg", "Doe", "1234", "+94711526501" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "Image", "LastName", "Password", "Phone" },
                values: new object[] { 2L, "janed123@gmail.com", "Jane", "https://randomuser.me/api/portraits/women/72.jpg", "Doe", "1234", "+94711526501" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "Image", "LastName", "Password", "Phone" },
                values: new object[] { 3L, "alphabet@gmail.com", "abc", "https://randomuser.me/api/portraits/men/52.jpg", "xyz", "1234", "+94711526501" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
