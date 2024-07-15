﻿using System.ComponentModel.DataAnnotations;

namespace Tienda.Microservicios.Api.Cupon.Models
{
    public class Cupon
    {
        [Key]
        public int CuponId { get; set; }
        [Required]
        public string CuponCode { get; set; }
        [Required]
        public decimal PorcentajeDescuento {  get; set; }
        public int DescuentoMinimo {  get; set; }
    }
}
