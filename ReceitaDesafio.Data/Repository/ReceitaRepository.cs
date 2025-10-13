using ReceitaDesafio.Data.Data;
using ReceitaDesafio.Data.Repository.Interface;
using ReceitaDesafio.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDesafio.Data.Repository
{
    public class ReceitaRepository : IReceitaRepository
    {
        private readonly ReceitaDesafioContext _context;

        public ReceitaRepository(ReceitaDesafioContext context)
        {
            _context = context;
        }

        public async Task<Receita> AdicionarReceita(Receita receita)
        {
            await _context.AddAsync(receita);
            await _context.SaveChangesAsync();
            return receita;
        }
    }
}
