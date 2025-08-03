using Resume.Presenation.Models.ResumeDbContext;
using Reume.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly ResumeDbContext _context;
    public UnitOfWork(ResumeDbContext context)
    {
        _context = context;
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}
