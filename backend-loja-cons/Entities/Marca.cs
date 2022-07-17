// ReSharper disable All
namespace backend_loja_cons.Entities;

public class Marca: EntitiyBase
{
    public string m_nombre { get; set; } = string.Empty;
    public string m_nombre_corto { get; set; } = string.Empty;
    public string m_descripcion { get; set; } = string.Empty;
    public string m_imagen_url { get; set; } = string.Empty;
    public string m_icono { get; set; } = string.Empty;
    public List<Producto>m_productos { get; set; } = new ();
}