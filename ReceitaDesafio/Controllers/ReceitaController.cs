using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReceitaDesafio.Data.DTO;
using ReceitaDesafio.Dominio.Dominio;
using ReceitaDesafio.Service.Service;
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

        [HttpPost("AdicionarReceita")]
        public async Task<IActionResult> AdicionarReceita([FromBody] ReceitaDTO receitaDTO)
        {
            if (receitaDTO == null)
                return BadRequest("Dados da receita não foram fornecidos.");

            var receitaMapeada = _mapper.Map<Receita>(receitaDTO);

            receitaMapeada.Turno = _receitaService.DeterminarTurno(receitaMapeada.DataEmissao);

            var receitaSalva = await _receitaService.AdicionarReceita(receitaMapeada);

            var receitaRetorno = _mapper.Map<ReceitaDTO>(receitaSalva);

            return Ok(receitaRetorno);
        }


        [HttpGet]
        [Route("ObterTodasReceitas")]
        public async Task<IActionResult> ObterTodasReceitas()
        {
            var receitas = await _receitaService.ObterTodasReceitas();
            var receitasDTO = _mapper.Map<List<ReceitaDTO>>(receitas);
            return Ok(receitasDTO);
        }
    }
}
