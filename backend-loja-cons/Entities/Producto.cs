namespace backend_loja_cons.Entities;

public class Producto: EntitiyBase
{
    public string Codigo { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string NombreCorto { get; set; } = string.Empty;
    public List<Info<object>> Detalles { get; set; } = new ();
    public List<Info<object>> Caracteristicas { get; set; } = new ();
    public decimal Precio { get; set; } = 0;
    public decimal Descuento { get; set; } = 0;
    public int Stock { get; set; } = 0;
    public string ImagenUrl { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public int Valoracion { get; set; } = 0;
    public int MarcaId { get; set; } = 0;
    public Marca Marca { get; set; } = new Marca();
    public List<Categoria> ProductosCategorias { get; set; } = new ();

    public abstract class Info<T>
    {
        public int Id { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public T? Valor { get; set; }
        public int Orden { get; set; } = 0;
    }

}