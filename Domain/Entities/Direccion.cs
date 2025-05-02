using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAppHexagonal.Domain.Entities
{
    public class Direccion
    {
        public int Id {get; set;}
        public string? Ciudad {get; set;}
        public string? Calle {get; set;}
        public string? CodigoPostal {get; set;}
    }
}