namespace backend_loja_cons.Entities;

public class Categoria: EntitiyBase
{
    public string Nombre { get; set; } = string.Empty;
    public string NombreCorto { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string ImagenUrl { get; set; } = string.Empty;
    public string Icono { get; set; } = string.Empty;
    
}