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
    public class PetRepository : GenericRepository<Pet>, IPet
    {
        private readonly JwtDbContext _context;

        public PetRepository(JwtDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
