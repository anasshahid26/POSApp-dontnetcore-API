using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace POSApp.API.Migrations
{
    public partial class itemstableadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    supplier_id = table.Column<int>(nullable: false),
                    item_number = table.Column<string>(nullable: true),
                    product_id = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    tax_included = table.Column<int>(nullable: false),
                    cost_price = table.Column<decimal>(nullable: false),
                    unit_price = table.Column<decimal>(nullable: false),
                    promo_price = table.Column<decimal>(nullable: false),
                    start_date = table.Column<DateTime>(nullable: false),
                    end_date = table.Column<DateTime>(nullable: false),
                    reorder_level = table.Column<decimal>(nullable: false),
                    item_id = table.Column<int>(nullable: false),
                    allow_alt_description = table.Column<int>(nullable: false),
                    is_serialized = table.Column<int>(nullable: false),
                    image_id = table.Column<int>(nullable: false),
                    override_default_tax = table.Column<int>(nullable: false),
                    is_service = table.Column<int>(nullable: false),
                    deleted = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
