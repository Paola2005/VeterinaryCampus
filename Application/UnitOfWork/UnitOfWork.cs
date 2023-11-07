using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;
using Persistence.Data;

namespace Application.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly JwtDbContext _context;

    private ICity _city;
    private IAppointment _appointment;
    private IBreed _breed;
    private IPet _pet;
    private IPhoneUser _phoneuser;
    private IService _service;
    private IUserAddress _useraddress;
    private ICountry _country;
    private IState _state;
    private IUser _users;

    public IUser Users
    {
        get
        {
            if (_users == null)
            {
                _users = new UserRepository(_context);
            }
            return _users;
        }
    }

    public IAppointment Appointments
    {
        get
        {
            if (_appointment == null)
            {
                _appointment = new AppointmentRepository(_context);
            }
            return _appointment;
        }
    }

    public IBreed Breeds
    {
        get
        {
            if (_breed == null)
            {
                _breed = new BreedRepository(_context);
            }
            return _breed;
        }
    }    

    public ICity Cities
    {
        get
        {
            if (_city == null)
            {
                _city = new CityRepository(_context);
            }
            return _city;
        }
    }

    public ICountry Countries
    {
        get
        {
            if (_country == null)
            {
                _country = new CountryRepository(_context);
            }
            return _country;
        }
    }

    public IPet Pets
    {
        get
        {
            if (_pet == null)
            {
                _pet = new PetRepository(_context);
            }
            return _pet;
        }
    }

    public IPhoneUser PhonesUsers
    {
        get
        {
            if (_phoneuser == null)
            {
                _phoneuser = new PhoneUserRepository(_context);
            }
            return _phoneuser;
        }
    }    

    public IService Services
    {
        get
        {
            if (_service== null)
            {
                _service= new ServiceRepository(_context);
            }
            return _service;
        }
    }

    public IState States
    {
        get
        {
            if (_state == null)
            {
                _state = new StateRepository(_context);
            }
            return _state;
        }
    }

    public IUserAddress UserAddress
    {
        get
        {
            if (_useraddress == null)
            {
                _useraddress = new UserAddressRepository(_context);
            }
            return _useraddress;
        }
    }

    public UnitOfWork(JwtDbContext context)
    {
        _context = context;
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
