using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternLink.Migrations
{
    /// <inheritdoc />
    public partial class InternshipsFKCompanyLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Internships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Internships_CompanyId",
                table: "Internships",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Internships_CompanyProfiles_CompanyId",
                table: "Internships",
                column: "CompanyId",
                principalTable: "CompanyProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Internships_CompanyProfiles_CompanyId",
                table: "Internships");

            migrationBuilder.DropIndex(
                name: "IX_Internships_CompanyId",
                table: "Internships");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Internships");
        }
    }
}
