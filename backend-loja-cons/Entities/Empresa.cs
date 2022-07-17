namespace backend_loja_cons.Entities;

public class Empresa: EntitiyBase
{
    public string Mision { get; set; } = string.Empty;
    public string Vision { get; set; } = string.Empty;
    public string CorreoPrincipal { get; set; } = string.Empty;
    public string TelefonoPrincipal { get; set; } = string.Empty;
    public List<Valores> Valores { get; set; } = new ();
    public List<Objetivos> Objetivos { get; set; } = new ();
    public List<Direcciones> Direcciones { get; set; } = new ();
    public List<Telefonos> Telefonos { get; set; } = new ();
    public List<Correos> Correos { get; set; } = new ();
    public List<RedesSociales> RedesSociales { get; set; } = new ();
    public List<Logos> Logos { get; set; } = new ();
    public List<Banners> Imagenes { get; set; } = new ();

}
public abstract class Valores
{
    public string Nombre { get; set; } = string.Empty;
    public int Orden { get; set; } = 0;
}

public abstract class Objetivos
{
    public string Nombre { get; set; } = string.Empty;
    public int Orden { get; set; } = 0;
}
public abstract class Direcciones
{
    public int Id { get; set; } = 0;
    public string Ciudad { get; set; } = string.Empty;
    public string Pais { get; set; } = "Ecuador";
    public string Direccion { get; set; } = string.Empty;
    public string CallePrincipal { get; set; } = string.Empty;
    public string CalleSecundaria { get; set; } = string.Empty;
    public string Barrio { get; set; } = string.Empty;
    public string Latitud { get; set; } = string.Empty;
    public string Longitud { get; set; } = string.Empty;
    public Tipo TipoOficina { get; set; } = Tipo.Matriz;
    public bool Estado { get; set; } = true;
}

public enum Tipo
{
    Matriz,
    Sucursal,
    Oficina,
    Otro
}
public abstract class Telefonos
{
    public int Id { get; set; } = 0;
    public string Numero { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public TipoTelefono TipoTelefono { get; set; } = TipoTelefono.Celular;
    public bool Estado { get; set; } = true;
}
public enum TipoTelefono
{
    Celular,
    Convencional,
}
public abstract class Correos
{
    public int Id { get; set; } = 0;
    public string Correo { get; set; } = string.Empty;
    public Tipo TipoOficina { get; set; } =  Tipo.Matriz;
    public string TipoCorreo { get; set; } = string.Empty;
    public bool Estado { get; set; } = true;
}

public abstract class RedesSociales
{
    public int Id { get; set; } = 0;
    public string Nombre { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Icono { get; set; } = string.Empty;
    public TipoRedSocial TipoRedSocial { get; set; }
    public bool Estado { get; set; } = true;
}

public enum  TipoRedSocial{
Facebook,
Twitter,
Instagram,
Youtube,
Twitch,
Tiktok
}

public abstract class Banners
{
    public int Id { get; set; } = 0;
    public string Descripcion { get; set; } = string.Empty;
    public string ImagenUrl { get; set; } = string.Empty;
    public int Orden { get; set; } = 0;
    public TipoBannerLogos TipoBanner { get; set; } = TipoBannerLogos.Configuracion;
    public bool Estado { get; set; } = true;
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
public abstract class Logos
{
    public int Id { get; set; } = 0;
    public string Nombre { get; set; } = string.Empty;
    public string ImagenUrl { get; set; } = string.Empty;
    public int Orden { get; set; } = 0;
    public TipoBannerLogos TipoLogo { get; set; } = TipoBannerLogos.Configuracion;
    public bool Estado { get; set; } = true;
}