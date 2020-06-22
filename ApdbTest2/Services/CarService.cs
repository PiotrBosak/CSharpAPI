using System;
using System.Collections.Generic;
using System.Linq;
using ApdbTest2.Domain;
using ApdbTest2.Dtos;
using ApdbTest2.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ApdbTest2.Services
{
    public class CarService : ICarService
    {
        private readonly CarContext _context;

        public CarService(CarContext context)
        {
            _context = context;
        }

        public CarDto GetCar(int id)
        {
            var car = _context
                .Cars
                .Include(c => c.Manufacturer)
                .Include(c => c.Rents)
                .FirstOrDefault(c => c.IdCar == id);
            if (car == null)
                throw new NoSuchCarException();
            var rentals = GetRentals(car);
            var manDto = GetManDto(car);
            return new CarDto
            {
                Manufacturer = manDto,
                Model = car.Model,
                Rents = rentals,
                EngineCapacity = car.EngineCapacity,
                ProdYear = car.ProdYear,
                NumOfDoors = car.NumOfDoors
            };


        }

        private static ManufacturerDto GetManDto(Car car)
        {
            return new ManufacturerDto
            {
                IdManufacturer = car.Manufacturer.IdManufacturer,
                ManufacturerName = car.Manufacturer.ManufacturerName
            };
        }

        private List<RentDto> GetRentals(Car car)
        {
            var rents = car.Rents;
            var rentals = new List<RentDto>();
            foreach (var rent in rents)
            {
                var client = _context
                    .Clients
                    .Include(c => c.Rents)
                    .FirstOrDefault(c => c.IdClient == rent.IdClient);
                if (client == null)
                    throw new NoClientWithGivenIdException("should never happen I  think");
                rentals.Add(new RentDto
                {
                    ClientFirstName = client.FirstName,
                    ClientLastName = client.LastName,
                    EndDate = rent.EndDate,
                    IdRent = rent.IdRent,
                    StartDate = rent.StartDate,
                    RentalPrice = rent.RentalPrice
                });
            }
            rentals.Sort((r1,r2) => r1.RentalPrice.CompareTo(r2.RentalPrice));
            return rentals;
        }

       
    }
}