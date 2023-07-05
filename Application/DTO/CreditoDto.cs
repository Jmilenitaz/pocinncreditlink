using System;

namespace Application.DTO
{
    public class CreditoDto
    {
        public string IdCliente { get; set; }

        public int? IdComercio { get; set; }

        public double? Monto { get; set; }

        public DateTime? FechaApro { get; set; }

        public DateTime? FechaCierre { get; set; }
    }
}