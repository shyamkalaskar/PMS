using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Migrations
{
    /// <inheritdoc />
    public partial class CategoryChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "CateogryModels",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "companyId",
                table: "CateogryModels",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "CateogryModels",
                newName: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "CateogryModels",
                newName: "isDelete");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "CateogryModels",
                newName: "companyId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "CateogryModels",
                newName: "categoryId");
        }
    }
}
