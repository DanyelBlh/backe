using Microsoft.EntityFrameworkCore;
using TESTE.models;

namespace TESTE.Data;

public class AppDataContext: DbContext {

    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) 
    {}
       
        public DbSet<Cliente> Clientes {get; set;}

    
}