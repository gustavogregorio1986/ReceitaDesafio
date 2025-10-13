using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReceitaDesafio.Data.DTO;
using ReceitaDesafio.Dominio.Dominio;
using ReceitaDesafio.Service.Service.Interface;

namespace ReceitaDesafio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitaController : ControllerBase
    {
        private readonly IReceitaService _receitaService;
        private readonly IMapper _mapper;

        public ReceitaController(IReceitaService receitaService, IMapper mapper)
        {
            _receitaService = receitaService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("AdicionarReceita")]
        public async Task<JsonResult> AdicionarReceita(ReceitaDTO receitaDTO)
        {
            var receita = new ReceitaDTO()
            {
                NomeCliente = receitaDTO.NomeCliente,
                Valor = receitaDTO.Valor,
                Descricao = receitaDTO.Descricao,
                Situacao = receitaDTO.Situacao,
                DataEmissao = receitaDTO.DataEmissao,
                Turno = receitaDTO.Turno
            };

            return new JsonResult(receita);
        }
    }
}
