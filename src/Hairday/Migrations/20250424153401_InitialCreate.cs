using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hairday.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Barbearias",
                columns: table => new
                {
                    CNPJ_barbearia = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barbearias", x => x.CNPJ_barbearia);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id_cliente);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Barbeiros",
                columns: table => new
                {
                    CPF_barbeiro = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ_barbearia = table.Column<string>(type: "varchar(14)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barbeiros", x => x.CPF_barbeiro);
                    table.ForeignKey(
                        name: "FK_Barbeiros_Barbearias_CNPJ_barbearia",
                        column: x => x.CNPJ_barbearia,
                        principalTable: "Barbearias",
                        principalColumn: "CNPJ_barbearia",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    id_agendamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    CPF_barbeiro = table.Column<string>(type: "varchar(11)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ_barbearia = table.Column<string>(type: "varchar(14)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    hora = table.Column<TimeSpan>(type: "time(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.id_agendamento);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Barbearias_CNPJ_barbearia",
                        column: x => x.CNPJ_barbearia,
                        principalTable: "Barbearias",
                        principalColumn: "CNPJ_barbearia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Barbeiros_CPF_barbeiro",
                        column: x => x.CPF_barbeiro,
                        principalTable: "Barbeiros",
                        principalColumn: "CPF_barbeiro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Clientes_id_cliente",
                        column: x => x.id_cliente,
                        principalTable: "Clientes",
                        principalColumn: "id_cliente",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    id_servico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome_servico = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    preco = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CNPJ_barbearia = table.Column<string>(type: "varchar(14)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF_barbeiro = table.Column<string>(type: "varchar(11)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.id_servico);
                    table.ForeignKey(
                        name: "FK_Servicos_Barbearias_CNPJ_barbearia",
                        column: x => x.CNPJ_barbearia,
                        principalTable: "Barbearias",
                        principalColumn: "CNPJ_barbearia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Servicos_Barbeiros_CPF_barbeiro",
                        column: x => x.CPF_barbeiro,
                        principalTable: "Barbeiros",
                        principalColumn: "CPF_barbeiro",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Horario_Disponivel",
                columns: table => new
                {
                    id_horario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CPF_barbeiro = table.Column<string>(type: "varchar(11)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    hora = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    ocupado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    id_agendamento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario_Disponivel", x => x.id_horario);
                    table.ForeignKey(
                        name: "FK_Horario_Disponivel_Agendamentos_id_agendamento",
                        column: x => x.id_agendamento,
                        principalTable: "Agendamentos",
                        principalColumn: "id_agendamento",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Horario_Disponivel_Barbeiros_CPF_barbeiro",
                        column: x => x.CPF_barbeiro,
                        principalTable: "Barbeiros",
                        principalColumn: "CPF_barbeiro",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Agendamento_Servicos",
                columns: table => new
                {
                    id_agendamento = table.Column<int>(type: "int", nullable: false),
                    id_servico = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento_Servicos", x => new { x.id_agendamento, x.id_servico });
                    table.ForeignKey(
                        name: "FK_Agendamento_Servicos_Agendamentos_id_agendamento",
                        column: x => x.id_agendamento,
                        principalTable: "Agendamentos",
                        principalColumn: "id_agendamento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamento_Servicos_Servicos_id_servico",
                        column: x => x.id_servico,
                        principalTable: "Servicos",
                        principalColumn: "id_servico",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_Servicos_id_servico",
                table: "Agendamento_Servicos",
                column: "id_servico");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_CNPJ_barbearia",
                table: "Agendamentos",
                column: "CNPJ_barbearia");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_CPF_barbeiro",
                table: "Agendamentos",
                column: "CPF_barbeiro");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_id_cliente",
                table: "Agendamentos",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Barbearias_email",
                table: "Barbearias",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Barbeiros_CNPJ_barbearia",
                table: "Barbeiros",
                column: "CNPJ_barbearia");

            migrationBuilder.CreateIndex(
                name: "IX_Barbeiros_email",
                table: "Barbeiros",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_email",
                table: "Clientes",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Horario_Disponivel_CPF_barbeiro",
                table: "Horario_Disponivel",
                column: "CPF_barbeiro");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_Disponivel_id_agendamento",
                table: "Horario_Disponivel",
                column: "id_agendamento");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_CNPJ_barbearia",
                table: "Servicos",
                column: "CNPJ_barbearia");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_CPF_barbeiro",
                table: "Servicos",
                column: "CPF_barbeiro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamento_Servicos");

            migrationBuilder.DropTable(
                name: "Horario_Disponivel");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Barbeiros");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Barbearias");
        }
    }
}
