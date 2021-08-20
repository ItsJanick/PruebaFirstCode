using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaFisrtCode.Models
{
    public class Clients
    {
        [Key]

        public int ClientID { get; set;}

        public string Name { get; set; }

        public string LastName { get; set; }

        public string IdentificationCard { get; set; }

        public DateTime Birthdate { get; set; }

        public string Photo { get; set; }

        public float Height { get; set; }

        public float Weight { get; set; }

        public string Address { get; set; }

        public ICollection<Bills> Bills { get; set; }

    }
}
