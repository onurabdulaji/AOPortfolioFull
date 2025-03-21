using AOPortfolioFull.Domain.Entities;
using AOPortfolioFull.Domain.Interfaces.IRepositories.IAboutRepositories.WriteRepository;
using AOPortfolioFull.Persistence.Context.Data;
using AOPortfolioFull.Persistence.Repositories.WriteRepository;

namespace AOPortfolioFull.Persistence.Repositories.Concretes.AboutRepositories.WriteRepository;

public class AboutWriteRepository : WriteRepository<About>, IAboutWriteRepository
{
    public AboutWriteRepository(AppDbContext context) : base(context)
    {
    }
    public async Task<About> ChangeStatus(Guid id)
    {
        var about = await _context.Abouts.FindAsync(id);
        if (about == null)
        {
            throw new KeyNotFoundException("About entity not found.");
        }

        about.IsActive = !about.IsActive;
        if (about.IsActive)
        {
            about.ModifiedDate = DateTime.UtcNow;
        }
        else
        {
            about.DeletedDate = DateTime.UtcNow;
        }

        _context.Abouts.Update(about);
        await _context.SaveChangesAsync();
        return about;
    }

    public async Task<About> CreateAbout(About createAbout)
    {
        await _context.Abouts.AddAsync(createAbout);
        await _context.SaveChangesAsync();
        return createAbout;
    }

    public async Task<About> DeleteAbout(Guid Id)
    {
        var about = await _context.Abouts.FindAsync(Id);
        if (about == null)
        {
            throw new KeyNotFoundException("About entity not found.");
        }

        _context.Abouts.Remove(about);
        await _context.SaveChangesAsync();
        return about;
    }

    public async Task<About> UpdateAbout(About updateAbout)
    {
        var about = await _context.Abouts.FindAsync(updateAbout.Id);
        if (about == null) throw new KeyNotFoundException("About entity not found.");
        if (updateAbout.Age <= 10) throw new ArgumentException("Age must be greater than 10.");
       
        _context.Entry(about).CurrentValues.SetValues(updateAbout);
        _context.Entry(about).Entity.ModifiedDate = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return updateAbout;
    }
}
