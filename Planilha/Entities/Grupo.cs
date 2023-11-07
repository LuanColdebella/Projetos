using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilha.Entities
{
    class Grupo
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal Subtotal { get; set; }
        public List<SubGrupos> SubGrupos { get; private set; } = new List<SubGrupos>();

        public Grupo(string descricao)
        {
            Descricao = descricao;
        }

        public decimal ValorTotal()
        {
            decimal soma = 0;

            foreach (var subGrupos in SubGrupos)
                soma += subGrupos.Valor;

            return soma;
        }

        public void AdicionarSubGrupo(SubGrupos subGrupos)
        {
            foreach (var item in SubGrupos)
            {
                if (item.Descricao == subGrupos.Descricao)
                {
                    int posicao = SubGrupos.IndexOf(item);

                    SubGrupos[posicao].Valor += subGrupos.Valor;
                    return;
                }
            }

            SubGrupos.Add(subGrupos);
        }

        public void RemoverSubGrupo(string descrica)
        {
            foreach (var item in SubGrupos)
            {
                if (item.Descricao == descrica)
                {
                    SubGrupos.Remove(item);
                    return;
                }
            }
        }

        public string MostrarNaTela()
        {
            var sb = new StringBuilder();

            foreach (var item in SubGrupos)
            {
                sb.AppendLine("Descrição: " + item.Descricao + " Valor: $ " + item.Valor.ToString("N2"));   
            }

            return sb.ToString();
        }
    }
}
