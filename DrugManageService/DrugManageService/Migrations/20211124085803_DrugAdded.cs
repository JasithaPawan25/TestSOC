using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrugManageService.Migrations
{
    public partial class DrugAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

           /* migrationBuilder.CreateTable(
               name: "Drugs",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Price = table.Column<int>(type: "int", nullable: true),
                   SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Quantity = table.Column<int>(type: "int", nullable: false),
                   ExpDate = table.Column<DateOnly>(type: "DateOnly", nullable: true),
                   MnfDate = table.Column<DateOnly>(type: "DateOnly", nullable: true),
                   brandName = table.Column<string>(type: "nvarchar(max)", nullable: false)



                   /*
                   
                     public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string SupplierName { get; set; }
        public string Discription { get; set; }
        public int Quantity { get; set; }
        public DateOnly ExpDate { get; set; }
        public DateOnly MnfDate { get; set; }
        public string brandName { get; set; }

                    */



/*

               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Suppliers", x => x.Id);
               });
            */

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropTable(
              name: "Drugs");*/

        }
    }
}
