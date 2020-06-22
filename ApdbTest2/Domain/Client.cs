using System;
using System.Collections.Generic;
using ApdbTest2.Domain;

namespace ApdbTest2.Domain
{
    public class Client
    {
        public int IdClient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string Apartment { get; set; }
        public int IdCityDict { get; set; }
        public string DriverLicenseNr { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Rent> Rents { get; set; }
        
        
    }
}