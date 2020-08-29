using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ttp.EfCore.Web.Infrastructure
{
    public class Seeder : ISeeder
    {
        private readonly IServiceProvider _serviceProvider;

        public Seeder(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void InitDatabase()
        {
            var dbContext = _serviceProvider.GetService<ApplicationDbContext>();
            using (var context = dbContext)
            {
                context.Database.Migrate();
            }
        }
    }
}
