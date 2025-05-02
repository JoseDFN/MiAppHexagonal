using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAppHexagonal.Domain.Entities
{
    public class DetallePedido
    {
        public int ProductoId {get; set;}
        public string? NombreProducto {get; set;}
        public int Cantidad {get; set;}
        public decimal PrecioUnitario {get; set;}

        public decimal Total => Cantidad * PrecioUnitario;
    }
}