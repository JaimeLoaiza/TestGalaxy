using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestGalaxy.Models
{
    public class TRabajadores
    {
        [Key]
        public int TrabajadorID { get; set; }
        [Column("int(5)")]
        [Required]
        public string Tipo_identificacion { get; set; }
        [Column("varchar(2)")]
        public string Numero_identificacion { get; set; }
        [Column("varchar(10)")]
        public string Primer_nombre { get; set; }
        [Column("varchar(15)")]
        public string Segundo_nombre { get; set; }
        [Column("varchar(15)")]
        public string Primer_apellido { get; set; }
        [Column("varchar(15)")]
        public string Segundo_apellido { get; set; }
        [Column("varchar(15)")]
        public DateTime Fecha_nacimiento { get; set; }
        [Column("date")]
        public int Edad { get; set; }
    }
}
