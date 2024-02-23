using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoRH.Migrations
{
    public partial class CriandoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setores",
                columns: table => new
                {
                    CodSetor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeSetor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setores", x => x.CodSetor);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gerentes",
                columns: table => new
                {
                    CodGerente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeGerente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodSetor = table.Column<int>(type: "int", nullable: true),
                    Cpf = table.Column<int>(type: "int", nullable: false),
                    Cep = table.Column<int>(type: "int", nullable: false),
                    TelContato = table.Column<int>(type: "int", nullable: false),
                    ContatoEmergencia = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modalidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorExtra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HorasTrabalhadas = table.Column<int>(type: "int", nullable: false),
                    HorasExtras = table.Column<int>(type: "int", nullable: true),
                    SalarioTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CodSetorNavigationCodSetor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gerentes", x => x.CodGerente);
                    table.ForeignKey(
                        name: "FK_Gerentes_Setores_CodSetorNavigationCodSetor",
                        column: x => x.CodSetorNavigationCodSetor,
                        principalTable: "Setores",
                        principalColumn: "CodSetor");
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    CodCargo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescricaoCargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalarioBase = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CodGerente = table.Column<int>(type: "int", nullable: true),
                    CodGerenteNavigationCodGerente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.CodCargo);
                    table.ForeignKey(
                        name: "FK_Cargos_Gerentes_CodGerenteNavigationCodGerente",
                        column: x => x.CodGerenteNavigationCodGerente,
                        principalTable: "Gerentes",
                        principalColumn: "CodGerente");
                });

            migrationBuilder.CreateTable(
                name: "BancoTalentos",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<int>(type: "int", nullable: false),
                    Cep = table.Column<int>(type: "int", nullable: false),
                    TelContato = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodCargo = table.Column<int>(type: "int", nullable: true),
                    DataEntrevista = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotaEntrevista = table.Column<int>(type: "int", nullable: false),
                    CodEntrevistador = table.Column<int>(type: "int", nullable: false),
                    CodCargoNavigationCodCargo = table.Column<int>(type: "int", nullable: true),
                    CodEntrevistadorNavigationCodGerente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BancoTalentos", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "FK_BancoTalentos_Cargos_CodCargoNavigationCodCargo",
                        column: x => x.CodCargoNavigationCodCargo,
                        principalTable: "Cargos",
                        principalColumn: "CodCargo");
                    table.ForeignKey(
                        name: "FK_BancoTalentos_Gerentes_CodEntrevistadorNavigationCodGerente",
                        column: x => x.CodEntrevistadorNavigationCodGerente,
                        principalTable: "Gerentes",
                        principalColumn: "CodGerente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<int>(type: "int", nullable: false),
                    Cep = table.Column<int>(type: "int", nullable: false),
                    TelContato = table.Column<int>(type: "int", nullable: false),
                    ContatoEmergencia = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodCargo = table.Column<int>(type: "int", nullable: true),
                    Modalidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorExtra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HorasTrabalhadas = table.Column<int>(type: "int", nullable: false),
                    HorasExtras = table.Column<int>(type: "int", nullable: true),
                    SalarioTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ferias = table.Column<bool>(type: "bit", nullable: true),
                    CodCargoNavigationCodCargo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Cargos_CodCargoNavigationCodCargo",
                        column: x => x.CodCargoNavigationCodCargo,
                        principalTable: "Cargos",
                        principalColumn: "CodCargo");
                });

            migrationBuilder.CreateTable(
                name: "FuncionariosInativos",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<int>(type: "int", nullable: false),
                    Cep = table.Column<int>(type: "int", nullable: false),
                    TelContato = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodCargo = table.Column<int>(type: "int", nullable: true),
                    Modalidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDesligamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodCargoNavigationCodCargo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionariosInativos", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "FK_FuncionariosInativos_Cargos_CodCargoNavigationCodCargo",
                        column: x => x.CodCargoNavigationCodCargo,
                        principalTable: "Cargos",
                        principalColumn: "CodCargo");
                });

            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    IdAdm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFuncionario = table.Column<int>(type: "int", nullable: true),
                    IdFuncionarioNavigationIdFuncionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.IdAdm);
                    table.ForeignKey(
                        name: "FK_Administradores_Funcionarios_IdFuncionarioNavigationIdFuncionario",
                        column: x => x.IdFuncionarioNavigationIdFuncionario,
                        principalTable: "Funcionarios",
                        principalColumn: "IdFuncionario");
                });

            migrationBuilder.CreateTable(
                name: "Treinamentos",
                columns: table => new
                {
                    IdTreinamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFuncionario = table.Column<int>(type: "int", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataTermino = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdFuncionarioNavigationIdFuncionario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinamentos", x => x.IdTreinamento);
                    table.ForeignKey(
                        name: "FK_Treinamentos_Funcionarios_IdFuncionarioNavigationIdFuncionario",
                        column: x => x.IdFuncionarioNavigationIdFuncionario,
                        principalTable: "Funcionarios",
                        principalColumn: "IdFuncionario");
                });

            migrationBuilder.CreateTable(
                name: "FolhaPagamentos",
                columns: table => new
                {
                    IdLancamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponsavelLancamento = table.Column<int>(type: "int", nullable: true),
                    IdFuncionario = table.Column<int>(type: "int", nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorBase = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descontos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorFinal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdFuncionarioNavigationIdFuncionario = table.Column<int>(type: "int", nullable: true),
                    ResponsavelLancamentoNavigationIdAdm = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolhaPagamentos", x => x.IdLancamento);
                    table.ForeignKey(
                        name: "FK_FolhaPagamentos_Administradores_ResponsavelLancamentoNavigationIdAdm",
                        column: x => x.ResponsavelLancamentoNavigationIdAdm,
                        principalTable: "Administradores",
                        principalColumn: "IdAdm");
                    table.ForeignKey(
                        name: "FK_FolhaPagamentos_Funcionarios_IdFuncionarioNavigationIdFuncionario",
                        column: x => x.IdFuncionarioNavigationIdFuncionario,
                        principalTable: "Funcionarios",
                        principalColumn: "IdFuncionario");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administradores_IdFuncionarioNavigationIdFuncionario",
                table: "Administradores",
                column: "IdFuncionarioNavigationIdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BancoTalentos_CodCargoNavigationCodCargo",
                table: "BancoTalentos",
                column: "CodCargoNavigationCodCargo");

            migrationBuilder.CreateIndex(
                name: "IX_BancoTalentos_CodEntrevistadorNavigationCodGerente",
                table: "BancoTalentos",
                column: "CodEntrevistadorNavigationCodGerente");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_CodGerenteNavigationCodGerente",
                table: "Cargos",
                column: "CodGerenteNavigationCodGerente");

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamentos_IdFuncionarioNavigationIdFuncionario",
                table: "FolhaPagamentos",
                column: "IdFuncionarioNavigationIdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamentos_ResponsavelLancamentoNavigationIdAdm",
                table: "FolhaPagamentos",
                column: "ResponsavelLancamentoNavigationIdAdm");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_CodCargoNavigationCodCargo",
                table: "Funcionarios",
                column: "CodCargoNavigationCodCargo");

            migrationBuilder.CreateIndex(
                name: "IX_FuncionariosInativos_CodCargoNavigationCodCargo",
                table: "FuncionariosInativos",
                column: "CodCargoNavigationCodCargo");

            migrationBuilder.CreateIndex(
                name: "IX_Gerentes_CodSetorNavigationCodSetor",
                table: "Gerentes",
                column: "CodSetorNavigationCodSetor");

            migrationBuilder.CreateIndex(
                name: "IX_Treinamentos_IdFuncionarioNavigationIdFuncionario",
                table: "Treinamentos",
                column: "IdFuncionarioNavigationIdFuncionario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BancoTalentos");

            migrationBuilder.DropTable(
                name: "FolhaPagamentos");

            migrationBuilder.DropTable(
                name: "FuncionariosInativos");

            migrationBuilder.DropTable(
                name: "Treinamentos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Gerentes");

            migrationBuilder.DropTable(
                name: "Setores");
        }
    }
}
