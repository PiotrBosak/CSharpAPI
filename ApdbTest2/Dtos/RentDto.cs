using System;

namespace ApdbTest2.Dtos
{
    public class RentDto
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }//nullable
        public int  IdRent { get; set; }
        public string ClientFirstName { get; set; }
        public double RentalPrice { get; set; }
        public string ClientLastName { get; set; }
    }
}