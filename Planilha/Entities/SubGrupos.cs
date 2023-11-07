using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilha.Entities
{
    class SubGrupos
    {
        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public SubGrupos(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

    }
}
