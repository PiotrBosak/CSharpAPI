using System;
using System.Collections.Generic;
using System.Linq;
using ApdbTest2.Domain;
using ApdbTest2.Dtos;
using ApdbTest2.Exceptions;

namespace ApdbTest2.Services
{
    public class ClientService: IClientService
    {
        private readonly CarContext _context;

        public ClientService(CarContext context)
        {
            _context = context;
        }
     
        public void AddClient(ClientDto dto)
        {
            AddCityIfNeeded(dto.CityName);
            var city = _context.Cities.FirstOrDefault(c => c.CityName == dto.CityName);
            if (city == null)
                throw new CityWasNotAddedException("should never happen if we don't use multiple threads");
            try
            {

                _context.Clients.Add(new Client
                {
                    Apartment = dto.Apartment,
                    City = city,
                    Rents = new List<Rent>(),
                    BirthDate = dto.BirthDate,
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    PhoneNumber = dto.PhoneNumber,
                    StreetName = dto.StreetName,
                    StreetNumber = dto.StreetNumber,
                    DriverLicenseNr = dto.DriverLicenseNr,
                    IdCityDict = city.IdCity
                });
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new InvalidClientDataException();
            }
            
            
        }

        private void AddCityIfNeeded(string name)
        {
            var city = _context.Cities.FirstOrDefault(c => c.CityName == name);
            if (city == null)
                _context.Cities.Add(new City
                {
                    CityName = name
                });
            _context.SaveChanges();

        }
    }
}