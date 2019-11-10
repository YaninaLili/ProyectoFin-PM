using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFin_PM.Models
{
    public class VidaSaludableContext : IdentityDbContext
    {
   
        public VidaSaludableContext(DbContextOptions<VidaSaludableContext> o) : base(o)
        {

        }
    }
}