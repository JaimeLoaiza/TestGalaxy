using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestGalaxy.Models
{
    public class Contratos
    {
        [Key]
        public int ContratoId { get; set; }
        [Column("int(5)")]
        [Required]
        public string Nombre_entidad { get; set; }
        [Column("varchar(25)")]
        public int Numero_contrato { get; set; }
        [Column("int(6)")]
        public string Trabajador_vinculado { get; set; }
        [Column("char(2)")]
        public DateTime Fecha_inicio { get; set; }
        [Column("date")]
        public DateTime Fecha_Finalizacion { get; set; }
    }   
}
