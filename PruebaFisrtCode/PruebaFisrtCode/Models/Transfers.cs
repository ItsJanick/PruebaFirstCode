using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaFisrtCode.Models
{
    public class Transfers
    {
        [Key]
        public int TransferID { get; set; }

        public int ClientsID { get; set; }

        public float Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public  Bills Start { get; set; }

        public Bills End{ get; set; }

    }
}
