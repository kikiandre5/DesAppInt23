using System.ComponentModel.DataAnnotations;

public class Articulo
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(25, MinimumLength = 3)]
    public string Descripcion { get; set; }
    [Required]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Range(typeof(DateTime), "01/01/2023", "31/12/2024", ErrorMessage = "La FechaAlta debe estar en el rango de 01/01/2023 a 31/12/2024.")]
    public DateTime FechaAlta { get; set; }
    [Required]
    [Range(1, 100, ErrorMessage = "La Cantidad debe estar en el rango de 1 a 100.")]
    public int Cantidad { get; set; }
    [Required]
    [Range(1, 2500, ErrorMessage = "El Precio debe estar en el rango de 1 a 2500.")]
    public double Precio { get; set; }
    [Required]
    [RegularExpression("^(metro|Litro|Kilo|Pieza|Caja)$", ErrorMessage = "Unidad de medida no válida.")]
    public string UdeMedida { get; set; }
}