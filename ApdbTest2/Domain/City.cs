using System.Collections;
using System.Collections.Generic;
using ApdbTest2.Dtos;

namespace ApdbTest2.Domain
{
    public class City
    {
        public int IdCity { get; set; }
        public string CityName { get; set; }
        public virtual ICollection<Client> Clients { get; set; } 
        
    }
}