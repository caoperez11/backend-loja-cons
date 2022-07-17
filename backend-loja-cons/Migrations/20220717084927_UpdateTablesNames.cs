using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace backend_loja_cons.Migrations
{
    public partial class UpdateTablesNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Productos_ProductoId",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marcas_MarcaId",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Caracteristica");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "Correos");

            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "Logos");

            migrationBuilder.DropTable(
                name: "Objetivos");

            migrationBuilder.DropTable(
                name: "RedesSociales");

            migrationBuilder.DropTable(
                name: "Valores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Informacion",
                table: "Informacion");

            migrationBuilder.RenameTable(
                name: "Informacion",
                newName: "Empresa");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Productos",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Productos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Valoracion",
                table: "Productos",
                newName: "usuario_creacion");

            migrationBuilder.RenameColumn(
                name: "UsuarioCreacion",
                table: "Productos",
                newName: "pr_valoracion");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Productos",
                newName: "pr_stock");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Productos",
                newName: "pr_precio");

            migrationBuilder.RenameColumn(
                name: "NombreCorto",
                table: "Productos",
                newName: "pr_nombre_corto");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Productos",
                newName: "pr_nombre");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Productos",
                newName: "pr_modelo");

            migrationBuilder.RenameColumn(
                name: "MarcaId",
                table: "Productos",
                newName: "pr_marcaid");

            migrationBuilder.RenameColumn(
                name: "ImagenUrl",
                table: "Productos",
                newName: "pr_imagen_url");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                table: "Productos",
                newName: "fecha_modificacion");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "Productos",
                newName: "fecha_creacion");

            migrationBuilder.RenameColumn(
                name: "Descuento",
                table: "Productos",
                newName: "pr_descuento");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Productos",
                newName: "pr_codigo");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_MarcaId",
                table: "Productos",
                newName: "IX_Productos_pr_marcaid");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Marcas",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Marcas",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioCreacion",
                table: "Marcas",
                newName: "usuario_creacion");

            migrationBuilder.RenameColumn(
                name: "NombreCorto",
                table: "Marcas",
                newName: "m_nombre_corto");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Marcas",
                newName: "m_nombre");

            migrationBuilder.RenameColumn(
                name: "ImagenUrl",
                table: "Marcas",
                newName: "m_imagen_url");

            migrationBuilder.RenameColumn(
                name: "Icono",
                table: "Marcas",
                newName: "m_icono");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                table: "Marcas",
                newName: "fecha_modificacion");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "Marcas",
                newName: "fecha_creacion");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Marcas",
                newName: "m_descripcion");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "Categorias",
                newName: "Productoid");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Categorias",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categorias",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioCreacion",
                table: "Categorias",
                newName: "usuario_creacion");

            migrationBuilder.RenameColumn(
                name: "NombreCorto",
                table: "Categorias",
                newName: "c_nombreCorto");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Categorias",
                newName: "c_nombre");

            migrationBuilder.RenameColumn(
                name: "ImagenUrl",
                table: "Categorias",
                newName: "c_imagen_url");

            migrationBuilder.RenameColumn(
                name: "Icono",
                table: "Categorias",
                newName: "c_icono");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                table: "Categorias",
                newName: "fecha_modificacion");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "Categorias",
                newName: "fecha_creacion");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Categorias",
                newName: "c_descripcion");

            migrationBuilder.RenameIndex(
                name: "IX_Categorias_ProductoId",
                table: "Categorias",
                newName: "IX_Categorias_Productoid");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Empresa",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Empresa",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Vision",
                table: "Empresa",
                newName: "em_vision");

            migrationBuilder.RenameColumn(
                name: "UsuarioCreacion",
                table: "Empresa",
                newName: "usuario_creacion");

            migrationBuilder.RenameColumn(
                name: "TelefonoPrincipal",
                table: "Empresa",
                newName: "em_telefono_principal");

            migrationBuilder.RenameColumn(
                name: "Mision",
                table: "Empresa",
                newName: "em_mision");

            migrationBuilder.RenameColumn(
                name: "FechaModificacion",
                table: "Empresa",
                newName: "fecha_modificacion");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "Empresa",
                newName: "fecha_creacion");

            migrationBuilder.RenameColumn(
                name: "CorreoPrincipal",
                table: "Empresa",
                newName: "em_correo_principal");

            migrationBuilder.AddColumn<int>(
                name: "pr_marca_id",
                table: "Productos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa",
                column: "id");

            migrationBuilder.CreateTable(
                name: "BannersEmpresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    be_descripcion = table.Column<string>(type: "text", nullable: false),
                    be_imagen_url = table.Column<string>(type: "text", nullable: false),
                    be_tipo_banner = table.Column<int>(type: "integer", nullable: false),
                    Empresaid = table.Column<int>(type: "integer", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: false),
                    orden = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannersEmpresa", x => x.id);
                    table.ForeignKey(
                        name: "FK_BannersEmpresa_Empresa_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresa",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CaracteristicaProductos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cp_titulo = table.Column<string>(type: "text", nullable: false),
                    cp_cracteristicas = table.Column<string>(type: "text", nullable: false),
                    cp_orden = table.Column<int>(type: "integer", nullable: false),
                    Productoid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicaProductos", x => x.id);
                    table.ForeignKey(
                        name: "FK_CaracteristicaProductos_Productos_Productoid",
                        column: x => x.Productoid,
                        principalTable: "Productos",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ContactosEmpresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    con_numero = table.Column<string>(type: "text", nullable: false),
                    con_detalle = table.Column<string>(type: "text", nullable: false),
                    con_tipo_contacto = table.Column<int>(type: "integer", nullable: false),
                    Empresaid = table.Column<int>(type: "integer", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: false),
                    orden = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactosEmpresa", x => x.id);
                    table.ForeignKey(
                        name: "FK_ContactosEmpresa_Empresa_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresa",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CorreosEmpresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ce_correo = table.Column<string>(type: "text", nullable: false),
                    ce_tipo_oficina = table.Column<int>(type: "integer", nullable: false),
                    ce_tipo_correo = table.Column<string>(type: "text", nullable: false),
                    Empresaid = table.Column<int>(type: "integer", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: false),
                    orden = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorreosEmpresa", x => x.id);
                    table.ForeignKey(
                        name: "FK_CorreosEmpresa_Empresa_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresa",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DetalleProductos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dp_titulo = table.Column<string>(type: "text", nullable: false),
                    dp_cracteristicas = table.Column<string>(type: "text", nullable: false),
                    dp_orden = table.Column<int>(type: "integer", nullable: false),
                    Productoid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleProductos", x => x.id);
                    table.ForeignKey(
                        name: "FK_DetalleProductos_Productos_Productoid",
                        column: x => x.Productoid,
                        principalTable: "Productos",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "DireccionesEmpresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    de_ciudad = table.Column<string>(type: "text", nullable: false),
                    de_pais = table.Column<string>(type: "text", nullable: false),
                    de_direccion = table.Column<string>(type: "text", nullable: false),
                    de_calle_principal = table.Column<string>(type: "text", nullable: false),
                    de_calle_secundaria = table.Column<string>(type: "text", nullable: false),
                    de_barrio = table.Column<string>(type: "text", nullable: false),
                    de_latitud = table.Column<string>(type: "text", nullable: false),
                    de_longitud = table.Column<string>(type: "text", nullable: false),
                    de_tipo_oficina = table.Column<int>(type: "integer", nullable: false),
                    Empresaid = table.Column<int>(type: "integer", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: false),
                    orden = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccionesEmpresa", x => x.id);
                    table.ForeignKey(
                        name: "FK_DireccionesEmpresa_Empresa_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresa",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "LogosEmpresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    le_nombre = table.Column<string>(type: "text", nullable: false),
                    lg_imagen_url = table.Column<string>(type: "text", nullable: false),
                    lg_tipo_logo = table.Column<int>(type: "integer", nullable: false),
                    Empresaid = table.Column<int>(type: "integer", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: false),
                    orden = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogosEmpresa", x => x.id);
                    table.ForeignKey(
                        name: "FK_LogosEmpresa_Empresa_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresa",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ObjetivosEmpresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    obe_titulo = table.Column<string>(type: "text", nullable: false),
                    obe_nombre = table.Column<string>(type: "text", nullable: false),
                    Empresaid = table.Column<int>(type: "integer", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: false),
                    orden = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjetivosEmpresa", x => x.id);
                    table.ForeignKey(
                        name: "FK_ObjetivosEmpresa_Empresa_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresa",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "RedesSocialesEmpresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rse_nombre = table.Column<string>(type: "text", nullable: false),
                    rse_url = table.Column<string>(type: "text", nullable: false),
                    rse_icono = table.Column<string>(type: "text", nullable: false),
                    rse_tipo_red_social = table.Column<int>(type: "integer", nullable: false),
                    Empresaid = table.Column<int>(type: "integer", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: false),
                    orden = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedesSocialesEmpresa", x => x.id);
                    table.ForeignKey(
                        name: "FK_RedesSocialesEmpresa_Empresa_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresa",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ValoresEmpresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vae_titulo = table.Column<string>(type: "text", nullable: false),
                    vae_nombre = table.Column<string>(type: "text", nullable: false),
                    Empresaid = table.Column<int>(type: "integer", nullable: true),
                    estado = table.Column<bool>(type: "boolean", nullable: false),
                    orden = table.Column<int>(type: "integer", nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_modificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValoresEmpresa", x => x.id);
                    table.ForeignKey(
                        name: "FK_ValoresEmpresa_Empresa_Empresaid",
                        column: x => x.Empresaid,
                        principalTable: "Empresa",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BannersEmpresa_Empresaid",
                table: "BannersEmpresa",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_CaracteristicaProductos_Productoid",
                table: "CaracteristicaProductos",
                column: "Productoid");

            migrationBuilder.CreateIndex(
                name: "IX_ContactosEmpresa_Empresaid",
                table: "ContactosEmpresa",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_CorreosEmpresa_Empresaid",
                table: "CorreosEmpresa",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleProductos_Productoid",
                table: "DetalleProductos",
                column: "Productoid");

            migrationBuilder.CreateIndex(
                name: "IX_DireccionesEmpresa_Empresaid",
                table: "DireccionesEmpresa",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_LogosEmpresa_Empresaid",
                table: "LogosEmpresa",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_ObjetivosEmpresa_Empresaid",
                table: "ObjetivosEmpresa",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_RedesSocialesEmpresa_Empresaid",
                table: "RedesSocialesEmpresa",
                column: "Empresaid");

            migrationBuilder.CreateIndex(
                name: "IX_ValoresEmpresa_Empresaid",
                table: "ValoresEmpresa",
                column: "Empresaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Productos_Productoid",
                table: "Categorias",
                column: "Productoid",
                principalTable: "Productos",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marcas_pr_marcaid",
                table: "Productos",
                column: "pr_marcaid",
                principalTable: "Marcas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Productos_Productoid",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Marcas_pr_marcaid",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "BannersEmpresa");

            migrationBuilder.DropTable(
                name: "CaracteristicaProductos");

            migrationBuilder.DropTable(
                name: "ContactosEmpresa");

            migrationBuilder.DropTable(
                name: "CorreosEmpresa");

            migrationBuilder.DropTable(
                name: "DetalleProductos");

            migrationBuilder.DropTable(
                name: "DireccionesEmpresa");

            migrationBuilder.DropTable(
                name: "LogosEmpresa");

            migrationBuilder.DropTable(
                name: "ObjetivosEmpresa");

            migrationBuilder.DropTable(
                name: "RedesSocialesEmpresa");

            migrationBuilder.DropTable(
                name: "ValoresEmpresa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "pr_marca_id",
                table: "Productos");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "Informacion");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Productos",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Productos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuario_creacion",
                table: "Productos",
                newName: "Valoracion");

            migrationBuilder.RenameColumn(
                name: "pr_valoracion",
                table: "Productos",
                newName: "UsuarioCreacion");

            migrationBuilder.RenameColumn(
                name: "pr_stock",
                table: "Productos",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "pr_precio",
                table: "Productos",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "pr_nombre_corto",
                table: "Productos",
                newName: "NombreCorto");

            migrationBuilder.RenameColumn(
                name: "pr_nombre",
                table: "Productos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "pr_modelo",
                table: "Productos",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "pr_marcaid",
                table: "Productos",
                newName: "MarcaId");

            migrationBuilder.RenameColumn(
                name: "pr_imagen_url",
                table: "Productos",
                newName: "ImagenUrl");

            migrationBuilder.RenameColumn(
                name: "pr_descuento",
                table: "Productos",
                newName: "Descuento");

            migrationBuilder.RenameColumn(
                name: "pr_codigo",
                table: "Productos",
                newName: "Codigo");

            migrationBuilder.RenameColumn(
                name: "fecha_modificacion",
                table: "Productos",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "fecha_creacion",
                table: "Productos",
                newName: "FechaCreacion");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_pr_marcaid",
                table: "Productos",
                newName: "IX_Productos_MarcaId");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Marcas",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Marcas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuario_creacion",
                table: "Marcas",
                newName: "UsuarioCreacion");

            migrationBuilder.RenameColumn(
                name: "m_nombre_corto",
                table: "Marcas",
                newName: "NombreCorto");

            migrationBuilder.RenameColumn(
                name: "m_nombre",
                table: "Marcas",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "m_imagen_url",
                table: "Marcas",
                newName: "ImagenUrl");

            migrationBuilder.RenameColumn(
                name: "m_icono",
                table: "Marcas",
                newName: "Icono");

            migrationBuilder.RenameColumn(
                name: "m_descripcion",
                table: "Marcas",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "fecha_modificacion",
                table: "Marcas",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "fecha_creacion",
                table: "Marcas",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Categorias",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "Productoid",
                table: "Categorias",
                newName: "ProductoId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Categorias",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuario_creacion",
                table: "Categorias",
                newName: "UsuarioCreacion");

            migrationBuilder.RenameColumn(
                name: "fecha_modificacion",
                table: "Categorias",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "fecha_creacion",
                table: "Categorias",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "c_nombreCorto",
                table: "Categorias",
                newName: "NombreCorto");

            migrationBuilder.RenameColumn(
                name: "c_nombre",
                table: "Categorias",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "c_imagen_url",
                table: "Categorias",
                newName: "ImagenUrl");

            migrationBuilder.RenameColumn(
                name: "c_icono",
                table: "Categorias",
                newName: "Icono");

            migrationBuilder.RenameColumn(
                name: "c_descripcion",
                table: "Categorias",
                newName: "Descripcion");

            migrationBuilder.RenameIndex(
                name: "IX_Categorias_Productoid",
                table: "Categorias",
                newName: "IX_Categorias_ProductoId");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Informacion",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Informacion",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuario_creacion",
                table: "Informacion",
                newName: "UsuarioCreacion");

            migrationBuilder.RenameColumn(
                name: "fecha_modificacion",
                table: "Informacion",
                newName: "FechaModificacion");

            migrationBuilder.RenameColumn(
                name: "fecha_creacion",
                table: "Informacion",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "em_vision",
                table: "Informacion",
                newName: "Vision");

            migrationBuilder.RenameColumn(
                name: "em_telefono_principal",
                table: "Informacion",
                newName: "TelefonoPrincipal");

            migrationBuilder.RenameColumn(
                name: "em_mision",
                table: "Informacion",
                newName: "Mision");

            migrationBuilder.RenameColumn(
                name: "em_correo_principal",
                table: "Informacion",
                newName: "CorreoPrincipal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Informacion",
                table: "Informacion",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    Estado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ImagenUrl = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    TipoBanner = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banners_Informacion_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Informacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Caracteristica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ValorId = table.Column<int>(type: "integer", nullable: true),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    ProductoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caracteristica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caracteristica_Caracteristica_ValorId",
                        column: x => x.ValorId,
                        principalTable: "Caracteristica",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Caracteristica_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Detalle = table.Column<string>(type: "text", nullable: false),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    Estado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    TipoContacto = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contactos_Informacion_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Informacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Correos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Correo = table.Column<string>(type: "text", nullable: false),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    Estado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    TipoCorreo = table.Column<string>(type: "text", nullable: false),
                    TipoOficina = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Correos_Informacion_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Informacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ValorId = table.Column<int>(type: "integer", nullable: true),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    ProductoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detalle_Detalle_ValorId",
                        column: x => x.ValorId,
                        principalTable: "Detalle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Detalle_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Barrio = table.Column<string>(type: "text", nullable: false),
                    CallePrincipal = table.Column<string>(type: "text", nullable: false),
                    CalleSecundaria = table.Column<string>(type: "text", nullable: false),
                    Ciudad = table.Column<string>(type: "text", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: false),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    Estado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Latitud = table.Column<string>(type: "text", nullable: false),
                    Longitud = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    Pais = table.Column<string>(type: "text", nullable: false),
                    TipoOficina = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Direcciones_Informacion_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Informacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Logos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    Estado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ImagenUrl = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    TipoLogo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logos_Informacion_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Informacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Objetivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    Estado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objetivos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objetivos_Informacion_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Informacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RedesSociales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    Estado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Icono = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    TipoRedSocial = table.Column<int>(type: "integer", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedesSociales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedesSociales_Informacion_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Informacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Valores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmpresaId = table.Column<int>(type: "integer", nullable: true),
                    Estado = table.Column<bool>(type: "boolean", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Valores_Informacion_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Informacion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banners_EmpresaId",
                table: "Banners",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Caracteristica_ProductoId",
                table: "Caracteristica",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Caracteristica_ValorId",
                table: "Caracteristica",
                column: "ValorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_EmpresaId",
                table: "Contactos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Correos_EmpresaId",
                table: "Correos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_ProductoId",
                table: "Detalle",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_ValorId",
                table: "Detalle",
                column: "ValorId");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_EmpresaId",
                table: "Direcciones",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Logos_EmpresaId",
                table: "Logos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Objetivos_EmpresaId",
                table: "Objetivos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_RedesSociales_EmpresaId",
                table: "RedesSociales",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Valores_EmpresaId",
                table: "Valores",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Productos_ProductoId",
                table: "Categorias",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Marcas_MarcaId",
                table: "Productos",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
