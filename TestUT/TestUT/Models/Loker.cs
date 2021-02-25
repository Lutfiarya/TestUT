using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestUT.Models
{
    [Table("Loker")]
    public class Loker
    {
        [Key]
        public int IdLoker { get; set; }
        public int LantaiLoker { get; set; }
        public int NomerLoker { get; set; }
    }
}
