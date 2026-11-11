

using System.Net.Http.Headers;
using Exercicios;

// EXERCICIO 1

// Veiculo carro = new Carro("Fiat", "Fiat Uno", 4);
// Veiculo motocicleta = new Motocicleta("Fiat", "Moto3000", 220);

// carro.exibirInformacoes();
// motocicleta.exibirInformacoes();

// EXERCICIO 2

// Ebook ebook = new Ebook("HelloWorlds", 200, 60);
// CursoOnline curso = new CursoOnline("Python Iniciante", 300, 50);

// Console.WriteLine($"Nome Ebook: {ebook.nome} | Preço: {ebook.preco} | Páginas: {ebook.quantidadePaginas}");
// Console.WriteLine($"Nome Curso: {curso.nome} | Preço: {curso.preco} | Carga Horária: {curso.cargaHoraria}");


// EXERCICIO 3

// JogoDigital jogo1 = new JogoDigital("Spider Man", "Playstation 5", 45);
// JogoFisico jogo2 = new JogoFisico("Naruto Storm 4", "Xbox One S", 50);

// jogo1.exibirInformacoes();
// jogo2.exibirInformacoes();

// EXERCICIO 4

// NotificacaoEmail mensagem1 = new NotificacaoEmail();
// NotificacaoPush mensagem2 = new NotificacaoPush();
// NotificacaoSMS mensagem3 = new NotificacaoSMS();

// mensagem1.Enviar();
// mensagem2.Enviar();
// mensagem3.Enviar();

// EXERCICIO 5

// Entrega e1 = new EntregaEconomica(20);
// Entrega e2 = new EntregaExpressa(20);
// Entrega r = new RetiradaLocal(20);

// List<Entrega> entregas = new List<Entrega>();

// entregas.Add(e1);
// entregas.Add(e2);
// entregas.Add(r);

// foreach(Entrega entrega in entregas)
// {
//     System.Console.WriteLine($"Valor Frete: {entrega.CalcularFrete()}");
// }

// EXERCICIO 6

Relatorio relatorio = new Relatorio();
relatorio.Exportar();
relatorio.imprimir();

Contrato contrato = new Contrato();
contrato.imprimir();