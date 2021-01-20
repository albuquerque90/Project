using Project.Core.Base;
using Project.Core.Model;
using Project.Infra.Data.Repository;
using System;
using System.Collections.Generic;

namespace Project.Domain.Services
{
    public class ClienteServices : SingletonBase<ClienteServices>
    {

        public Cliente GetCliente(Guid id)
        {
            return ClienteRepository.Instance().GetCliente(id);
        }

        public List<Cliente> GetClientes()
        {
            return ClienteRepository.Instance().GetClientes();
        }

        public void InsertCliente(Cliente cliente)
        {
            //suponhamos que abaixo seja uma regra de negócio
            cliente.CPF.Replace('.', ' ').Replace('-', ' ');

            ClienteRepository.Instance().InsertCliente(cliente);
        }

        public void DeleteCliente(Guid id)
        {
            ClienteRepository.Instance().DeleteCliente(id);
        }
    }
}
