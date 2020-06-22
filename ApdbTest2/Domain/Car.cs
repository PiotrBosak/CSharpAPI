using System.Collections;
using System.Collections.Generic;

namespace ApdbTest2.Domain
{
    public class Car
    {
        public int IdCar { get; set; }
        public int ProdYear { get; set; }
        public int NumOfDoors { get; set; }
        public double EngineCapacity { get; set; }
        public string Model { get; set; }
        public int IdManufactureDict { get; set; }
        public virtual ICollection<Rent> Rents { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        
    }
}