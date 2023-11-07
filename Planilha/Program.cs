using Planilha.Entities;

Planilhas receita = new Planilhas("Receitas", DateTime.Now.Year);

Console.WriteLine("----------------------------------------");
Console.WriteLine("            "+receita.Descricao + " " + receita.Ano);
Console.WriteLine("----------------------------------------");

Grupo grupo = receita.AdicionarGrupo(new Grupo("Receita"));

grupo.AdicionarSubGrupo(new SubGrupos("Salario jeni", 10));
grupo.AdicionarSubGrupo(new SubGrupos("Salario Luan", 10));

Grupo grupo2 = receita.AdicionarGrupo(new Grupo("Despesas"));
grupo2.AdicionarSubGrupo(new SubGrupos("Salario jeni", 10));
grupo2.AdicionarSubGrupo(new SubGrupos("Salario Luan", 10));


    Console.WriteLine(receita.MostrarNaTela());



Console.WriteLine(receita);
Console.ForegroundColor = ConsoleColor.White;


