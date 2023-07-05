using System;
using System.Collections.Generic;

namespace Domain
{

    public partial class Cliente
    {
        public string IdCliente { get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? Direccion { get; set; }

        public string? Telefono { get; set; }

        public decimal Cupo { get; set; }

        public decimal Deuda { get; set; }

        public virtual ICollection<Credito> Creditos { get; set; } = new List<Credito>();







    }
}
