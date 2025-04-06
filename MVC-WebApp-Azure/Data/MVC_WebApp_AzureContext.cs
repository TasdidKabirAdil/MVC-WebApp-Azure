using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MVC_WebApp_Azure.Data
{
    public class MVC_WebApp_AzureContext : DbContext
    {
        public MVC_WebApp_AzureContext (DbContextOptions<MVC_WebApp_AzureContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
