using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaFisrtCode.Models
{
    public class Bills
    {
        [Key]
        public int BillsId { get; set; }
        public string Alias { get; set; }
        public string AccountNumber { get; set; }
        public float Balance { get; set; }
    }
}
