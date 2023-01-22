using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoParking.Models
{
    public class AutoParkingModel
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int pojemnoscsilnik { get; set; }
        public int Rokprod { get; set; }
        public int cena { get; set; }
        public bool czysprzedany { get; set; }
    }
}
