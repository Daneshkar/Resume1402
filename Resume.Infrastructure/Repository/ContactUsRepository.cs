using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Presenation.Models.ResumeDbContext;

namespace Resume.Infrastructure.Repository;

public class ContactUsRepository : IContactUsRepository
{
    #region Ctor

    private readonly ResumeDbContext _context;

    public ContactUsRepository(ResumeDbContext Context)
    {
        _context = Context;
    }

    #endregion

    public async Task AddContactUsToTheDataBase(ContactUs contact)
    {
        await _context.ContactUs.AddAsync(contact);
        await _context.SaveChangesAsync();
    }

    public async Task AddLocationToTheDataBase(ContactUsLocation location)
    {
        await _context.locations.AddAsync(location);
        await _context.SaveChangesAsync();
    }
}
