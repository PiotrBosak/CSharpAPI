using System.Collections.Generic;
using ApdbTest2.Domain;

namespace ApdbTest2.Dtos
{
    public class CarDto
    {
        public int ProdYear { get; set; }
        public int NumOfDoors { get; set; }
        public double EngineCapacity { get; set; }
        public string Model { get; set; }
        public  ManufacturerDto Manufacturer { get; set; }
        public List<RentDto> Rents { get; set; }
        
    }
}