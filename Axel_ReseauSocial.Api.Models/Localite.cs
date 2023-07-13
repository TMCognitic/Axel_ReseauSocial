using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Models
{
    public class Localite
    {
        public Guid IdLocalite { get; set; }
        public int CP { get; set; }
        public string Ville { get; set; }
        public double Longitude { get; set;}
        public double Latitude { get; set; }
    }
}
