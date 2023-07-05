using Application.DTO;
using Domain;
using System;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Interfaces;



namespace Application.Interfaces
{
    public interface IClienteService
    {
        Task CrearCliente(string idCliente, string nombre, string apellido, string direccion, string telefono, decimal cupo, decimal deuda);







    }
}