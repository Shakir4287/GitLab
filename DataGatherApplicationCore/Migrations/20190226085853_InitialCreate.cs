using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataGatherApplicationCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "peoples",
                columns: table => new
                {
                    PeopleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PeopleFirstName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PeopleLastName = table.Column<string>(nullable: false),
                    PeopleProfession = table.Column<string>(nullable: false),
                    PeoplePhoneNumber = table.Column<int>(nullable: false),
                    PeopleAddress = table.Column<string>(nullable: false),
                    PeopleCity = table.Column<string>(nullable: false),
                    PeopleCountry = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_peoples", x => x.PeopleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "peoples");
        }
    }
}
