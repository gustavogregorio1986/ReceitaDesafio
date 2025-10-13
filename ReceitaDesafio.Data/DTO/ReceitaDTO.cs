using ReceitaDesafio.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDesafio.Data.DTO
{
    public class ReceitaDTO
    {
        public int Id { get; set; }

        public string? NomeCliente { get; set; }

        public decimal? Valor { get; set; }

        public Situacao? Situacao { get; set; }

        public string? Descricao { get; set; }

        public DateTime? DataEmissao { get; set; }

        public string? Turno { get; set; }
    }
}
