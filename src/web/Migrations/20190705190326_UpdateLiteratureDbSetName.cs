using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class UpdateLiteratureDbSetName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Literature_Publication_PublicationId",
                table: "Literature");

            migrationBuilder.DropForeignKey(
                name: "FK_LiteratureCategory_Literature_LiteratureId",
                table: "LiteratureCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Literature",
                table: "Literature");

            migrationBuilder.RenameTable(
                name: "Literature",
                newName: "LiteratureSet");

            migrationBuilder.RenameIndex(
                name: "IX_Literature_PublicationId",
                table: "LiteratureSet",
                newName: "IX_LiteratureSet_PublicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LiteratureSet",
                table: "LiteratureSet",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LiteratureCategory_LiteratureSet_LiteratureId",
                table: "LiteratureCategory",
                column: "LiteratureId",
                principalTable: "LiteratureSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LiteratureSet_Publication_PublicationId",
                table: "LiteratureSet",
                column: "PublicationId",
                principalTable: "Publication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiteratureCategory_LiteratureSet_LiteratureId",
                table: "LiteratureCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_LiteratureSet_Publication_PublicationId",
                table: "LiteratureSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LiteratureSet",
                table: "LiteratureSet");

            migrationBuilder.RenameTable(
                name: "LiteratureSet",
                newName: "Literature");

            migrationBuilder.RenameIndex(
                name: "IX_LiteratureSet_PublicationId",
                table: "Literature",
                newName: "IX_Literature_PublicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Literature",
                table: "Literature",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Literature_Publication_PublicationId",
                table: "Literature",
                column: "PublicationId",
                principalTable: "Publication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LiteratureCategory_Literature_LiteratureId",
                table: "LiteratureCategory",
                column: "LiteratureId",
                principalTable: "Literature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
