using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Application.DTO
{
    public class ClienteDTO
    {
        public String IdCliente { get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? Direccion { get; set; }

        public string? Telefono { get; set; }

        public decimal Cupo { get; set; }

        public decimal Deuda { get; set; }
    }
}
