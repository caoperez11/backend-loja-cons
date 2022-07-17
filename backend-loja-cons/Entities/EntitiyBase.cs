// ReSharper disable All
namespace backend_loja_cons.Entities;

public class EntitiyBase
{
    public int id { get; set; }
    public bool estado { get; set; } = true;
    public DateTime fecha_creacion { get; set; } = DateTime.Now;
    public DateTime fecha_modificacion { get; set; } = DateTime.Now;
    public int usuario_creacion { get; set; } = 0;
}