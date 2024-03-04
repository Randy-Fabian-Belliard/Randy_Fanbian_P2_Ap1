using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Randy_Fanbian_P2_Ap1.Models
{
    public class Accesorios
    {
        [Key]
        public int AccesorioId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }

        [ForeignKey("AccesorioId")]
        public List<VehiculoDetalle> VehiculoDetalle { get; set; } = new List<VehiculoDetalle>();
    }
}
