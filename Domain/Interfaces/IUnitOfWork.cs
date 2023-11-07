using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IUser Users { get; }
        IAppointment Appointments { get; }
        IBreed Breeds { get; }
        ICity Cities { get; }
        ICountry Countries { get; }
        IPet Pets { get; }
        IPhoneUser PhonesUsers { get; }
        IService Services { get; }
        IState States { get; }
        IUserAddress UserAddress { get; }
        Task<int> SaveAsync();
    }
}
