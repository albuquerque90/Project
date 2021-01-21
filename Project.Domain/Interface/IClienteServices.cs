﻿using Project.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Interface
{
    public interface IClienteServices
    {
        Cliente GetCliente(Guid id);

        List<Cliente> GetClientes();
        void InsertCliente(Cliente cliente);

        void DeleteCliente(Guid id);
    }
}
