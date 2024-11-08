namespace ApiEmpresa.Models;

public class Producto
{
    public int id_producto { get; set; }
    public string? codigo { get; set; }
    public string? producto { get; set; } // Cambiado a "string" en lugar de "String"
    public string? descripcion { get; set; }
    public string? presentacion { get; set; }
    public double? precio_costo { get; set; }
    public DateTime? fecha_vencimiento { get; set; }
}
