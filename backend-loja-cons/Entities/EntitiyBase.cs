namespace backend_loja_cons.Entities;

public class EntitiyBase
{
    public int Id { get; set; }
    public bool Estado { get; set; } = true;
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaModificacion { get; set; } = DateTime.Now;
    public int UsuarioCreacion { get; set; } = 0;
}