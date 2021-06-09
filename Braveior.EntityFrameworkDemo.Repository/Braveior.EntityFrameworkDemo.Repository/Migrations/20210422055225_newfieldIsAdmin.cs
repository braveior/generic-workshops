using Microsoft.EntityFrameworkCore.Migrations;

namespace Braveior.EntityFrameworkDemo.Repository.Migrations
{
    public partial class newfieldIsAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 100,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 177,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 190,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 200,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 202,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 204,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 205,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 210,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 213,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 217,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 218,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 220,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 221,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 224,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 227,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 231,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 238,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 242,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 247,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 248,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 249,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 250,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 251,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 254,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 255,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 256,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 262,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 264,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 266,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 267,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 272,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 273,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 274,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 276,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 282,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 285,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 286,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 287,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 296,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 299,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 304,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 306,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 307,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 309,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 312,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 313,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 314,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 318,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 319,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 324,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 325,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 326,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 327,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 329,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 331,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 336,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 341,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 344,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 348,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 351,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 357,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 360,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 364,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 369,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 370,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 371,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 372,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 373,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 375,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 377,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 383,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 386,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 387,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 388,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 392,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 394,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 395,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 399,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 401,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 403,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 406,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 407,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 410,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 411,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 412,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 418,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 419,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 421,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 422,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 425,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 426,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 427,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 435,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 438,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 443,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 444,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 445,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 446,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 447,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 448,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 450,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 451,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 453,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 456,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 460,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 461,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 462,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 468,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 472,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 473,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 475,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 480,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 482,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 500,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 503,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 504,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 505,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 507,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 512,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 513,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 515,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 516,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 518,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 520,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 524,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 531,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 532,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 533,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 534,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 537,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 538,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 549,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 551,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 553,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 557,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 559,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 560,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 561,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 562,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 569,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 570,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 576,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 577,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 578,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 583,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 587,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 589,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 590,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 591,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 593,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 598,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 599,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 604,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 608,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 610,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 615,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 620,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 621,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 628,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 629,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 633,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 634,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 638,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 640,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 644,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 645,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 647,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 652,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 653,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 654,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 656,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 659,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 669,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 670,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 674,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 675,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 677,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 678,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 679,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 681,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 685,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 689,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 691,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 692,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 693,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 700,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 702,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 703,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 705,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 706,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 707,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 708,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 711,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 715,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 720,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 722,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 727,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 728,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 733,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 740,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 741,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 743,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 744,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 747,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 749,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 750,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 755,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 759,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 765,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 766,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 773,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 775,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 781,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 783,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 785,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 788,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 793,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 794,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 796,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 797,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 799,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 800,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 804,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 806,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 809,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 810,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 811,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 816,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 824,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 827,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 829,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 837,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 847,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 848,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 850,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 851,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 852,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 853,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 858,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 860,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 864,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 866,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 868,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 869,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 872,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 873,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 874,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 876,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 877,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 880,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 884,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 887,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 888,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 894,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 895,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 896,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 901,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 906,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 907,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 910,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 912,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 915,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 918,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 920,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 922,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 929,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 931,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 932,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 933,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 934,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 935,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 939,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 940,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 947,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 948,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 949,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 954,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 957,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 960,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 964,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 968,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 972,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 973,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 975,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 978,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 981,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 989,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 990,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 991,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 992,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 993,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 994,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 996,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 997,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 999,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 100,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 177,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 190,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 200,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 202,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 204,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 205,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 210,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 213,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 217,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 218,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 220,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 221,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 224,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 227,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 231,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 238,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 242,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 247,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 248,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 249,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 250,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 251,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 254,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 255,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 256,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 262,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 264,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 266,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 267,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 272,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 273,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 274,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 276,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 282,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 285,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 286,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 287,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 296,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 299,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 304,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 306,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 307,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 309,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 312,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 313,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 314,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 318,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 319,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 324,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 325,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 326,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 327,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 329,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 331,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 336,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 341,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 344,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 348,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 351,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 357,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 360,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 364,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 369,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 370,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 371,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 372,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 373,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 375,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 377,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 383,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 386,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 387,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 388,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 392,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 394,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 395,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 399,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 401,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 403,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 406,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 407,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 410,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 411,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 412,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 418,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 419,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 421,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 422,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 425,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 426,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 427,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 435,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 438,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 443,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 444,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 445,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 446,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 447,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 448,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 450,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 451,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 453,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 456,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 460,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 461,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 462,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 468,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 472,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 473,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 475,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 480,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 482,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 500,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 503,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 504,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 505,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 507,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 512,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 513,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 515,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 516,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 518,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 520,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 524,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 531,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 532,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 533,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 534,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 537,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 538,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 549,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 551,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 553,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 557,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 559,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 560,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 561,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 562,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 569,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 570,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 576,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 577,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 578,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 583,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 587,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 589,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 590,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 591,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 593,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 598,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 599,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 604,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 608,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 610,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 615,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 620,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 621,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 628,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 629,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 633,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 634,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 638,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 640,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 644,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 645,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 647,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 652,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 653,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 654,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 656,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 659,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 669,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 670,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 674,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 675,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 677,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 678,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 679,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 681,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 685,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 689,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 691,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 692,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 693,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 700,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 702,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 703,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 705,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 706,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 707,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 708,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 711,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 715,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 720,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 722,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 727,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 728,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 733,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 740,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 741,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 743,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 744,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 747,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 749,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 750,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 755,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 759,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 765,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 766,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 773,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 775,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 781,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 783,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 785,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 788,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 793,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 794,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 796,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 797,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 799,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 800,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 804,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 806,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 809,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 810,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 811,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 816,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 824,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 827,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 829,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 837,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 847,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 848,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 850,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 851,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 852,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 853,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 858,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 860,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 864,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 866,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 868,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 869,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 872,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 873,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 874,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 876,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 877,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 880,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 884,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 887,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 888,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 894,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 895,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 896,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 901,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 906,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 907,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 910,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 912,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 915,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 918,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 920,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 922,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 929,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 931,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 932,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 933,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 934,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 935,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 939,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 940,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 947,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 948,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 949,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 954,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 957,
                column: "Source",
                value: "App");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 960,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 964,
                column: "Stars",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 968,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 972,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 973,
                column: "Source",
                value: "Internet");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 975,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 978,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 981,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "App", 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Newspaper", 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 989,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 990,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 991,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 992,
                column: "Source",
                value: "Magazine");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 993,
                column: "Source",
                value: "Newspaper");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 994,
                column: "Stars",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 996,
                column: "Stars",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 997,
                column: "Stars",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Magazine", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 999,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "Source", "Stars" },
                values: new object[] { "Internet", 1 });
        }
    }
}
