// ReSharper disable All
namespace backend_loja_cons.Entities;

public class Producto: EntitiyBase
{
    public string pr_codigo { get; set; } = string.Empty;
    public string pr_nombre { get; set; } = string.Empty;
    public string pr_nombre_corto { get; set; } = string.Empty;
    public List<DetalleProductos> pr_detalles { get; set; } = new ();
    public List<CaracteristicaProductos> pr_caracteristicas { get; set; } = new ();
    public decimal pr_precio { get; set; } = 0;
    public decimal pr_descuento { get; set; } = 0;
    public int pr_stock { get; set; } = 0;
    public string pr_imagen_url { get; set; } = string.Empty;
    public string pr_modelo { get; set; } = string.Empty;
    public int pr_valoracion { get; set; } = 0;
    public int pr_marca_id { get; set; } = 0;
    public Marca pr_marca { get; set; } = new Marca();
    public List<Categoria> pr_categorias { get; set; } = new ();


    public class DetalleProductos
    {
        public int id { get; set; } = 0;
        public string dp_titulo { get; set; } = string.Empty;
        public string dp_cracteristicas { get; set; } = string.Empty;
        public int dp_orden { get; set; } = 0;
    }

    public class CaracteristicaProductos
    {
        public int id { get; set; } = 0;
        public string cp_titulo { get; set; } = string.Empty;
        public string cp_cracteristicas { get; set; } = string.Empty;
        public int cp_orden { get; set; } = 0;
    }

}