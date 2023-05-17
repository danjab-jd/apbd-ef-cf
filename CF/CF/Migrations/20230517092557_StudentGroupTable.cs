using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CF.Migrations
{
    /// <inheritdoc />
    public partial class StudentGroupTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student_Group",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    IdGroup = table.Column<int>(type: "int", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("StudentGroup_pk", x => new { x.IdGroup, x.IdStudent });
                    table.ForeignKey(
                        name: "StudentGroup_Group",
                        column: x => x.IdGroup,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "StudentGroup_Student",
                        column: x => x.IdStudent,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Group_IdStudent",
                table: "Student_Group",
                column: "IdStudent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student_Group");
        }
    }
}
