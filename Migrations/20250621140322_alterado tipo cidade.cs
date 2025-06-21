using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenaiApi.Migrations
{
    /// <inheritdoc />
    public partial class alteradotipocidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //  migrationBuilder.AlterColumn<int>(
            //  name: "Cidade",
            //  table: "Endereco",
            //  type: "integer",
            //  maxLength: 60,
            //  nullable: false,
            //  oldClrType: typeof(string),
            //  oldType: "character varying(50)",
            //  oldMaxLength: 50);
            migrationBuilder.Sql(@"
            ALTERE TABLE ""eNDERECO""
            ALTERE COLUMN ""Cidade"" TYPE integer
            USING ""Cidade""::integer;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 60);
        }
    }
}
