using ReceitaDesafio.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDesafio.Dominio.Dominio
{
    public class Receita
    {
        public int Id { get; set; }

        public string? NomeCliente { get; set; }

        public decimal? Valor { get; set; }

        public Situacao? Situacao { get; set; }

        public string? Descricao { get; set; }

        public DateTime? DataEmissao { get; set; }
    }
}
