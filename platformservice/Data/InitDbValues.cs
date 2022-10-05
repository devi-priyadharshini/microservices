using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using platformservice.Model;
using System;

namespace platformservice.Data
{

    public static class InitDbValues
    {

        // Find App Builder
        // Find IServiceScope

        public static void PopulateData(IApplicationBuilder appBuilder)
        {
            using (var scope = appBuilder.ApplicationServices.CreateScope())
            {
                SeedData(scope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext dbContext)
        {
            if (dbContext.Platforms.Count() > 0)
                return;

            dbContext.Platforms.AddRange(Data);
            dbContext.SaveChanges();
        }

        private static IEnumerable<Platform> Data
        {
            get
            {
                return new List<Platform>(){
                new Platform(){Name=".Net", Publisher="Microsoft", Cost="Free"},
                new Platform(){Name="Kafka", Publisher="Confluent", Cost="Free"},
                new Platform(){Name="SQL Server", Publisher="Microsoft", Cost="Free"},
                new Platform(){Name="Docker", Publisher="Docker Org", Cost="Free"},
            };
            }
        }
    }
}