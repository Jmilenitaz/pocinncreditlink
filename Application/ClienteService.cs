using Application.Interfaces;
using Domain;
using System.Threading.Tasks;

namespace Application
{

    public class ClienteService : IClienteService
    {
        private readonly IGenericRepository<Cliente> _GenericRepository;

        public ClienteService(IGenericRepository<Cliente> GenericRepository)
        {
            _GenericRepository = GenericRepository;
        }

        public async Task CrearCliente(string idCliente, string nombre, string apellido, string direccion, string telefono, decimal cupo, decimal deuda)
        {
            // Realiza cualquier lógica adicional de validación o manipulación de datos aquí

            // Crea una instancia de la entidad Cliente con los datos proporcionados
            var cliente = new Cliente
            {
                IdCliente = idCliente,
                Nombre = nombre,
                Apellido = apellido,
                Direccion = direccion,
                Telefono = telefono,
                Cupo = cupo,
                Deuda = deuda
            };

            // Guarda el cliente en el repositorio
            await _GenericRepository.Insert(cliente);
        }
    }
}
