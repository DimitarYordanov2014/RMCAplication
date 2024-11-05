using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RMCAplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class SomeChangesInWarehouseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MechanizationConsumables_Consumable_ConsumableId",
                table: "MechanizationConsumables");

            migrationBuilder.DropForeignKey(
                name: "FK_MechanizationConsumables_Warehouse_ConsuableId",
                table: "MechanizationConsumables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MechanizationConsumables",
                table: "MechanizationConsumables");

            migrationBuilder.DropIndex(
                name: "IX_MechanizationConsumables_ConsuableId",
                table: "MechanizationConsumables");

            migrationBuilder.DropColumn(
                name: "ConsuableId",
                table: "MechanizationConsumables");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Warehouse",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Warehouse",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Tools",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tools",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SpareParts",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Persons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mechanizations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<int>(
                name: "ConsumableId",
                table: "MechanizationConsumables",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Consumable",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Consumable",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MechanizationConsumables",
                table: "MechanizationConsumables",
                columns: new[] { "MechanizationId", "ConsumableId" });

            migrationBuilder.UpdateData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 1,
                column: "WarehouseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 2,
                column: "WarehouseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 3,
                column: "WarehouseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 7,
                column: "WarehouseId",
                value: 3);

            migrationBuilder.InsertData(
                table: "Mechanizations",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Гранул-преса 1" },
                    { 2, false, "Гранул-преса 2" },
                    { 3, false, "Елктрокар 1" },
                    { 4, false, "Елктрокар 2" },
                    { 5, false, "Миксер 1" },
                    { 6, false, "Миксер 2" },
                    { 7, false, "Мерцедес 312" },
                    { 8, false, "ДАФ ХФ - РА5765ВР" },
                    { 9, false, "ДАФ ХФ - РА7133КМ" },
                    { 10, false, "ДАФ ХФ - РА7766КВ" },
                    { 11, false, "Пакетажна линия 1" },
                    { 12, false, "Пакетажна линия 2" },
                    { 13, false, "Пакетажна линия 3" },
                    { 14, false, "Пакетажна линия 4" },
                    { 15, false, "Мелница линия 1" },
                    { 16, false, "Мелница линия 2" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Светослав Ненчев" },
                    { 2, false, "Димитър Присадников" },
                    { 3, false, "Иван Иванов" },
                    { 4, false, "Петър Петров" }
                });

            migrationBuilder.InsertData(
                table: "SpareParts",
                columns: new[] { "Id", "Count", "Description", "IsDeleted", "Name", "Price", "WarehouseId" },
                values: new object[,]
                {
                    { 1, 4, "За Мерцердес", false, "Гума 190/70/16", 234.70m, 4 },
                    { 2, 4, "За ДАФ", false, "Гума 240/70/14", 234.70m, 4 },
                    { 3, 2, "За ДАФ - диферинцялни", false, "Гума 240/70/14", 234.70m, 4 },
                    { 4, 4, "За силози", false, "Елктродвигате 22кв", 1234.70m, 4 },
                    { 5, 4, "За редлери", false, "Елктродвигате 5кв", 234.70m, 3 },
                    { 6, 6, "За елеватор", false, "Елктродвигате 12кв", 234.70m, 3 },
                    { 7, 1, "За мелница", false, "Лента номер 4", 2324.70m, 2 },
                    { 8, 7, "За мелница", false, "Лента номер 5", 2324.70m, 2 },
                    { 9, 4, "За мелница", false, "Лента номер 6", 2324.70m, 2 },
                    { 10, 14, "За офиса", false, "Ремък за шевна машина", 34.70m, 1 },
                    { 11, 2, "За офиса", false, "Принтер", 34.70m, 1 },
                    { 12, 1, "За офиса", false, "Монитор 22 инча", 34.70m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tools",
                columns: new[] { "Id", "Count", "Description", "IsDeleted", "Location", "Name", "PersonId", "Price", "WarehouseId" },
                values: new object[,]
                {
                    { 1, 1, "Малка кутия", false, "Гардероб в ляво.", "Комплект клчове 6 - 22", null, 22.70m, 1 },
                    { 2, 1, "Бош", false, "Третия рафт срещу вратата.", "Шлайф на батерия", null, 232.00m, 1 },
                    { 3, 3, "", false, "", "Статична бормашина", null, 2322.00m, 3 },
                    { 4, 2, "Червено куфарче", false, "Гардероб в ляво.", "Комплект за обслужване на пакетажна машина.", null, 450.70m, 2 },
                    { 5, 4, "", false, "В ляво до стената.", "Комплект за смяна на масло на автомобили.", null, 540.00m, 4 },
                    { 6, 1, "Бензинова", false, "Трети рафт в дясно.", "Косачка за трева", null, 1320.00m, 4 },
                    { 7, 1, "Малък на батерии.", false, "трети рефт от ляво.", "Винтоверт Бош", null, 522.70m, 1 },
                    { 8, 1, "Голям на батерии.", false, null, "Винтоверт Тошиба", null, 452.70m, 1 }
                });

            migrationBuilder.InsertData(
                table: "MechanizationConsumables",
                columns: new[] { "ConsumableId", "MechanizationId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 6, 1 },
                    { 5, 2 },
                    { 6, 2 },
                    { 1, 7 },
                    { 2, 11 },
                    { 3, 11 },
                    { 2, 12 },
                    { 3, 12 },
                    { 2, 13 },
                    { 3, 13 },
                    { 2, 14 },
                    { 3, 14 }
                });

            migrationBuilder.InsertData(
                table: "MechanizationSpareParts",
                columns: new[] { "MechanizationId", "SparePartId" },
                values: new object[,]
                {
                    { 5, 7 },
                    { 5, 8 },
                    { 6, 7 },
                    { 6, 8 },
                    { 7, 1 },
                    { 8, 2 },
                    { 9, 2 },
                    { 10, 2 },
                    { 11, 4 },
                    { 11, 7 },
                    { 11, 8 },
                    { 12, 4 },
                    { 12, 7 },
                    { 12, 8 },
                    { 13, 4 },
                    { 13, 7 },
                    { 13, 8 },
                    { 14, 4 },
                    { 14, 7 },
                    { 14, 8 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MechanizationConsumables_Consumable_ConsumableId",
                table: "MechanizationConsumables",
                column: "ConsumableId",
                principalTable: "Consumable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MechanizationConsumables_Consumable_ConsumableId",
                table: "MechanizationConsumables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MechanizationConsumables",
                table: "MechanizationConsumables");

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "MechanizationConsumables",
                keyColumns: new[] { "ConsumableId", "MechanizationId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "MechanizationSpareParts",
                keyColumns: new[] { "MechanizationId", "SparePartId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tools",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tools",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tools",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tools",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tools",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tools",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Mechanizations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SpareParts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Warehouse",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Warehouse",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Tools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tools",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SpareParts",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Persons",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Mechanizations",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "ConsumableId",
                table: "MechanizationConsumables",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ConsuableId",
                table: "MechanizationConsumables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Consumable",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Consumable",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MechanizationConsumables",
                table: "MechanizationConsumables",
                columns: new[] { "MechanizationId", "ConsuableId" });

            migrationBuilder.UpdateData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 1,
                column: "WarehouseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 2,
                column: "WarehouseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 3,
                column: "WarehouseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 7,
                column: "WarehouseId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_MechanizationConsumables_ConsuableId",
                table: "MechanizationConsumables",
                column: "ConsuableId");

            migrationBuilder.AddForeignKey(
                name: "FK_MechanizationConsumables_Consumable_ConsumableId",
                table: "MechanizationConsumables",
                column: "ConsumableId",
                principalTable: "Consumable",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MechanizationConsumables_Warehouse_ConsuableId",
                table: "MechanizationConsumables",
                column: "ConsuableId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
