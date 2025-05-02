using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAppHexagonal.Domain.Entities
{
    public class Pedido
    {
        public int Id {get; set;}
        public DateTime Fecha {get; set;}

        public List<DetallePedido>? Detalles {get; set;}
    }
}