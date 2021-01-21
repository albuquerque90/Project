using Project.Core.Model;
using Project.Domain.Interface;
using Project.Infra.Data.Interface;
using Project.Infra.Data.Repository;
using System;
using System.Collections.Generic;

namespace Project.Domain.Services
{
    public class ClienteServices : IClienteServices
    {
        IClienteRepository _clienteRepository;

        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente GetCliente(Guid id)
        {
            return _clienteRepository.GetCliente(id);
        }

        public List<Cliente> GetClientes()
        {
            return _clienteRepository.GetClientes();
        }

        public void InsertCliente(Cliente cliente)
        {
            //suponhamos que abaixo seja uma regra de negócio
            cliente.CPF.Replace('.', ' ').Replace('-', ' ');

            _clienteRepository.InsertCliente(cliente);
        }

        public void DeleteCliente(Guid id)
        {
            _clienteRepository.DeleteCliente(id);
        }
    }
}
