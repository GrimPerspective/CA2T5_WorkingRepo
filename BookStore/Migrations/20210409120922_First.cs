using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Desc", "Name", "UnitPrice" },
                values: new object[] { "Brings powerful charting capabilities to your .NET applications.", ".NET Charts", 99.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Desc", "Name", "UnitPrice" },
                values: new object[] { "Integrate your .NET apps with PayPal the easy way!", ".NET PayPal", 69.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Desc", "Name", "UnitPrice" },
                values: new object[] { "Supercharged .NET machine learning libraries.", ".NET ML", 299.0 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Desc", "Image", "Name", "UnitPrice" },
                values: new object[,]
                {
                    { 4, "Performs data mining and analytics easily in .NET.", "1.png", ".NET Analytics", 299.0 },
                    { 5, "Logs and aggregates events easily in your .NET apps.", "1.png", ".NET Logger", 49.0 },
                    { 6, "Powerful numerical methods for your .NET simulations. ", "1.png", ".NET Numerics", 199.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Desc", "Name", "UnitPrice" },
                values: new object[] { "CAD Designers use technology to help generate designs for complex projects.", "Design CAD", 89.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Desc", "Name", "UnitPrice" },
                values: new object[] { "Designers xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.", "C#", 77.0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Desc", "Name", "UnitPrice" },
                values: new object[] { "Designers xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.", ".Net Core", 66.0 });
        }
    }
}
