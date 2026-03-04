namespace EcommerceAPI.Models;
using System.ComponentModel.DataAnnotations;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(0.01, 10000, ErrorMessage = "El precio debe ser mayor a 0")]
    public decimal Price { get; set; }

}