using ReceitaDesafio.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDesafio.Service.Service.Interface
{
    public interface IReceitaService
    {
        Task<Receita> AdicionarReceita(Receita receita);

        string GerarTurno(DateTime dataHora);

        Task<List<Receita>> ObterTodasReceitas();

        string DeterminarTurno(DateTime? dataEmissao)
    }
}
