using ReceitaDesafio.Data.Repository.Interface;
using ReceitaDesafio.Dominio.Dominio;
using ReceitaDesafio.Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDesafio.Service.Service
{
    public class ReceitaService : IReceitaService
    {
        private readonly IReceitaRepository _repository;

        public ReceitaService(IReceitaRepository repository)
        {
            _repository = repository;
        }

        public async Task<Receita> AdicionarReceita(Receita receita)
        {
            return await _repository.AdicionarReceita(receita);
        }

        public string DeterminarTurno(DateTime? dataEmissao)
        {
            if (!dataEmissao.HasValue)
                return "Turno indefinido";

            // Lógica real de turno
            return GerarTurno(dataEmissao.Value);
        }

        public string GerarTurno(DateTime dataHora)
        {
            var hora = dataHora.Hour;

            if (hora >= 0 && hora < 6)
                return "Madrugada";
            else if (hora >= 6 && hora < 12)
                return "Manhã";
            else if (hora >= 12 && hora < 18)
                return "Tarde";
            else
                return "Noite";
        }

        public async Task<List<Receita>> ObterTodasReceitas()
        {
            return await _repository.ObterTodasReceitas();
        }
    }
}
