using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendaPOS.Models
{
    public class Venta
    { 
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Total { get; set; }

        //Acá definimos dos claves foraneas hacia 2 entidades
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<DetalleVenta> Detalles { get; set; } = new();
    }
}
