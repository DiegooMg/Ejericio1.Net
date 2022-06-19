using Comenzando.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Comenzando.DataAccess
{
    public class ComenzandoDBContext : DbContext
    {
        public ComenzandoDBContext(DbContextOptions<ComenzandoDBContext> options): base(options)
        {

        }
        //Agregar DbSets (Tablas para la Data Base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
    }
}
