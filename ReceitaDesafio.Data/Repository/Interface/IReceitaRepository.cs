using ReceitaDesafio.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDesafio.Data.Repository.Interface
{
    public interface IReceitaRepository
    {
        Task<Receita> AdicionarReceita(Receita receita);

        Task<List<Receita>> ObterTodasReceitas();
    }
}
