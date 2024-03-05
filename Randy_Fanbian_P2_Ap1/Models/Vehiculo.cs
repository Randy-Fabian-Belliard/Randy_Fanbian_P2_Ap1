using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Randy_Fanbian_P2_Ap1.Models
{
    public class Vehiculo
    {

            [Key]
            public int  VehiculoId { get; set; }
        
            [Required(ErrorMessage = "Este campo es requerido")]
            public DateTime Fecha { get; set; } = DateTime.Today;
        
            [Required(ErrorMessage = "Este campo es requerido")]
            public string? Descripcion { get; set; }
        
            [Range(1, int.MaxValue, ErrorMessage = "El campo debe ser mayor que cero")]
            public decimal Costo { get; set; }

            [Range(1, int.MaxValue, ErrorMessage = "El campo debe ser mayor que cero")]
            public decimal Gasto { get; set; }

            [ForeignKey("VehiculoId")]
            public List<VehiculoDetalle> VehiculoDetalle { get; set; } = new List<VehiculoDetalle>();
        
    }
}




