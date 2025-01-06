using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternLink.Migrations
{
    /// <inheritdoc />
    public partial class Createdadditionalrelationshipsforeasilyaccessingswipesprofilesfromlinkedentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Swipes_Internships_InternshipId",
                table: "Swipes");

            migrationBuilder.AddColumn<int>(
                name: "StudentProfileId",
                table: "Swipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Swipes_StudentProfileId",
                table: "Swipes",
                column: "StudentProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Swipes_Internships_InternshipId",
                table: "Swipes",
                column: "InternshipId",
                principalTable: "Internships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Swipes_StudentProfiles_StudentProfileId",
                table: "Swipes",
                column: "StudentProfileId",
                principalTable: "StudentProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Swipes_Internships_InternshipId",
                table: "Swipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Swipes_StudentProfiles_StudentProfileId",
                table: "Swipes");

            migrationBuilder.DropIndex(
                name: "IX_Swipes_StudentProfileId",
                table: "Swipes");

            migrationBuilder.DropColumn(
                name: "StudentProfileId",
                table: "Swipes");

            migrationBuilder.AddForeignKey(
                name: "FK_Swipes_Internships_InternshipId",
                table: "Swipes",
                column: "InternshipId",
                principalTable: "Internships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
