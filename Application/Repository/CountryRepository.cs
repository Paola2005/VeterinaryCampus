using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;
using Persistence.Data;


namespace Application.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountry
    {
        private readonly JwtDbContext _context;

        public CountryRepository(JwtDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
