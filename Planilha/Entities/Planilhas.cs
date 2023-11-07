
using System.Text;

namespace Planilha.Entities
{
    class Planilhas
    {
        public string Descricao { get; set; }
        public int Ano { get; set; }
        private List<Grupo> Grupos { get; set; } = new List<Grupo>();

        public Planilhas(string descricao, int ano)
        {
            Descricao = descricao;
            Ano = ano;
        }

        public decimal ValorTotal()
        {
            decimal soma = 0;

            foreach (var grupo in Grupos)
            {
                soma += grupo.ValorTotal();
            }

            return soma;
        }

        public Grupo AdicionarGrupo(Grupo grupo)
        {
            foreach (var item in Grupos)
            {
                if (item.Descricao == grupo.Descricao)
                {
                    int posicao = Grupos.IndexOf(item);

                    Grupos[posicao].Valor += grupo.Valor;
                    return grupo;
                }
            }

            Grupos.Add(grupo);
            return grupo;
        }



        public void RemoverGrupo(string descrica)
        {
            foreach (var item in Grupos)
            {
                if (item.Descricao == descrica)
                {
                    Grupos.Remove(item);
                    return;
                }
            }
        }

        public string MostrarNaTela()
        {
            var sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");

            foreach (var grupos in Grupos)
            {
                sb.AppendLine($"            -Grupo: {grupos.Descricao}-");


                foreach (var item in grupos.SubGrupos)
                {
                    sb.Append($"Descrição: {item.Descricao} ");
                    sb.Append($"Valor: $ {item.Valor} ");
                    sb.AppendLine();
                }
            }
            sb.AppendLine("----------------------------------------");
            return sb.ToString();
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return "A soma de toda a planilha $" + ValorTotal().ToString("N2");
        }
    }
}
