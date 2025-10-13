using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDesafio.Data.AutoMapper
{
    public class ReceitaProfile : Profile 
    {
        public ReceitaProfile()
        {
            CreateMap<ReceitaDesafio.Dominio.Dominio.Receita, DTO.ReceitaDTO>().ReverseMap();
        }
    }
}
