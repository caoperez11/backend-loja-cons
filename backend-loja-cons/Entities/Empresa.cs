// ReSharper disable All
namespace backend_loja_cons.Entities;

public class Empresa: EntitiyBase
{
    public string em_mision { get; set; } = string.Empty;
    public string em_vision { get; set; } = string.Empty;
    public string em_correo_principal { get; set; } = string.Empty;
    public string em_telefono_principal { get; set; } = string.Empty;
    public List<ValoresEmpresa> em_valores { get; set; } = new();
    public List<ObjetivosEmpresa> em_objetivos { get; set; } = new();
    public List<DireccionesEmpresa> em_direcciones { get; set; } = new();
    public List<ContactosEmpresa> em_telefonos { get; set; } = new();
    public List<CorreosEmpresa> em_correos { get; set; } = new();
    public List<RedesSocialesEmpresa> em_redes_sociales { get; set; } = new();
    public List<LogosEmpresa> em_logos { get; set; } = new();
    public List<BannersEmpresa> em_imagenes { get; set; } = new();


    public class EntityBaseEmpresa
    {
        public int id { get; set; } = 0;
        public bool estado { get; set; } = true;
        public int orden { get; set; } = 0;
        public DateTime fecha_creacion { get; set; } = DateTime.Now;
        public DateTime fecha_modificacion { get; set; } = DateTime.Now;
    }

    public class ValoresEmpresa: EntityBaseEmpresa
    {
        public string vae_titulo { get; set; } = string.Empty;
        public string vae_nombre { get; set; } = string.Empty;
    }

    public class ObjetivosEmpresa: EntityBaseEmpresa
    {
        public string obe_titulo { get; set; } = string.Empty;
        public string obe_nombre { get; set; } = string.Empty;
    }

    public class DireccionesEmpresa: EntityBaseEmpresa
    {
        public string de_ciudad { get; set; } = string.Empty;
        public string de_pais { get; set; } = "Ecuador";
        public string de_direccion { get; set; } = string.Empty;
        public string de_calle_principal { get; set; } = string.Empty;
        public string de_calle_secundaria { get; set; } = string.Empty;
        public string de_barrio { get; set; } = string.Empty;
        public string de_latitud { get; set; } = string.Empty;
        public string de_longitud { get; set; } = string.Empty;
        public Tipo de_tipo_oficina { get; set; } = Tipo.Matriz;
    }

    public enum Tipo
    {
        Matriz,
        Sucursal,
        Oficina,
        Otro
    }

    public class ContactosEmpresa: EntityBaseEmpresa
    {
        public string con_numero { get; set; } = string.Empty;
        public string con_detalle { get; set; } = string.Empty;
        public TipoTelefono con_tipo_contacto { get; set; } = TipoTelefono.Celular;
    }

    public enum TipoTelefono
    {
        Celular,
        Convencional,
    }

    public class CorreosEmpresa: EntityBaseEmpresa
    {
        public string ce_correo { get; set; } = string.Empty;
        public Tipo ce_tipo_oficina { get; set; } = Tipo.Matriz;
        public string ce_tipo_correo { get; set; } = string.Empty;
    }

    public class RedesSocialesEmpresa: EntityBaseEmpresa
    {
        public string rse_nombre { get; set; } = string.Empty;
        public string rse_url { get; set; } = string.Empty;
        public string rse_icono { get; set; } = string.Empty;
        public TipoRedSocial rse_tipo_red_social { get; set; }
    }

    public enum TipoRedSocial
    {
        Facebook,
        Twitter,
        Instagram,
        Youtube,
        Twitch,
        Tiktok
    }

    public class BannersEmpresa: EntityBaseEmpresa
    {
        public string be_descripcion { get; set; } = string.Empty;
        public string be_imagen_url { get; set; } = string.Empty;
        public TipoBannerLogos be_tipo_banner { get; set; } = TipoBannerLogos.Configuracion;
    }

    public enum TipoBannerLogos
    {
        Principal,
        Secundario,
        Landing,
        Footer,
        Header,
        Configuracion,
    }

    public class LogosEmpresa: EntityBaseEmpresa
    {
        public string le_nombre { get; set; } = string.Empty;
        public string lg_imagen_url { get; set; } = string.Empty;
        public TipoBannerLogos lg_tipo_logo { get; set; } = TipoBannerLogos.Configuracion;
    }
}