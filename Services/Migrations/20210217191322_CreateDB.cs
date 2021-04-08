using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "tblContactInfoAccountDetails",
                columns: table => new
                {
                    ContactInfoAccountDetailsId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryEmail = table.Column<string>(nullable: true),
                    SecondaryEmail = table.Column<string>(nullable: false),
                    PrimaryPhone = table.Column<string>(nullable: false),
                    SecondaryPhone = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    FilePath = table.Column<string>(nullable: false),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblContactInfoAccountDetails", x => x.ContactInfoAccountDetailsId);
                    table.ForeignKey(
                        name: "FK_tblContactInfoAccountDetails_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblContactInfoBusiness",
                columns: table => new
                {
                    ContactInfoBusinessId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryEmail = table.Column<string>(nullable: false),
                    SecondaryEmail = table.Column<string>(nullable: false),
                    PrimaryPhone = table.Column<string>(nullable: false),
                    SecondaryPhone = table.Column<string>(nullable: false),
                    SaveASAccountDetails = table.Column<bool>(nullable: false),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblContactInfoBusiness", x => x.ContactInfoBusinessId);
                    table.ForeignKey(
                        name: "FK_tblContactInfoBusiness_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblIdentifiaction",
                columns: table => new
                {
                    IdentifiactionId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Suffix = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Ethencity = table.Column<string>(nullable: false),
                    GovernmentName = table.Column<string>(nullable: false),
                    FilePath = table.Column<string>(nullable: false),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblIdentifiaction", x => x.IdentifiactionId);
                    table.ForeignKey(
                        name: "FK_tblIdentifiaction_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblLegalInfo",
                columns: table => new
                {
                    LegalInfoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessLogo = table.Column<string>(nullable: false),
                    LegalBusinessName = table.Column<string>(nullable: false),
                    FilePath1 = table.Column<string>(nullable: false),
                    FilePath2 = table.Column<string>(nullable: false),
                    FilePath3 = table.Column<string>(nullable: false),
                    LegalStructure = table.Column<string>(nullable: false),
                    LicenseNumber = table.Column<string>(nullable: false),
                    OwnershipType = table.Column<string>(nullable: false),
                    Industry = table.Column<string>(nullable: false),
                    DateEstablished = table.Column<DateTime>(nullable: false),
                    AnnaulRvenue = table.Column<double>(nullable: false),
                    EstimentalWorth = table.Column<string>(nullable: false),
                    BusinessSpendPerMonth = table.Column<string>(nullable: false),
                    LargestEstimentPurchase = table.Column<double>(nullable: false),
                    EstimentEcommercePrice = table.Column<double>(nullable: false),
                    LargestPeriodWithoutRevenue = table.Column<double>(nullable: false),
                    FilePath = table.Column<string>(nullable: false),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLegalInfo", x => x.LegalInfoId);
                    table.ForeignKey(
                        name: "FK_tblLegalInfo_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblResidence",
                columns: table => new
                {
                    ResidenceId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitzenshipCountry = table.Column<string>(nullable: false),
                    ResidingCountry = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(nullable: false),
                    SuitApt = table.Column<string>(nullable: false),
                    StateProvince = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblResidence", x => x.ResidenceId);
                    table.ForeignKey(
                        name: "FK_tblResidence_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblSecure",
                columns: table => new
                {
                    SecureId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecurityQuestion1 = table.Column<string>(nullable: false),
                    Answer1 = table.Column<string>(nullable: false),
                    SecurityQuestion2 = table.Column<string>(nullable: false),
                    Answer2 = table.Column<string>(nullable: false),
                    UserId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSecure", x => x.SecureId);
                    table.ForeignKey(
                        name: "FK_tblSecure_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblContactInfoAccountDetails_UserId",
                table: "tblContactInfoAccountDetails",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblContactInfoBusiness_UserId",
                table: "tblContactInfoBusiness",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblIdentifiaction_UserId",
                table: "tblIdentifiaction",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblLegalInfo_UserId",
                table: "tblLegalInfo",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblResidence_UserId",
                table: "tblResidence",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tblSecure_UserId",
                table: "tblSecure",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblContactInfoAccountDetails");

            migrationBuilder.DropTable(
                name: "tblContactInfoBusiness");

            migrationBuilder.DropTable(
                name: "tblIdentifiaction");

            migrationBuilder.DropTable(
                name: "tblLegalInfo");

            migrationBuilder.DropTable(
                name: "tblResidence");

            migrationBuilder.DropTable(
                name: "tblSecure");

            migrationBuilder.DropTable(
                name: "tblUser");
        }
    }
}
