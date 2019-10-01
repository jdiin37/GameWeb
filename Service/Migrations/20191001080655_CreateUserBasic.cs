using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class CreateUserBasic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserBasic",
                columns: table => new
                {
                    Gid = table.Column<Guid>(nullable: false),
                    Account = table.Column<string>(maxLength: 20, nullable: false),
                    HashedPassword = table.Column<string>(nullable: false),
                    Enable = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Sex = table.Column<int>(nullable: false),
                    NickName = table.Column<string>(maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    LineId = table.Column<string>(maxLength: 50, nullable: true),
                    Hospital = table.Column<string>(nullable: true),
                    Sexual = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    Career = table.Column<string>(nullable: true),
                    Income = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBasic", x => x.Gid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBasic");
        }
    }
}
