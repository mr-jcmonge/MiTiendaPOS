using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendaPOS.Models
{
    public class Producto
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal PrecioUnitario { get; set; }

        [Required]
        public int Stock { get; set; }
        public bool Activo { get; set; }

        //Definimos la clave foranea hacia categoria
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
