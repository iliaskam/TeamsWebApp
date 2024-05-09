using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamsWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbluser",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbluser", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "tbluser",
                columns: new[] { "ID", "FullName" },
                values: new object[,]
                {
                    { 1, "John Smith" },
                    { 2, "Jane Johnson" }
                });

            migrationBuilder.CreateTable(
                name: "tblDiscussion",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDUserFrom = table.Column<int>(type: "int", nullable: false),
                    IDUserTo = table.Column<int>(type: "int", nullable: false),
                    ChatText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDiscussion", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_tblDiscussion_tbluser_IDUserFrom",
                        column: x => x.IDUserFrom,
                        principalTable: "tbluser",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_tblDiscussion_tbluser_IDUserTo",
                        column: x => x.IDUserTo,
                        principalTable: "tbluser",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "tblDiscussion",
                columns: new[] { "IDUserFrom", "IDUserTo", "ChatText", "DateTime" },
                values: new object[,]
                {
                    { 2, 1, "Hi, John!", new DateTime(2024, 5, 9, 12, 10, 20) },
                    { 1, 2, "Hello, Jane!", new DateTime(2024, 5, 9, 12, 10, 21) },
                    { 2, 1, "How are you?", new DateTime(2024, 5, 9, 12, 10, 22) },
                    { 1, 2, "I'm good, thanks!", new DateTime(2024, 5, 9, 12, 10, 23) },
                    { 2, 1, "What are you doing today?", new DateTime(2024, 5, 9, 12, 10, 24) },
                    { 1, 2, "Just working on some projects.", new DateTime(2024, 5, 9, 12, 10, 25) },
                    { 2, 1, "Sounds busy!", new DateTime(2024, 5, 9, 12, 10, 26) },
                    { 1, 2, "Yeah, but it's manageable.", new DateTime(2024, 5, 9, 12, 10, 27) },
                    { 2, 1, "That's good to hear.", new DateTime(2024, 5, 9, 12, 10, 28) },
                    { 1, 2, "How about you?", new DateTime(2024, 5, 9, 12, 10, 29) },
                    { 2, 1, "I'm just relaxing at home.", new DateTime(2024, 5, 9, 12, 10, 30) },
                    { 1, 2, "Nice! Enjoy your day off.", new DateTime(2024, 5, 9, 12, 10, 31) },
                    { 2, 1, "Thanks, John!", new DateTime(2024, 5, 9, 12, 10, 32) },
                    { 1, 2, "Anytime!", new DateTime(2024, 5, 9, 12, 10, 33) },
                    { 2, 1, "Talk to you later.", new DateTime(2024, 5, 9, 12, 10, 34) },
                    { 1, 2, "Sure, bye!", new DateTime(2024, 5, 9, 12, 10, 35) },
                    { 2, 1, "Bye!", new DateTime(2024, 5, 9, 12, 10, 36) },
                    { 1, 2, "Hi again!", new DateTime(2024, 5, 9, 12, 10, 37) },
                    { 2, 1, "Hey!", new DateTime(2024, 5, 9, 12, 10, 38) },
                    { 1, 2, "What's up?", new DateTime(2024, 5, 9, 12, 10, 39) },
                    { 2, 1, "Not much, just watching TV.", new DateTime(2024, 5, 9, 12, 10, 40) },
                    { 2, 1, "Happy Birthday.", new DateTime(2024, 5, 5, 12, 10, 40) },
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblDiscussion_IDUserFrom",
                table: "tblDiscussion",
                column: "IDUserFrom");

            migrationBuilder.CreateIndex(
                name: "IX_tblDiscussion_IDUserTo",
                table: "tblDiscussion",
                column: "IDUserTo");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbluser");

            migrationBuilder.DropTable(
                name: "tblDiscussion");
        }
    }
}
