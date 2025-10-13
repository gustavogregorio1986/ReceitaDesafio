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
    }
}
