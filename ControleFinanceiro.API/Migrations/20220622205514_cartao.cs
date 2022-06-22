using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleFinanceiro.API.Migrations
{
    /// <inheritdoc />
    public partial class cartao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_despesa_cartao_idCartao",
                table: "despesa");

            migrationBuilder.AlterColumn<int>(
                name: "idCartao",
                table: "despesa",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_despesa_cartao_idCartao",
                table: "despesa",
                column: "idCartao",
                principalTable: "cartao",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_despesa_cartao_idCartao",
                table: "despesa");

            migrationBuilder.AlterColumn<int>(
                name: "idCartao",
                table: "despesa",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_despesa_cartao_idCartao",
                table: "despesa",
                column: "idCartao",
                principalTable: "cartao",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
