using Microsoft.EntityFrameworkCore.Migrations;

namespace DocsGeniusWebAPI.Migrations
{
    public partial class SetTableRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatedDocs_Fields_FieldId",
                table: "CreatedDocs");

            migrationBuilder.DropIndex(
                name: "IX_CreatedDocs_FieldId",
                table: "CreatedDocs");

            migrationBuilder.DropColumn(
                name: "FieldId",
                table: "CreatedDocs");

            migrationBuilder.AddColumn<int>(
                name: "FieldAuxId",
                table: "CreatedDocs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fields_DocTemplateId",
                table: "Fields",
                column: "DocTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatedDocs_DocTemplateId",
                table: "CreatedDocs",
                column: "DocTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatedDocs_DocTemplates_DocTemplateId",
                table: "CreatedDocs",
                column: "DocTemplateId",
                principalTable: "DocTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fields_DocTemplates_DocTemplateId",
                table: "Fields",
                column: "DocTemplateId",
                principalTable: "DocTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreatedDocs_DocTemplates_DocTemplateId",
                table: "CreatedDocs");

            migrationBuilder.DropForeignKey(
                name: "FK_Fields_DocTemplates_DocTemplateId",
                table: "Fields");

            migrationBuilder.DropIndex(
                name: "IX_Fields_DocTemplateId",
                table: "Fields");

            migrationBuilder.DropIndex(
                name: "IX_CreatedDocs_DocTemplateId",
                table: "CreatedDocs");

            migrationBuilder.DropColumn(
                name: "FieldAuxId",
                table: "CreatedDocs");

            migrationBuilder.AddColumn<int>(
                name: "FieldId",
                table: "CreatedDocs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CreatedDocs_FieldId",
                table: "CreatedDocs",
                column: "FieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_CreatedDocs_Fields_FieldId",
                table: "CreatedDocs",
                column: "FieldId",
                principalTable: "Fields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
