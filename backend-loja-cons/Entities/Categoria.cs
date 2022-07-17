// ReSharper disable All
namespace backend_loja_cons.Entities;

public class Categoria: EntitiyBase
{
    
    public string c_nombre { get; set; } = string.Empty;
    public string c_nombreCorto { get; set; } = string.Empty;
    public string c_descripcion { get; set; } = string.Empty;
    public string c_imagen_url { get; set; } = string.Empty;
    public string c_icono { get; set; } = string.Empty;
    
}