using M01S09.Aula01.Models;
using Microsoft.EntityFrameworkCore;

namespace M01S09.Aula01
{
    public class LojaContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }


    }
}
