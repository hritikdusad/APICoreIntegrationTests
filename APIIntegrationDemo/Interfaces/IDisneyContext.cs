using System.Threading;
using System.Threading.Tasks;
using APIIntegrationDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIIntegrationDemo.Interfaces
{
    public interface IDisneyContext
    {
        void SeedFakeDatabase();
        DbSet<Attraction> Attraction { get; set; }
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken);
    }
}