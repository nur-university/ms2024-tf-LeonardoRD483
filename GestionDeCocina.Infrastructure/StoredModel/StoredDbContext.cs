using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Infrastructure.StoredModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCocina.Infrastructure.StoredModel
{
    internal class StoredDbContext: DbContext
    {
        public DbSet<IngredienteStoredModel> Ingrediente{ get; set; }
        
        public StoredDbContext(DbContextOptions<StoredDbContext> options) : base(options) { 
        }
    }
}
