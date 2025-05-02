using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiAppHexagonal.Domain.Ports;

namespace MiAppHexagonal.Domain.Factory
{
    public interface IDbFactory
    {
        IClienteRepository CrearClienteRepository();
    }
}