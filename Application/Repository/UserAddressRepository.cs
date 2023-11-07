using Domain.Entities;
using Domain.Interfaces;
using Persistence;
using Persistence.Data;

namespace Application.Repository
{
    public class UserAddressRepository : GenericRepository<UserAddress>, IUserAddress
    {
        private readonly JwtDbContext _context;

        public UserAddressRepository(JwtDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
