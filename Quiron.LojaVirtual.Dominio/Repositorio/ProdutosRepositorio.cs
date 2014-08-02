using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        public readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produto> Produtos //retorna produto
        {
            get { return _context.Produtos; }
        }

    }
}
