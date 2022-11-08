

using bytebank_adm.funcionarios;
using bytebank_adm.Utilitario;
using System.Xml.Schema;

Funcionario pedro = new Funcionario("1321432");
pedro.Nome = "Pedro Guimarães";
pedro.Salario = 2550;

Console.WriteLine(pedro.Nome);
Console.WriteLine("sua bonificação é de: " + pedro.GetBonificacao());

Diretor roberta = new Diretor("9953845");
roberta.Nome = "roberta silva";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine("sua bonificação é de: " + roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("total de bonificação: " + gerenciador.TotalDeBonificacao);
Console.WriteLine("total de funcionarios: " + Funcionario.TotalFuncionarios);