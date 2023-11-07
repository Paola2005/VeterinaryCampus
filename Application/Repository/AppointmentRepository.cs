using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;


namespace Application.Repository
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointment
    {
        private readonly JwtDbContext _context;

        public AppointmentRepository(JwtDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
