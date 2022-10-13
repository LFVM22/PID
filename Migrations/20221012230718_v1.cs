using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Antecedentes",
                columns: table => new
                {
                    IdAntecedente = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Traco = table.Column<string>(type: "TEXT", nullable: false),
                    Ideal = table.Column<string>(type: "TEXT", nullable: false),
                    Vinculo = table.Column<string>(type: "TEXT", nullable: false),
                    Defeito = table.Column<string>(type: "TEXT", nullable: false),
                    Habilidade = table.Column<string>(type: "TEXT", nullable: false),
                    Proficiencia = table.Column<string>(type: "TEXT", nullable: false),
                    IdiomaQtd = table.Column<int>(type: "INTEGER", nullable: true),
                    Equipamento = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antecedentes", x => x.IdAntecedente);
                });

            migrationBuilder.CreateTable(
                name: "Arquetipos",
                columns: table => new
                {
                    IdArquetipo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    HabilidadeArquetipo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquetipos", x => x.IdArquetipo);
                });

            migrationBuilder.CreateTable(
                name: "ASVTracoes",
                columns: table => new
                {
                    IdASVTracao = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Preco = table.Column<string>(type: "TEXT", nullable: true),
                    Peso = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASVTracoes", x => x.IdASVTracao);
                });

            migrationBuilder.CreateTable(
                name: "Designers",
                columns: table => new
                {
                    IdDesigner = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designers", x => x.IdDesigner);
                });

            migrationBuilder.CreateTable(
                name: "HabilidadesRaciais",
                columns: table => new
                {
                    IdHabilidadeRacial = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilidadesRaciais", x => x.IdHabilidadeRacial);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    IdItem = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Peso = table.Column<string>(type: "TEXT", nullable: false),
                    Preco = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.IdItem);
                });

            migrationBuilder.CreateTable(
                name: "ListasMagias",
                columns: table => new
                {
                    IdListaMagia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListasMagias", x => x.IdListaMagia);
                });

            migrationBuilder.CreateTable(
                name: "Personagens_Armaduras",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdArmadura = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens_Armaduras", x => new { x.IdPersonagem, x.IdArmadura });
                });

            migrationBuilder.CreateTable(
                name: "Personagens_Armas",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdArma = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens_Armas", x => new { x.IdPersonagem, x.IdArma });
                });

            migrationBuilder.CreateTable(
                name: "Personagens_ASVTracoes",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdASVTracao = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens_ASVTracoes", x => new { x.IdPersonagem, x.IdASVTracao });
                });

            migrationBuilder.CreateTable(
                name: "Personagens_Itens",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdItem = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens_Itens", x => new { x.IdPersonagem, x.IdItem });
                });

            migrationBuilder.CreateTable(
                name: "Personagens_VeiculosAquaticos",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdVeiculoAquatico = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens_VeiculosAquaticos", x => new { x.IdPersonagem, x.IdVeiculoAquatico });
                });

            migrationBuilder.CreateTable(
                name: "Personagens_VeiculosTerrestres",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdVeiculoTerrestre = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens_VeiculosTerrestres", x => new { x.IdPersonagem, x.IdVeiculoTerrestre });
                });

            migrationBuilder.CreateTable(
                name: "Proficiencias_Armaduras",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdArmadura = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiencias_Armaduras", x => new { x.IdPersonagem, x.IdArmadura });
                });

            migrationBuilder.CreateTable(
                name: "Proficiencias_Armas",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdArma = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiencias_Armas", x => new { x.IdPersonagem, x.IdArma });
                });

            migrationBuilder.CreateTable(
                name: "Proficiencias_ASVTracoes",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdASVTracao = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiencias_ASVTracoes", x => new { x.IdPersonagem, x.IdASVTracao });
                });

            migrationBuilder.CreateTable(
                name: "Proficiencias_Itens",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdItem = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiencias_Itens", x => new { x.IdPersonagem, x.IdItem });
                });

            migrationBuilder.CreateTable(
                name: "Proficiencias_VeiculosAquaticos",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdVeiculoAquatico = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiencias_VeiculosAquaticos", x => new { x.IdPersonagem, x.IdVeiculoAquatico });
                });

            migrationBuilder.CreateTable(
                name: "Proficiencias_VeiculosTerrestres",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    IdVeiculoTerrestre = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiencias_VeiculosTerrestres", x => new { x.IdPersonagem, x.IdVeiculoTerrestre });
                });

            migrationBuilder.CreateTable(
                name: "TiposArmaduras",
                columns: table => new
                {
                    IdTipoArmadura = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposArmaduras", x => x.IdTipoArmadura);
                });

            migrationBuilder.CreateTable(
                name: "TiposArmas",
                columns: table => new
                {
                    IdTipoArma = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposArmas", x => x.IdTipoArma);
                });

            migrationBuilder.CreateTable(
                name: "TiposIdiomas",
                columns: table => new
                {
                    IdTipoIdioma = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIdiomas", x => x.IdTipoIdioma);
                });

            migrationBuilder.CreateTable(
                name: "TiposMagias",
                columns: table => new
                {
                    IdTipoMagia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposMagias", x => x.IdTipoMagia);
                });

            migrationBuilder.CreateTable(
                name: "TracosdeClasse",
                columns: table => new
                {
                    IdTracodeClasse = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    HabilidadeTracodeClasse = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TracosdeClasse", x => x.IdTracodeClasse);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Login = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "VeiculosAquaticos",
                columns: table => new
                {
                    IdVeiculoAquatico = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Preco = table.Column<string>(type: "TEXT", nullable: true),
                    Velocidade = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculosAquaticos", x => x.IdVeiculoAquatico);
                });

            migrationBuilder.CreateTable(
                name: "VeiculosTerrestres",
                columns: table => new
                {
                    IdVeiculoTerrestre = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Preco = table.Column<string>(type: "TEXT", nullable: true),
                    Deslocamento = table.Column<string>(type: "TEXT", nullable: true),
                    CapacidadedeCarga = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculosTerrestres", x => x.IdVeiculoTerrestre);
                });

            migrationBuilder.CreateTable(
                name: "Skins",
                columns: table => new
                {
                    IdSkin = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Valor = table.Column<double>(type: "REAL", nullable: false),
                    IdDesigner = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skins", x => x.IdSkin);
                    table.ForeignKey(
                        name: "FK_Skins_Designers_IdDesigner",
                        column: x => x.IdDesigner,
                        principalTable: "Designers",
                        principalColumn: "IdDesigner",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    IdClasse = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DadoVida = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Equipamento = table.Column<string>(type: "TEXT", nullable: true),
                    Proficiencia = table.Column<string>(type: "TEXT", nullable: true),
                    Forca = table.Column<bool>(type: "INTEGER", nullable: false),
                    Destreza = table.Column<bool>(type: "INTEGER", nullable: false),
                    Constituicao = table.Column<bool>(type: "INTEGER", nullable: false),
                    Inteligencia = table.Column<bool>(type: "INTEGER", nullable: false),
                    Sabedoria = table.Column<bool>(type: "INTEGER", nullable: false),
                    Carisma = table.Column<bool>(type: "INTEGER", nullable: false),
                    IdListaMagia = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.IdClasse);
                    table.ForeignKey(
                        name: "FK_Classes_ListasMagias_IdListaMagia",
                        column: x => x.IdListaMagia,
                        principalTable: "ListasMagias",
                        principalColumn: "IdListaMagia");
                });

            migrationBuilder.CreateTable(
                name: "Armaduras",
                columns: table => new
                {
                    IdArmadura = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClassedeArmadura = table.Column<int>(type: "INTEGER", nullable: false),
                    ModificadorDestrezaMaximo = table.Column<int>(type: "INTEGER", nullable: true),
                    Forca = table.Column<int>(type: "INTEGER", nullable: true),
                    Furtividade = table.Column<bool>(type: "INTEGER", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Peso = table.Column<string>(type: "TEXT", nullable: false),
                    Preco = table.Column<string>(type: "TEXT", nullable: false),
                    IdTipoArmadura = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armaduras", x => x.IdArmadura);
                    table.ForeignKey(
                        name: "FK_Armaduras_TiposArmaduras_IdTipoArmadura",
                        column: x => x.IdTipoArmadura,
                        principalTable: "TiposArmaduras",
                        principalColumn: "IdTipoArmadura",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Armas",
                columns: table => new
                {
                    IdArma = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DadoDano = table.Column<string>(type: "TEXT", nullable: true),
                    Propriedade = table.Column<string>(type: "TEXT", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Peso = table.Column<string>(type: "TEXT", nullable: false),
                    Preco = table.Column<string>(type: "TEXT", nullable: false),
                    IdTipoArma = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armas", x => x.IdArma);
                    table.ForeignKey(
                        name: "FK_Armas_TiposArmas_IdTipoArma",
                        column: x => x.IdTipoArma,
                        principalTable: "TiposArmas",
                        principalColumn: "IdTipoArma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Idiomas",
                columns: table => new
                {
                    IdIdioma = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    FaladoPor = table.Column<string>(type: "TEXT", nullable: false),
                    Alfabeto = table.Column<string>(type: "TEXT", nullable: false),
                    IdTipoIdioma = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idiomas", x => x.IdIdioma);
                    table.ForeignKey(
                        name: "FK_Idiomas_TiposIdiomas_IdTipoIdioma",
                        column: x => x.IdTipoIdioma,
                        principalTable: "TiposIdiomas",
                        principalColumn: "IdTipoIdioma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Magias",
                columns: table => new
                {
                    IdMagia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Escola = table.Column<string>(type: "TEXT", nullable: false),
                    Alcance = table.Column<string>(type: "TEXT", nullable: false),
                    TempodeConjuracao = table.Column<string>(type: "TEXT", nullable: false),
                    Duracao = table.Column<string>(type: "TEXT", nullable: false),
                    Componente = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    IdTipoMagia = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magias", x => x.IdMagia);
                    table.ForeignKey(
                        name: "FK_Magias_TiposMagias_IdTipoMagia",
                        column: x => x.IdTipoMagia,
                        principalTable: "TiposMagias",
                        principalColumn: "IdTipoMagia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TracosdeClasse_Arquetipos",
                columns: table => new
                {
                    IdTracodeClasse = table.Column<int>(type: "INTEGER", nullable: false),
                    IdArquetipo = table.Column<int>(type: "INTEGER", nullable: false),
                    TracodeClasseIdTracodeClasse = table.Column<int>(type: "INTEGER", nullable: true),
                    ArquetipoIdArquetipo = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TracosdeClasse_Arquetipos", x => new { x.IdTracodeClasse, x.IdArquetipo });
                    table.ForeignKey(
                        name: "FK_TracosdeClasse_Arquetipos_Arquetipos_ArquetipoIdArquetipo",
                        column: x => x.ArquetipoIdArquetipo,
                        principalTable: "Arquetipos",
                        principalColumn: "IdArquetipo");
                    table.ForeignKey(
                        name: "FK_TracosdeClasse_Arquetipos_TracosdeClasse_TracodeClasseIdTracodeClasse",
                        column: x => x.TracodeClasseIdTracodeClasse,
                        principalTable: "TracosdeClasse",
                        principalColumn: "IdTracodeClasse");
                });

            migrationBuilder.CreateTable(
                name: "Classes_TracosdeClasses",
                columns: table => new
                {
                    IdClasse = table.Column<int>(type: "INTEGER", nullable: false),
                    IdTracodeClasse = table.Column<int>(type: "INTEGER", nullable: false),
                    ClasseIdClasse = table.Column<int>(type: "INTEGER", nullable: true),
                    TracodeClasseIdTracodeClasse = table.Column<int>(type: "INTEGER", nullable: true),
                    Nivel = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes_TracosdeClasses", x => new { x.IdClasse, x.IdTracodeClasse });
                    table.ForeignKey(
                        name: "FK_Classes_TracosdeClasses_Classes_ClasseIdClasse",
                        column: x => x.ClasseIdClasse,
                        principalTable: "Classes",
                        principalColumn: "IdClasse");
                    table.ForeignKey(
                        name: "FK_Classes_TracosdeClasses_TracosdeClasse_TracodeClasseIdTracodeClasse",
                        column: x => x.TracodeClasseIdTracodeClasse,
                        principalTable: "TracosdeClasse",
                        principalColumn: "IdTracodeClasse");
                });

            migrationBuilder.CreateTable(
                name: "Racas",
                columns: table => new
                {
                    IdRaca = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Tamanho = table.Column<string>(type: "TEXT", nullable: false),
                    Idade = table.Column<int>(type: "INTEGER", nullable: false),
                    Deslocamento = table.Column<double>(type: "REAL", nullable: false),
                    BonusConstituicao = table.Column<int>(type: "INTEGER", nullable: true),
                    BonusForca = table.Column<int>(type: "INTEGER", nullable: true),
                    BonusDestreza = table.Column<int>(type: "INTEGER", nullable: true),
                    BonusInteligencia = table.Column<int>(type: "INTEGER", nullable: true),
                    BonusSabedoria = table.Column<int>(type: "INTEGER", nullable: true),
                    BonusCarisma = table.Column<int>(type: "INTEGER", nullable: true),
                    IdIdioma = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racas", x => x.IdRaca);
                    table.ForeignKey(
                        name: "FK_Racas_Idiomas_IdIdioma",
                        column: x => x.IdIdioma,
                        principalTable: "Idiomas",
                        principalColumn: "IdIdioma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Magias_ListasMagias",
                columns: table => new
                {
                    IdMagia = table.Column<int>(type: "INTEGER", nullable: false),
                    MagiaIdMagia = table.Column<int>(type: "INTEGER", nullable: true),
                    IdListaMagia = table.Column<int>(type: "INTEGER", nullable: false),
                    ListaMagiaIdListaMagia = table.Column<int>(type: "INTEGER", nullable: true),
                    Ciclo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Magias_ListasMagias_ListasMagias_ListaMagiaIdListaMagia",
                        column: x => x.ListaMagiaIdListaMagia,
                        principalTable: "ListasMagias",
                        principalColumn: "IdListaMagia");
                    table.ForeignKey(
                        name: "FK_Magias_ListasMagias_Magias_MagiaIdMagia",
                        column: x => x.MagiaIdMagia,
                        principalTable: "Magias",
                        principalColumn: "IdMagia");
                });

            migrationBuilder.CreateTable(
                name: "HabilidadesRaciais_Racas",
                columns: table => new
                {
                    IdHabilidadeRacial = table.Column<int>(type: "INTEGER", nullable: false),
                    IdRaca = table.Column<int>(type: "INTEGER", nullable: false),
                    HabilidadeRacialIdHabilidadeRacial = table.Column<int>(type: "INTEGER", nullable: true),
                    RacaIdRaca = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilidadesRaciais_Racas", x => new { x.IdHabilidadeRacial, x.IdRaca });
                    table.ForeignKey(
                        name: "FK_HabilidadesRaciais_Racas_HabilidadesRaciais_HabilidadeRacialIdHabilidadeRacial",
                        column: x => x.HabilidadeRacialIdHabilidadeRacial,
                        principalTable: "HabilidadesRaciais",
                        principalColumn: "IdHabilidadeRacial");
                    table.ForeignKey(
                        name: "FK_HabilidadesRaciais_Racas_Racas_RacaIdRaca",
                        column: x => x.RacaIdRaca,
                        principalTable: "Racas",
                        principalColumn: "IdRaca");
                });

            migrationBuilder.CreateTable(
                name: "SubRacas",
                columns: table => new
                {
                    IdSubRaca = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    BonusConstituicao = table.Column<int>(type: "INTEGER", nullable: true),
                    BonusForca = table.Column<int>(type: "INTEGER", nullable: true),
                    BonusDestreza = table.Column<int>(type: "INTEGER", nullable: true),
                    BonusInteligencia = table.Column<int>(type: "INTEGER", nullable: true),
                    BonusSabedoria = table.Column<int>(type: "INTEGER", nullable: true),
                    BonusCarisma = table.Column<int>(type: "INTEGER", nullable: true),
                    IdRaca = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRacas", x => x.IdSubRaca);
                    table.ForeignKey(
                        name: "FK_SubRacas_Racas_IdRaca",
                        column: x => x.IdRaca,
                        principalTable: "Racas",
                        principalColumn: "IdRaca",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HabilidadesRaciais_SubRacas",
                columns: table => new
                {
                    IdHabilidadeRacial = table.Column<int>(type: "INTEGER", nullable: false),
                    IdSubRaca = table.Column<int>(type: "INTEGER", nullable: false),
                    HabilidadeRacialIdHabilidadeRacial = table.Column<int>(type: "INTEGER", nullable: true),
                    SubRacaIdSubRaca = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilidadesRaciais_SubRacas", x => new { x.IdHabilidadeRacial, x.IdSubRaca });
                    table.ForeignKey(
                        name: "FK_HabilidadesRaciais_SubRacas_HabilidadesRaciais_HabilidadeRacialIdHabilidadeRacial",
                        column: x => x.HabilidadeRacialIdHabilidadeRacial,
                        principalTable: "HabilidadesRaciais",
                        principalColumn: "IdHabilidadeRacial");
                    table.ForeignKey(
                        name: "FK_HabilidadesRaciais_SubRacas_SubRacas_SubRacaIdSubRaca",
                        column: x => x.SubRacaIdSubRaca,
                        principalTable: "SubRacas",
                        principalColumn: "IdSubRaca");
                });

            migrationBuilder.CreateTable(
                name: "Personagens",
                columns: table => new
                {
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Tendencia = table.Column<string>(type: "TEXT", nullable: false),
                    Iniciativa = table.Column<int>(type: "INTEGER", nullable: true),
                    Slots = table.Column<int>(type: "INTEGER", nullable: true),
                    Constituicao = table.Column<int>(type: "INTEGER", nullable: true),
                    ModificadorConstituicao = table.Column<int>(type: "INTEGER", nullable: true),
                    Forca = table.Column<int>(type: "INTEGER", nullable: true),
                    ModificadorForca = table.Column<int>(type: "INTEGER", nullable: true),
                    Destreza = table.Column<int>(type: "INTEGER", nullable: true),
                    ModificadorDestreza = table.Column<int>(type: "INTEGER", nullable: true),
                    Inteligencia = table.Column<int>(type: "INTEGER", nullable: true),
                    ModificadorInteligencia = table.Column<int>(type: "INTEGER", nullable: true),
                    Sabedoria = table.Column<int>(type: "INTEGER", nullable: true),
                    ModificadorSabedoria = table.Column<int>(type: "INTEGER", nullable: true),
                    Carisma = table.Column<int>(type: "INTEGER", nullable: true),
                    ModificadorCarisma = table.Column<int>(type: "INTEGER", nullable: true),
                    Tamanho = table.Column<double>(type: "REAL", nullable: false),
                    Idade = table.Column<int>(type: "INTEGER", nullable: false),
                    Peso = table.Column<double>(type: "REAL", nullable: false),
                    Olhos = table.Column<string>(type: "TEXT", nullable: false),
                    Cabelos = table.Column<string>(type: "TEXT", nullable: false),
                    Pele = table.Column<string>(type: "TEXT", nullable: false),
                    Traco = table.Column<string>(type: "TEXT", nullable: true),
                    Ideal = table.Column<string>(type: "TEXT", nullable: true),
                    Vinculo = table.Column<string>(type: "TEXT", nullable: true),
                    Defeito = table.Column<string>(type: "TEXT", nullable: true),
                    Bio = table.Column<string>(type: "TEXT", nullable: true),
                    Nivel = table.Column<int>(type: "INTEGER", nullable: false),
                    BonusProficiencia = table.Column<int>(type: "INTEGER", nullable: false),
                    PC = table.Column<int>(type: "INTEGER", nullable: true),
                    PP = table.Column<int>(type: "INTEGER", nullable: true),
                    PE = table.Column<int>(type: "INTEGER", nullable: true),
                    PO = table.Column<int>(type: "INTEGER", nullable: true),
                    PL = table.Column<int>(type: "INTEGER", nullable: true),
                    Acrobacia = table.Column<bool>(type: "INTEGER", nullable: true),
                    AcrobaciaValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Arcanismo = table.Column<bool>(type: "INTEGER", nullable: true),
                    ArcanismoValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Atletismo = table.Column<bool>(type: "INTEGER", nullable: true),
                    AtletismoValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Atuacao = table.Column<bool>(type: "INTEGER", nullable: true),
                    AtuacaoValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Enganacao = table.Column<bool>(type: "INTEGER", nullable: true),
                    EnganacaoValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Furtividade = table.Column<bool>(type: "INTEGER", nullable: true),
                    FurtividadeValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Historia = table.Column<bool>(type: "INTEGER", nullable: true),
                    HistoriaValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Intimidacao = table.Column<bool>(type: "INTEGER", nullable: true),
                    IntimidacaoValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Intuicao = table.Column<bool>(type: "INTEGER", nullable: true),
                    IntuicaoValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Investigacao = table.Column<bool>(type: "INTEGER", nullable: true),
                    InvestigacaoValor = table.Column<int>(type: "INTEGER", nullable: true),
                    LidarcomAnimais = table.Column<bool>(type: "INTEGER", nullable: true),
                    LidarcomAnimaisValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Medicina = table.Column<bool>(type: "INTEGER", nullable: true),
                    MedicinaValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Natureza = table.Column<bool>(type: "INTEGER", nullable: true),
                    NaturezaValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Percepcao = table.Column<bool>(type: "INTEGER", nullable: true),
                    PercepcaoValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Persuasao = table.Column<bool>(type: "INTEGER", nullable: true),
                    PersuasaoValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Prestidigitacao = table.Column<bool>(type: "INTEGER", nullable: true),
                    PrestidigitacaoValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Religiao = table.Column<bool>(type: "INTEGER", nullable: true),
                    ReligiaoValor = table.Column<int>(type: "INTEGER", nullable: true),
                    Sobrevivencia = table.Column<bool>(type: "INTEGER", nullable: true),
                    SobrevivenciaValor = table.Column<int>(type: "INTEGER", nullable: true),
                    IdClasse = table.Column<int>(type: "INTEGER", nullable: true),
                    IdRaca = table.Column<int>(type: "INTEGER", nullable: true),
                    IdSubRaca = table.Column<int>(type: "INTEGER", nullable: true),
                    IdAntecedente = table.Column<int>(type: "INTEGER", nullable: true),
                    IdSkin = table.Column<int>(type: "INTEGER", nullable: true),
                    IdUsuario = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens", x => x.IdPersonagem);
                    table.ForeignKey(
                        name: "FK_Personagens_Antecedentes_IdAntecedente",
                        column: x => x.IdAntecedente,
                        principalTable: "Antecedentes",
                        principalColumn: "IdAntecedente");
                    table.ForeignKey(
                        name: "FK_Personagens_Classes_IdClasse",
                        column: x => x.IdClasse,
                        principalTable: "Classes",
                        principalColumn: "IdClasse");
                    table.ForeignKey(
                        name: "FK_Personagens_Racas_IdRaca",
                        column: x => x.IdRaca,
                        principalTable: "Racas",
                        principalColumn: "IdRaca");
                    table.ForeignKey(
                        name: "FK_Personagens_Skins_IdSkin",
                        column: x => x.IdSkin,
                        principalTable: "Skins",
                        principalColumn: "IdSkin");
                    table.ForeignKey(
                        name: "FK_Personagens_SubRacas_IdSubRaca",
                        column: x => x.IdSubRaca,
                        principalTable: "SubRacas",
                        principalColumn: "IdSubRaca");
                    table.ForeignKey(
                        name: "FK_Personagens_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateTable(
                name: "Idiomas_Personagens",
                columns: table => new
                {
                    IdIdioma = table.Column<int>(type: "INTEGER", nullable: false),
                    IdiomaIdIdioma = table.Column<int>(type: "INTEGER", nullable: true),
                    IdPersonagem = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonagemIdPersonagem = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Idiomas_Personagens_Idiomas_IdiomaIdIdioma",
                        column: x => x.IdiomaIdIdioma,
                        principalTable: "Idiomas",
                        principalColumn: "IdIdioma");
                    table.ForeignKey(
                        name: "FK_Idiomas_Personagens_Personagens_PersonagemIdPersonagem",
                        column: x => x.PersonagemIdPersonagem,
                        principalTable: "Personagens",
                        principalColumn: "IdPersonagem");
                });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 1, "Alforje", "4 Kg", "4 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 2, "Armadura e montaria", "X2", "X4" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 3, "Biga", "50 Kg", "250 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 4, "Carroça", "100 Kg", "15 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 5, "Carruagem", "300 Kg", "100 Peças" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 6, "Estábulo", "-", "5 Peças de Prata" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 7, "Freio e rédea", "0.5 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 8, "Ração", "5 Peças de Cobre", "5 Kg" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 9, "Sela Compacta", "7.5 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 10, "Sela Exótica", "20 Kg", "60 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 11, "Sela Militar", "15 Kg", "20 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 12, "Sela p/ Viagem", "12.5 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "ASVTracoes",
                columns: new[] { "IdASVTracao", "Nome", "Peso", "Preco" },
                values: new object[] { 13, "Trenó", "150 Kg", "20 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 1, "1 Eu julgo os outros severamente, e a mim mesmo mais ainda. \n2 Eu deposito muita confiança naqueles que detêm o poder na hierarquia de meu templo. \n3 Minha devoção é muitas vezes me cega perante aqueles que professam a fé do meu deus. \n4 Meu pensamento é inflexível. \n5 Eu suspeito de estranhos e sempre espero o pior deles. \n6 Depois de escolher um objetivo, eu fico obcecado em cumpri-lo, até mesmo em detrimento de qualquer outra coisa em minha vida.", "Um símbolo sagrado (um presente dado quando você entrou no templo), um livro de preces ou uma conta de orações, 5 varetas de incenso, vestimentas, um conjunto de roupas comuns e uma algibeira contendo 15 po", "CARACTERÍSTICA: ABRIGO DOS FIÉIS \nComo um acólito, você detém o respeito daqueles que compartilham de sua fé, e você pode realizar cerimônias de sua divindade. Você e seus companheiros de aventura podem até receber cura e caridade de um templo, santuário ou outro posto de sua fé, embora devam fornecer quaisquer componentes materiais necessários para as magias. Aqueles que compartilham de sua religião vão garantir a você (mas apenas você), custeando um estilo de vida modesto. Você também pode possuir laços com um templo específico devotado à sua divindade ou panteão, e fixar residência nele. Pode ser o templo que você está acostumado a servir, se ainda tiver boas relações com ele, ou um templo no qual você encontrou um novo lar. Enquanto frequentar as redondezas desse templo, você pode solicitar os sacerdotes para assisti-lo, desde que essa assistência não seja de alguma forma perigosa e que você sempre esteja em uma boa relação com seu templo.", "1 Tradição. As tradições ancestrais de adoração e sacrifício devem ser preservadas e perpetradas. (Leal) \n2 Caridade. Eu sempre tento ajudar aqueles em necessidade, não importando o custo pessoal. (Bom) \n3 Mudança. Nós devemos ajudar a conduzir as mudanças que os deuses estão constantemente trabalhando para o mundo. (Caótico) \n4 Poder. Eu espero que um dia eu consiga chegar ao topo na hierarquia da minha religião. (Leal) \n5 Fé. Eu acredito que minha divindade guia minhas ações. Eu tenho fé que, se eu trabalhar duro, coisas boas acontecerão. (Leal) \n6 Aspiração. Eu busco ser digno da graça do meu deus ao corresponder minhas ações aos seus ensinamentos. (Qualquer)", 2, "Acólito", "Intuição, Religião", "1 Eu idolatro um herói particular da minha fé, e constantemente me refiro a seus feitos e exemplos. \n2 Eu consigo encontrar semelhanças mesmo entre os inimigos mais violentos, com empatia e sempre trabalhando pela paz. \n3 Eu vejo presságios em cada evento e ação. Os deuses estão falando conosco, nós apenas temos de ouvi-los. \n4 Nada pode abalar minha atitude otimista. \n5 Eu cito (corretamente ou não) textos sagrados e provérbios em quase qualquer situação. \n6 Eu sou tolerante (ou intolerante) a qualquer outra fé, e respeito (ou condeno) a adoração a outros deuses. \n7 Eu aprecio comida requintada, bebidas e a elite entre o alto escalão de meu templo. Uma vida dura me irrita. \n8 Eu passei tanto tempo no templo que possuo pouca prática em lidar com as pessoas mundo a fora.", "1 Eu morreria para recuperar uma relíquia ancestral de minha fé, perdida há muito tempo. \n2 Eu ainda terei minha vingança contra o templo corrupto que me acusou de heresia. \n3 Eu devo minha vida ao sacerdote que me acolheu quando meus pais morreram. \n4 Tudo o que faço, faço pelo povo. \n5 Eu farei qualquer coisa para proteger o templo que sirvo. \n6 Eu busco guardar um texto sagrado que meus inimigos dizem ser herético e tentam destruí-lo." });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 2, "1 Eu farei de tudo para pôr minha mãos em algo raro ou inestimável. \n2 Eu rapidamente presumo que alguém está tentando me trapacear. \n3 Ninguém nunca poderá saber que eu, certa vez, roubei dinheiro dos cofres da guilda. \n4 Eu nunca estou satisfeito com o que tenho – eu sempre quero mais.\n5 Eu mataria para adquirir um título de nobreza. \n6 Eu sou terrivelmente invejoso com qualquer um que possa ofuscar meu ofício. Todo lugar que eu vou, estou cercado de rivais. ", "Um conjunto de ferramentas de artesão (à sua escolha), uma carta de apresentação da sua guilda, um conjunto de roupas de viajante e uma algibeira com 15 po", "CARACTERÍSTICA: ASSOCIADOS DA GUILDA \nComo um membro cativo e respeitado da guilda, você pode contar com certos benefícios que a sociedade garante. Seus camaradas, membros da guilda, irão provêlo com hospedagem e comida, se necessário, e pagarão pelo seu funeral se preciso for. Em algumas cidades e vilas, um salão da guilda oferece um local central para conhecer outros membros de profissão, podendo ser um bom lugar para se conhecer patrões, aliados e empregados em potencial. Guildas, muitas vezes, detêm tremendos poderes políticos. Se você for acusado de um crime, sua guilda irá ampará-lo se uma boa defesa puder ser apresentada para provar sua inocência ou se o crime for justificável. Você pode, também, ter acesso a figuras políticas poderosas através da guilda, se você for um membro bem posicionado. Tais conexões devem exigir doações de dinheiro ou itens mágicos para os cofres da guilda. Você deve pagar cotas de 5 po por mês a guilda. Se você não pagar, você irá contrair uma dívida para permanecer nas boas graças da guilda.", "1 Comunidade. É dever de todo cidadão civilizado fortalecer os elos da comunidade e a segurança da civilização. (Leal) \n2 Generosidade. Meus talentos me foram dados para que eu pudesse usá-los para beneficiar o mundo. (Bom) \n3 Liberdade. Todos deveriam ser livres para perseguir seus próprios meios de vida. (Caótico) \n4 Ganância. Eu só estou aqui pelo dinheiro. (Mau)\n5 Povo. Eu sou cometido com o povo com quem me importo, não com ideias. (Neutro) \n6 Aspiração. Eu trabalho duro para ser o melhor no meu ofício. (Qualquer)", 1, "Artesão de Guilda", "Intuição, Persuasão. \nUm tipo de ferramenta de artesão", "1 Eu acredito que tudo que valha a pena fazer, vale a pena ser feito direito. Eu não posso evitar – Eu sou perfeccionista. \n2 Eu sou um esnobe que olha de cima a baixo aqueles que não sabem apreciar artes requintadas. \n3 Eu sempre quero aprender como as coisas funcionam e o que deixa as pessoas motivadas. \n4 Eu sou cheio de aforismos espirituosos e tenho um proverbio para cada ocasião.\n5 Eu sou grosso com as pessoas que não tem o mesmo comprometimento que eu com o trabalho duro e honesto. \n6 Eu gosto de falar longamente sobre minha profissão. \n7 Eu não gasto meu dinheiro facilmente e vou barganhar incansavelmente para conseguir o melhor acordo possível. \n8 Eu sou bem conhecido pelo meu trabalho e quero ter certeza que todos o apreciam. Eu sempre fico surpreso quando conheço pessoas que não ouviram falar de mim.", "1 A oficina onde aprendi meu negócio é o local mais importante do mundo pra mim. \n2 Eu criei um trabalho incrível para alguém, mas descobri que ele não era merecedor de recebê-lo. Ainda estou à procura de alguém que seja merecedor. \n3 Eu tenho uma grande dívida para com minha guilda por fazer de mim a pessoa que sou hoje. \n4 Eu busco riqueza para conseguir o amor de alguém.\n5 Um dia eu voltarei para a minha guilda e provarei que sou o maior artesão dentre eles. \n6 Eu irem me vingar das forças malignas que destruíram meu local de negócios e arruinaram meu estilo de vida." });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 3, "1 Eu farei de tudo para ganhar fama e renome. \n2 Eu viro um idiota quando vejo um rosto bonito. \n3 Um escândalo me impede de voltar para casa novamente. Esse tipo de problema parece me perseguir por ai. \n4 Eu, certa vez, satirizei um nobre que ainda quer minha cabeça. Foi um erro que eu adoraria repetir. \n5 Eu tenho problemas em esconder meus verdadeiros sentimentos. Minha língua afiada me mete em confusão. \n6 Apesar dos meus melhores esforços, meus amigos não me consideram confiável.", "Um instrumento musical (à sua escolha), um presente de um admirador (carta de amor, mecha de cabelo ou uma bijuteria), um traje e uma algibeira contendo 15 peças de ouro ", "CARACTERÍSTICA: PELA DEMANDA POPULAR \nVocê sempre encontra um lugar para atuar, geralmente em tavernas ou estalagens mas, possivelmente em circos, teatros ou até em cortes nobres. Em tais lugares, você recebe alojamento e comida modesta ou de patrões confortáveis, de graça (dependendo da qualidade do estabelecimento), contanto que você atue a cada noite. Além disso, sua atuação torna você um tipo de figura local. Quando estranhos reconhecerem você em uma cidade em que você já tenha atuado, eles geralmente gostaram de você.", "1 Beleza. Quando eu atuo, eu torno o mundo um lugar melhor. (Bom) \n2 Tradição. As histórias, lendas e canções do passado nunca devem ser esquecidas, pois elas nos ensinam quem nós somos. (Leal) \n3 Criatividade. O mundo precisa de novas ideias e ações ousadas. (Caótico) \n4 Ganância. Eu só estou aqui pelo dinheiro e pela fama. (Mau) \n5 Povo. Eu gosto de ver os sorrisos nos rostos das pessoas quando eu atuo. Isso é tudo que importa. (Neutro) \n6 Honestidade. A arte deve refletir a alma; ela deve vir de dentro e revelar quem realmente somos. (Qualquer)", 0, "Artista", "Acrobacia, Atuação. \nKit de disfarce, um tipo de instrumento musical", "1 Eu conheço uma história relevante de praticamente todas as situações. \n2 Sempre que eu chego em um lugar novo, eu coleto os rumores locais e espalho fofocas. \n3 Eu sou um romântico incorrigível, sempre em busca daquele “alguém especial.” \n4 Ninguém fica com raiva de mim ou perto de mim por muito tempo, já que eu posso acabar com qualquer tipo de tensão. \n5 Eu amo um bom insulto, até os direcionados a mim. \n6 Eu fico sentido se eu não for o centro das atenções. \n7 Eu não vou me contentar com nada menos que a perfeição. \n8 Eu mudo de ânimo ou de pensamento tão rápido quando mudo eu mudo de nota em uma canção.", "1 Meu instrumento é meu bem mais valioso e ele me lembra de alguém que eu amo. \n2 Alguém roubou meu precioso instrumento e, algum dia, eu vou pegá-lo de volta. \n3 Eu quero ser famoso, custe o que custar. \n4 Eu idolatro um herói dos contos antigos e mensuro meus feitos baseados nessa personalidade. \n5 Eu vou fazer tudo para provar que sou superior eu meu odiado rival. \n6 Eu faria qualquer coisa pelos membros da minha antiga trupe." });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 4, "1 Não resisto um rostinho bonito. \n2 Estou sempre com dividas. Eu gasto meus lucros ilícitos com luxurias decadentes mais rápido do que os ganho... \n3 Estou convencido que ninguém pode me enganar da forma que eu engano os outros. \n4 Eu sou ganancioso demais pra meu próprio bem. Eu não consigo resistir a me arriscar se tiver dinheiro envolvido. \n5 Eu não resisto a enganar pessoas que são mais poderosas que eu. \n6 Eu odeio admitir e vou me odiar por isso, mas, eu vou correr e salvar minha própria pele se as coisas engrossarem.", "Um conjunto de roupas finas, um kit de disfarce, ferramentas de trapaça, à sua escolha (dez garrafas tampadas preenchidas com líquidos coloridos, um conjunto de dados viciados, um baralho de cartas marcadas ou um anel de sinete de um duque imaginário), e uma algibeira contendo 15 peças de ouro", "CARACTERÍSTICA: IDENTIDADE FALSA \nVocê criou uma segunda identidade que inclui documentos, conhecidos estabelecidos e disfarces que possibilitam que você assuma essa persona. Além disso, você pode forjar documentos, incluindo papeis oficiais e cartas pessoais, contanto que você tenha visto um exemplo desse tipo de documento ou a caligrafia de quem você está tentando copiar.", "1 Independência. Sou um espirito livre – ninguém me diz o que fazer. (Caótico) \n2 Justiça. Eu nunca roubo de pessoas que não podem perder algumas moedas. (Leal) \n3 Caridade. Eu distribuo o dinheiro que adquiro com as pessoas que realmente precisam. (Bom) \n4 Criatividade. Eu nunca faço a mesma trapaça duas vezes. (Caótico) \n5 Amizade. Bens materiais vem e vão. Os laços de amizade duram pra sempre. (Bom) \n6 Aspiração. Eu estou determinado a fazer algo por mim mesmo. (Qualquer)", 0, "Charlatão", "Enganação, Prestidigitação,  \nKit de disfarce, kit de falsificação ", "1 Eu me apaixono e desapaixono facilmente, e estou sempre em busca de alguém. \n2 Eu tenho uma piada para cada ocasião, especialmente ocasiões em que o humor é inapropriado. \n3 Bajulação é meu truque predileto para conseguir o que eu quero. \n4 Eu sou um jogador nato que não consegue resistir a se arriscar por uma possível recompensa. \n5 Eu minto sobre quase tudo, mesmo quando não existe qualquer boa razão. \n6 Sarcasmo e insultos são minhas armas prediletas. \n7 Eu tenho vários símbolos sagrados comigo, e invoco a divindade que seja mais útil em cada dado momento. \n8 Eu furto qualquer coisa que eu vejo que possa ter algum valor.", "1 Independência. Sou um espirito livre – ninguém me diz o que fazer. (Caótico) \n2 Justiça. Eu nunca roubo de pessoas que não podem perder algumas moedas. (Leal) \n3 Caridade. Eu distribuo o dinheiro que adquiro com as pessoas que realmente precisam. (Bom) \n4 Criatividade. Eu nunca faço a mesma trapaça duas vezes. (Caótico) \n5 Amizade. Bens materiais vem e vão. Os laços de amizade duram pra sempre. (Bom) \n6 Aspiração. Eu estou determinado a fazer algo por mim mesmo. (Qualquer)" });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 5, "1 Quando vejo algo valioso, não consigo pensar em mais nada, além de roubá-lo. \n2 Quando confrontado com uma escolha entre dinheiro e amigo, eu bem que escolho o dinheiro. \n3 Se há um plano, eu vou esquecê-lo. Se eu não esquecê-lo, vou ignorá-lo. \n4 Eu tenho um 'tique' que revela se estou mentindo. \n5 Eu viro as costas e corro quando as coisas começam a ficar ruins. \n6 Um inocente foi preso por um crime que eu cometi. Por mim tudo bem.", "Um pé de cabra, um conjunto de roupas escuras comuns com capuz e uma algibeira contendo 15 po ", "CARACTERÍSTICA: CONTATO CRIMINAL \nVocê possui contatos de confiança que agem como seus informantes em uma rede criminosa. Você sabe como se comunicar com eles mesmo em grandes distâncias. Você conhece em especial os mensageiros locais, mestres de caravana corruptos, e marinheiros escusos que podem transmitir seus recados. ", "1 Honra. Eu não roubo de irmãos de profissão. (Leal) \n2 Liberdade. Correntes foram feitas para serem partidas, assim como aqueles que as forjaram. (Caótico) \n3 Caridade. Eu roubo dos ricos para dar aos que realmente precisam. (Bom) \n4 Ganância. Eu farei qualquer coisa para me tornar rico. (Mal) \n5 Povo. Eu sou leal aos meus amigos, não a qualquer ideal, e todos sabem que posso viajar até o Estige por aqueles que me importo. (Neutro) \n6 Redenção. Há uma centelha de bondade em todo mundo. (Bom)", 0, "Criminoso", "Enganação, Furtividade, \nUm tipo de kit de jogo, ferramentas de ladrão", "1 Eu sempre tenho um plano para quando as coisas dão errado. \n2 Eu estou sempre calmo, não importa a situação. Eu nunca levanto minha voz ou deixo minhas emoções me controlarem. \n3 A primeira coisa que faço ao chegar a um novo local é decorar a localização de coisas valiosas – ou onde essas coisas podem estar escondidas. \n4 Eu prefiro fazer um novo amigo a um novo inimigo. \n5 Eu sou incrivelmente receoso em confiar. Aqueles que parecem mais amigáveis geralmente têm mais a esconder. \n6 Eu não presto atenção aos riscos envolvidos em uma situação, nunca me alerte sobre as probabilidades de fracasso. \n7 A melhor maneira de me levar a fazer algo é dizendo que eu não posso fazer. \n8 Eu explodo ao menor insulto.", "1 Eu estou tentando quitar uma dívida que tenho com um generoso benfeitor. \n2 Meus ganhos, honestos ou não, são para sustentar minha família. \n3 Algo importante foi roubado de mim, e eu vou recuperá-lo. \n4 Eu me tornarei o maior ladrão que já existiu. \n5 Eu sou culpado por um terrível crime, espero algum dia poder me redimir. \n6 Alguém que amo morreu por causa de um erro que cometi. Isso nunca acontecerá novamente." });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 6, "1 Agora que voltei ao mundo, eu desfruto de seus prazeres um pouco demais. \n2 Eu escondo nas sombras, pensamentos sanguinários que meu isolamento e meditação não conseguiram apagar. \n3 Eu sou dogmático em meus pensamentos e filosofia. \n4 Eu deixo meu desejo de vencer discussões ofuscar amizades e harmonia. \n5 Eu me arrisco muito para descobrir um pouco de conhecimento perdido. \n6 Eu gosto de guardar segredos e não os partilho com ninguém.", "Um estojo de pergaminho cheio de notas dos seus estudos e orações, um cobertor de inverno, um conjunto de roupas comuns, um kit de herbalismo e 5 po. ", "CARACTERÍSTICA: DESCOBERTA \nA calma reclusão da seu eremitério prolongado lhe deu acesso a descobertas únicas e poderosas. A natureza exata dessas revelações depende da natureza da sua reclusão. Poderia ser uma grande verdade sobre o cosmos, os deuses, os poderosos seres de outros planos ou as forças da natureza. Poderia ser um local nunca visto por mais ninguém. Você pode ter descoberto um fato que a muito foi esquecido, ou desenterrado uma relíquia do passado que poderia reescrever a história. Poderia ser uma informação que seria prejudicial para as pessoas responsáveis pelo seu exilio, consequentemente, a razão que fez você voltar para a sociedade. Converse com o Mestre para determinar os detalhes da sua descoberta e o impacto na campanha.", "1 Bem Maior. Meus dons devem ser partilhados com todos, não usados em benefício próprio (Bom) \n2 Lógica. Emoções não podem obscurecer meus sentidos do que é certo e verdade, ou meu pensamento lógico. (Leal) \n3 Pensamento Livre. Questionamentos e curiosidade são os pilares do progresso. (Caótico) \n4 Poder. Isolamento e contemplação são caminhos para poderes místicos e mágicos. (Mau) \n5 Viva e Deixe Viver. Se intrometer nos assuntos dos outros só traz problemas. (Neutro) \n6 Autoconhecimento. Se você conhece a si mesmo, não a mais nada para saber. (Qualquer)", 1, "Eremita", "Medicina, Religião,  \nKit de herbalismo", "1 Eu fiquei tanto tempo isolado que raramente falo, preferindo gestos e grunhidos ocasionais. \n2 Eu sou absurdamente sereno, mesmo em face do desespero. \n3 O líder da minha comunidade tem algo sábio a dizer sobre cada tópico, eu estou ansioso para partilhar dessa sabedoria. \n4 Eu sinto uma empatia tremenda por todos que sofrem. \n5 Eu estou alheio a etiqueta e expectativas sociais. \n6 Eu relaciono tudo que acontece comigo a um grande plano cósmico. \n7 Eu, muitas vezes, me perco em meus pensamentos e contemplação me tornando alheio ao meu redor. \n8 Eu estou trabalhando em uma grande teoria filosófica e adoro partilhar minhas ideias.", "1 Nada é mais importante que os outros membros do eremitério, ordem ou associação. \n2 Eu entrei em reclusão para me esconder daqueles que ainda devem estar me caçando. Algum dia irei confrontálos. \n3 Eu ainda busco o esclarecimento que eu perseguia durante meu isolamento e continuo a me iludir. \n4 Eu entrei em reclusão porque eu amava alguém que eu não podia ter. \n5 Se minha descoberta vir à tona, ela poderá trazer destruição ao mundo. \n6 Meu isolamento me deu grande discernimento sobre um grande mal que apenas eu posso destruir." });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 7, "1 Sou muito apaixonado por cerveja, vinho e outras bebidas. \n2 Não existe lugar para precaução em uma vida vivida ao máximo. \n3 Eu lembro de cada insulto que sofri e nutro um ressentimento silencioso contra qualquer um que já tenha me insultado \n4 Eu tenho dificuldade em confiar em membros de outras raças, tribos ou sociedades. \n5 A violência é minha resposta para quase todos os obstáculos. \n6 Não espere que eu salve aqueles que não conseguem se virar sozinhos. É a lei da natureza que os fortes prosperem e os fracos pereçam.", "Um bordão, uma armadilha de caça, um fetiche de um animal que você matou, um conjunto de roupas de viajante e uma algibeira contendo 10 po", "CARACTERÍSTICA: ANDARILHO Você tem uma memória excelente para mapas e geografia, e você sempre pode recobrar o plano geral de terrenos, assentamentos ou outras características ao seu redor. Além disso, você pode encontrar comida e água fresca para você a até cinco outras pessoas a cada dia, considerando que a terra ofereça bagas, pequenas frutas, água e similares.", "1 Mudança. A vida é como as estações, em constante mudança, e nós devemos mudar com ela. (Caótico) \n2 Bem maior. É responsabilidade de todos trazer a maior felicidade para toda a tribo. (Bom) \n3 Honra. Se eu me desonrar, eu desonrarei todo o meu clã. (Leal) \n4 Força. O mais forte deve governar. (Mau) \n5 Natureza. O mundo natural é mais importante que todas as construções da civilização. (Neutro) \n6 Gloria. Eu devo adquirir gloria em batalha, para mim e para meu clã. (Qualquer)", 1, "Forasteiro", "Atletismo, Sobrevivência, \nUm tipo de instrumento musical", "1 Eu fui guiado por uma sede de viagens que me levou a abandonas meu lar. \n2 Eu cuido dos meus amigos como se eles fossem filhotes recém-nascidos. \n3 Certa vez, eu corri quarenta quilômetros sem parar alertar meu clã da aproximação de uma horda orc. Eu faria de novo se fosse necessário. \n4 Eu tenho uma lição pra cada situação, aprendida observando a natureza. \n5 Eu não vejo lugar para o povo rico e educado. Dinheiro e modos não vão salvá-lo de um urso-coruja faminto. \n6 Estou sempre pegando coisas, distraidamente brincando com elas e, às vezes, quebrando-as. \n7 Eu me sinto muito mais confortável entre animais que entre pessoas. \n8 Eu fui, de fato, criado por lobos.", "1 Minha família, clã ou tribo é a coisa mais importante na minha vida, mesmo quando eles estão longe. \n2 Uma ofensa a natureza intocada do meu lar é uma ofensa a mim. \n3 Eu trarei uma fúria terrível aos malfeitores que destruíram minha terra natal. \n4 Eu sou o último da minha tribo e cabe a mim garantir que seus nomes façam parte das lendas. \n5 Eu sofro de visões terríveis de um desastre vindouro, e farei qualquer coisa para impedi-lo. \n6 É meu dever prover filhos para sustentar minha tribo." });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 8, "1 O tirano que comanda minha terra não vai parar até ver meu cadáver. \n2 Eu estou convencido sobre o significado do meu destino, e cego aos riscos e falhas. \n3 As pessoas que me conhecem desde criança sabem de um vergonhoso segredo meu, eu não poderei voltar para casa nunca. \n4 Eu tenho uma fraqueza pelos vícios da cidade, especialmente a bebedeira. \n5 Secretamente, eu acredito que as coisas estariam melhores se algum tirano comandasse a região. \n6 Eu tenho dificuldades em confiar em meus aliados.", " Um conjunto de ferramentas de artesão (à sua escolha), uma pá, um pote de ferro, um conjunto de roupas comuns e uma algibeira contendo 10 po ", "CARACTERÍSTICA: HOSPITALIDADE RÚSTICA Já que você ascendeu da categoria de pessoas comuns até onde você está agora, é fácil se misturar a eles. Você pode encontrar lugar entre os camponeses para se esconder, descansar ou se recuperar, a menos que isso ofereça um risco direto a eles. Eles o esconderão da lei e de qualquer um que venha perguntando por você, desde que não tenham que arriscar suas vidas. ", "1 Respeito. As pessoas merecem ser tratadas com dignidade e respeito. (Bom) \n2 Justiça. Ninguém merece tratamento diferenciado perante a lei, muito menos estar acima dela. (Leal) \n3 Liberdade. Não pode haver permissão para tiranos oprimirem o povo. (Caótico) \n4 Força. Se eu ficar forte, eu posso pegar tudo o que eu quiser – o que eu desejar. (Mal) \n5 Sinceridade. Não há nada de bom em fingir ser algo que não sou. (Neutro) \n6 Destino. Nada, nem ninguém, pode me manter longe do meu chamado. (Qualquer)", 0, "Herói do Povo", "Adestrar Animais, Sobrevivência, \nUm tipo de ferramenta de artesão, veículos (terrestre)", "1 Eu julgo as pessoas por suas ações, não por suas palavras. \n2 Se alguém está em apuros, eu estou sempre pronto para ajudar. \n3 Quando eu fixo minha mente em algo, eu sigo esse caminho, não importa o que fique no caminho. \n4 Eu possuo um forte senso de justiça e sempre tento encontrar a solução mais equilibrada para as discussões. \n5 Eu confio em minhas habilidades e farei o que for necessário para que os outros confiem também. \n6 Pensar é para os outros, eu prefiro agir. \n7 Eu abuso de palavras longas na tentativa de soar inteligente. \n8 Eu me entedio fácil. Para onde devo ir para me encontrar com meu destino?", "1 Eu tenho família, embora não faça a mínima ideia de onde eles estão, espero encontrá-los um dia. \n2 Eu trabalho a terra, eu amo a terra e eu vou defender a terra. \n3 Um nobre orgulhoso me deu uma bela surra, e eu vou ter minha vingança em qualquer valentão que encontrar. \n4 Minhas ferramentas são símbolo de minha vida passada, eu as carregarei para nunca me esquecer de minhas origens. \n5 Eu devo proteger aqueles que não podem se defender. \n6 Gostaria que meu amor viesse comigo para seguir meu destino." });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 9, "1 Eu sigo ordens, mesmo que eu ache que estão erradas. \n2 Eu direi qualquer coisa para evitar trabalho extra. \n3 Certa vez, alguém duvidou da minha coragem, eu nunca recuo, não importa o quão perigosa seja a situação. \n4 Quando começo a beber, é difícil pra mim parar. \n5 Eu não resisto a uma sacolinha de moedas dando sopa ou outras bugigangas que encontro. \n6 Meu orgulho provavelmente levará a minha destruição.", "Uma malagueta (clava), 15 metros de corda de seda, uma amuleto da sorte como um pé de coelho ou uma pequena pedra com um furo no centro (ou você pode rolar uma bugiganga da tabela Bugigangas no capítulo 5), um conjunto de trajes comuns e uma algibeira contendo 10 po ", "CARACTERÍSTICA: PASSAGEM DE NAVIO \nQuando você precisar, você pode conseguir passagem de graça em um navio para você e seus companheiros de aventura. Você precisa viajar no navio em que você trabalhou ou em outro navio com o qual você teve boas 139 relações (talvez um comandado por um ex-companheiro de tripulação). Por ser um favor, você não pode solicitar uma programação ou rota que atenda à todas as suas necessidades. Seu Mestre determina quanto tempo levará pra chegar aonde você quer ir. Em troca da passagem grátis, espera-se que você e seus companheiros ajudem a tripulação durante a viagem. ", "1 Respeito. A coisa que mantem um navio unido é o respeito mútuo entre o capitão e a tripulação. (Bem) \n2 Justiça. Todos nós fazemos o trabalho, portanto, todos partilhamos os espólios. (Leal) \n3 Liberdade. O mar é liberdade – a liberdade de ir aonde quiser. (Caótico) \n4 Domínio. Eu sou um predador e os outros navios no mar são minhas presas. (Mau) \n5 Povo. Eu sou apegado aos meus companheiros de tripulação, não a ideais. (Neutro) \n6 Aspiração. Algum dia eu serei dono do meu próprio navio e traçarei meu próprio destino. (Qualquer)", 0, "Marinheiro", "Atletismo, Percepção, \nFerramentas de navegador, veículo (aquático)", "1 Meus amigos sabem que podem contar comigo pro que der e vier. \n2 Eu trabalho duro para que possa me divertir muito quando o trabalho estiver pronto. \n3 Eu gosto de navegar para novos portos e fazer novas amizades acompanhado de uma jarra de cerveja. \n4 Eu modifico alguns fatos para o bem de uma boa história. \n5 Pra mim, uma briga de taverna é uma ótima forma de conhecer uma nova cidade. \n6 Eu nunca deixo passar uma aposta amigável. \n7 Meu vocabulário é tão sujo quanto o covil de um otyugh. \n8 Eu gosto de trabalhos bem feitos, especialmente se eu puder convencer alguém a fazê-los.", "1 Eu sou leal ao meu capitão, primeiramente, o resto vem em segundo. \n2 O navio é o mais importante – tripulantes e capitães vem e vão. \n3 Eu sempre me lembrarei do meu primeiro navio. \n4 Em uma cidade portuária, eu tenho uma amante que quase me roubou do mar. \n5 Eu fui enganado na divisão dos espólios e eu quero o que me é devido. \n6 Cruéis piratas mataram meu capitão e companheiros de tripulação, saquearam nosso navio e me deixaram para morrer. A vingança será minha." });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 10, "\n1 Eu secretamente acredito que todos estão abaixo de mim. \n2 Eu escondo um segredo verdadeiramente escandaloso que poderia arruinar minha família para sempre. \n3 Muitas vezes eu ouço insultos e ameaças veladas em cada palavra dirigida a mim, e me irrito muito rápido. \n4 Eu tenho um desejo insaciável por prazeres carnais. \n5 Na verdade, o mundo gira ao meu redor. \n6 Pelas minhas palavras e ações, muitas vezes, envergonho minha família.", "Um conjunto de trajes finos, um anel de sinete, um pergaminho de linhagem e uma algibeira contendo 25 po", "CARACTERÍSTICA: POSIÇÃO PRIVILEGIADA \nGraças a sua origem nobre, as pessoas tendem a pensar o melhor de você. Você é bem-vindo na alta sociedade e as pessoas assumem que você tem o direito de estar onde está. As pessoas comuns fazem todos os esforços para acomodá-lo e evitar seu desprazer, e outros nobres o tratam como um membro da mesma classe social. Você pode conseguir uma audiência com um nobre local se precisar. ", "1 Respeito. O respeito a mim é devido por causa da minha posição, mas todas as pessoas, independentemente da posição merecem ser tratados com dignidade. (Bom) \n2 Responsabilidade. É o meu dever respeitar a autoridade daqueles acima de mim, assim como aqueles abaixo de mim devem me respeitar. (Leal) \n3 Independência. Devo provar que posso me cuidar sem os mimos da minha família. (Caótico) \n4 Poder. Se eu puder alcançar mais poder, ninguém vai me dizer o que fazer. (Mau) \n5 Família. O sangue corre mais grosso que a água. (Qualquer) \n6 Obrigação Nobre. É o meu dever proteger e cuidar das pessoas abaixo de mim. (Bom)", 1, "Nobre", "História, Persuasão, \nUm tipo de kit de jogos ", "1 Minha bajulação eloquente faz com que todos com quem eu converse se sintam a pessoa mais maravilhosa e importante do mundo. \n2 As pessoas comuns me amam por minha bondade e generosidade. \n3 Ninguém pode duvidar, olhando para o meu porte real, que estou acima das massas plebeias. \n4 Eu tenho grande cuidado de sempre estar no meu melhor e seguir as últimas modas. \n5 Eu não gosto de sujar minhas mãos, e eu não vou ser pego em acomodações inadequadas. \n6 Apesar da minha origem nobre, eu não estou acima dos outros. O sangue é um só. \n7 Meu apoio, uma vez perdido, não volta. \n8 Se você me ferir, eu irei esmagá-lo, arruinar seu nome, e salgar seus campos.", "1 Eu vou encarar qualquer desafio para ganhar a aprovação da minha família. \n2 A aliança da minha casa com outra família nobre deve ser mantida a todo custo. \n3 Nada é mais importante do que os outros membros da minha família. \n4 Eu sou apaixonado pela herdeira de uma família que a minha família despreza. \n5 Minha lealdade ao meu soberano é inabalável. \n6 As pessoas comuns devem me ver como um herói do povo." });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 11, "1 Se eu estiver em desvantagem, eu vou fugir de uma briga. \n2 Ouro parece ser muito dinheiro pra mim, e eu faria praticamente qualquer coisa por mais dele. \n3 Eu nunca vou confiar em ninguém plenamente, além de mim mesmo. \n4 Eu prefiro matar alguém enquanto dorme que uma luta justa. \n5 Não é roubo se eu preciso mais que outra pessoa. \n6 As pessoas que não podem se virar sozinhas, tem o que merecem.", "Uma faca pequena, um mapa da cidade em que você cresceu, um rato de estimação, um pequeno objeto para lembrar dos seus pais, um conjunto de roupas comuns e uma algibeira contendo 10 peças de ouro", "CARACTERÍSTICA: SEGREDOS DA CIDADE \nVocê conhece os padrões secretos e o fluxo das cidades e pode encontrar passagens através da expansão urbana que os outros deixariam passar. Quando você não estiver em combate, você (e os companheiros que você guiar) podem viajar entre dois locais quaisquer na cidade com o dobro da velocidade normalmente permitida. ", "1 Respeito. Todas as pessoas, ricas ou pobres, merecem respeito. (Bom) \n2 Comunidade. Nós temos que tomar conta uns dos outros, porque ninguém mais o fará. (Leal) \n3 Mudança. Os baixos se erguerão e os altos irão tombar. A mudança é a natureza das coisas. (Caótico) \n4 Retribuição. Os ricos precisam ver como a vida e morte é nas sarjetas. (Mau) \n5 Povo. Eu ajudo as pessoas que me ajudam – é isso que nos mantem vivos. (Neutro) \n6 Aspiração. Eu vou provar que sou merecedor de uma vida melhor. (Qualquer)", 0, "Órfão", "Furtividade, Prestidigitação, \nKit de disfarce, ferramentas de ladrão ", "1 Eu escondo pedaços de comida e bugigangas em meus bolsos. \n2 Eu pergunto um monte e coisas. \n3 Eu gosto de me espremer em locais pequenos onde ninguém possa me alcançar. \n4 Eu durmo encostado em um muro ou árvore, abraçado com todas as minhas posses. \n5 Eu como feito um porco e tenho maus modos. \n6 Eu acho que todos que são gentis comigo tem segundas intenções. \n7 Eu não gosto de tomar banho. \n8 Eu digo na cara o que as outras pessoas insinuam ou escondem.", "1 Minha cidade ou vila é meu lar, e eu vou lutar para defendêlo. \n2 Eu patrocino um orfanato para que outros não passem pelo que fui forçado a passar. \n3 Eu devo minha sobrevivência a outros órfão que me ensinou a vida nas ruas. \n4 Eu tenho uma dívida que nunca poderei pagar com uma pessoa que teve pena de mim. \n5 Eu sai da minha vida de pobreza roubando uma pessoa importante, eu sou procurado por isso. \n6 Ninguém deveria ter suportar as dificuldades pelas quais passei." });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 12, "1 Eu me distraio facilmente com a promessa de informação. \n2 Muitas pessoas gritam e correm quando veem um corruptor. Eu paro e tomo notas de sua anatomia. \n3 Desvendar um mistério ancestral pode muito bem valer o preço e uma civilização. \n4 E prefiro soluções óbvias a complicadas. \n5 Eu falo sem antes pensar em minhas palavras, invariavelmente insultando outros. \n6 Eu não consigo guardar um segredo para salvar minha vida. Ou a vida de qualquer outra pessoa.", "Um vidro de tinta escura, uma pena, uma faca pequena, uma carta de um falecido colega perguntando a você algo que você nunca terá a chance de responder, um conjunto de roupas comuns e uma algibeira contendo 10 po ", "CARACTERÍSTICA: PESQUISADOR \nQuando tentar obter ou recuperar um fragmento de conhecimento que você não saiba, você descobre aonde e com quem pode obter essa informação. Normalmente ela será adquirida em bibliotecas, arquivos de escribas, universidade ou outros sábios e pessoas aptas. Seu Mestre pode decidir que o conhecimento que busca está escondido em algum lugar quase inacessível, ou é simplesmente impossível de se obter. Desvendar os 142 segredos mais profundos do multiverso pode requerer uma campanha inteira. ", "1 Conhecimento. O caminho para o poder e o auto aperfeiçoamento é através do conhecimento. (Neutro) \n2 Beleza. O que é belo nos mostra o que está além disso perto do que é verdadeiro. (Bom) \n3 Logica. Emoções não devem nublar seu pensamento lógico. (Leal) \n4 Sem Limites. Nada pode apaziguar a possibilidade infinita de toda a existência. (Caótico) \n5 Poder. Conhecimento é o caminho para o poder e a dominação. (Mau) \n6 Auto Aperfeiçoamento. O objetivo de uma vida de estudos é a melhoria de si mesmo. (Qualquer)", 2, "Sábio", "Arcanismo, História", "1 Eu uso palavras polissilábicas para endossar minha impressão de grande erudição. \n2 Eu já li todos os livros das grandes bibliotecas – ou gosto de me vangloriar e dizer que li. \n3 Eu costumo ajudar os outros que não são tão inteligentes quanto eu, e pacientemente explico tudo quantas vezes forem necessárias. \n4 Nada para mim é melhor que um bom mistério. \n5 Eu voluntariamente escuto cada lado, e seus argumentos, antes de tomar uma decisão final. \n6 Eu...falo...lentamente...ao...conversar...com idiotas...que tentam...se comparar...comigo. \n7 E sou horrível e estranho em situações sociais. \n8 Estou convencido de que todos tentam roubar os meus segredos de mim.", "1 É meu dever proteger meus estudantes. \n2 Eu guardo um texto ancestral que contém terríveis segredos que não podem cair em mãos erradas. \n3 Eu trabalho para preservar uma biblioteca, universidade, arquivo de escribas ou monastério. \n4 O trabalho a da minha vida é uma série de tomos relatando um campo de conhecimento específico. \n5 Eu venho procurando a minha vida inteira pela resposta de certa questão. \n6 Eu vendi minha alma por conhecimento. Espero realizar grandes feitos para ganhá-la de volta." });

            migrationBuilder.InsertData(
                table: "Antecedentes",
                columns: new[] { "IdAntecedente", "Defeito", "Equipamento", "Habilidade", "Ideal", "IdiomaQtd", "Nome", "Proficiencia", "Traco", "Vinculo" },
                values: new object[] { 13, "1 O inimigo monstruoso que enfrentei em uma batalha ainda me deixa tremendo de medo. \n2 Eu tenho pouco respeito por aqueles que não se provam bons combatentes. \n3 Eu cometi um terrível erro em batalha, o que custou muitas vidas – eu farei de tudo para manter esse erro em segredo. \n4 Meu ódio por meus inimigos é cego e irracional. \n5 Eu obedeço a lei, mesmo se a lei trouxer a angústia. \n6 Eu prefiro comer minha armadura a admitir que estou errado.", "Uma insígnia de patente, um fetiche obtido de um inimigo caído (uma adaga, lâmina partida ou tira de estandarte), um conjunto de dados de osso ou baralho, um conjunto de roupas comuns e uma algibeira contendo 10 po ", "CARACTERÍSTICA: PATENTE MILITAR \nVocê possui uma patente militar da sua época como soldado. Soldados leais à sua antiga organização reconhecem sua autoridade e influência, e o prestam deferência se forem de uma patente mais baixa. Você pode invocar sua patente para exercer influência sobre soldados, e requisitar equipamentos simples ou cavalos para uso temporário. Você também pode ganhar acesso a acampamentos militares aliados, e fortalezas onde usa patente é reconhecida. ", "1 Bem Maior. Nosso destino é dar nossas vidas em defesa de terceiros. (Bom) \n2 Responsabilidade. Eu faço o que tenho que fazer e obedeço apenas a autoridade. (Leal) \n3 Independência. Quando pessoas seguem ordens cegas elas apoiam um tipo de tirania. (Caótico) \n4 Força. A vida é como uma guerra, o mais forte vence. (Mau) \n5 Viva e Deixa Viver. Ideais não valem a pena se você matar, ou for à guerra por eles. (Neutro) \n6 Aspiração. Minha cidade, nação ou meu povo, são tudo o que importa para mim. (Qualquer)", 0, "Soldado", "Atletismo, Intimidação ", "1 Eu sou sempre polido e respeitoso. \n2 Eu sou assombrado pelas memórias da guerra. Não consigo tirar aquelas imagens da minha cabeça. \n3 Eu perdi muitos amigos, e sou muito devagar para fazer novos. \n4 Eu tenho muitas histórias de inspiração e cautela da época de minha experiência militar que são relevantes em todas as situações de combate. \n5 Eu não consigo encarar um cão infernal sem vacilar. \n6 Eu gosto de ser forte e de quebrar coisas. \n7 Eu tenho um senso de humor grosseiro. \n8 Eu enfrento os problemas de frente. Uma solução direta é o melhor caminho para o sucesso.", "1 Eu ainda daria a minha vida pelas pessoas com quem servi. \n2 Alguém salvou minha vida no campo de batalha. Desde aquele dia eu nunca deixo nenhum amigo para trás. \n3 Minha honra é minha vida. \n4 Eu nunca esquecerei a destruidora derrota que minha companhia sofreu ou os inimigos que a causaram. \n5 Aqueles que lutam ao meu lado são aqueles por quem vale a pena morrer. \n6 Eu luto por aqueles que não podem lutar por si mesmos." });

            migrationBuilder.InsertData(
                table: "Arquetipos",
                columns: new[] { "IdArquetipo", "HabilidadeArquetipo", "Nome" },
                values: new object[] { 1, "CAMINHO DO FURIOSO Para alguns bárbaros, a fúria é um meio para um fim – esse fim é a violência. O Caminho do Furioso é um caminho de fúria livre, entumecido em sangue. A medida que você entra na fúria de um furioso, você vibra no caos da batalha, despreocupado com a sua própria saúde ou bem-estar. FRENESI Começando no momento que você escolhe esse caminho no 3° nível, você pode entrar num frenesi quando estiver em fúria. Se você desejar, pela duração da sua fúria, você pode realizar um único ataque corpo-a-corpo com arma, com uma ação bônus, em cada um de seus turnos após esse. Quando sua fúria acabar, você sofrerá um nível de exaustão (como descrito no apêndice A). FÚRIA INCONSCIENTE A partir do 6° nível, você não pode ser enfeitiçado ou amedrontado enquanto estiver em fúria. Se você estava enfeitiçado ou amedrontado quando entrou em fúria, o efeito é suspenso pela duração da fúria. PRESENÇA INTIMIDANTE A partir do 10° nível, você pode usar sua ação para amedrontar alguém com sua presença intimidante. Quando o fizer, escolha uma criatura que você possa ver a 9 metros. Se a criatura puder ver ou ouvir você, ela deve ser bem sucedida num teste de resistência de Sabedoria (CD igual a 8 + seu bônus de proficiência + seu modificador de Carisma) ou ficara com medo de você até o fim do seu próximo turno. Nos turnos seguintes, você pode usar sua ação para estender a duração desse efeito na criatura amedrontada até o início do seu próximo turno. Esse efeito termina se a criatura terminar seu turno fora da sua linha de visão ao a mais de 18 metros de você. Se a criatura for bem sucedida no teste de resistência, você não poderá usar essa característica nessa criatura novamente por 24 horas. RETALIAÇÃO A partir do 14° nível, quando você sofrer dano de uma criatura que esteja a até 1,5 metro de você, você pode usar sua reação para realizar um ataque corpo-a-corpo com arma contra essa criatura. ", "Caminho do Furioso" });

            migrationBuilder.InsertData(
                table: "Arquetipos",
                columns: new[] { "IdArquetipo", "HabilidadeArquetipo", "Nome" },
                values: new object[] { 2, "O Caminho do Guerreiro Totêmico é uma jornada espiritual, à partir do momento que o bárbaro aceita um espirito animal como seu guia, protetor e inspiração. Em batalha, seu espirito totêmico preenche você com força sobrenatural, adicionando combustível mágico a sua fúria bárbara. A maioria das tribos bárbaras consideram que um animal totêmico possui parentesco a um clã em particular. Em tais casos, é incomum a um indivíduo possuir mais de um espirito animal totêmico, apesar de existirem exceções. CONSELHEIRO ESPIRITUAL Seu caminho é buscar a sintonia com o mundo natural, concedendo a você uma afinidade com as bestas. A partir do 3° nível, quando você toma esse caminho, você recebe a habilidade de conjurar as magias sentido bestial e falar com animais, mas apenas na forma de rituais, como descrito no capítulo 10. TOTEM ESPIRITUAL A partir do 3° nível, quando você adota esse caminho, você escolhe um totem espiritual e ganha suas características. Você deve fazer ou adquirir um objeto físico como totem – um amuleto ou adorno similar – que incorpora o pelo ou penas, garras, dente ou ossos do animal totêmico. Se você quiser, você também adquire pequenos atributos físicos que o assemelham ao seu totem espiritual. Por exemplo, se você tiver o totem espiritual do urso, você seria incomumente peludo e de pele grossa, ou se o seu totem for a águia, seu olhos teriam um brilho amarelado. Seu totem animal deve ser um animal relacionado aos listados aqui, mas pode ser um mais apropriado a sua terra natal. Por exemplo, você poderia escolher falcão ou abutre ao invés de águia. Águia. Quando estiver em fúria e não estiver vestindo uma armadura pesada, as outras criaturas terão desvantagem nas jogadas de ataque de oportunidade contra você e você pode usar a ação de Disparada como uma ação bônus no seu turno. O espirito da águia torna você um predador que pode vagar pelo meio da briga com facilidade. Lobo. Quando estiver em fúria, seus amigos tem vantagem nas jogadas de ataque corpo-a-corpo realizadas contra qualquer criatura a 1,5 metro de você que seja hostil a você. O espirito do lobo transforma você em um líder de caça. Urso. Quando em fúria, você adquire resistência a todos os tipos de dano, exceto dano psíquico. O espirito do urso torna você vigoroso o suficiente para permanecer de pé diante de qualquer castigo. ASPECTO DA BESTA No 6° nível, você adquire um benefício místico baseado no totem que você escolheu. Você pode escolher o mesmo animal que selecionou no 3° nível ou um diferente. Águia. Você ganha a visão aguçada de uma águia. Você pode ver a até 1,6 km sem dificuldade, sendo capaz de discernir até os menores detalhes quando estiver olhando para algo a menos de 30 metros de você. Além disso, penumbra não impõem desvantagem nos seus testes de Sabedoria (Percepção). Lobo. Você ganha a sensibilidade predatória de um lobo. Você pode rastrear outras criaturas quando estiver viajando a passo rápido e você pode se mover furtivamente quando estiver viajando a passo normal (veja o capítulo 8 para as regras de passo de viagem). Urso. Você ganha a força de um urso. Sua capacidade de carga (incluindo carga máxima e capacidade de erguer) é dobrada e você tem vantagem em testes de Força realizados para empurrar, puxar, erguer ou quebrar objetos. ANDARILHO ESPIRITUAL No 10° nível, você pode conjurar a magia comunhão com a natureza, mas apenas como um ritual. Quando o fizer, uma versão espiritual de um dos animais que você escolheu como Totem Espiritual ou Aspecto da Besta aparece para você para transmitir a informação que você busca. SINTONIA TOTÊMICA No 14° nível, você ganha um benefício magico baseado em um totem animal, à sua escolha. Você pode escolher o mesmo animal que selecionou anteriormente ou um diferente. Águia. Quando estiver em fúria, você adquire um deslocamento de voo igual ao seu deslocamento de caminhada. Esse benefício funciona apenas em pequenos explosões: você cai se terminar seu turno no ar e não tiver nada em que possa se agarrar. Lobo. Quando estiver em fúria, você pode usar uma ação bônus no seu turno para derrubar uma criatura Grande ou menor no chão quando você atingi-la com um ataque corpo-a-corpo com arma. Urso. Quando estiver em fúria, qualquer criatura a até 1,5 metro de você que for hostil a você terá desvantagem nas jogadas de ataque contra outros alvos além de você ou outro personagem com essa característica. Um inimigo é imune a esse efeito se ele não puder ver ou ouvir você ou caso ele não possa ser amedrontado. ", "Caminho do Guerreiro Totêmico" });

            migrationBuilder.InsertData(
                table: "Arquetipos",
                columns: new[] { "IdArquetipo", "HabilidadeArquetipo", "Nome" },
                values: new object[] { 3, "Bardos do Colégio do Conhecimento conhecem algo sobre a maioria das coisas, coletando pedaços de conhecimento de fontes tão diversas quanto tomos eruditos ou contos de camponeses. Quer seja cantando baladas populares em taverna, quer seja elaborando composições para cortes reais, esses bardos usam seus dons para manter a audiência enfeitiçada. Quando os aplausos acabam, os membros da audiência vão estar se questionando se tudo que eles creem é verdade, desde sua crença no sacerdócio do templo local até sua lealdade ao rei. A fidelidade desses bardos reside na busca pela beleza e verdade, não na lealdade a um monarca ou em seguir os dogmas de uma divindade. Um nobre que mantem um bardo desses como seu arauto ou conselheiro, sabe que o bardo prefere ser honesto que político. Os membros do colégio se reúnem em bibliotecas e, as vezes, em faculdades de verdade, completas com salas de aula e dormitórios, para partilhar seu conhecimento uns com os outros. Eles também se encontram em festivais ou em assuntos de estado, onde eles podem expor corrupção, desvendar mentiras e zombar da superestima de figuras de autoridade. PROFICIÊNCIA ADICIONAL Quando você se junta ao Colégio do Conhecimento no 3° nível, você ganha proficiência em três perícias, à sua escolha. PALAVRAS DE INTERRUPÇÃO Também no 3° nível, você aprende como usar sua perspicácia para distrair, confundir e, de outras formas, atrapalhar a confiança e competência de outros. Quando uma criatura que você pode ver a até 18 metros de você realizar uma jogada de ataque, um teste de habilidade ou uma jogada de dano, você pode usar sua reação para gastar um uso de Inspiração de Bardo, rolando o dado de Inspiração de Bardo e subtraindo o número rolado da rolagem da criatura. Você escolhe usar essa característica depois da criatura fazer a rolagem, mas antes do Mestre determinar se a jogada de ataque ou teste de habilidade foi bem ou mal sucedido, ou antes da criatura causar dano. A criatura será imune se não puder ouvir ou se não puder ser enfeitiçada. SEGREDOS MÁGICOS ADICIONAIS No 6° nível, você aprende duas magias, à sua escolha, de qualquer classe. As magias que você escolher devem ser de um nível que você possa conjurar, como mostrado na tabela O Bardo, ou um truque. As magias escolhidas contam como magias de bardo pra você, mas não contam no número de magias de bardo que você conhece. PERÍCIA INIGUALÁVEL A partir do 14° nível, quando você fizer um teste de habilidade, você pode gastar um uso de Inspiração de Bardo. Role o dado de Inspiração de Bardo e adicione o número rolado ao seu teste de habilidade. Você pode escolher fazer isso depois de rolar o dado do teste de habilidade, mas antes do Mestre dizer se foi bem ou mal sucedido. ", "Colégio do Conhecimento" });

            migrationBuilder.InsertData(
                table: "Arquetipos",
                columns: new[] { "IdArquetipo", "HabilidadeArquetipo", "Nome" },
                values: new object[] { 4, "Os bardos do Colégio da Bravura são escaldos destemidos de quem os contos mantem viva a memória dos grandes heróis do passado, dessa forma inspirando uma nova geração de heróis. Esses bardos se reúnem em salões de hidromel ou ao redor de fogueiras para cantar os feitos dos grandiosos, tanto do passado quanto do presente. Eles viajam pelos lugares para testemunhar grandes eventos em primeira mão e para garantir que a memória desses eventos não se perca nesse mundo. Com suas canções, eles inspiram outros a alcançar o mesmo patamar de realizações dos antigos heróis. PROFICIÊNCIA ADICIONAL Quando você se junta ao Colégio da Bravura no 3° nível, você adquire proficiência com armadura médias, escudos e armas marciais. INSPIRAÇÃO EM COMBATE Também no 3° nível, você aprende a inspirar os outros em batalha. Uma criatura que possuir um dado de Inspiração de Bardo seu, pode rolar esse dado e adicionar o número rolado a uma jogada de dano que ele tenha acabado de fazer. Alternativamente, quando uma jogada de ataque for realizada contra essa criatura, ela pode usar sua reação para rolar o dado de Inspiração de Bardo e adicionar o número rolado a sua CA contra esse ataque, depois da rolagem ser feita, mas antes de saber se errou ou acertou. ATAQUE EXTRA A partir do 6° nível, você pode atacar duas vezes, ao invés de uma, sempre que você realizar a ação de Ataque no seu turno. MAGIA DE BATALHA No 14° nível, você dominou a arte de tecer a conjuração e usar armas em um ato harmonioso. Quando você usar sua ação para conjurar uma magia de bardo, você pode realizar um ataque com arma com uma ação bônus.", "Colégio da Bravura" });

            migrationBuilder.InsertData(
                table: "Arquetipos",
                columns: new[] { "IdArquetipo", "HabilidadeArquetipo", "Nome" },
                values: new object[] { 5, "PACTO DA CORRENTE Você aprende a magia convocar familiar e pode conjurá-la como um ritual. Essa magia não conta no número de magias que você conhece. Quando você conjura essa magia, você pode escolher uma das formas convencionais para o seu familiar ou uma das seguintes formas especiais: diabrete, pseudodragão, quasit ou sprite. Além disso, quando você realiza a ação de Ataque, você pode renunciar s um dos seus ataques para permitir que seu familiar realize um ataque, com a reação dele", "Pacto da Corrente" });

            migrationBuilder.InsertData(
                table: "Arquetipos",
                columns: new[] { "IdArquetipo", "HabilidadeArquetipo", "Nome" },
                values: new object[] { 6, "Você pode usar sua ação para criar uma arma de pactom em sua mão vazia. Você escolhe a forma que essa arma corpo-a-corpo tem a cada vez que você a cria (veja as opções de arma no capítulo 5). Você é proficiente com ela enquanto a empunhar. Essa arma conta como sendo mágica com os propósitos de ultrapassar resistência e imunidade a ataques e danos não-mágicos. Sua arma de pacto desaparece se ela estiver a mais de 1,5 metro de você por 1 minuto ou mais. Ela também desaparece se você usar essa característica novamente, se você dissipar a arma (não requer ação) ou se você morrer. Você pode transformar uma arma mágica em sua arma de pacto ao realizar um ritual especial enquanto empunha a arma. Você precisa de 1 hora para concluir o ritual, que pode ser realizado durante um descanso curto. Você pode dissipar a arma, guardando-a em um espaço extradimensional, e ela reaparece toda vez que você criar sua arma de pacto. A arma deixa de ser sua arma de pacto se você morrer, se você realizar um ritual de 1 hora com outra arma diferente ou se você realizar um ritual de 1 hora para romper seu elo com ela. A arma aparece aos seus pés se ela estiver no espaço extradimensional quando o elo for quebrado.", "Pacto da Lâmina" });

            migrationBuilder.InsertData(
                table: "Arquetipos",
                columns: new[] { "IdArquetipo", "HabilidadeArquetipo", "Nome" },
                values: new object[] { 7, "Seu patrono lhe deu um grimório chamado Livro das Sombras. Quando você adquire essa característica, escolha três truques da lista de magias de qualquer classe. Enquanto o livro estiver com você, você poderá conjurar esses truques à vontade. Eles não contam no número de truques que você conhece. Esses truques são considerados magias de bruxo para você e não precisam ser da mesma lista de magia. Se você perder seu Livro das Sombras, você pode realizar uma cerimônia de 1 hora para receber um substituto do seu patrono. Essa cerimônia pode ser realizada durante um descanso curto ou longo e destrói o livro anterior. O livro se torna cinzas quando você morre", "Pacto do Tomo" });

            migrationBuilder.InsertData(
                table: "Arquetipos",
                columns: new[] { "IdArquetipo", "HabilidadeArquetipo", "Nome" },
                values: new object[] { 8, "Seu patrono é um senhor ou senhora das fadas, uma criatura lendária que detém segredos que foram esquecidos antes das raças mortais nascerem. As motivações desses seres são, muitas vezes, inescrutáveis e, as vezes, excêntricas e podem envolver esforços para adquirir grandes poderes mágicos ou resolução de desavenças antigas. Incluem-se dentre esses seres o Príncipe do Frio; a Rainha do Ar e Trevas, regente da Corte do Crepúsculo; Titania da Corte do Verão; seu cônjuge, Oberon, o Senhor Verdejante; Hyrsam, o Príncipe dos Tolos; e bruxas antigas. LISTA DE MAGIA EXPANDIDA A Arquifada permite que você escolha magias de uma lista expandida quando você for aprender magias de bruxo. As seguintes magias são adicionadas a sua lista de magias de bruxo. MAGIAS EXPANDIDAS DA ARQUIFADA Nível de Magia Magias 1° fogo das fadas, sono 2° acalmar emoções, força fantasmagórica 3° piscar, ampliar plantas 4° dominar besta, invisibilidade maior 5° dominar pessoa, similaridade PRESENÇA FEÉRICA A partir do 1° nível, seu patrono concede a você a habilidade de projetar a sedução e temeridade da presença da fada. Com uma ação, você pode fazer com que cada criatura num cubo de 3 metros centrado em você, faça um teste de resistência de Sabedoria com uma CD igual a de sua magia de bruxo. As criaturas que falharem no teste ficaram enfeitiçadas ou amedrontadas por você (à sua escolha) até o início do seu próximo turno. Quando você usar essa característica, você não poderá utilizá-la novamente antes de realizar um descanso curto ou longo. NÉVOA DE FUGA A partir do 6° nível, você pode desaparecer em uma lufada de névoa em resposta a alguma ofensa. Quando você sofrer dano, você pode usar sua reação para ficar invisível e se teletransportar a até 18 metros para um espaço desocupado que você possa ver. Você permanece invisível até o início do seu próximo turno ou até realizar um ataque ou conjurar uma magia. Após usar essa características, você não poderá utilizá-la novamente até terminar um descanso curto ou longo. DEFESA SEDUTORA A partir do 10° nível, seu patrono ensina você como voltar as magias de efeito mental dos seus inimigos contra eles. Você não pode ser enfeitiçado e, quando outra criatura tenta enfeitiçá-lo, você pode usar sua reação para tentar reverter o encanto de volta aquela criatura. A criatura deve ser bem sucedida num teste de resistência de Sabedoria contra a CD da sua magia de bruxo ou ficara enfeitiçado por 1 minuto ou até a criatura sofrer dano. DELÍRIO SOMBRIO Começando no 14° nível, você pode imergir uma criatura num reino ilusório. Com um ação, escolha uma criatura que você possa ver a até 18 metros de você. Ela deve ser bem sucedida num teste de resistência de Sabedoria contra a CD da sua magia de bruxo. Se ela falhar, ela ficará enfeitiçada ou amedrontada por você (à sua escolha) por 1 minuto ou até você quebrar sua concentração (como se você estivesse se concentrando em uma magia). Esse efeito termina prematuramente se a criatura sofrer dano. Até que essa ilusão termine, a criatura acredita que está perdida num reino enevoado, a aparência desse reino fica a seu critério. A criatura só pode ver e ouvir a si mesma, a você e a sua ilusão. Você deve terminar um descanso curto ou longo antes de poder usar essa característica novamente. ", "A Arquifada" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 1, false, true, 12, false, "(a) um machado grande ou (b) qualquer arma marcial corpo-a-corpo  (a) dois machados de mão ou (b) qualquer arma simples  Um pacote de aventureiro e quatro azagaias", true, null, false, "Bárbaro", "Armaduras: Armaduras leves, armaduras médias e escudos Armas: Armas simples, armas marciais Ferramentas: Nenhuma Testes de Resistência: Força, Constituição Perícias: Escolha duas dentre Adestrar Animais, Atletismo, Intimidação, Natureza, Percepção e Sobrevivência", false });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 7, false, true, 10, false, "(a) cota de malha ou (b) gibão de peles, arco longo e 20 flechas  (a) uma arma marcial e um escudo ou (b) duas armas marciais  (a) uma besta leve e 20 virotes ou (b) dois machados de arremesso  (a) um pacote de aventureiro ou (b) um pacote de explorador", true, null, false, "Guerreiro", "Armaduras: Todas as armaduras, escudos Armas: Armas simples, armas marciais Ferramentas: nenhum Testes de Resistência: Força, Constituição Perícias: Escolha duas dentre Acrobacia, Adestrar Animais, Atletismo, História, Intuição, Intimidação, Percepção e Sobrevivência ", false });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 8, false, false, 8, true, "(a) uma rapieira ou (b) uma espada longa  (a) um arco curto e uma aljava com 20 flechas ou (b) uma espada curta  (a) um pacote de assaltante ou (b) um pacote de aventureiro ou (c) um pacote de explorador  Armadura de couro, duas adagas e ferramentas de ladrão", false, null, true, "Ladino", "(a) uma arma marcial e um escudo ou (b) duas armas marciais  (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo  (a) um pacote de sacerdote ou (b) um pacote de aventureiro  Cota de malha e um símbolo sagrado", false });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 10, false, false, 8, true, "(a) uma arma marcial e um escudo ou (b) duas armas marciais  (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo  (a) um pacote de sacerdote ou (b) um pacote de aventureiro  Cota de malha e um símbolo sagrado", true, null, false, "Monge", "Armaduras: Todas as armaduras, escudos Armas: Armas simples, armas marciais Ferramentas: Nenhum Testes de Resistência: Sabedoria, Carisma Perícias: Escolha duas dentre Atletismo, Intuição, Intimidação, Medicina, Persuasão e Religião", false });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 1, null, 1, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 2, null, 1, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 3, null, 2, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 4, null, 2, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 5, null, 3, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 6, null, 4, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 7, null, 5, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 8, null, 5, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 9, null, 7, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 10, null, 9, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 11, null, 11, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 12, null, 15, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 13, null, 18, null });

            migrationBuilder.InsertData(
                table: "Classes_TracosdeClasses",
                columns: new[] { "IdClasse", "IdTracodeClasse", "ClasseIdClasse", "Nivel", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 14, null, 20, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 1, "Acostumado à vida subterrânea ou às florestas crepusculares e ao céu noturno, você tem uma visão superior no escuro e na penumbra. Você enxerga na penumbra a até 18 metros como se fosse luz plena, e no escuro como se fosse na penumbra. Você não pode discernir cores no escuro, apenas tons de cinza.", "Visão no Escuro" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 2, "Você possui vantagem em testes de resistência contra venenos e resistência contra dano de veneno", "Resiliência Anã" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 3, "Você tem proficiência com machados de batalha, machadinhas,martelos leves e martelos de guerra.", "Treinamento Anão em Combate" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 4, "Você tem proficiência em uma ferramenta de artesão à sua escolha entre: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro. ", "Proficiência com Ferramentas" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 5, "Sempre que você realizar um teste de Inteligência (História) relacionado à origem de um trabalho em pedra, você é considerado proficiente na perícia História e adiciona o dobro do seu bônus de proficiência ao teste, ao invés do seu bônus de proficiência normal.", "Especialização em Rochas" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 6, "Seu máximo de pontos de vida aumentam em 1, e cada vez que o anão da colina sobe um nível, ele recebe 1 ponto de vida adicional.", "Tenacidade Anã" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 7, "Você adquire proficiência em armaduras leves e médias. ", "Treinamento Anão com Armaduras" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 8, "Você tem proficiência na perícia Percepção.", "Sentidos Aguçados" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 9, "Você tem vantagem nos testes de resistência para resistir a ser enfeitiçado e magias não podem colocá-lo para dormir. ", "Ancestral Feérico" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 11, "Elfos não precisam dormir. Ao invés disso, eles meditam profundamente, permanecendo semiconscientes, durante 4 horas por dia. (A palavra em idioma comum para tal meditação é 'transe'.) Enquanto medita, um elfo é capaz de sonhar de certo modo. Esses sonhos na verdade são exercícios mentais que se tornam reflexos através de anos de prática. Depois de descansar dessa forma, você ganha os mesmos benefícios que um humano depois de 8 horas de sono.", "Transe" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 12, "Você possui proficiência com espadas longas, espadas curtas, arcos longos e arcos curtos. ", "Treinamento Élfico com Armas" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 13, "Você conhece um truque, à sua escolha, da lista de truques do mago. Inteligência é a habilidade usado para conjurar este truque. ", "Truque" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 14, " Você pode falar, ler e escrever um idioma adicional à sua escolha.", "Idioma Adicional" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 15, "Seu deslocamento base de caminhada aumenta para 10,5 metros.", "Pés Ligeiros" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 16, "Você pode tentar se esconder mesmo quando você está apenas levemente obscurecido por folhagem, chuva forte, neve caindo, névoa ou outro fenômeno natural. ", "Máscara da Natureza" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 17, " Sua visão no escuro tem alcance de 36 metros de raio", "Visão no Escuro Superior" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 18, "Você possui desvantagem nas jogadas de ataque e testes de Sabedoria (Percepção) relacionados a visão quando você, o alvo do seu ataque, ou qualquer coisa que você está tentando perceber, esteja sob luz solar direta. ", "Sensibilidade à Luz Solar" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 19, ". Você possui o truque globos de luz. Quando você alcança o 3° nível, você pode conjurar a magia fogo das fadas. Quando você alcança o 5° nível, você pode conjurar escuridão. Você precisa terminar um descanso longo para poder conjurar as magias desse traço novamente. Carisma é sua habilidade chave para conjurar essas magias. ", "Magia Drow" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 20, "Você possui proficiência com rapieiras, espadas curtas e bestas de mão. ", "Treinamento Drow com Armas" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 21, "Quando você obtiver um 1 natural em uma jogada de ataque, teste de habilidade ou teste de resistência, você pode jogar de novo o dado e deve utilizar o novo resultado", "Sortudo" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 22, "Você tem vantagem em testes de resistência contra ficar amedrontado", "Bravura" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 23, "Você pode mover-se através do espaço de qualquer criatura que for de um tamanho maior que o seu", "Agilidade Halfling" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 24, "Você pode tentar se esconder mesmo quando possuir apenas a cobertura de uma criatura que for no mínimo um tamanho maior que o seu", "Furtividade Natural" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 25, "Você tem vantagem em testes de resistência contra veneno e tem resistência contra dano de veneno", "Resiliência dos Robustos" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 26, "Você possui um ancestral dracônico. Escolha um tipo de dragão da tablea Ancestral Dracônico. sua arma de sopro e resistência a dano são determinadas pelo tipo de dragão, como mostrado na tabela", "Ancestral Dracônico" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 27, "Você pode usar uma ação para exalar energia destrutiva. Seu ancestral dracônico determina o tamanho, formado e tipo de dano que você expele.Quando você usa sua arma de sopro, cada criatura na área exalada deve realizar um teste de resistência, o tipo do teste é determinado pelo seu ancestral dracônico. A CD do teste de resistência é 8 + seu modificador de Constituição + seu bônus de proficiência. Uma criatura sofre 2d6 de dano num fracasso e metade desse dano num sucesso. O dano aumenta para 3d6 no 6° nível, 4d6 no 11° nível e 5d6 no 16° nível. Depois de usar sua arma de sopro, você não poderá utilizá-la novamente até completar um descanso curto ou longo. ", "Arma de Sopro" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 28, "Você possui resistência ao tipo de dano associado ao seu ancestral dracônico", "Resistência a Dano" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 29, "Você possui vantagem em todos os testes de resistência de Inteligência, Sabedoria e Carisma contra magia", "Esperteza Gnômica" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 30, "Você conhece o truque ilusão menor. Inteligência é a sua habilidade usada para cunjurá-la", "Ilusionista Nato" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 31, "Através de sons e gestos, você pode comunicar ideias simples para Bestas pequenas ou menores. Gnomos da floresta amam os animais e normalmente possuem esquilos, doninhas, coelhos, toupeiras, pica-paus e outras criaturas como amados animais de estimação. ", "Falar com Bestas Pequenas" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 32, "Toda vez que você fizer um teste de Inteligência (História) relacionado a itens mágicos, objetos alquímicos ou mecanismos tecnológicos, você pode adicionar o dobro do seu bônus de proficiência, ao invés de qualquer bônus de proficiência que você normalmente use. ", "Conhecimento de Artífice" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 33, "Você possui proficiência com ferramentas de artesão (ferramentas de engenhoqueiro). Usando essas ferramentas, você pode gastar 1 hora e 10 po em materiais para construir um mecanismo Miúdo (CA 5, 1 pv). O mecanismo para de funcionar após 24 horas (a não ser que você gaste 1 hora reparando-o para manter o mecanismo funcionando), ou quando você usa sua ação para desmantelá-lo; nesse momento, você pode recuperar o material usado para criá-lo. Você pode ter até três desses mecanismos ativos ao mesmo tempo. Quando você criar um mecanismo, escolha uma das seguintes opções: Brinquedo Mecânico. Esse brinquedo é um animal, monstro ou pessoa mecânica, como um sapo, rato, pássaro, dragão ou soldado. Quando colocado no chão, o brinquedo se move 1,5 metro pelo chão em cada um dos seus turnos em uma direção aleatória. Ele faz barulhos apropriados a criatura que ele representa. Isqueiro Mecânico. O mecanismo produz uma miniatura de chama, que você pode usar para acender uma vela, tocha ou fogueira. Usar o mecanismo requer sua ação. Caixa de Música. Quando aberta, essa caixa de música toca uma canção a um volume moderado. A caixa para de tocar quando alcança o fim da música ou quando é fechada.", "Engenhoqueiro" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 34, "Você ganha proficiência em duas perícias, à sua escolha", "Versatilidade em Perícia" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 35, "Você adquire proficiência na perícia Intimidação", "Ameaçador" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 36, "Quando você é reduzido a 0 pontos de vida mas não é completamente morto, você pode voltar para 1 ponto de vida. você não pode usar essa característica novamente até completar um descanso longo.", "Resistência Implacável" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 37, "Quando você atinge um ataque crítico com uma arma corpo-a-corpo, você pode rolar um dos dados de dano da arma mais uma vez e adicioná-lo ao dano extra causado pelo crítico", "Ataques Selvagens" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 38, "Você possui resistência a dano do fogo", "Resistência Infernal" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais",
                columns: new[] { "IdHabilidadeRacial", "Descricao", "Nome" },
                values: new object[] { 39, "Você conhece o truque taumaturgia. Quando você atingir o 3° nível, você poderá conjurar a magia repreensão infernal como uma magia de 2° nível. Quando você atingir o 5° nível, você também poderá conjurar a magia escuridão. Você precisa terminar um descanso longo para poder usar as magias desse traço novamente. Sua habilidade de conjuração para essas magias é Carisma. ", "Legado Infernal" });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 1, 1, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 1, 2, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 1, 6, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 1, 7, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 1, 8, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 2, 1, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 3, 1, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 4, 1, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 5, 1, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 8, 2, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 9, 2, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 9, 7, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 10, 2, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 21, 3, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 22, 3, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 23, 3, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 26, 5, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 27, 5, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 28, 5, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 29, 6, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 34, 7, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 35, 8, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 36, 8, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 37, 8, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 38, 9, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_Racas",
                columns: new[] { "IdHabilidadeRacial", "IdRaca", "HabilidadeRacialIdHabilidadeRacial", "RacaIdRaca" },
                values: new object[] { 39, 9, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 6, 1, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 7, 2, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 12, 3, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 12, 4, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 13, 3, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 14, 3, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 15, 4, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 16, 4, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 17, 5, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 18, 5, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 19, 5, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 20, 5, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 24, 6, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 25, 7, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 30, 8, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 31, 8, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 32, 9, null, null });

            migrationBuilder.InsertData(
                table: "HabilidadesRaciais_SubRacas",
                columns: new[] { "IdHabilidadeRacial", "IdSubRaca", "HabilidadeRacialIdHabilidadeRacial", "SubRacaIdSubRaca" },
                values: new object[] { 33, 9, null, null });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 1, "", "Ábaco", "1 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 2, "", "Ácido (vidro)", "0.5 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 3, "Usando uma ação, você pode espalhar o conteúdo desse frasco em uma criatura a até 1,5 metro de você ou arremessar a até 6 metros, quebrando o frasco com o impacto. Em ambos os casos, você deve realizar um ataque à distância contra uma criatura alvo, tratando a água benta como uma arma improvisada. Se o alvo for um corruptor ou morto-vivo, ele sofre 2d6 de dano radiante. Um clérigo ou paladino pode criar água benta realizando um ritual especial. O ritual leva 1 hora para ser realizado, consome 25 po de prata em pó e exige que se gaste um espaço de magia de 1º nível. ", "Água Benta (frasco)", "0.5 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 4, " Essas algemas de metal podem prender uma criatura Pequena ou Média. Escapar das algemas exige sucesso em um teste de Destreza CD 20. Quebrá-las exige um teste de Força CD 20 bem sucedido. Cada conjunto de algemas vem com uma chave. Sem a chave, uma criatura proficiente com ferramentas de ladrão pode abrir a fechadura das algemas com um sucesso em um teste de Destreza CD 15. As algemas têm 15 pontos de vida. ", "Algemas", "2 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 5, " Uma bolsa de pano ou couro que pode armazenar até 20 munições de funda ou 50 munições de zarabatana, entre outras coisas. Para armazenar componentes de magia, veja bolsa de componentes, também descrita nessa seção. ", "Algibeira", "0.5 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 6, " Uma aljava pode guardar até 20 flechas.", "Aljava", "0.5 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 7, "", "Ampulheta", "0.5 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 8, "Uma criatura que beber o líquido desse vidro tem vantagem em testes de resistência contra venenos por 1 hora. O antídoto não confere nenhum benefício para mortos-vivos ou constructos. ", "Antídoto", "0.5 Kg", "50 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 9, "", "Apito de advertência", "0.5 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 10, "Você pode usar um aríete portátil para quebrar portas. Ao fazer isso, você ganha um bônus de +4 no teste de Força. Outra criatura pode ajudá-lo a usar o aríete, o que concede vantagem no teste. ", "Aríete portátil", "17.5 Kg", "4 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 11, "Quando você usa sua ação para armá-la, essa armadilha forma um anel de aço com dentes serrilhados. Eles se fecham quando uma criatura pisa sobre uma placa de pressão no seu centro. A armadilha é fixada por uma pesada corrente em um objeto fixo e imóvel, como uma árvore ou um cravo enterrado no chão. Uma criatura que pisar na placa de pressão deve ser bem sucedida em um teste de resistência de Destreza CD 13 ou sofrerá 1d4 de dano perfurante e para de se mover. Daí em diante, até que a criatura se liberte da armadilha, seu movimento é limitado ao comprimento da corrente (tipicamente 1 metro de comprimento). A criatura presa pode usar sua ação para fazer um teste de Força CD 13 e se libertar, ou outra criatura no alcance pode fazer o teste para libertá-la. Cada fracasso no teste causa 1 de dano perfurante à criatura presa. ", "Armadilha de caça", "12.5 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 12, "", "Arpéu", "2 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 13, "Trata-se de uma pequena balança, pratos e um sortimento adequado de pesos de até 1 kg. Com ela, você pode medir o peso exato de pequenos objetos, como metais preciosos brutos ou bens comerciais, para ajudar a determinar seu valor. ", "Balança de mercador", "1.5 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 14, "", "Balde", "1.5 Kg", "5 Peças de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 15, "", "Barril", "35 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 16, "", "Baú", "12.5 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 17, "Trata-se de uma pequena bolsa de couro à prova d'água que pode ser fixada em um cinto. Ela possui compartimentos para armazenar todos os componentes materiais e outros itens especiais que você precisa para lançar suas magias, exceto os componentes que possuem um custo específico (conforme indicado na descrição da magia).", "Bolsa de componentes", "1 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 18, "Esse pequeno recipiente detém uma pederneira, isqueiro e um pavio (um pano geralmente seco embebido em óleo) usado para acender uma fogueira. Usá-lo para acender uma tocha – ou qualquer outra coisa exposta a um combustível abundante – leva uma ação. Acender qualquer outro fogo leva 1 minuto ", "Caixa de Fogo", "0.5 Kg", "5 Peças de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 19, "", "Caneca", "0.5 Kg", "2 Peças de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 20, "", "Caneta Tinteiro", "", "2 Peças de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 21, "", "Cantil", "2.5 Kg", "2 Peças de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 22, "", "Cesto", "1 Kg", "4 Peças de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 23, "", "Cobertor de inverno", "1.5 Kg", "5 Peças de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 24, "", "Corda de cânhamo (15 metros)", "5 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 25, "", "Corda de seda (15 metros)", "2.5 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 26, "", "Corrente", "5 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 27, "", "Equipamento de pescaria", "2 Kg", "1 Peça Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 28, "", "Escadas", "12.5 Kg", "1 Peça Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 29, "", "Esferas (sacola com 1000)", "1 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 30, "", "Espelho de aço", "0.25 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 31, "", "Estrepes (bolsa com 20)", "1 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 32, "", "Fechadura", "0.5 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 33, "", "Bastão", "1 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 34, "", "Cajado", "2 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 35, "", "Cristal", "0.5 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 36, "", "Orbe", "1.5 Kg", "20 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 37, "", "Varinha", "0.5 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 38, "", "Cajado de madeira", "2 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 39, "", "Ramo de visco", "-", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 40, "", "Totem", "-", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 41, "", "Varinha de teixo", "0.5 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 42, "", "Fogo alquímico (frasco)", "0.5 Kg", "50 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 43, "", "Frasco", "1 Kg", "2 Peças de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 44, "", "Garrafa de vidro", "1 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 45, "", "Giz (1 peça)", "-", "1 Peça de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 46, "", "Grimório", "1.5 Kg", "50 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 47, "", "Jarra", "2 Kg", "4 Peças de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 48, "", "Kit de escalada", "6 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 49, "", "Kit de primeiros-socorros", "1.5 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 50, "", "Lâmpada", "0.5 Kg", "5 Peças de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 51, "", "Lanterna coberta", "1 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 52, "", "Lanterna furta-fogo", "1 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 53, "", "Lente de aumento", "-", "100 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 54, "", "Livro", "2.5 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 55, "", "Luneta", "0.5 Kg", "1000 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 56, "", "Manto", "2 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 57, "", "Marreta", "5 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 58, "", "Martelo", "1.5 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 59, "", "Mochila", "2.5 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 60, "", "Balas de Funda (20)", "0.75 Kg", "4 Peças de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 61, "", "Flechas (20)", "0.5 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 62, "", "Virotes (20)", "0.75 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 63, "", "Zarabatana (20)", "0.5 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 64, "", "Óleo (frasco)", "0.5 Kg", "1 Peça de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 65, "", "Pá", "2.5 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 66, "", "Panela de Ferro", "5 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 67, "", "Papel (uma folha)", "-", "2 Peças de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 68, "", "Parafina", "-", "5 Peças de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 69, "", "Pé de cabra", "2.5 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 70, "", "Pedra de amolar", "-", "1 Peça de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 71, "", "Perfume (frasco)", "-", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 72, "", "Pergaminho (uma folha", "-", "1 Peça de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 73, "", "Picareta de minerador", "5 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 74, "", "Píton", "-", "5 Peças de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 75, "", "Poção de Cura", "0.25 Kg", "50 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 76, "", "Porta mapas ou pergaminhos", "0.5 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 77, "", "Porta virotes", "0.5 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 78, "", "Pregos de ferro (10)", "2.5 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 79, "", "Rações de viagem (1 dia)", "1 Kg", "5 Peças de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 80, "", "Robes", "2 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 81, "", "Roldana e polia", "2.5 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 82, "", "Roupas comuns", "1.5 Kg", "5 Peças de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 83, "", "Roupas de viajante", "2 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 84, "", "Roupas de entretenimento", "2 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 85, "", "Roupas finas", "3 Kg", "15 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 86, "", "Sabão", "-", "1 Peças de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 87, "", "Saco", "0.25 Kg", "1 Peça de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 88, "", "Saco de dormir", "3.5 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 89, "", "Amuleto", "0.5 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 90, "", "Emblema", "-", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 91, "", "Relicário", "1 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 92, "", "Sinete", "-", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 93, "", "Sino", "-", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 94, "", "Tenda para duas pessoas", "10 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 95, "", "Tocha", "0.5 Kg", "1 Peça de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 96, "", "Tinta (frasco de 30 ml)", "-", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 97, "", "Vara (3 metros)", "3.5 Kg", "5 Peças de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 98, "", "Vela", "-", "1 Peça de Cobre" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 99, "", "Veneno básico (frasco)", "-", "100 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 100, "", "Ferramentas de carpinteiro", "3 Kg", "8 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 101, "", "Ferramentas de cartógrafo", "3 Kg", "15 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 102, "", "Ferramentas de costureiro", "2.5 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 103, "", "Ferramentas de entalhador", "2.5 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 104, "", "Ferramentas de ferreiro", "4 Kg", "20 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 105, "", "Ferramentas de funileiro", "5 Kg", "50 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 106, "", "Ferramentas de joalheiro", "1 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 107, "", "Ferramentas de oleiro", "1.5 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 108, "", "Ferramentas de pedreiro", "4 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 109, "", "Ferramentas de pintor", "2.5 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 110, "", "Ferramentas de sapateiro", "2.5 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 111, "", "Ferramentas de vidreiro", "2.5 Kg", "30 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 112, "", "Suprimentos de alquimista", "4 Kg", "50 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 113, "", "Suprimentos de cervejeiro", "4.5 Kg", "20 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 114, "", "Suprimentos de caligrafia", "2.5 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 115, "", "Utensílios de cozinheiro", "4 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 116, "", "Ferramentas de navegação", "1 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 117, "", "Ferramentas de ladrão", "0.5 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 118, "", "Alaúde", "1 Kg", "35 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 119, "", "Flauta", "0.5 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 120, "", "Flauta de pã", "1 Kg", "12 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 121, "", "Gaita de foles", "3 Kg", "30 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 122, "", "Lira", "1 Kg", "30 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 123, "", "Oboé", "0.5 Kg", "2 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 124, "", "Tambor", "1.5 Kg", "6 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 125, "", "Trombeta", "1 Kg", "3 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 126, "", "Violino", "3 Kg", "30 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 127, "", "Xilofone", "5 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 128, "", "Kit de disfarce", "1.5 Kg", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 129, "", "Kit de falsificação", "2.5 Kg", "15 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 130, "", "Kit de herbalismo", "1.5 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 131, "", "Baralho de cartas", "-", "5 Peças de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 132, "", "Conjunto de dados", "-", "1 Peça de Prata" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 133, "", "Jogo dos três dragões", "-", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 134, "", "Xadrez do dragão", "0.25 Kg", "1 Peça de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 135, "", "Kit de venenos", "1 Kg", "50 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 136, "Mochila; saco de dormir; duas fantasias; 5 velas; 5 dias de rações; cantil; kit de disfarce", "Pacote de Artista", "-", "40 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 137, "Mochila; saco com 1000 esferas de metal; 3 metros de linha; sino; 5 velas; pé de cabra; martelo; 10 pítons; lanterna coberta; 2 fascos de óleo; 5 dias de ração; caixa de fogo; cantil; 15 metros de corda de cânhamo", "Pacote de Assaltante", "-", "16 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 138, "Mochila; pé de cabra; martelo; 10 pítons; 10 tochas; caixa de fogo; 10 dias de rações; cantil; 15 metros de corda de cânhamo", "Pacote de Aventureiro", "-", "12 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 139, "Baú; 2 caixas para mapas ou pergaminhos; conjunto de roupas finas; vidro de tinta; caneta tinteiro; lâmpada; 2 frascos de óleo; 5 folhas de papel; vidro de perfume; parafina; sabão", "Pacote de Diplomata", "-", "39 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 140, "Mochila; livro de estudo; vidro de tinta; caneta tinteiro; 10 folhas de pergaminho; saquinho de areia; pequena faca", "Pacote de Estudioso", "-", "40 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 141, "Mochila; saco de dormir; kit de refeição; caixa de fogo; 10 tochas; 10 dias de rações; cantil; 15 metros de corda de cânhamo", "Pacote de Explorador", "-", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "IdItem", "Descricao", "Nome", "Peso", "Preco" },
                values: new object[] { 142, "Mochila; cobertor; 10 velas; caixa de fogo; caixa de esmola; 2 blocos de incenso; incensário; vestes; 2 dias de rações; cantil", "Pacote de Sacerdote", "-", "19 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "ListasMagias",
                columns: new[] { "IdListaMagia", "Nome" },
                values: new object[] { 1, "Magias de Bardo" });

            migrationBuilder.InsertData(
                table: "ListasMagias",
                columns: new[] { "IdListaMagia", "Nome" },
                values: new object[] { 2, "Magias de Bruxo" });

            migrationBuilder.InsertData(
                table: "ListasMagias",
                columns: new[] { "IdListaMagia", "Nome" },
                values: new object[] { 3, "Magias de Clérigo" });

            migrationBuilder.InsertData(
                table: "ListasMagias",
                columns: new[] { "IdListaMagia", "Nome" },
                values: new object[] { 4, "Magias de Druida" });

            migrationBuilder.InsertData(
                table: "ListasMagias",
                columns: new[] { "IdListaMagia", "Nome" },
                values: new object[] { 5, "Magias de Feiticeiro" });

            migrationBuilder.InsertData(
                table: "ListasMagias",
                columns: new[] { "IdListaMagia", "Nome" },
                values: new object[] { 6, "Magias de Paladino" });

            migrationBuilder.InsertData(
                table: "ListasMagias",
                columns: new[] { "IdListaMagia", "Nome" },
                values: new object[] { 7, "Magias de Patrulheiro" });

            migrationBuilder.InsertData(
                table: "ListasMagias",
                columns: new[] { "IdListaMagia", "Nome" },
                values: new object[] { 8, "Magias de Mago" });

            migrationBuilder.InsertData(
                table: "TiposArmaduras",
                columns: new[] { "IdTipoArmadura", "Tipo" },
                values: new object[] { 1, "Armadura Leve" });

            migrationBuilder.InsertData(
                table: "TiposArmaduras",
                columns: new[] { "IdTipoArmadura", "Tipo" },
                values: new object[] { 2, "Armadura Média" });

            migrationBuilder.InsertData(
                table: "TiposArmaduras",
                columns: new[] { "IdTipoArmadura", "Tipo" },
                values: new object[] { 3, "Armadura Pesada" });

            migrationBuilder.InsertData(
                table: "TiposArmaduras",
                columns: new[] { "IdTipoArmadura", "Tipo" },
                values: new object[] { 4, "Escudo" });

            migrationBuilder.InsertData(
                table: "TiposArmas",
                columns: new[] { "IdTipoArma", "Tipo" },
                values: new object[] { 1, "Arma Simples Corpo-a-Corpo" });

            migrationBuilder.InsertData(
                table: "TiposArmas",
                columns: new[] { "IdTipoArma", "Tipo" },
                values: new object[] { 2, "Arma Simples à Distância" });

            migrationBuilder.InsertData(
                table: "TiposArmas",
                columns: new[] { "IdTipoArma", "Tipo" },
                values: new object[] { 3, "Arma Marcial Corpo-a-Corpo" });

            migrationBuilder.InsertData(
                table: "TiposArmas",
                columns: new[] { "IdTipoArma", "Tipo" },
                values: new object[] { 4, "Arma Marcial à Distância" });

            migrationBuilder.InsertData(
                table: "TiposIdiomas",
                columns: new[] { "IdTipoIdioma", "Tipo" },
                values: new object[] { 1, "Padrão" });

            migrationBuilder.InsertData(
                table: "TiposIdiomas",
                columns: new[] { "IdTipoIdioma", "Tipo" },
                values: new object[] { 2, "Exótico" });

            migrationBuilder.InsertData(
                table: "TiposMagias",
                columns: new[] { "IdTipoMagia", "Tipo" },
                values: new object[] { 1, "Truque" });

            migrationBuilder.InsertData(
                table: "TiposMagias",
                columns: new[] { "IdTipoMagia", "Tipo" },
                values: new object[] { 2, "Ciclo" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 1, "Em batalha, você luta com uma ferocidade primitiva. No seu turno, você pode entrar em fúria com uma ação bônus. \nEnquanto estiver em fúria, você recebe os seguintes benefícios se você não estiver vestindo uma armadura pesada: *Você tem vantagem em testes de Força e testes de resistência de Força. *Quando você desferir um ataque com arma corpo-acorpo usando Força, você recebe um bônus nas jogadas de dano que aumenta à medida que você adquire níveis de bárbaro, como mostrado na coluna Dano de Fúria na tabela O Bárbaro. *Você possui resistência contra dano de concussão, cortante e perfurante. Se você for capaz de conjurar magias, você não poderá conjurá-las ou se concentrar nelas enquanto estiver em fúria. Sua fúria dura por 1 minuto. Ela termina prematuramente se você cair inconsciente ou se seu turno acabar e você não tiver atacado nenhuma criatura hostil desde seu último turno ou não tiver sofrido dano nesse período. Você também pode terminar sua fúria no seu turno com uma ação bônus. Quando você tiver usado a quantidade de fúrias mostrada para o seu nível de bárbaro na coluna Fúrias da tabela O Bárbaro, você precisará terminar um descanso longo antes de poder entrar em fúria novamente. ", "Fúria" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 2, "Quando você não estiver vestindo qualquer armadura, sua Classe de Armadura será 10 + seu modificador de Destreza + seu modificador de Constituição. Você pode usar um escudo e continuar a receber esse benefício. ", "Defesa sem Armadura" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 3, "A partir do 2° nível, você pode desistir de toda preocupação com sua defesa para atacar com um desespero feroz. Quando você fizer o seu primeiro ataque no turno, você pode decidir atacar descuidadamente. Fazer isso lhe concede vantagem nas jogadas de ataque com armas corpo-a-corpo usando Força durante seu turno, porém, as jogadas de ataques feitas contra você possuem vantagem até o início do seu próximo turno.", "Ataque Descuidado" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 4, "No 2° nível, você adquire um sentido sobrenatural de quando as coisas próximas não estão como deveriam, concedendo a você uma chance maior quando estiver evitando perigos. Você possui vantagem em testes de resistência de Destreza contra efeitos que você possa ver, como armadilhas e magias. Para receber esse benefício você não pode estar cego, surdo ou incapacitado. ", "Sentido de Perigo" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 5, "No 3° nível, você escolhe um caminho que molda a natureza da sua fúria. Escolha o Caminho do Furioso ou o Caminho do Guerreiro Totêmico, ambos detalhados no final da descrição de classe. Sua escolha lhe concederá características no 3° nível e novamente no 6°, 10° e 14° níveis. ", "Caminho Primitivo" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 6, "Quando você atinge o 4° nível e novamente no 8°, 12°, 16° e 19° nível, você pode aumentar um valor de habilidade, à sua escolha, em 2 ou você pode aumentar dois valores de habilidade, à sua escolha em 1. Como padrão, você não pode elevar um valor de habilidade acima de 20 com essa característica.", "Incremento no Valor de Habilidade" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 7, "A partir do 5° nível, você pode atacar duas vezes, ao invés de uma, sempre que você realizar a ação de Ataque no seu turno. ", "Ataque Extra" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 8, "Começando no 5° nível, seu deslocamento aumenta em 3 metros enquanto você não estiver vestindo uma armadura pesada.", "Movimento Rápido" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 9, "No 7° nível, seu instinto está tão apurado que você recebe vantagem nas jogadas de iniciativa. Além disso, se você estiver surpreso no começo de um combate e não estiver incapacitado, você pode agir normalmente no seu primeiro turno, mas apenas se você entrar em fúria antes de realizar qualquer outra coisa neste turno. ", "Instinto Selvagem" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 10, "A partir do 9° nível, você pode rolar um dado de dano de arma adicional quando estiver determinando o dano extra de um acerto crítico com uma arma corpo-a-corpo. Isso aumenta para dois dados adicionais no 13° nível e três dados adicionais no 17° nível.", "Crítico Brutal" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 11, "A partir do 11° nível, sua fúria pode manter você lutando independente da gravidade dos seus ferimentos. Se você cair para 0 pontos de vida enquanto estiver em fúria e não morrer, você pode realizar um teste de resistência de Constituição CD 10. Se você for bem sucedido, você volta para 1 ponto de vida ao invés disso. Cada vez que você utilizar essa característica após a primeira, a CD aumenta em 5. Assim que você terminar um descanso curto ou longo a CD volta para 10", "Fúria Implacável" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 12, "A partir do 15° nível, sua fúria é tão brutal que ela só termina prematuramente se você cair inconsciente ou se você decidir terminá-la. ", "Fúria Persistente" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 13, "A partir do 18° nível, se o total de um teste de Força seu for menor que o seu valor de Força, você pode usar esse valor no lugar do resultado. ", "Força Indomável" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 14, "No 20° nível, você incorpora os poderes da natureza. Seus valores de Força e Constituição aumentam em 4. Seu máximo para esses valores agora é 24.", "Campeão Primitivo" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 15, "Você aprendeu a desembaraçar e remodelar o decido da realidade em harmonia com os seus desejos e música. Suas magias são parte do seu vasto repertório, magia que você pode entoar em diferentes situações. Veja o capítulo 10 para as regras gerais de conjuração e o capítulo 11 para a lista de magias de bardo. TRUQUES Você conhece dois truques, à sua escolha da lista de magias de bardo. Você aprende truques de bardo adicionais, à sua escolha em níveis mais altos, como mostrado na coluna Truques Conhecidos da tabela O Bardo. A tabela O Bardo mostra quantos espaços de magia de 1° nível e superiores você possui disponíveis para conjuração. Para conjurar uma dessas magias, você deve gastar uma espaço de magia do nível da magia ou superior. Você recobra todos os espaços de magia gastos quando você completa um descanso longo. Por exemplo, se você quiser conjurar a magia de 1° nível curar ferimentos e você tiver um espaço de magia de 1° nível e um de 2° nível disponíveis, você poderá conjurar curar ferimentos usando qualquer dos dois espaços. MAGIAS CONHECIDAS DE 1° NÍVEL E SUPERIORES Você conhece quatro magias de 1° nível, à sua escolha, da lista de magias de bardo. A coluna Magias Conhecidas na tabela O Bardo mostra quando você aprende mais magias de bardo, à sua escolha. Cada uma dessas magias deve ser de um nível a que você tenha acesso, como mostrado na tabela. Por exemplo, quando você alcança o 3° nível da classe, você pode aprender uma nova magia de 1° ou 2° nível. Além disso, quando você adquire um nível nessa classe, você pode escolher uma magia de bardo que você conheça e substituí-la por outra magia da lista de magias de bardo, que também deve ser de um nível ao qual você tenha espaços de magia. HABILIDADE DE CONJURAÇÃO Sua habilidade de conjuração é Carisma para suas magias de bardo, portanto, você usa seu Carisma sempre que alguma magia se referir à sua habilidade de conjurar magias. Além disso, você usa o seu modificador de Carisma para definir a CD dos testes de resistência para as magias de bardo que você conjura e quando você realiza uma jogada de ataque com uma magia. CD para suas magias = 8 + bônus de proficiência + seu modificador de Carisma Modificador de ataque de magia = seu bônus de proficiência + seu modificador de Carisma CONJURAÇÃO DE RITUAL Você pode conjurar qualquer magia de bardo que você conheça como um ritual se ela possuir o descritor ritual. FOCO DE CONJURAÇÃO Você pode usar um instrumento musical (encontrado no capítulo 5) como foco de conjuração das suas magias de bardo. ", "Conjuração" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 16, "Você pode inspirar os outros através de palavras animadoras ou música. Para tanto, você usa uma ação bônus no seu turno para escolher uma outra criatura, que não seja você mesmo, a até 18 metros de você que possa ouvi-lo. Essa criatura ganha um dado de Inspiração de Bardo, um d6. Uma vez, nos próximos 10 minutos, a criatura poderá rolar o dado e adicionar o valor rolado a um teste de habilidade, jogada de ataque ou teste de resistência que ela fizer. A criatura pode esperar até rolar o d20 antes de decidir usar o dado de Inspiração de Bardo, mas deve decidir antes do Mestre dizer se a rolagem foi bem ou mal sucedida. Quando o dado de Inspiração de Bardo for rolado, ele é gasto. Uma criatura pode ter apenas um dado de Inspiração de Bardo por vez. Você pode usar essa característica um número de vezes igual ao seu modificador de Carisma (no mínimo uma vez). Você recupera todos os usos quando termina um descanso longo. Seu dado de Inspiração de Bardo muda quando você atinge certos níveis na classe. O dado se torna um d8 no 5° nível, um d10 no 10° nível e um d12 no 15° nível.", "Inspiração de Bardo (d6)" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 17, "A partir do 2° nível, você pode adicionar metade do seu bônus de proficiência, arredondado para baixo, em qualquer teste de habilidade que você fizer que ainda não possua seu bônus de proficiência. ", "Versatilidade" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 18, "A partir do 2° nível, você pode usar música ou oração calmantes para ajudar a revitalizar seus aliados feridos durante um descanso curto. Se você ou qualquer criatura amigável que puder ouvir sua atuação recuperar pontos de vida no fim do descanso curto ao gastar um ou mais Dados de Vida, cada uma dessas criaturas recupera 1d6 pontos de vida adicionais. Os pontos de vida adicionais aumentam quando você alcança determinados níveis na classe: para 1d8 no 9° nível, para 1d10 no 13° nível e para 1d12 no 17° nível. ", "Canção de Descanso" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 19, "No 3° nível, você investiga as técnicas avançadas de um colégio de bardo, à sua escolha: o Colégio do Conhecimento ou o Colégio da Bravura, ambos detalhados no final da descrição da classe. Sua escolha lhe concede características no 3° nível e novamente no 6° e 14° nível.", "Colégio de Bardo" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 20, "No 3° nível, escolha duas das perícias em que você é proficiente. Seu bônus de proficiência é dobrado em teste de habilidade que você fizer que utilize qualquer das perícias escolhidas. No 10° nível, você escolhe mais duas perícias em que é proficiente para ganhar esse benefício. ", "Aptidão" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 21, "Começando no momento em que você atinge o 5° nível, você recupera todas as utilizações gastas da sua Inspiração de Bardo quando você termina um descanso curto ou longo. ", "Fonte de Inspiração" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 22, "No 6° nível, você adquire a habilidade de usar notas musicais ou palavras de poder para interromper efeito de influência mental. Com uma ação, você pode começar uma atuação que dura até o fim do seu próximo turno. Durante esse tempo, você e qualquer criatura amigável a até 9 metros de você terá vantagem em testes de resistência para não ser amedrontado ou enfeitiçado. Uma criatura deve ser capaz de ouvir você para receber esse benefício. A atuação termina prematuramente se você for incapacitado ou silenciado ou se você terminá-la voluntariamente (não requer ação)", "Canção de Proteção" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 23, "No 10° nível, você usurpou conhecimento mágico de um vasto espectro de disciplinas. Escolha duas magias de qualquer classe, incluindo essa. A magia que você escolher deve ser de um nível que você possa conjurar, como mostrado na tabela O Bardo, ou um truque. As magias escolhidas contam como magias de bardo para você e já estão incluídas no número da coluna Magias Conhecidas da tabela O Bardo. Você aprende duas magias adicionais de qualquer classe no 14° nível e novamente no 18° nível.", "Segredos Mágicos" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 24, "No 20° nível, quando você rolar iniciativa e não tiver nenhum uso restante de Inspiração de Bardo, você recupera um uso.", "Inspiração Superior" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 25, "No 1° nível, você conclui uma barganha com um ser transcendental, à sua escolha: a Arquifada, o Corruptor ou o Grande Antigo, cada um deles é detalhado no final da descrição da classe. Sua escolha lhe confere traços no 1° nível e novamente no6°, 10° e 14° nível.", "Patrono Transcendental" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 26, "Sua pesquisa arcana e a magia outorgada a você por seu patrono, lhe concedem uma gama de magias. Veja o capítulo 10 para as regras gerais de conjuração e o capítulo 11 para a lista de magias de bruxo. TRUQUES Você conhece dois truques, à sua escolha, da lista de magias de bruxo. Você aprende truques de bruxo adicionais, à sua escolha, em níveis mais altos, como mostrado na coluna Truques Conhecidos da tabela O Bruxo. ESPAÇOS DE MAGIA A tabela O Bruxo mostra quantos espaços de magia você possui. A tabela também mostra qual o nível desses espaços; todos os seus espaços de magia são do mesmo nível. Para conjurar uma magia de bruxo de 1° nível ou superior, você deve gastar uma espaço de magia. Você recobra todos os espaços de magia gastos quando você completa um descanso curto ou longo. Por exemplo, quando você atingir o 5° nível, você terá dois espaços de magia de 3° nível. Para conjurar a magia de 1° nível onda trovejante, você deve gastar um desses espaços e você a conjura como uma magia de 3° nível. MAGIAS CONHECIDAS DE 1° NÍVEL E SUPERIORES No 1° nível, você conhece duas magias de 1° nível, à sua escolha da lista de magias de bruxo. A coluna Magias Conhecidas na tabela O Bruxo mostra quando você aprende mais magias de bruxo, à sua escolha, de 1° nível ou superior. Cada uma dessas magias deve ser de um nível a que você tenha acesso, como mostrado na tabela na coluna de Nível de Magia para o seu nível. Quando você alcança o 6° nível, por exemplo, você aprende uma nova magia de bruxo, que pode ser de 1°, 2° ou 3° nível. Além disso, quando você adquire um nível nessa classe, você pode escolher uma magia de bruxo que você conheça e substituí-la por outra magia da lista de magias de bruxo, que também deve ser de um nível ao qual você tenha espaços de magia. HABILIDADE DE CONJURAÇÃO Sua habilidade de conjuração é Carisma para suas magias de bruxo, portanto, você usa seu Carisma sempre que alguma magia se referir à sua habilidade de conjurar magias. Além disso, você usa o seu modificador de Carisma para definir a CD dos testes de resistência para as magias de bruxo que você conjura e quando você realiza uma jogada de ataque com uma magia. CD para suas magias = 8 + bônus de proficiência + seu modificador de Carisma Modificador de ataque de magia = seu bônus de proficiência + seu modificador de Carisma FOCO DE CONJURAÇÃO Você pode usar um foco arcano (encontrado no capítulo 5) como foco de conjuração das suas magias de bruxo. ", "Magia de Pacto" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 27, "Durante seus estudos sobre conhecimento oculto, você descobriu as invocações místicas, fragmentos de conhecimento proibido que infundiram você com habilidade mágica permanente. No 2° nível, você ganha duas invocações místicas, à sua escolha. Suas opções de invocação estão detalhadas no final da descrição dessa classe. Quando você atinge certos nível de bruxo, você adquire novas invocações à sua escolha, como mostrado na coluna Invocações Conhecidas na tabela O Bruxo. Além disso, quando você adquire um novo nível nessa classe, você pode escolher uma invocação que você conheça e substituí-la por outra invocação que você possa aprender nesse nível. ", "Invocações Místicas" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 28, "No 3° nível, seu patrono transcendental lhe confere um dom por seus leais serviços. Você adquire uma das características a seguir, à sua escolha.", "Dádiva de Pacto" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 29, "No 11° nível, seu patrono confere a você um segredo mágico conhecido como arcana. Escolha uma magia de 6° nível da lista de magias de bruxo como sua arcana. Você pode conjurar essa magia arcana uma vez sem gastar um espaço de magia. Você deve terminar um descanso longo antes de poder fazer isso novamente. Em nível altos, você adquire mais magias de bruxo de sua escolha que podem ser conjuradas dessa forma: uma magia de 7° nível no 13° nível, uma magia de 8° nível no 15° nível e uma magia de 9° nível no 17° nível. Você recupera todos os usos de sua Arcana Mística quando você termina um descanso longo.", "Arcana Mística" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse",
                columns: new[] { "IdTracodeClasse", "HabilidadeTracodeClasse", "Nome" },
                values: new object[] { 30, "No 20° nível, você pode recarregar sua reserva interior de poder místico quando suplicar ao seu patrono para recuperar espaços de magia gastos. Você pode gastar 1 minuto suplicando pela ajuda do seu patrono para recuperar todos os espaços de magia gastos da sua característica Magia de Pacto. Uma vez que você recuperou espaços de magia com essa característica, você deve terminar um descanso longo antes de fazê-lo novamente. ", "Mestre Místico" });

            migrationBuilder.InsertData(
                table: "TracosdeClasse_Arquetipos",
                columns: new[] { "IdArquetipo", "IdTracodeClasse", "ArquetipoIdArquetipo", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 1, 5, null, null });

            migrationBuilder.InsertData(
                table: "TracosdeClasse_Arquetipos",
                columns: new[] { "IdArquetipo", "IdTracodeClasse", "ArquetipoIdArquetipo", "TracodeClasseIdTracodeClasse" },
                values: new object[] { 2, 5, null, null });

            migrationBuilder.InsertData(
                table: "VeiculosAquaticos",
                columns: new[] { "IdVeiculoAquatico", "Nome", "Preco", "Velocidade" },
                values: new object[] { 1, "Barco de quilha", "3000 Peças de Ouro", "1.5 km/h" });

            migrationBuilder.InsertData(
                table: "VeiculosAquaticos",
                columns: new[] { "IdVeiculoAquatico", "Nome", "Preco", "Velocidade" },
                values: new object[] { 2, "Barco a remo", "50 Peças de Ouro", "2 km/h" });

            migrationBuilder.InsertData(
                table: "VeiculosAquaticos",
                columns: new[] { "IdVeiculoAquatico", "Nome", "Preco", "Velocidade" },
                values: new object[] { 3, "Dracar", "10000 Peças de Ouro", "5 km/h" });

            migrationBuilder.InsertData(
                table: "VeiculosAquaticos",
                columns: new[] { "IdVeiculoAquatico", "Nome", "Preco", "Velocidade" },
                values: new object[] { 4, "Galera", "30000 Peças de Ouro", "6.5 km/h" });

            migrationBuilder.InsertData(
                table: "VeiculosAquaticos",
                columns: new[] { "IdVeiculoAquatico", "Nome", "Preco", "Velocidade" },
                values: new object[] { 5, "Navio de guerra", "25000 Peças de Ouro", "4 km/h" });

            migrationBuilder.InsertData(
                table: "VeiculosAquaticos",
                columns: new[] { "IdVeiculoAquatico", "Nome", "Preco", "Velocidade" },
                values: new object[] { 6, "Veleiro", "10000 Peças de Ouro", "3 km/h" });

            migrationBuilder.InsertData(
                table: "VeiculosTerrestres",
                columns: new[] { "IdVeiculoTerrestre", "CapacidadedeCarga", "Deslocamento", "Nome", "Preco" },
                values: new object[] { 1, "210 Kg", "12 metros", "Burro/mula", "8 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "VeiculosTerrestres",
                columns: new[] { "IdVeiculoTerrestre", "CapacidadedeCarga", "Deslocamento", "Nome", "Preco" },
                values: new object[] { 2, "240 Kg", "15 metros", "Camelo", "50 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "VeiculosTerrestres",
                columns: new[] { "IdVeiculoTerrestre", "CapacidadedeCarga", "Deslocamento", "Nome", "Preco" },
                values: new object[] { 3, "270 Kg", "18 metros", "Cavalo de guerra", "400 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "VeiculosTerrestres",
                columns: new[] { "IdVeiculoTerrestre", "CapacidadedeCarga", "Deslocamento", "Nome", "Preco" },
                values: new object[] { 4, "220 Kg", "18 metros", "Cavalo de montaria", "75 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "VeiculosTerrestres",
                columns: new[] { "IdVeiculoTerrestre", "CapacidadedeCarga", "Deslocamento", "Nome", "Preco" },
                values: new object[] { 5, "270 Kg", "12 metros", "Cavalo Pesado", "50 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "VeiculosTerrestres",
                columns: new[] { "IdVeiculoTerrestre", "CapacidadedeCarga", "Deslocamento", "Nome", "Preco" },
                values: new object[] { 6, "660 Kg", "12 metros", "Elefante", "200 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "VeiculosTerrestres",
                columns: new[] { "IdVeiculoTerrestre", "CapacidadedeCarga", "Deslocamento", "Nome", "Preco" },
                values: new object[] { 7, "100 Kg", "12 metros", "Mastim", "25 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "VeiculosTerrestres",
                columns: new[] { "IdVeiculoTerrestre", "CapacidadedeCarga", "Deslocamento", "Nome", "Preco" },
                values: new object[] { 8, "115 Kg", "12 metros", "Pônei", "30 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 1, 11, null, true, 1, null, "Acolchoada", "4 Kg", "5 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 2, 11, null, false, 1, null, "Couro", "5 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 3, 12, null, false, 1, null, "Couro Batido", "6.5 Kg", "45 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 4, 12, null, false, 2, 2, "Gibão de Peles", "6 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 5, 13, null, false, 2, 2, "Camisão de Malha", "10 Kg", "30 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 6, 14, null, true, 2, 2, "Brunea", "22.5 Kg", "50 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 7, 14, null, true, 2, 2, "Peitoral", "10 Kg", "400 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 8, 15, null, true, 2, 2, "Meia-Armadura", "20 Kg", "750 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 9, 14, null, true, 3, 0, "Cota de Anéis", "20 Kg", "30 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 10, 16, 13, true, 3, 0, "Cota de Malha", "27.5 Kg", "75 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 11, 17, 15, true, 3, 0, "Cota de Talas", "30 Kg", "200 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 12, 18, 15, true, 3, 0, "Placas", "32.5 Kg", "1500 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armaduras",
                columns: new[] { "IdArmadura", "ClassedeArmadura", "Forca", "Furtividade", "IdTipoArmadura", "ModificadorDestrezaMaximo", "Nome", "Peso", "Preco" },
                values: new object[] { 13, 2, null, true, 4, 0, "Escudo", "3 Kg", "10 Peças de Ouro" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 1, "1d4 perfurante", 1, "Adaga", "0.5 Kg", "2 Peças de Ouro", "Acuidade, leve, arremesso (distância 6/18)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 2, "1d6 perfurante", 1, "Azagaia", "1 Kg", "5 Peças de Prata", "Arremesso (distância 9/36)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 3, "1d6 concussão", 1, "Bordão", "2 Kg", "2 Peças de Prata", "Versátil (1d8)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 4, "1d8 concussão", 1, "Clava Grande", "5 Kg", "2 Peças de Prata", "Pesada, duas mãos" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 5, "1d4 cortante", 1, "Foice Curta", "1 Kg", "1 Peça de Ouro", "Leve" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 6, "1d6 perfurante", 1, "Lança", "1.5 Kg", "1 Peça de Ouro", "Arremesso (distância 6/18), versãtil (1d8)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 7, "1d6 concussão", 1, "Maça", "2 Kg", "5 Peças de Ouro", "" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 8, "1d6 cortante", 1, "Machadinha", "1 Kg", "5 Peças de Ouro", "Leve, arremesso (distância 6/18)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 9, "1d4 concussão", 1, "Martelo Leve", "1 Kg", "2 Peças de Ouro", "Leve, arremesso (distância 6/18)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 10, "1d4 concussão", 1, "Porrete", "1 Kg", "1 Peça de Prata", "Leve" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 11, "1d6 perfurante", 2, "Arco Curto", "1 Kg", "25 Peças de Ouro", "Munição (distância 24/96), duas mãos" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 12, "1d8 perfurante", 2, "Beste Leve", "2.5 Kg", "25 Peças de Ouro", "Munição (distância 24/96), regarga, duas mãos" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 13, "1d4 perfurante", 2, "Dardo", "0.1 Kg", "5 Peças de Cobre", "Acuidade, arremesso (distância 6/18)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 14, "1d4 concussão", 2, "Funda", "-", "1 Peça de Prata", "Munição (distância 9/36)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 15, "1d10 cortante", 3, "Alabarda", "3 Kg", "20 Peças de Ouro", "Pesada, alcance, duas mãos" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 16, "1d6 cortante", 3, "Cimitarra", "1.5 Kg", "25 Peças de Ouro", "Acuidade, leve" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 17, "1d4 cortante", 3, "Chicote", "1.5 Kg", "2 Peças de Ouro", "Acuidade, alcance" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 18, "1d6 perfurante", 3, "Espada Curta", "1 Kg", "10 Peças de Ouro", "Acuidade, leve" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 19, "2d6 cortante", 3, "Espada Grande", "3 Kg", "50 Peças de Ouro", "Pesada, duas mãos" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 20, "1d8 cortante", 3, "Espada Longa", "1.5 Kg", "15 Peças de Ouro", "Versátil (1d10)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 21, "1d10 cortante", 3, "Glaive", "3 Kg", "20 Peças de Ouro", "Pesada, alcance, duas mãos" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 22, "1d12 perfurante", 3, "Lança de Montaria", "3 Kg", "3 Kg", "Alcance, especial" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 23, "1d8 perfurante", 3, "Maça Estrela", "2 Kg", "15 Peças de Ouro", "" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 24, "1d12 cortante", 3, "Machado Grande", "3.5 Kg", "30 Peças de Ouro", "Pesada, duas mãos" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 25, "1d8 cortante", 3, "Macado de Batalha", "2 Kg", "10 Peças de Ouro", "Versátil (1d10)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 26, "2d6 concussão", 3, "Malho", "5 Kg", "10 Peças de Ouro", "Pesada, duas mãos" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 27, "1d8 concussão", 3, "Mangual", "1 Kg", "10 Peças de Ouro", "" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 28, "1d8 concussão", 3, "Martelo de Guerra", "1 Kg", "15 Peças de Ouro", "Versátil (1d10)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 29, "1d8 perfurante", 3, "Picareta de Guerra", "1 Kg", "5 Peças de Ouro", "" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 30, "1d8 perfurante", 3, "Rapieira", "1 Kg", "25 Peças de Ouro", "Acuidade" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 31, "1d6 perfurante", 3, "Tridente", "2 Kg", "5 Peças de Ouro", "Arremesso (6/18), versátil(1d8)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 32, "1d8 perfurante", 4, "Arco Longo", "1 Kg", "50 Peças de Ouro", "Munição (distância 45/180), pesada, duas mãos" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 33, "1d6 perfurante", 4, "Besta de Mão", "1.5 Kg", "75 Peças de Ouro", "Munição (distância 9/36), leve, recarga" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 34, "1d10 perfurante", 4, "Besta Pesada", "4.5 Kg", "50 Peças de Ouro", "Munição (distância 30/120), pesada, recarga, duas mãos" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 35, "", 4, "Rede", "1.5 Kg", "1 Peça de Ouro", "Especial, arremesso (distância 1.4/4.5)" });

            migrationBuilder.InsertData(
                table: "Armas",
                columns: new[] { "IdArma", "DadoDano", "IdTipoArma", "Nome", "Peso", "Preco", "Propriedade" },
                values: new object[] { 36, "1 perfurante", 4, "Zarabatana", "0.5 Kg", "10 Peças de Ouro", "Munição (distância 7.5/30), recarga" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 2, true, false, 8, true, "(a) uma rapieira, (b) uma espada longa ou (c) qualquer arma simples  (a) um pacote de diplomata ou (b) um pacote de artista  (a) um lute ou (b) qualquer outro instrumento musical  Armadura de couro e uma adaga", false, 1, false, "Bardo", "Armaduras: Armaduras leves Armas: Armas simples, bestas de mão, espadas longas, rapieiras, espadas curtas Ferramentas: Três instrumentos musicais, à sua escolha Testes de Resistência: Destreza, Carisma Perícias: Escolha três quaisquer ", false });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 3, true, false, 8, false, "(a) uma besta leve e 20 virotes ou (b) qualquer arma simples  (a) uma bolsa de componentes ou (b) um foco arcano  (a) um pacote de estudioso ou (b) um pacote de explorador  Armadura de couro, qualquer arma simples e duas adagas", false, 2, false, "Bruxo", "Armaduras: Armaduras leves Armas: Armas simples Ferramentas: Nenhuma Testes de Resistência: Sabedoria, Carisma Perícias: Escolha duas dentre Arcanismo, Enganação, História, Intimidação, Investigação, Natureza e Religião ", true });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 4, true, false, 8, false, "(a) uma maça ou (b) um martelo de guerra (se for proficiente)  (a) brunea, (b) armadura de couro ou (c) cota de malha (se for proficiente)  (a) um besta leve e 20 virotes ou (b) qualquer arma simples  (a) um pacote de sacerdote ou (b) um pacote de aventureiro  Um escudo e um símbolo sagrado", false, 3, false, "Clérigo", "Armaduras: Armaduras leves, armaduras médias, escudos Armas: Todas as armas simples Testes de Resistência: Sabedoria, Carisma Perícias: Escolha duas dentre História, Intuição, Medicina, Persuasão e Religião", true });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 5, false, false, 8, false, "(a) um escudo de madeira ou (b) qualquer arma simples (a) uma cimitarra ou (b) qualquer arma corpo-a-corpo simples (a) um pacote de estudioso ou (b) um pacote de explorador  Armadura de couro, um pacote de aventureiro e um foco druídico", false, 4, true, "Druida", "(a) uma besta leve e 20 virotes ou (b) qualquer arma simples  (a) uma bolsa de componentes ou (b) um foco arcano  (a) um pacote de explorador ou (b) um pacote de aventureiro", true });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 6, true, true, 6, false, "(a) uma besta leve e 20 virotes ou (b) qualquer arma simples  (a) uma bolsa de componentes ou (b) um foco arcano  (a) um pacote de explorador ou (b) um pacote de aventureiro", false, 5, false, "Feiticeiro", "Armaduras: Nenhuma Armas: Adagas, dardos, fundas, bordões e bestas leves Ferramentas: Nenhuma Testes de Resistência: Constituição, Carisma Perícias: Escolha duas dentre Arcanismo, Enganação, Intuição, Intimidação, Persuasão e Religião", false });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 9, false, false, 6, false, "(a) uma arma marcial e um escudo ou (b) duas armas marciais  (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo  (a) um pacote de sacerdote ou (b) um pacote de aventureiro  Cota de malha e um símbolo sagrado", false, 8, true, "Mago", "Armaduras: Nenhuma Armas: Adagas, dardos, fundas, bordões, bestas leves Ferramentas: Nenhuma Testes de Resistência: Inteligência, Sabedoria Perícias: Escolha duas dentre Arcanismo, História, Intuição, Investigação, Medicina e Religião", true });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 11, true, false, 10, false, "(a) uma arma marcial e um escudo ou (b) duas armas marciais  (a) cinco azagaias ou (b) qualquer arma simples corpoa-corpo  (a) um pacote de sacerdote ou (b) um pacote de aventureiro  Cota de malha e um símbolo sagrado", false, 6, false, "Paladino", "Armaduras: Todas as armaduras, escudos Armas: Armas simples, armas marciais Ferramentas: Nenhum Testes de Resistência: Sabedoria, Carisma Perícias: Escolha duas dentre Atletismo, Intuição, Intimidação, Medicina, Persuasão e Religião", true });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "IdClasse", "Carisma", "Constituicao", "DadoVida", "Destreza", "Equipamento", "Forca", "IdListaMagia", "Inteligencia", "Nome", "Proficiencia", "Sabedoria" },
                values: new object[] { 12, false, false, 10, true, "(a) brunea ou (b) armadura de couro  (a) duas espadas curtas ou (b) duas armas simples corpo-a-corpo  (a) um pacote de explorador ou (b) um pacote de aventureiro  Um arco longo e uma aljava com 20 flechas", true, 7, false, "Patrulheiro", "Armaduras: Armaduras leves, armaduras médias, escudos Armas: Armas simples, armas marciais Ferramentas: Nenhuma 117 Testes de Resistência: Força, Destreza Perícias: Escolha três dentre Adestrar Animais, Atletismo, Furtividade, Intuição, Investigação, Natureza, Percepção e Sobrevivência", false });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 1, "Anão", "Anões", 1, "Anão" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 2, "Comum", "Humanos", 1, "Comum" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 3, "Élfico", "Elfos", 1, "Élfico" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 4, "Anão", "Ogros, gigantes", 1, "Gigante" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 5, "Anão", "Gnomos", 1, "Gnômico" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 6, "Anão", "Goblinoides", 1, "Goblin" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 7, "Comum", "Halfings", 1, "Halfling" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 8, "Anão", "Orcs", 1, "Orc" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 9, "Infernal", "Demônios", 2, "Abissal" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 10, "Celestial", "Celestiais", 2, "Celestial" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 11, "-", "Devoradores de mente, Observadores", 2, "Dialeto Subterrâneo" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 12, "Dracônico", "Dragões, Draconatos", 2, "Dracônico" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 13, "Infernal", "Diabos", 2, "Infernal" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 14, "Anão", "Elementais", 2, "Primordial" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 15, "Élfico", "Criaturas feéricas", 2, "Silvestre" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "IdIdioma", "Alfabeto", "FaladoPor", "IdTipoIdioma", "Nome" },
                values: new object[] { 16, "Élfico", "Comerciantes do Subterrâneo", 2, "Subcomum" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 1, "18 metros", "Verbal, Somático", "Você tenta suprimir emoções fortes em um grupo de pessoas.Cada humanoide em uma esfera de 6 metros de raio, centrada em um ponto que você escolher dentro do alcance, deve realizar um teste de resistência de Carisma; uma criatura pode escolher falhar nesse teste, se desejar. Se uma criatura falhar na resistência, escolha um dentre os dois efeitos a seguir. Você pode suprimir qualquer efeito que esteja deixando a criatura enfeitiçada ou amedrontada.Quando essa magia terminar, qualquer efeito suprimido volta a funcionar, considerando que sua duração não tenha acabado nesse meio tempo. Alternativamente, você pode tornar um alvo indiferente às criaturas que você escolher que forem hostis a ele. Essa indiferença acaba se o alvo for atacado ou ferido por uma magia ou se ele testemunhar qualquer dos seus amigos sendo ferido.Quando a magia terminar, a criatura se tornará hostil novamente, a não ser que o Mestre diga o contrário. ", "Concentração, até 1 minuto", "Encantamento", 2, "Acalmar Emoções", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 2, "Pessoal", "Verbal, Somático, Material  (incenso e uma oferenda apropriada para sacrifício à sua religião, juntos valendo, no mínimo, 25 po, consumidos pela magia)", "Sua magia e uma oferenda colocam você em contato com um deus ou servo divino. Você faz uma única pergunta a respeito de um objetivo, evento ou atividade específico que irá ocorrer dentro de 7 dias. O Mestre oferece uma resposta confiável. A resposta deve ser uma frase curta, uma rima enigmática ou um presságio. A magia não leva em consideração qualquer possível circunstância que possa mudar o que está por vir, como a conjuração de magias adicionais ou a perda ou ganho de um companheiro. Se você conjurar a magia duas ou mais vezes antes de completar seu próximo descanso longo, existe uma chance cumulativa de 25 por cento de cada conjuração, depois da primeira que você fez, ter um resultado aleatório. O Mestre faz essa jogada secretamente. ", "Instantânea", "Adivinhação (ritual)", 2, "Adivinhação", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 3, "9 metros", "Verbal, Somático, Material  (uma pequena fita de tecido branco)", "Sua magia inspira seus aliados com vigor e determinação. Escolha até três criaturas dentro do alcance. O máximo de pontos de vida e os pontos de vida atuais de cada alvo aumentam em 5, pela duração. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 3° nível ou superior, os pontos de vida dos alvos aumentam em 5 pontos adicionais para cada nível do espaço acima do o 2°. ", "8 horas", "Abjuração", 2, "Ajuda", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 4, "9 metros", "Verbal, Somático, Material (um pequeno sino e um pequeno fio de prata) ", "Você coloca um alarme para intrusos desavisados. Escolha uma porta, uma janela ou uma área dentro do alcance que não seja maior que 6 metros cúbicos. Até a magia acabar, um alarme alerta você sempre que uma criatura Miúda ou maior tocarem ou entrarem na área protegida. Quando você conjura a magia, você pode designar as criaturas que não ativarão o alarme. Você também escolhe se o alarme será mental ou audível. Um alarme mental alerta você com um silvo na sua mente, se você estiver a até de 1,5 quilômetro da área protegida. Esse silvo acordará você se você estiver dormindo. Um alarme audível produz o som de um sino de mão por 10 minutos num raio de 18 metros.", "8 horas", "Abjuração (ritual)", 2, "Alarme", "1 minuto" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 5, "18 metros", "Verbal, Somático", "Você suplica a uma entidade transcendental por ajuda. O ser deve ser conhecido por você: seu deus, um primordial, um príncipe demônio ou algum outro ser de poder cósmico. Essa entidade envia um celestial, um corruptor ou um elemental leal a ela para ajudar você, fazendo a criatura aparecer em um espaço desocupado dentro do alcance. Se você conhecer o nome de uma criatura especifica, você pode falar o nome quando conjurar essa magia para requisitar essa criatura, do contrário, você pode receber uma criatura diferente de qualquer forma (à escolha do Mestre). Quando a criatura aparecer, ela não está sob nenhuma compulsão para se comportar de um modo em particular. Você pode pedir a criatura que realize um serviço em troca de um pagamento, mas ela não é obrigada a fazê-lo. A tarefa solicitada pode variar de simples (carregue-nos voando para o outro lado do abismo ou nos ajude a lutar essa batalha) a complexa (espione nossos inimigos ou nos proteja durante nossa incursão na masmorra). Você deve ser capaz de se comunicar com a criatura para barganhar os serviços dela. O pagamento pode ser feito de várias formas. Um celestial pode requerer uma generosa doação de ouro ou itens mágicos para um templo aliado, enquanto que um corruptor pode exigir um sacrifício vivo ou uma parte dos espólios. Algumas criaturas podem trocar seus serviços por uma missão feita por você. Como regra geral, uma tarefa que possa ser medida em minutos, exigirá um pagamento de 100 po por minuto. Uma tarefa medida em horas exigirá 1.000 po por hora. E uma tarefa medida em dias (até 10 dias) exigirá 10.000 po por dia. O Mestre pode ajustar esses pagamentos baseado nas circunstâncias pelas quais a magia foi conjurada. Se a tarefa estiver de acordo com o caráter da criatura, o pagamento pode ser reduzido à metade, ou mesmo dispensado. Tarefas que não proporcionem perigo, tipicamente requerem apenas metade do pagamento sugerido, enquanto que tarefas especialmente perigosas podem exigir um grande presente. As criaturas raramente aceitarão tarefas que pareçam suicidas. Após a criatura completar a tarefa ou quando a duração acordada para o serviço expirar, a criatura retornará para seu plano natal depois de relatar sua partida a você, se apropriado para a tarefa e se possível. Se você não for capaz de acertar um preço para os serviços da criatura, ela imediatamente voltará para o seu plano natal. Uma criatura convidada para se juntar ao seu grupo, conta como um membro dele, recebendo sua parte total na premiação de pontos de experiência. ", "Instantânea", "Conjuração", 2, "Aliado Planar", "10 minutos" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 6, "Toque", "V, S, M (uma aljava contendo, pelo menos, uma munição)", "Você transmuta sua aljava para que ela produza um suprimento interminável de munições não-mágicas, que parecem saltar na sua mão quando você tenta pega-las. Em cada um dos seus turnos, até a magia acabar, você pode usar uma ação bônus para realizar dois ataques com uma arma que use munição de uma aljava. Cada vez que você fizer tais ataques à distância, sua aljava, magicamente, repõe a munição que você usou com uma munição não-mágica similar. Qualquer munição criada por essa magia se desintegra quando a magia acaba. Se a aljava não estiver mais com você, a magia acaba.", "Concentração, até 1 minuto", "Transmutação", 2, "Aljava Veloz", "1 ação bônus" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 7, "Pessoal", "V, S, M (uma argola de jade valendo, no mínimo, 1.500 po, que você deve colocar na sua cabeça antes de conjurar a magia) ", "Você assume a forma de uma criatura diferente, pela duração. A nova forma pode ser qualquer criatura com um nível de desafio igual ao seu nível ou menor. A criatura não pode ser nem um constructo nem um mortovivo e você deve ter visto esse tipo de criatura pelo menos uma vez. Você se transforma num exemplar médio da criatura, um sem quaisquer níveis de classe nem característica Conjuração. Suas estatísticas de jogo são substituídas pelas estatísticas da forma escolhida, no entanto, você mantém sua tendência e valores de Inteligência, Sabedoria e Carisma. Você também mantem suas proficiências em testes de resistência, além de ganhar as da nova criatura. Se a criatura tiver a mesma proficiência que você e o bônus listado nas estatísticas dela for maior que o seu, use os bônus da criatura no lugar do seu. Você não pode usar qualquer ação lendária ou de covil da nova forma. Você assume os pontos de vida e Dados de Vida da sua nova forma. Quando você reverter a sua forma normal, você retorna à quantidade de pontos de vida que tinha antes da transformação. Se você reverter como resultado de ter caído a 0 pontos de vida, qualquer dano excedente é recebido pela sua forma normal. Contanto que o dano excedente não reduza os pontos de vida da sua forma normal a 0, você não cairá inconsciente. Você mantem os benefícios de qualquer característica da sua classe, raça ou outra fonte e pode usa-las, considerando que sua nova forma é fisicamente capaz de fazê-lo. Você não pode usar quaisquer sentidos especiais que você possua (por exemplo, visão no escuro) a não ser que a nova forma também possua o sentido. Você só poderá falar se a nova forma, normalmente, puder falar. Quando você se transforma, você pode escolher se o seu equipamento cai no chão, é assimilado a sua nova forma ou é usado por ela. Equipamentos vestidos e carregados funcionam normalmente. O Mestre decide qual equipamento é viável para a nova forma vestir ou  sar, baseado na forma e tamanho da criatura. O seu equipamento não muda de forma ou tamanho para se adaptar à nova forma e, qualquer equipamento que a nova forma não possa vestir deve, ou cair no chão ou ser assimilado por ela. Equipamentos assimilados não terão efeito nesse estado. Pela duração da magia, você pode usar sua ação para assumir uma forma diferente, seguindo as mesmas restrições e regras da forma anterior, com uma exceção: se sua nova forma tiver mais pontos de vida que sua forma atual, seus pontos de vida mantem o valor atual. ", "Concentração, até 1 hora", "Transmutação", 2, "Alterar Forma", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 8, "Pessoal", "V, S", "Você assume uma forma diferente. Quando conjurar essa magia, escolha uma das seguintes opções, o efeito durará pela duração da magia. Enquanto a magia durar, você pode terminar uma opção com uma ação para ganhar os benefícios de uma diferente. Adaptação Aquática. Você adapta seu corpo para um ambiente aquático, brotando guelras e crescendo membranas entre seus dedos. Você pode respirar embaixo d’água e ganha deslocamento de natação igual a seu deslocamento terrestre. Mudar Aparência. Você transforam sua aparência. Você decide com o que você parece, incluindo altura, peso, traços faciais, timbre da sua voz, comprimento do cabelo, coloração e características distintas, se tiverem. Você pode ficar parecido com um membro de outra raça, apesar de nenhuma de suas estatísticas mudar. Você também não pode parecer com uma criatura de um tamanho diferente do seu, e seu formado básico permanece o mesmo; se você for bípede, você não pode usar essa magia para se tornar quadrupede, por exemplo. A qualquer momento, pela duração da magia, você pode usar sua ação para mudar sua aparência dessa forma, novamente. Armas Naturais. Você faz crescerem garras, presas, espinhos, chifres ou armas naturais diferentes, à sua escolha. Seus ataques desarmados causam 1d6 de dano de concussão, perfurante ou cortante, como apropriado para a arma natural que você escolheu, e você é proficiente com seus ataques desarmados. Finalmente, a arma natural é mágica e você tem +1 de bônus nas jogadas de ataque e dano que você fizer com ela. ", "Concentração, até 1 hora", "Transmutação", 2, "Alterar-se", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 9, "Pessoal", "S, M (uma pequena quantidade de maquiagem aplicada ao rosto durante a conjuração da magia) ", "Pela duração, você terá vantagem em todos os testes de Carisma direcionados a uma criatura, à sua escolha, que não seja hostil a você. Quando a magia acabar, a criatura perceberá que você usou maia para influenciar o humor dela, e ficará hostil a você. Uma criatura propensa a violência irá atacar você. Outra criatura pode buscar outras formas de retaliação (a critério do Mestre), dependendo da natureza da sua interação com ela.", "Concentração, até 1 minuto", "Encantamento", 1, "Amizade", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 10, "9 metros", "V, S, M (um punhado de comida)", "Essa magia deixa você convencer uma besta que você não quer prejudicar. Escolha uma besta que você possa ver dentro do alcance. Ela deve ver e ouvir você. Se a Inteligência da besta for 4 ou maior, a magia falha. Do contrário, a besta deve ser bem sucedida num teste de resistência de Sabedoria ou ficará enfeitiçada por você pela duração da magia. Se você ou um dos seus companheiros ferir o alvo, a magia termina. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 2° nível ou superior, você pode afetar uma besta adicional para cada nível do espaço acima do 1°. ", "24 horas", "Encantamento", 2, "Amizade Animal", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 11, "45 metros", "V, S", "Essa magia canaliza vitalidade nas plantas dentro de uma área especifica. Existem dois usos possíveis para essa magia, concedendo ou benefícios imediatos ou a longo prazo. Se você conjurar essa magia usando 1 ação, escolha um ponto dentro do alcance. Todas as plantas normais num raio de 30 metros centrado no ponto, tornam-se espessas e carregadas. Uma criatura se movendo na área deve gastar 6 metros de movimento para cada 1,5 metro que se mover. Você pode excluir uma ou mais áreas de qualquer tamanho, dentro da área da magia, para não ser afetada. Se você conjurar essa magia ao longo de 8 horas, você fertiliza a terra. Todas as plantas num raio de 800 metros, centrado no ponto dentro do alcance, ficam enriquecidas por 1 ano. As plantas fornecerão o dobro da quantidade normal de comida quando colhidas. ", "Instantânea", "Transmutação", 2, "Ampliar Plantas", "1 ação ou 8 horas" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 12, "18 metros", "V, S, M (uma joia valendo, no mínimo, 1.000 po, consumida pela magia)", "Com essa magia, você tenta obrigar um celestial, corruptor, elemental ou fada a servi-lo. A criatura deve estar dentro do alcance durante toda a conjuração da magia. (Tipicamente, a criatura, primeiramente, é invocada dentro de um círculo mágico invertido para mantê-la presa enquanto a magia é conjurada.) Ao completar a conjuração, o alvo deve realizar um teste de resistência de Carisma. Se falhar na resistência, ela é obrigada a servir você pela duração. Se a criatura foi invocada ou criada por outra magia, a duração da magia é estendida para se equiparar a dessa magia. Uma criatura obrigada deve seguir suas instruções da melhor forma que puder. Você poderia comandar a criatura a acompanhar você em uma aventura, a guardar um local ou a enviar uma mensagem. A criatura obedece ao pé da letra suas instruções, mas se a criatura for hostil a você, ela se esforçará para distorcer suas palavras para atingir seus próprios objetivos. Se a criatura atender suas instruções completamente antes da magia acabar, ela viajará até você para relatar esse fato se você estiver no mesmo plano de existência. Se você estiver em um plano de existência diferente, ela retornará para o lugar onde você a contatou e permanecerá lá até a magia acabar. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de nível superior, a duração aumenta para 10 dias com um espaço de 6° nível, para 30 dias com um espaço de 7° nível, para 180 dias com um espaço de 8° nível e para um ano com um espaço de magia de 9° nível. ", "24 horas", "Abjuração", 2, "Âncora Planar", "1 hora" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 13, "9 metros", "V, S, M (uma rolha)", "Essa magia concede a habilidade de se mover através de qualquer superfície líquida – como água, ácido, lama, neve, arreia movediça ou lava – como se ela fosse chão sólido inofensivo (as criaturas atravessando lava derretida ainda podem sofrer dano do calor). Até dez criaturas voluntárias que você possa ver, dentro do alcance, ganham essa habilidade pela duração. Se você afetar uma criatura submersa em um líquido, a magia ergue o alvo para a superfície do líquido a uma taxa de 18 metros por rodada. ", "1 hora", "Transmutação", 2, "Andar na Água", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 14, "3 metros", " V, S, M (uma gota de sangue, um pedaço de carne e um punhado de pó de osso)", "Essa magia cria um servo morto-vivo. Escolha uma pilha de ossos ou um corpo de um humanoide Médio ou Pequeno dentro do alcance. Sua magia imbui o alvo com uma imitação corrompida de vida, erguendo-o como uma criatura morta-viva. O alvo se torna um esqueleto, se você escolheu ossos, ou um zumbi, se você escolheu um corpo (o Mestre tem as estatísticas de jogo da criatura). Em cada um dos seus turnos, você pode usar uma ação bônus para comandar mentalmente qualquer criatura que você criou com essa magia, se a criatura estiver a até 18 metros de você (se você controla diversas criaturas, você pode comandar qualquer uma ou todas elas ao mesmo tempo, emitindo o mesmo comando para cada uma). Você decide qual ação a criatura irá fazer e para onde ela irá se mover durante o próximo turno dela, ou você pode emitir um comando geral, como para guardar uma câmara ou corredor especifico. Se você não der nenhum comando, as criaturas apenas se defenderão contra criaturas hostis. Uma vez que receba uma ordem, a criatura continuará a segui-la até a tarefa estar concluída. A criatura fica sob seu controle por 24 horas, depois disso ela para de obedecer aos seus comandos. Para 218 manter o controle da criatura por mais 24 horas, você deve conjurar essa magia na criatura novamente, antes das 24 horas atuais terminarem. Esse uso da magia recupera seu controle sobre até quatro criaturas que você tenha animado com essa magia, ao invés de animar uma nova. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 4° nível ou superior, você pode animar ou recuperar o controle de duas criaturas mortas-vivas para cada nível do espaço acima do 3°. Cada uma dessas criaturas deve vir de um corpo ou pilha de ossos diferente. ", "Instantânea", "Necromancia", 2, "Animar Mortos", "1 minuto" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 15, "36 metros", "V, S", "Objetos ganham vida ao seu comando. Escolha até dez objetos não-mágicos dentro do alcance, que não estejam sendo vestidos ou carregados. Alvos Médios contam como dois objetos, alvos Grandes contam como quatro objetos e alvos Enormes contam como oito objetos. Você não pode animar um objeto maior que Enorme. Cada alvo se anima e torna-se uma criatura sob seu controle até o final da magia ou até ser reduzido a 0 pontos de vida. Com uma ação bônus, você pode comandar mentalmente qualquer criatura que você criar com essa magia se a criatura estiver a até 150 metros de você (se você controla várias criaturas, você pode comandar qualquer ou todas elas ao mesmo tempo, emitindo o mesmo comando para cada uma). Você decide qual ação a criatura irá fazer e para onde ela irá se mover durante o próximo turno dela, ou você pode emitir um comando geral, como para guardar uma câmara ou corredor especifico. Se você não der nenhum comando, as criaturas apenas se defenderão contra criaturas hostis. Uma vez que receba uma ordem, a criatura continuará a segui-la até a tarefa estar concluída. Um objeto animado é um constructo com CA, pontos de vida, ataques, Força e Destreza determinados pelo seu tamanho. Sua Constituição é 10 e sua Inteligência e Sabedoria são 3 e seu Carisma é 1. Seu deslocamento é 9 metros; se o objeto não tiver pernas ou outros apêndices que ele possa usar para locomoção, ao invés, ele terá deslocamento de voo 9 metros e poderá planar. Se o objeto estiver firmemente preso a uma superfície ou objeto maior, como uma corrente presa a uma parede, seu deslocamento será 0. Ele tem percepção às cegas num raio de 9 metros e é cego além dessa distância. Quando o objeto animado cair a 0 pontos de vida, ele reverte a sua forma normal de objeto e qualquer dano restante é transferido para sua forma de objeto original. Se você ordenar a um objeto que ataque, ele pode realizar um único ataque corpo-a-corpo contra uma criatura a até 1,5 metro dele. Ele realiza um ataque de pancada com um bônus de ataque e dano de concussão determinado pelo seu tamanho. O Mestre pode definir que um objeto especifico inflige dano cortante ou perfurante, baseado na forma dele. Em Níveis Superiores. Se você conjurar essa magia usando um espaço de magia de 6° nível ou superior, você pode animar dois objetos adicionais para cada nível do espaço acima do 5°. ", "Concentração, até 1 minuto", "Transmutação", 2, "Animar Objetos", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 16, "18 metros", "Componentes: V, S, M (ou um pedaço de alume embebido em vinagre para o efeito de antipatia, ou uma gota de mel para o efeito de simpatia) ", "Essa magia atrai ou repele as criaturas de sua escolha. Você escolhe um alvo dentro do alcance, tanto um objeto ou criatura Enorme ou menor ou uma área que não seja maior que 60 metros cúbicos. Então, especifica um tipo de criatura inteligente, como dragões vermelhos, goblins ou vampiros. Você envolve o alvo com uma aura que pode atrair ou repelir as criaturas especificas pela duração. Escolha antipatia ou simpatia como efeito da aura. Antipatia. O encantamento faz com que criaturas do tipo designado por você sintam-se fortemente impelidos em deixar a área e evitar o alvo. Quando uma dessas criaturas puder ver o alvo ou ficar a 18 metros dele, a criatura deve ser bem sucedida num teste de resistência de Sabedoria ou ficará amedrontada. A criatura continuará amedrontada enquanto puder ver o alvo ou permanecer a 18 metros dele. Enquanto estiver amedrontada pelo alvo, a criatura deve usar seu deslocamento para se mover para o local seguro mais próximo o qual ela não possa ver o alvo. Se a criatura se mover para mais de 18 metros do alvo e não puder vê-lo, a criatura não estará mais amedrontada, mas ela ficará amedrontada novamente se voltar a ver o alvo ou ficar a 18 metros dele. Simpatia. O encantamento faz com que as criaturas especificadas sintam-se fortemente impelidos a se aproximar do alvo enquanto estiverem a 18 metros dele ou puderem vê-lo. Quando uma dessas criaturas puder ver o alvo ou ficar a 18 metros dele, a criatura deve ser bem sucedida num teste de resistência de Vontade ou usará seu deslocamento em cada um dos seus turnos para entrar na área ou se mover até o alcance do alvo. Quando a criatura tiver feito isso, ela não poderá se afastar do alvo voluntariamente. Se o alvo causar dano ou ferir a criatura afetada de alguma forma, a criatura afetada pode realizar um novo teste de resistência de Sabedoria para terminar o efeito, como descrito abaixo. Terminando o Efeito. Se uma criatura afetada terminar se turno enquanto não estiver a até 18 metros do alvo ou não for capaz de vê-lo, a  criatura faz um teste de resistência de Sabedoria. Em um sucesso, a criatura não estará mais afetada pelo alvo e  econhecerá o sentimento de repugnância ou atração como mágico. Além disso, uma criatura afetada pela magia tem direito a outro teste de resistência de Sabedoria a cada 24 horas enquanto a magia durar. Uma criatura que obtenha sucesso na resistência contra esse efeito ficará imune a ele por 1 minuto, depois desse tempo, ela pode ser afetada novamente. ", "10 dias", "Encantamento", 2, "Antipatia/Simpatia", "1 hora" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 17, "Toque", "V, S, M (pelo ou penas de uma besta)", "Você toca uma criatura e a agracia com aprimoramento mágico. Escolha um dos efeitos a seguir; o alvo ganha esse efeito até o fim da magia. Agilidade do Gato. O alvo tem vantagem em testes de Destreza. Ele também não sofre dano ao cair de 6 metros ou menos, se não estiver incapacitado. Esperteza da Raposa. O alvo tem vantagem em testes de Inteligência. Esplendor da Águia. O alvo tem vantagem em testes de Carisma. Força do Touro. O alvo tem vantagem em testes de Força e sua capacidade de carga é dobrada. Sabedoria da Coruja. O alvo tem vantagem em testes de Sabedoria. Vigor do Urso. O alvo tem vantagem em testes de Constituição. Ele também recebe 2d6 pontos de vida temporários, que são perdidos quando a magia termina. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 3° nível ou superior, você pode afetar uma criatura adicional para cada nível do espaço acima do 2°. ", "Concentração, até 1 hora", "Transmutação", 2, "Aprimorar Habilidade", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 18, "9 metros", "V, S, M (um pergaminho de representação ou uma estatueta esculpida para se parecer com o alvo e um componente especial, que varia de acordo com a versão da magia que você escolher, valendo, no mínimo, 500 po por Dado de Vida)", "Você cria um impedimento mágico para imobilizar uma criatura que você possa ver, dentro do alcance. O alvo deve ser bem sucedido num teste de resistência de Sabedoria ou será vinculado à magia; se ele for bem sucedido, ele será imune a essa magia se você conjura-la novamente. Enquanto estiver sob efeito dessa magia, a criatura não precisará respirar, comer ou beber e não envelhece. Magias de adivinhação não podem localizar ou perceber o alvo. Quando você conjura essa magia, você escolhe uma das seguintes formas de aprisionamento. Enterrar. O alvo é sepultado bem fundo na terra em uma esfera de energia mágica que é grande o suficiente para conter o alvo. Nada pode atravessar a esfera e nenhuma criatura pode se teletransportar ou usar viagem plantar para entrar ou sair dela. O componente especial para essa versão da magia é um pequeno globo de mitral. Acorrentar. Pesadas correntes, firmemente presas ao solo, matem o alvo no lugar. O alvo está impedido até a magia acabar e ele não pode se mover ou ser movido por nenhum meio, até lá. O componente especial para essa versão da magia é uma fina corrente de metal precioso. Prisão Cercada. A magia transporta o alvo para dentro de um pequeno semiplano que é protegido contra teletransporte e viagem planar. O semiplano pode ser um labirinto, uma jaula, uma torre ou qualquer estrutura ou área confinada similar, à sua escolha. O componente material especial para essa versão da magia é uma representação em miniatura da prisão, feita de jade. Contenção Reduzida. O alvo é reduzido até o tamanho de 30 centímetros e é aprisionado dentro de uma gema ou objeto similar. A luz pode passar através da gema normalmente (permitindo que o alvo veja o exterior e outras criaturas vejam o interior), mas nada mais pode atravessa-la, mesmo por meios de teletransporte ou viagem planar. A gema não pode ser partida ou quebrada enquanto a magia estiver efetiva. O componente especial para essa versão da magia é uma gema transparente grande, como um coríndon, diamante ou rubi. Torpor. O alvo cai no sono e não pode ser acordado. O componente especial para essa versão da magia consiste em ervas soporíferas raras. Terminando a Magia. Durante a conjuração da magia, em quaisquer das versões, você pode especificar uma condição que irá fazer a magia terminar e libertará o alvo. A condição pode ser o quão especifica ou elaborada quanto você quiser, mas o Mestre deve concordar que a condição é razoável e tem uma probabilidade de acontecer. As condições podem ser baseadas no nome, identidade ou divindade da criatura mas, no mais, devem ser baseadas em ações ou qualidades observáveis e não em valores intangíveis tais como nível, classe e pontos de vida. A magia dissipar magia pode terminar a magia apenas se for conjurada como uma magia de 9° nível, tendo como alvo ou a prisão ou o componente especial usado para cria-la. Você pode usar um componente especial em particular para criar apenas uma prisão por vez. Se você conjurar essa magia novamente usando o mesmo componente, o alvo da primeira conjuração é, imediatamente, liberado do vínculo.", "Até ser dissipada", "Abjuração", 2, "Aprisionamento", "1 minuto" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 19, "Toque", "V, S, M (um baú requintado, de 90 cm por 60 cm por 60 cm, construído com materiais raros valendo, no mínimo, 5.000 po e uma réplica Miúda feita do mesmo material valendo, no mínimo, 50 po)", "Você esconde um baú, e todo o seu conteúdo, no Plano Etéreo. Você deve tocar o baú e a réplica em miniatura que serve como componente material para a magia. O baú pode acomodar até 3,6 metros cúbicos de matéria inorgânica (90 cm por 60 cm por 60 cm). Enquanto o baú permanecer no Plano Etéreo, você pode usar uma ação e tocar a réplica para revocar o baú. Ele aparece em um espaço desocupado no chão a 1,5 metro de você. Você pode enviar o baú de volta ao Plano Etéreo usando uma ação e tocando tanto no baú quanto na réplica. Após 60 dias, existe 5 por cento de chance, cumulativa, por dia do efeito da magia terminar. Esse efeito termina se você conjurar essa magia novamente, se a pequena réplica do baú for destruída ou se você decidir terminar a magia usando uma ação. Se a magia terminar enquanto o baú maior estiver no Plano Etéreo, ele estará irremediavelmente perdido.", "Instantânea", "Conjuração", 2, "Arca Secreta de Leomund", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 20, "18 metros", "V, S, M (um pouco de pele de porco ou manteiga)", "Graxa escorregadia cobre o solo em um quadrado de 3 metros centrado em um ponto, dentro do alcance, tornando essa área em terreno difícil pela duração. Quando a graxa aparece, cada criatura de pé na área deve ser bem sucedida num teste de resistência de Destreza ou cairá no chão. Uma criatura que entre na área ou termine seu turno nela, deve ser bem sucedido num teste de resistência de Destreza ou cairá no chão.", "1 minuto", "Conjuração", 2, "Área Escorregadia", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 21, "Toque", "Verbal, Somático", "Uma arma não-mágica que você tocar se torna uma arma mágica. Escolha um dos tipos de dano a seguir: ácido, elétrico, frio, fogo ou trovejante. Pela duração, a arma tem +1 de bônus nas jogadas de ataque e causa 1d4 de dano extra, do tipo de elemento escolhido, ao atingir. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 5° ou 6° nível, o bônus nas jogadas de ataque aumenta pra +2 e o dano extra aumenta para 2d4. Quando você usar um espaço de magia de 7° nível ou superior, o bônus aumenta para +3 e o dano extra aumenta para 3d4.", "Concentração, até 1 hora", "Transmutação", 2, "Arma Elemental", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 22, "18 metros", "Verbal, Somático", "Você cria uma arma espectral flutuante, dentro do alcance, que permanece pela duração ou até você conjurar essa magia novamente. Quando você conjura essa magia, você pode realizar um ataque corpo-a-corpo com magia contra uma criatura a 1,5 metro da arma. Se atingir, o alvo sofre dano de energia igual a 1d8 + seu modificador de habilidade de conjuração. Com uma ação bônus, no seu turno, você pode mover a arma até 6 metros e repetir o ataque contra uma criatura a 1,5 metro dela. A arma pode ter a forma que você desejar. Clérigos de divindades associadas com uma arma em particular (como St. Cuthbert é conhecido por sua maça ou Thor por seu martelo) fazem o efeito dessa magia se assemelhar a essa arma. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 4° nível ou superior, o dano aumenta em 1d8 para cada dois níveis do espaço acima do 2°.", "1 minuto", "Evocação", 2, "Arma Espiritual", "1 ação bônus" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 23, "Toque", "Verbal, Somático", "Você toca uma arma não-mágica. Até a magia acabar, a arma se torna uma arma mágica com +1 de bônus nas jogadas de ataque e jogadas de dano. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 4° nível ou superior, o bônus aumenta para +2. Quando você usar um espaço de magia de 6° nível ou superior, o bônus aumenta para +3. ", "Concentração, até 1 hora", "Transmutação", 2, "Arma Mágica", "1 ação bônus" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 24, "Toque", "Verbal, Somático, Material (um pedaço de couro curado)", "Você toca uma criatura voluntária que não esteja vestindo armadura e uma energia mágica protetora a envolve até a magia acabar. A CA base do alvo se torna 13 + o modificador de Destreza dele. A magia acaba se o alvo colocar uma armadura ou se você dissipa-la usando uma ação. ", "8 horas", "Abjuração", 2, "Armadura Arcana", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 25, "Pessoal", "Verbal, Somático, Material (um copo de água)", "Uma força magica protetora envolve você, manifestandose como um frio espectral que cobre você e seu equipamento. Você ganha 5 pontos de vida temporários pela duração. Se uma criatura atingir você com um ataque corpo-a-corpo enquanto estiver com esses pontos de vida, a criatura sofrerá 5 de dano de frio. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 2° nível ou superior, tanto os pontos de vida temporários quanto o dano de frio aumentam em 5 para cada nível do espaço acima do 1°. ", "1 hora", "Abjuração", 2, "Armadura de Agathys", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 26, "18 metros", "Verbal", "Escolha um objeto que você possa ver, dentro do alcance. O objeto pode ser uma porta, uma caixa, um baú ou um par de algemas, um cadeado ou outro objeto que contenha um meio mundano ou mágico que previne o acesso. Um alvo que esteja fechado por uma fechadura mundana ou preso ou barrado torna-se destrancado, destravado ou desbloqueado. Se o objeto tiver múltiplas fechaduras, apenas uma delas é destrancada. Se você escolher um alvo que esteja travado pela magia tranca arcana, essa magia será suprimida por 10 minutos, durante esse período o alvo pode ser aberto e fechado normalmente. Quando você conjurar essa magia, uma batida forte, audível a até 90 metros de distância, emana do objeto alvo. ", "Instantânea", "Transmutação", 2, "Arrombar", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 27, "36 metros", "Verbal, Somático", "Você mexe com os pesadelos de uma criatura que você possa ver, dentro do alcance, e cria uma manifestação ilusória dos seus medos mais profundos, visível apenas para a criatura. O alvo deve realizar um teste de resistência de Sabedoria. Se falhar na resistência, ele ficará amedrontado pela duração. No final de cada turno do alvo, antes da magia acabar, ele deve ser bem sucedido num teste de resistência de Sabedoria ou sofrerá 4d10 de dano psíquico. Se passar na resistência, a magia acaba. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 5° nível ou superior, o dano aumenta em 1d10 para cada nível do espaço acima do 4°", "Concentração, até 1 minuto", "Ilusão", 2, "Assassino Fantasmagórico", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 28, "9 metros", "Somático", "Você estende sua mão e aponta o dedo para um alvo no alcance. Sua magia garante a você uma breve intuição sobre as defesas do alvo. No seu próximo turno, você terá vantagem na primeira jogada de ataque contra o alvo, considerando que essa magia não tenha acabado. ", "Concentração, até 1 rodada", "Adivinhação", 1, "Ataque Certeiro", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 29, "Pessoal", "Verbal, Somático", "Pela duração da magia, seus olhos tornam-se manchas vazias imbuídas com poder terrível. Uma criatura, à sua escolha, a até de 18 metros de você que você puder ver, deve ser bem sucedida num teste de resistência de Sabedoria ou será afetada por um dos efeitos a seguir, à sua escolha, pela duração. A cada um dos seus turnos, até a magia acabar, você pode usar sua ação para afetar outra criatura, mas não pode afetar uma criatura novamente se ela tiver sido bem sucedida no teste de resistência contra essa conjuração de ataque visual. Adormecer. O alvo cai inconsciente. Ele acorda se sofrer qualquer dano ou se outra criatura usar sua ação para sacudir o adormecido até acordá-lo. Apavorar. O alvo está amedrontado. Em cada um dos turnos dele, a criatura amedrontada deve realizar a ação de Disparada e se mover para longe de você pela rota segura mais curta disponível, a não ser que não haja lugar para se mover. Se o alvo se mover para um local a, pelo menos, 18 metros de distância de você onde ela não possa mais te ver, esse efeito termina. Adoecer. O alvo tem desvantagem nas jogadas de ataque e testes de habilidade. No final de cada um dos turnos dele, ele pode realizar outro teste de resistência de Sabedoria. Se for bem sucedido, o efeito termina. ", "Concentração, até 1 minuto", "Necromancia", 2, "Ataque Visual", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 30, "Pessoal", "Verbal, Somático, Material (varetas, ossos ou objetos similarmente marcados valendo, no mínimo, 25 Peças de Ouro", "Ao lançar varetas cravejados com gemas, rolar ossos de dragão, puxar cartas ornamentadas ou usar outro tipo de ferramenta de adivinhação, você recebe um pressagio de uma entidade de outro mundo, sobre os resultados de cursos de ação específicos que você planeja tomar nos próximos 30 minutos. O Mestre escolhe dentre os possíveis presságios a seguir: • Êxito, para resultados bons • Fracasso, para resultados maus • Êxito e fracasso, para resultados bons e maus • Nada, para resultados que não são especialmente bons ou ruins A magia não leva em conta qualquer possível circunstancia que possa mudar o resultado, como a conjuração de magias adicionais ou a perda ou ganho de um companheiro. Se você conjurar a magia duas ou mais vezes antes de completar seu próximo descanso longo, existe uma chance cumulativa de 25 por cento de cada conjuração, depois da primeira que você fez, ter um resultado aleatório. O Mestre faz essa jogada secretamente. ", "Instantânea", "Adivinhação (ritual)", 2, "Augúrio", "1 minuto" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 31, "9 metros", "Verbal, Somático, Material (um pouco de pó de ferro", "Você faz com que uma criatura ou um objeto que você possa ver dentro do alcance, fique maior ou menor, pela duração. Escolha entre uma criatura ou um objeto que não esteja sendo carregado nem vestido. Se o alvo for involuntário, ele deve realizar um teste de resistência de Constituição. Se for bem sucedido, a magia não surte efeito. Se o alvo for uma criatura, tudo que ele esteja vestindo ou carregando muda e tamanho com ela. Qualquer item largado por uma criatura afetada, retorna ao seu tamanho natural. Aumentar. O tamanho do alvo dobra em todas as dimensões e seu peso é multiplicado por oito. Esse aumento eleva seu tamanho em uma categoria – de Médio para Grande, por exemplo. Se não houver espaço suficiente para que o alvo dobre de tamanho, a criatura ou objeto alcança o tamanho máximo possível no espaço disponível. Até o fim da magia, o alvo também tem vantagem em testes de Força e testes de resistência de Força. O tamanho das armas do alvo crescem para se adequar ao seu novo tamanho. Quando essas armas são ampliadas, os ataques do alvo com elas causam 1d4 de dano extra. Reduzir. O tamanho do alvo é reduzido à metade em todas as dimensões e seu peso é reduzido a um oitavo do normal. Essa redução diminui o tamanho do alvo em uma categoria – de Médio para Pequeno, por exemplo. Até o fim da magia, o alvo tem desvantagem em testes de Força e testes de resistência de Força. O tamanho das armas doalvo diminuem para se adequar ao seu novo tamanho. Quando essas armas são reduzidas, os ataques do alvo com elas causam 1d4 de dano a menos (isso não pode reduzir o dano a menos de 1).", "Concentração, até 1 minuto", "Transmutação", 2, "Aumentar/Reduzir", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 32, "Pessoal (9 metros de raio)", "Verbal", "Energia purificante irradia de você em uma aura com 9 metros de raio. Até a magia acabar, a aura se move mantendo-se centrada em você. Todas as criaturas nãohostis na aura (incluindo você) não podem ficar doentes, tem resistência a dano de veneno e tem vantagem em testes de resistência contra efeitos que deixem ela com qualquer das condições a seguir: amedrontado, atordoado, cego, enfeitiçado, envenenado, paralisado e surdo. ", "Concentração, até 10 minutos", "Abjuração", 2, "Aura de Pureza", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 33, "Pessoal (9 metros)", "Verbal", "Energia de prevenção vital irradia de você em uma aura com 9 metros de raio. Até a magia acabar, a aura se move mantendo-se centrada em você. Todas as criaturas nãohostis na aura (incluindo você) tem resistência a dano necrótico e seu máximo de pontos de vida não pode ser reduzido. Além disso, uma criatura viva não-hostil, recupera 1 ponto de vida quando começa seu turno na aura com 0 pontos de vida. ", "Concentração, até 10 minutos", "Abjuração", 2, "Aura de Vida", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 34, "Pessoal (9 metros)", "Verbal", "Energia de prevenção vital irradia de você em uma aura com 9 metros de raio. Até a magia acabar, a aura se move mantendo-se centrada em você. Todas as criaturas nãohostis na aura (incluindo você) tem resistência a dano necrótico e seu máximo de pontos de vida não pode ser reduzido. Além disso, uma criatura viva não-hostil, recupera 1 ponto de vida quando começa seu turno na aura com 0 pontos de vida. ", "Concentração, até 1 minuto", "Evocação", 2, "Aura de Vitalidade", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 35, "Toque", "Verbal, Somático, Material (um pequeno quadrade do seda)", "Você coloca uma ilusão em uma criatura ou objeto que você tocar, então magias de adivinhação revelarão informações falsas sobre ele. O alvo pode ser uma criatura voluntária ou um objeto que não esteja sendo carregado ou vestido por outra criatura. Quando você conjura essa magia, escolha um ou ambos os efeitos seguintes. O efeito permanece pela duração. Se você conjurar essa magia na mesma criatura ou objeto a cada dia por 30 dias, colocando o mesmo efeito nele todas as vezes, a ilusão durará até ser dissipada. Aura Falsa. Você modifica a forma como o alvo aparece para magias e efeitos mágicos, como detectar magia, que detectam auras mágicas. Você pode fazer um objeto não-mágico parecer mágico ou mudar a aura mágica de um objeto para que ela pareça pertencer a outra escola de magia a sua escolha. Quando você usar esse efeito num objeto, você pode fazer a aura falsa aparente a qualquer criatura que manusear o item. Máscara. Você modifica a forma como o alvo aparece para magias e efeitos que detectam tipos de criaturas, como o Sentido Divino do paladino ou o gatilho de um magia símbolo. Você escolhe o tipo de criatura e outras magias e efeitos mágicos consideram o alvo como se ele fosse uma criatura desse tipo ou tendência.", "24 horas", "Ilusão", 2, "Aura Mágica de Nystul", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 36, "Pessoal", "Verbal, Somático, Material (um minúsculo relicário valendo, no mínimo, 1000 Peças de Ouro, contendo uma relíquia sagrada, como um pedaço de tecido do robe de um santo ou um pedaço de um pergaminho de um texto religioso", "Luz divina emana de você e adere em uma aureola suave num raio de 9 metros, em volta de você. As criaturas de sua escolha, no raio, quando você conjurar essa magia, emitem penumbra num raio de 1,5 metro e tem vantagem em todos os testes de resistência e as outras criaturas tem desvantagem nas jogadas de ataque contra elas, até a magia acabar. Além disso, quando um corruptor ou morto-vivo atingir uma criatura afetada com um ataque corpo-a-corpo, a aura lampeja com luz plena. O atacante deve ser bem sucedido num teste de resistência de Constituição ou ficara cego até a magia acabar. ", "Concentração, até 1 minuto", "Abjuração", 2, "Aura Sagrada", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 37, "Pessoal", "Verbal, Somático", "Sua oração fortalece você com radiação divina. Até o fim da magia, seus ataques com arma causam 1d4 de dano radiante extra ao atingirem.", "Concentração, até 1 minuto", "Evocação", 2, "Auxílio Divino", "1 ação bônus" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 38, "9 metros", "Verbal, Somático, Material (um item desagradável ao alvo", "Você tenta enviar uma criatura que você pode ver dentro do alcance, para outro plano de existência. O alvo deve ser bem sucedido num teste de resistência de Carisma ou será banido. Se o alvo for nativo do plano de existência que você está, você bane o alvo para um semiplano inofensivo. Enquanto estiver lá, a criatura estará incapacitada. Ela permanece lá até a magia acabar, a partir desse ponto, o alvo reaparece no espaço em que ela deixou ou no espaço desocupado mais próximo, se o espaço dela estive ocupado. Se o alvo for nativo de um plano de existência diferente do que você está, o alvo é banido em um lampejo sutil, retornando para o seu plano natal. Se a magia acabar antes de 1 minuto se passar, o alvo reaparece no lugar em que estava ou no espaço desocupado mais próximo, se o espaço dela estiver ocupado. Do contrário, o alvo não retorna. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 5° nível ou superior, você pode afetar uma criatura adicional para cada nível do espaço acima do 4°.", "Concentração, até 1 minuto", "Abjuração", 2, "Banimento", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 39, "9 metros", "Verbal, Somático, Material (uma tigela encrustada de gemas valendo, no mínimo, 1000 Peças de Ouro, que é consumida pela magia", "Você traz um grande banquete, incluindo comida e bebida magnificas. O banquete leva 1 hora para ser consumido e desaparece ao final desse tempo e os efeitos benéficos não se aplicam até essa hora terminar. Até doze criaturas podem participar do banquete. Uma criatura que participe do banquete ganha diversos benefícios. A criatura é curada de todas as doenças e venenos, torna-se imune a veneno e a ser amedrontada e faz todos os seus testes de resistência de Sabedoria com vantagem. Seu máximo de pontos de vida também aumenta em 2d10 e ela ganha a mesma quantidade de pontos de vida. Esses benefícios duram por 24 horas. ", "Instantânea", "Conjuração", 2, "Banquete de Heróis", "10 minutos" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 40, "24 metros", "Verbal, Somático", "Você cria uma muralha vertical de lâminas giratórias, afiadas como navalhas, feitas de energia mágica. A muralha aparece dentro do alcance e permanece pela duração. Você pode fazer uma muralha reta de até 30 metros de comprimento por 6 metros de altura e 1,5 metro de largura ou uma muralha anelar com até 18 metros de diâmetro, 6 metros de altura e 1,5 metro de largura. A muralha confere três-quartos de cobertura a criaturas atrás dela e seu espaço é terreno difícil. Quando uma criatura entrar a área da muralha pela primeira vez em um turno, ou começar seu turno nela, a criatura deve realizar um teste de resistência de Destreza. Se falhar, a criatura sofrerá 6d10 de dano cortante. Em um sucesso, a criatura sofre metade desse dano", "Concentração, até 10 minutos", "Evocação", 2, "Barreira de Lâminas", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 41, "9 metros", "Verbal, Somático, Material (um borrifo de água benta)", "Você abençoa até três criaturas, à sua escolha, dentro do alcance. Sempre que um alvo realizar uma jogada de ataque ou teste de resistência antes da magia acabar, o alvo pode jogar um d4 e adicionar o valor jogado ao ataque ou teste de resistência. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 2° nível ou superior, você pode afetar uma criatura adicional para cada nível do espaço acima do 1°. ", "Concentração, até 1 minuto", "Encantamento", 2, "Benção", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 42, "9 metros", "Verbal, Somático, Material (um pedaço de favo de mel e pó de jade valendo, no mínimo, 10 Peças de Ouro, consumidos pela magia)", "Você implanta uma mensagem em um objeto dentro do alcance, uma mensagem que é pronunciada quando uma condição de ativação é satisfeita. Escolha um objeto que você possa ver e não esteja sendo vestido ou carregado por outra criatura. Então, fale a mensagem, que deve conter 25 palavras ou menos, apesar de ela poder ser entregue durante um período de até 10 minutos. Finalmente, determine a circunstância que irá ativar a magia para que sua mensagem seja entregue. Quando essa circunstância ocorrer, a boca encantada aparecerá no objeto e recitará a mensagem com sua voz e com o mesmo volume que você falou. Se o objeto que você escolheu tiver uma boca ou algo semelhante a uma boca (por exemplo, a boca de uma estátua), a boca mágica aparece ai, então, as palavras parecerão vir da boca do objeto. Quando você conjura essa magia, você pode fazer a magia acabar depois de enviar sua mensagem ou ela pode permanecer e repetir a mensagem sempre que a circunstância de ativação ocorrer. A circunstância de ativação pode ser tão genérica ou tão detalhada quando você quiser, apesar de ela precisar ser baseada em condições visuais ou audíveis que ocorram a até 9 metros do objeto. Por exemplo, você pode instruir a boca a falar quando uma criatura se aproximar a menos de 9 metros do objeto ou quando um sino de prata tocar a menos de 9 metros dela", "Até ser dissipada", "Ilusão (ritual)", 2, "Boca Encanta", "1 minuto" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 43, "45 metros", "Verbal, Somática, Material (uma minúscula bola de guano de morcego e enxofre)", "Um veio brilhante lampeja na ponta do seu dedo em direção a um ponto que você escolher, dentro do alcance, e então eclode com um estampido baixo, explodindo em chamas. Cada criatura em uma esfera de 6 metros de raio, centrada no ponto, deve realizar um teste de resistência de Destreza. Um alvo sofre 8d6 de dano de fogo se falhar na resistência, ou metade desse dano se obtiver sucesso. O fogo se espalha, dobrando esquinas. Ele incendeia objetos inflamáveis na área que não estejam sendo vestidos ou carregados. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 4° nível ou superior, o dano aumenta em 1d6 para cada nível do espaço acima do 3°. ", "Instantânea", "Evocação", 2, "Bola de Fogo", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 44, "45 metros", "Verbal, Somático, Material (uma minúscula bola de guano de morcego e enxofre)", "Um feixe de luz amarelada é disparado da ponta do seu dedo, então se condensa e aguarda no ponto escolhido, dentro do alcance, como uma conta brilhante, pela duração. Quando a magia termina, seja por sua concentração ter sido interrompida ou por você ter decidido termina-la, a conta eclode com um estampido baixo, explodindo em chamas que se espalhando, dobrando esquinas. Cada criatura numa esfera, com 6 metros de raio, centrada na conta, deve realizar um teste de resistência de Destreza. Uma criatura sofre dano igual ao total de dano acumulado se falhar na resistência, ou metade do total se obtiver sucesso. 224 O dano base da magia é 12d6. Se até o final do seu turno, a conta ainda não tiver sido detonada, o dano aumenta em 1d6. Se a conta brilhante for tocada antes do intervalo expirar, a criatura que a tocou deve realizar um teste de resistência de Destreza. Se falhar na resistência, a magia termina imediatamente, fazendo a conta explodir em chamas. Se obtiver sucesso na resistência, a criatura pode arremessar a conta a até 12 metros. Quando ela atinge uma criatura ou objeto solido, a magia termina e a conta explode. O fogo danifica objetos na área e incendeia objetos inflamáveis que não estejam sendo vestidos ou carregados. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 8° nível ou superior, o dano base aumenta e 1d6 para cada nível do espaço acima do 7°. ", "Concentração, até 1 minuto", "Evocação", 2, "Bola de Fogo Controlável", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 45, "Toque", "Verbal, Somática, Material (um raminho de visco)", "Até dez frutos aparecem na sua mão e são infundidos com magia pela duração. Uma criatura pode usar sua ação para comer um fruto. Comer um fruto restaura 1 ponto de vida e um fruto produz nutrientes suficientes para sustentar uma criatura por um dia. Os frutos perdem seu potencial se não forem consumidos dentro de 24 horas da conjuração dessa magia", "Instantânea", "Transmutação", 2, "Bom Fruto", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 46, "Toque", "Verbal, Somático, Material (visco, uma folha de trevo e uma clava ou bordão)", "A madeira de uma clava ou bordão, que você esteja segurando, é imbuída com o poder da natureza. Pela duração, você pode usar sua habilidade de conjuração ao invés da sua Força para as jogadas de ataque e dano corpo-a-corpo usando essa arma, e o dado de dano da arma se torna um d8. A arma também se torna mágica, se ela já não for. A magia acaba se você conjura-la novamente ou se você soltar a arma.", "1 minuto", "Transmutação", 1, "Bordão Místico", "1 ação bônus" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 47, "Pessoal (3 metros de raio)", "Verbal, Somática", "Você invoca o poder de Hadar, o Faminto Sombrio. Tentáculos de energia negra brotam de você e golpeiam todas as criaturas a até 3 metros de você. Cada criatura na área deve realizar um teste de resistência de Força. Se falhar, o alvo sofre 2d6 de dano necrótico e não pode fazer reações até o próximo turno dela. Em um sucesso, uma criatura sofre metade do dano e não sofre qualquer outro efeito. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 2° nível ou superior, o dano aumenta em 1d6 para cada nível do espaço acima do 1°.", "Instantânea", "Conjuração", 2, "Braços de Hadar", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 48, "18 metros", "Verbal, Somático, Material (o olho petrificado de um tritão)", "Você coloca uma maldição em uma criatura que você possa ver, dentro do alcance. Até a magia acabar, você causa 1d6 de dano necrótico extra no alvo sempre que atingi-lo com um ataque. Além disso, escolha uma habilidade quando você conjurar a magia. O alvo tem desvantagem em testes de habilidade feitos com a habilidade escolhida. Se o alvo cair a 0 pontos de vida antes da magia acabar, você pode usar uma ação bônus, em um turno subsequente, para amaldiçoar outra criatura. Uma magia remover maldição conjurada no alvo acaba com a magia prematuramente. Em Níveis Superiores. Quando você conjurar essa magia usando um espaço de magia de 3° ou 4° nível, você poderá manter sua concentração na magia por até 8 horas. Quando você usar um espaço de magia de 5° nível ou superior, você poderá manter sua concentração na magia por até 24 horas.", "Concentração, até 1 hora", "Encantamento", 2, "Bruxaria", "1 ação bônus" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 49, "Pessoal", "Verbal, Somático", "Você adquire a habilidade de entrar em uma árvore e se mover de dentro dela para dentro de outra árvore de mesmo tipo à até 150 metros. Ambas as árvores devem estar vivas e ter, pelo menos, o mesmo tamanho que você. Você deve usar 1,5 metro de deslocamento para entrar numa árvore. Você, instantaneamente, sabe a localização de todas as outras árvores de mesmo tipo à 150 metros e, como parte do movimento usado para entrar na árvore, pode tanto passar por uma dessas árvores quanto sair da árvore em que você está. Você aparece no espaço que você quiser a 1,5 metro da árvore destino, usando outro movimento de 1,5 metro. Se você não tiver movimento restante, você aparece a 1,5 metro da árvore que você terminou seu movimento. Você pode usar esse habilidade de transporte uma vez por rodada pela duração. Você deve terminar cada turno fora da árvore. ", "Concentração, até 1 minuto", "Conjuração", 2, "Caminhar em Árvores", "1 ação" });

            migrationBuilder.InsertData(
                table: "Magias",
                columns: new[] { "IdMagia", "Alcance", "Componente", "Descricao", "Duracao", "Escola", "IdTipoMagia", "Nome", "TempodeConjuracao" },
                values: new object[] { 50, "9 metros", "Verbal, Somático, Material (fogo e água benta)", "Você e até dez criaturas voluntária que você possa ver, dentro do alcance, assumem uma forma gasosa pela duração, parecidas com pedaços de nuvem. Enquanto estiver na forma de nuvem, uma criatura tem deslocamento de voo de 90 metros e tem resistência a dano de concussão, cortante e perfurante de ataques nãomágicos. As únicas ações que uma criatura pode realizar nessa forma são a ação de Disparada ou para reverter a sua forma normal. Reverter leva 1 minuto, período pelo qual a criatura estará incapacitada e não poderá se mover. Até a magia acabar, uma criatura pode reverter para a forma de nuvem, o que também requer a transformação de 1 minuto. Se uma criatura estiver na forma de nuvem e voando quando o efeito acabar, a criatura descerá a 18 metros por rodada por 1 minuto, até aterrissar na solo, o que é feito com segurança. Se ela não puder aterrissar em 1 minuto, a criatura cairá a distância restante. ", "8 horas", "Transmutação", 2, "Caminhar no Vento", "1 minuto" });

            migrationBuilder.InsertData(
                table: "Racas",
                columns: new[] { "IdRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "Deslocamento", "IdIdioma", "Idade", "Nome", "Tamanho" },
                values: new object[] { 1, null, 2, null, null, null, null, 7.5, 1, 350, "Anão", "1.20m ~ 1.50m" });

            migrationBuilder.InsertData(
                table: "Racas",
                columns: new[] { "IdRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "Deslocamento", "IdIdioma", "Idade", "Nome", "Tamanho" },
                values: new object[] { 2, null, 2, null, null, null, null, 9.0, 2, 750, "Elfo", "1.50m ~ 1.80m" });

            migrationBuilder.InsertData(
                table: "Racas",
                columns: new[] { "IdRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "Deslocamento", "IdIdioma", "Idade", "Nome", "Tamanho" },
                values: new object[] { 3, null, 2, null, null, null, null, 7.5, 7, 150, "Halfling", "0.90m" });

            migrationBuilder.InsertData(
                table: "Racas",
                columns: new[] { "IdRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "Deslocamento", "IdIdioma", "Idade", "Nome", "Tamanho" },
                values: new object[] { 4, null, 1, null, null, null, null, 9.0, 2, 100, "Humano", "1.5m ~ 1.8m" });

            migrationBuilder.InsertData(
                table: "Racas",
                columns: new[] { "IdRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "Deslocamento", "IdIdioma", "Idade", "Nome", "Tamanho" },
                values: new object[] { 5, 1, 2, null, null, null, null, 9.0, 12, 80, "Draconato", "1.8m" });

            migrationBuilder.InsertData(
                table: "Racas",
                columns: new[] { "IdRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "Deslocamento", "IdIdioma", "Idade", "Nome", "Tamanho" },
                values: new object[] { 6, null, null, null, null, null, null, 7.5, 1, 500, "Gnomo", "0.90m ~ 1.20m" });

            migrationBuilder.InsertData(
                table: "Racas",
                columns: new[] { "IdRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "Deslocamento", "IdIdioma", "Idade", "Nome", "Tamanho" },
                values: new object[] { 7, 2, null, null, null, null, null, 1.0, 3, 180, "Meio-Elfo", "1.50m ~ 1.80m" });

            migrationBuilder.InsertData(
                table: "Racas",
                columns: new[] { "IdRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "Deslocamento", "IdIdioma", "Idade", "Nome", "Tamanho" },
                values: new object[] { 8, null, 1, null, 2, null, null, 9.0, 8, 75, "Meio-Orc", "1.80m ~ 2.10m" });

            migrationBuilder.InsertData(
                table: "Racas",
                columns: new[] { "IdRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "Deslocamento", "IdIdioma", "Idade", "Nome", "Tamanho" },
                values: new object[] { 9, 2, null, null, null, 1, null, 9.0, 2, 120, "Tiefling", "1.50m ~ 1.80m" });

            migrationBuilder.InsertData(
                table: "SubRacas",
                columns: new[] { "IdSubRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "IdRaca", "Nome" },
                values: new object[] { 1, null, null, null, null, null, 1, 1, "Anão da Colina" });

            migrationBuilder.InsertData(
                table: "SubRacas",
                columns: new[] { "IdSubRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "IdRaca", "Nome" },
                values: new object[] { 2, null, null, null, 2, null, null, 1, "Anão da Montanha" });

            migrationBuilder.InsertData(
                table: "SubRacas",
                columns: new[] { "IdSubRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "IdRaca", "Nome" },
                values: new object[] { 3, null, null, null, null, 1, null, 2, "Alto Elfo" });

            migrationBuilder.InsertData(
                table: "SubRacas",
                columns: new[] { "IdSubRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "IdRaca", "Nome" },
                values: new object[] { 4, null, null, null, null, null, 1, 2, "Elfo da Floresta" });

            migrationBuilder.InsertData(
                table: "SubRacas",
                columns: new[] { "IdSubRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "IdRaca", "Nome" },
                values: new object[] { 5, null, null, null, null, null, null, 2, "Elfo Negro (Drow)" });

            migrationBuilder.InsertData(
                table: "SubRacas",
                columns: new[] { "IdSubRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "IdRaca", "Nome" },
                values: new object[] { 6, 1, null, null, null, null, null, 3, "Pés Leves" });

            migrationBuilder.InsertData(
                table: "SubRacas",
                columns: new[] { "IdSubRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "IdRaca", "Nome" },
                values: new object[] { 7, null, 1, null, null, null, null, 3, "Robusto" });

            migrationBuilder.InsertData(
                table: "SubRacas",
                columns: new[] { "IdSubRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "IdRaca", "Nome" },
                values: new object[] { 8, null, null, 1, null, null, null, 6, "Gnomo da Floresta" });

            migrationBuilder.InsertData(
                table: "SubRacas",
                columns: new[] { "IdSubRaca", "BonusCarisma", "BonusConstituicao", "BonusDestreza", "BonusForca", "BonusInteligencia", "BonusSabedoria", "IdRaca", "Nome" },
                values: new object[] { 9, null, 1, null, null, null, null, 6, "Gnomo das Rochas" });

            migrationBuilder.CreateIndex(
                name: "IX_Armaduras_IdTipoArmadura",
                table: "Armaduras",
                column: "IdTipoArmadura");

            migrationBuilder.CreateIndex(
                name: "IX_Armas_IdTipoArma",
                table: "Armas",
                column: "IdTipoArma");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_IdListaMagia",
                table: "Classes",
                column: "IdListaMagia");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TracosdeClasses_ClasseIdClasse",
                table: "Classes_TracosdeClasses",
                column: "ClasseIdClasse");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TracosdeClasses_TracodeClasseIdTracodeClasse",
                table: "Classes_TracosdeClasses",
                column: "TracodeClasseIdTracodeClasse");

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadesRaciais_Racas_HabilidadeRacialIdHabilidadeRacial",
                table: "HabilidadesRaciais_Racas",
                column: "HabilidadeRacialIdHabilidadeRacial");

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadesRaciais_Racas_RacaIdRaca",
                table: "HabilidadesRaciais_Racas",
                column: "RacaIdRaca");

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadesRaciais_SubRacas_HabilidadeRacialIdHabilidadeRacial",
                table: "HabilidadesRaciais_SubRacas",
                column: "HabilidadeRacialIdHabilidadeRacial");

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadesRaciais_SubRacas_SubRacaIdSubRaca",
                table: "HabilidadesRaciais_SubRacas",
                column: "SubRacaIdSubRaca");

            migrationBuilder.CreateIndex(
                name: "IX_Idiomas_IdTipoIdioma",
                table: "Idiomas",
                column: "IdTipoIdioma");

            migrationBuilder.CreateIndex(
                name: "IX_Idiomas_Personagens_IdiomaIdIdioma",
                table: "Idiomas_Personagens",
                column: "IdiomaIdIdioma");

            migrationBuilder.CreateIndex(
                name: "IX_Idiomas_Personagens_PersonagemIdPersonagem",
                table: "Idiomas_Personagens",
                column: "PersonagemIdPersonagem");

            migrationBuilder.CreateIndex(
                name: "IX_Magias_IdTipoMagia",
                table: "Magias",
                column: "IdTipoMagia");

            migrationBuilder.CreateIndex(
                name: "IX_Magias_ListasMagias_ListaMagiaIdListaMagia",
                table: "Magias_ListasMagias",
                column: "ListaMagiaIdListaMagia");

            migrationBuilder.CreateIndex(
                name: "IX_Magias_ListasMagias_MagiaIdMagia",
                table: "Magias_ListasMagias",
                column: "MagiaIdMagia");

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_IdAntecedente",
                table: "Personagens",
                column: "IdAntecedente");

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_IdClasse",
                table: "Personagens",
                column: "IdClasse");

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_IdRaca",
                table: "Personagens",
                column: "IdRaca");

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_IdSkin",
                table: "Personagens",
                column: "IdSkin");

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_IdSubRaca",
                table: "Personagens",
                column: "IdSubRaca");

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_IdUsuario",
                table: "Personagens",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Racas_IdIdioma",
                table: "Racas",
                column: "IdIdioma");

            migrationBuilder.CreateIndex(
                name: "IX_Skins_IdDesigner",
                table: "Skins",
                column: "IdDesigner");

            migrationBuilder.CreateIndex(
                name: "IX_SubRacas_IdRaca",
                table: "SubRacas",
                column: "IdRaca");

            migrationBuilder.CreateIndex(
                name: "IX_TracosdeClasse_Arquetipos_ArquetipoIdArquetipo",
                table: "TracosdeClasse_Arquetipos",
                column: "ArquetipoIdArquetipo");

            migrationBuilder.CreateIndex(
                name: "IX_TracosdeClasse_Arquetipos_TracodeClasseIdTracodeClasse",
                table: "TracosdeClasse_Arquetipos",
                column: "TracodeClasseIdTracodeClasse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armaduras");

            migrationBuilder.DropTable(
                name: "Armas");

            migrationBuilder.DropTable(
                name: "ASVTracoes");

            migrationBuilder.DropTable(
                name: "Classes_TracosdeClasses");

            migrationBuilder.DropTable(
                name: "HabilidadesRaciais_Racas");

            migrationBuilder.DropTable(
                name: "HabilidadesRaciais_SubRacas");

            migrationBuilder.DropTable(
                name: "Idiomas_Personagens");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Magias_ListasMagias");

            migrationBuilder.DropTable(
                name: "Personagens_Armaduras");

            migrationBuilder.DropTable(
                name: "Personagens_Armas");

            migrationBuilder.DropTable(
                name: "Personagens_ASVTracoes");

            migrationBuilder.DropTable(
                name: "Personagens_Itens");

            migrationBuilder.DropTable(
                name: "Personagens_VeiculosAquaticos");

            migrationBuilder.DropTable(
                name: "Personagens_VeiculosTerrestres");

            migrationBuilder.DropTable(
                name: "Proficiencias_Armaduras");

            migrationBuilder.DropTable(
                name: "Proficiencias_Armas");

            migrationBuilder.DropTable(
                name: "Proficiencias_ASVTracoes");

            migrationBuilder.DropTable(
                name: "Proficiencias_Itens");

            migrationBuilder.DropTable(
                name: "Proficiencias_VeiculosAquaticos");

            migrationBuilder.DropTable(
                name: "Proficiencias_VeiculosTerrestres");

            migrationBuilder.DropTable(
                name: "TracosdeClasse_Arquetipos");

            migrationBuilder.DropTable(
                name: "VeiculosAquaticos");

            migrationBuilder.DropTable(
                name: "VeiculosTerrestres");

            migrationBuilder.DropTable(
                name: "TiposArmaduras");

            migrationBuilder.DropTable(
                name: "TiposArmas");

            migrationBuilder.DropTable(
                name: "HabilidadesRaciais");

            migrationBuilder.DropTable(
                name: "Personagens");

            migrationBuilder.DropTable(
                name: "Magias");

            migrationBuilder.DropTable(
                name: "Arquetipos");

            migrationBuilder.DropTable(
                name: "TracosdeClasse");

            migrationBuilder.DropTable(
                name: "Antecedentes");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Skins");

            migrationBuilder.DropTable(
                name: "SubRacas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "TiposMagias");

            migrationBuilder.DropTable(
                name: "ListasMagias");

            migrationBuilder.DropTable(
                name: "Designers");

            migrationBuilder.DropTable(
                name: "Racas");

            migrationBuilder.DropTable(
                name: "Idiomas");

            migrationBuilder.DropTable(
                name: "TiposIdiomas");
        }
    }
}
