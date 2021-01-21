using Project.Core.Enum;
using Project.Core.Model;
using Project.Infra.Data.Interface;
using System;
using System.Collections.Generic;

namespace Project.Infra.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public Cliente GetCliente(Guid id)
        {
            //Sua query select no banco para buscar cliente usando EF ou Dapper
            Cliente c = new Cliente
            {
                Nome = "Lebron James",
                CPF = "12312312323",
                DataNascimento = new DateTime(1990, 10, 24),
                TipoCliente = TipoClienteEnum.Titular
            };

            return c;
        }

        public List<Cliente> GetClientes()
        {
            //Sua query select no banco para buscar cliente usando EF ou Dapper
            List<Cliente> lstClientes = new List<Cliente>();
            Cliente c = new Cliente
            {
                Nome = "Lebron James",
                CPF = "12312312323",
                DataNascimento = new DateTime(1990, 10, 24),
                TipoCliente = TipoClienteEnum.Titular
            };
            Cliente c1 = new Cliente
            {
                Nome = "Anthony Davies",
                CPF = "12312312323",
                DataNascimento = new DateTime(1995, 10, 24),
                TipoCliente = TipoClienteEnum.Dependente
            };
            Cliente c2 = new Cliente
            {
                Nome = "James Harden",
                CPF = "12312312323",
                DataNascimento = new DateTime(2010, 10, 24),
                TipoCliente = TipoClienteEnum.Dependente
            };
            lstClientes.Add(c);
            lstClientes.Add(c1);
            lstClientes.Add(c2);

            return lstClientes;
        }

        public void InsertCliente(Cliente cliente)
        {
            //Seu insert no banco
            //Insert into cliente ...
        }

        public void DeleteCliente(Guid id)
        {
            //Seu delete
        }
    }
}
