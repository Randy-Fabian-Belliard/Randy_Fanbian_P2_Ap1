﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Randy_Fanbian_P2_Ap1.Models
{
    public class VehiculoDetalle
    {

        [Key]
        public int VehiculoDetalleId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int VehiculoId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int AccesorioId { get; set; }

        [Range(1, (double)decimal.MaxValue, ErrorMessage = "El campo debe ser mayor que cero")]
        public decimal Valor { get; set; }

    }
}
