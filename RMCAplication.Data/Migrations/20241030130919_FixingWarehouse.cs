using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RMCAplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixingWarehouse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumables_Warehouses_WarehouseId",
                table: "Consumables");

            migrationBuilder.DropForeignKey(
                name: "FK_MechanizationConsumables_Consumables_ConsuableId",
                table: "MechanizationConsumables");

            migrationBuilder.DropForeignKey(
                name: "FK_SpareParts_Warehouses_WarehouseId",
                table: "SpareParts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tools_Warehouses_WarehouseId",
                table: "Tools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consumables",
                table: "Consumables");

            migrationBuilder.RenameTable(
                name: "Warehouses",
                newName: "Warehouse");

            migrationBuilder.RenameTable(
                name: "Consumables",
                newName: "Consumable");

            migrationBuilder.RenameIndex(
                name: "IX_Consumables_WarehouseId",
                table: "Consumable",
                newName: "IX_Consumable_WarehouseId");

            migrationBuilder.AddColumn<int>(
                name: "ConsumableId",
                table: "MechanizationConsumables",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consumable",
                table: "Consumable",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "Id", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Намира се в търговската част на фирмата. В него се съхраняват важните резервни части и повечето инструменти", false, "Централен склад" },
                    { 2, "Намира се в производсвото на фирмата. В него се съхраняват резервни части за призводството", false, "Производствен склад" },
                    { 3, "Намира се в двора на фирмата. В него се извършват повечето ремонтни дейност.", false, "Ремонтна стая" },
                    { 4, "Намира се в двора на фирмата. В него се съхраняват резервни части и автомобилни гуми.", false, "Авто-мото склад" }
                });

            migrationBuilder.InsertData(
                table: "Consumable",
                columns: new[] { "Id", "Count", "Description", "IsDeleted", "Name", "Price", "WarehouseId" },
                values: new object[,]
                {
                    { 1, 5, "Масло за малки превозни средства, Сменя се на 15 000 км.", false, "Масло 5/40 Мобил", 2.70m, 2 },
                    { 2, 3, "За малки шевни машини. Сменя се когато изгори.", false, "Мотор за шевна машина", 45.50m, 2 },
                    { 3, 5, "За малки шевни машини. Сменя се когато свърши.", false, "Макри за шевни машини", 2.70m, 2 },
                    { 4, 5, "Става за всички видове мелници.", false, "Сито номе 4", 320m, 2 },
                    { 5, 15, "Става за всички видове мелници.", false, "Сито номе 5", 450m, 2 },
                    { 6, 8, "Става за всички видове мелници.", false, "Сито номе 3", 325m, 2 },
                    { 7, 5, "Става за всички лампи на паркинга и двора.", false, "Лампа за улично осветление", 32.40m, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MechanizationConsumables_ConsumableId",
                table: "MechanizationConsumables",
                column: "ConsumableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumable_Warehouse_WarehouseId",
                table: "Consumable",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_SpareParts_Warehouse_WarehouseId",
                table: "SpareParts",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tools_Warehouse_WarehouseId",
                table: "Tools",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumable_Warehouse_WarehouseId",
                table: "Consumable");

            migrationBuilder.DropForeignKey(
                name: "FK_MechanizationConsumables_Consumable_ConsumableId",
                table: "MechanizationConsumables");

            migrationBuilder.DropForeignKey(
                name: "FK_MechanizationConsumables_Warehouse_ConsuableId",
                table: "MechanizationConsumables");

            migrationBuilder.DropForeignKey(
                name: "FK_SpareParts_Warehouse_WarehouseId",
                table: "SpareParts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tools_Warehouse_WarehouseId",
                table: "Tools");

            migrationBuilder.DropIndex(
                name: "IX_MechanizationConsumables_ConsumableId",
                table: "MechanizationConsumables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consumable",
                table: "Consumable");

            migrationBuilder.DeleteData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Consumable",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Warehouse",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ConsumableId",
                table: "MechanizationConsumables");

            migrationBuilder.RenameTable(
                name: "Warehouse",
                newName: "Warehouses");

            migrationBuilder.RenameTable(
                name: "Consumable",
                newName: "Consumables");

            migrationBuilder.RenameIndex(
                name: "IX_Consumable_WarehouseId",
                table: "Consumables",
                newName: "IX_Consumables_WarehouseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouses",
                table: "Warehouses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consumables",
                table: "Consumables",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumables_Warehouses_WarehouseId",
                table: "Consumables",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MechanizationConsumables_Consumables_ConsuableId",
                table: "MechanizationConsumables",
                column: "ConsuableId",
                principalTable: "Consumables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpareParts_Warehouses_WarehouseId",
                table: "SpareParts",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tools_Warehouses_WarehouseId",
                table: "Tools",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
