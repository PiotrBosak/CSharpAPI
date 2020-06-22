using System;
using System.Collections;
using ApdbTest2.Dtos;

namespace ApdbTest2.Domain
{
    public class Rent
    {
        public int  IdRent { get; set; }
        public int IdCar { get; set; }
        public int IdClient { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }//nullable
        public double RentalPrice { get; set; }//maybe change
        public virtual Client Client { get; set; }
        public virtual Car Car { get; set; }
    }
}