using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeagueMaster.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estadisticas_Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Jugador = table.Column<int>(type: "int", nullable: false),
                    Nombre_Jugador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Minutos_Jugados = table.Column<int>(type: "int", nullable: false),
                    Tiros_Campo_Intentados = table.Column<int>(type: "int", nullable: false),
                    Tiros_Campo_Exitosos = table.Column<int>(type: "int", nullable: false),
                    Porcentaje_Tiros_Campo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tiros_3P_Intentados = table.Column<int>(type: "int", nullable: false),
                    Tiros_3P_Exitosos = table.Column<int>(type: "int", nullable: false),
                    Porcentaje_Tiros_3P = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tiros_2P_Intentados = table.Column<int>(type: "int", nullable: false),
                    Tiros_2P_Exitosos = table.Column<int>(type: "int", nullable: false),
                    Porcentaje_Tiros_2P = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tiros_Libres_Intentados = table.Column<int>(type: "int", nullable: false),
                    Tiros_Libres_Exitosos = table.Column<int>(type: "int", nullable: false),
                    Porcentaje_Tiros_Libres = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rebotes_Ofensivos = table.Column<int>(type: "int", nullable: false),
                    Rebotes_Densivos = table.Column<int>(type: "int", nullable: false),
                    Total_Rebotes = table.Column<int>(type: "int", nullable: false),
                    Asistencias = table.Column<int>(type: "int", nullable: false),
                    Robos = table.Column<int>(type: "int", nullable: false),
                    Bloqueos = table.Column<int>(type: "int", nullable: false),
                    Perdidas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadisticas_Jugadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estadisticas_Partidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipo_Local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipo_Visitante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puntos_Local = table.Column<int>(type: "int", nullable: false),
                    Puntos_Visitantes = table.Column<int>(type: "int", nullable: false),
                    Canastas_3 = table.Column<int>(type: "int", nullable: false),
                    Canastas_2 = table.Column<int>(type: "int", nullable: false),
                    Canastas_1 = table.Column<int>(type: "int", nullable: false),
                    Total_Faltas = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    Estadio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jornada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Competicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notas_Adicionales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arbitro_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arbitro_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesa_principal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadisticas_Partidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    Estadio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resultado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calendario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    Estadio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipo_Local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipo_Visitante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jornada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Competicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notas_Adicionales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arbitro_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arbitro_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mesa_principal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estadisticas_PartidosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendario_Estadisticas_Partidos_Estadisticas_PartidosId",
                        column: x => x.Estadisticas_PartidosId,
                        principalTable: "Estadisticas_Partidos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entrenador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estadisticas_JugadoresId = table.Column<int>(type: "int", nullable: true),
                    Estadisticas_PartidosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_Estadisticas_Jugadores_Estadisticas_JugadoresId",
                        column: x => x.Estadisticas_JugadoresId,
                        principalTable: "Estadisticas_Jugadores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipos_Estadisticas_Partidos_Estadisticas_PartidosId",
                        column: x => x.Estadisticas_PartidosId,
                        principalTable: "Estadisticas_Partidos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Estadisticas_PartidosPartidos",
                columns: table => new
                {
                    Estadisticas_PartidoId = table.Column<int>(type: "int", nullable: false),
                    PartidosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadisticas_PartidosPartidos", x => new { x.Estadisticas_PartidoId, x.PartidosId });
                    table.ForeignKey(
                        name: "FK_Estadisticas_PartidosPartidos_Estadisticas_Partidos_Estadisticas_PartidoId",
                        column: x => x.Estadisticas_PartidoId,
                        principalTable: "Estadisticas_Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estadisticas_PartidosPartidos_Partidos_PartidosId",
                        column: x => x.PartidosId,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalendarioPartidos",
                columns: table => new
                {
                    CalendariosId = table.Column<int>(type: "int", nullable: false),
                    PartidosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarioPartidos", x => new { x.CalendariosId, x.PartidosId });
                    table.ForeignKey(
                        name: "FK_CalendarioPartidos_Calendario_CalendariosId",
                        column: x => x.CalendariosId,
                        principalTable: "Calendario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalendarioPartidos_Partidos_PartidosId",
                        column: x => x.PartidosId,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalendarioEquipos",
                columns: table => new
                {
                    EquiposId = table.Column<int>(type: "int", nullable: false),
                    calendarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarioEquipos", x => new { x.EquiposId, x.calendarioId });
                    table.ForeignKey(
                        name: "FK_CalendarioEquipos_Calendario_calendarioId",
                        column: x => x.calendarioId,
                        principalTable: "Calendario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalendarioEquipos_Equipos_EquiposId",
                        column: x => x.EquiposId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquiposPartidos",
                columns: table => new
                {
                    EquiposId = table.Column<int>(type: "int", nullable: false),
                    PartidosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquiposPartidos", x => new { x.EquiposId, x.PartidosId });
                    table.ForeignKey(
                        name: "FK_EquiposPartidos_Equipos_EquiposId",
                        column: x => x.EquiposId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquiposPartidos_Partidos_PartidosId",
                        column: x => x.PartidosId,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Altura = table.Column<bool>(type: "bit", nullable: false),
                    Equipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquiposId = table.Column<int>(type: "int", nullable: true),
                    Estadisticas_JugadoresId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_EquiposId",
                        column: x => x.EquiposId,
                        principalTable: "Equipos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jugadores_Estadisticas_Jugadores_Estadisticas_JugadoresId",
                        column: x => x.Estadisticas_JugadoresId,
                        principalTable: "Estadisticas_Jugadores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    NivelAcceso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquiposId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rol_Equipos_EquiposId",
                        column: x => x.EquiposId,
                        principalTable: "Equipos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RolUsuarios",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UsuariosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolUsuarios", x => new { x.RolesId, x.UsuariosId });
                    table.ForeignKey(
                        name: "FK_RolUsuarios_Rol_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolUsuarios_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calendario_Estadisticas_PartidosId",
                table: "Calendario",
                column: "Estadisticas_PartidosId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarioEquipos_calendarioId",
                table: "CalendarioEquipos",
                column: "calendarioId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarioPartidos_PartidosId",
                table: "CalendarioPartidos",
                column: "PartidosId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_Estadisticas_JugadoresId",
                table: "Equipos",
                column: "Estadisticas_JugadoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_Estadisticas_PartidosId",
                table: "Equipos",
                column: "Estadisticas_PartidosId");

            migrationBuilder.CreateIndex(
                name: "IX_EquiposPartidos_PartidosId",
                table: "EquiposPartidos",
                column: "PartidosId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadisticas_PartidosPartidos_PartidosId",
                table: "Estadisticas_PartidosPartidos",
                column: "PartidosId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_EquiposId",
                table: "Jugadores",
                column: "EquiposId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_Estadisticas_JugadoresId",
                table: "Jugadores",
                column: "Estadisticas_JugadoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_EquiposId",
                table: "Rol",
                column: "EquiposId");

            migrationBuilder.CreateIndex(
                name: "IX_RolUsuarios_UsuariosId",
                table: "RolUsuarios",
                column: "UsuariosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalendarioEquipos");

            migrationBuilder.DropTable(
                name: "CalendarioPartidos");

            migrationBuilder.DropTable(
                name: "EquiposPartidos");

            migrationBuilder.DropTable(
                name: "Estadisticas_PartidosPartidos");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "RolUsuarios");

            migrationBuilder.DropTable(
                name: "Calendario");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Estadisticas_Jugadores");

            migrationBuilder.DropTable(
                name: "Estadisticas_Partidos");
        }
    }
}
