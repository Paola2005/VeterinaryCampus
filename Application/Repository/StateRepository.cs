using Domain.Entities;
using Domain.Interfaces;
using Persistence;
using Persistence.Data;

namespace Application.Repository
{
    public class StateRepository : GenericRepository<State>, IState
    {
        private readonly JwtDbContext _context;

        public StateRepository(JwtDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
