using System.Collections;
using System.Collections.Generic;

namespace ApdbTest2.Domain
{
    public class Manufacturer
    {
        public int IdManufacturer { get; set; }
        public string ManufacturerName { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        
    }
}