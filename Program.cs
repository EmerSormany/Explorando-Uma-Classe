
using Explorando_Uma_Classe.models;

Console.WriteLine("Hello, World!");

/// classe instanciada com valores passados como argumentos
/// 
Pessoa pessoa_1 = new Pessoa(nome: "Sormany", sobrenome: "Azevedo", idade: 29);
Pessoa pessoa_2 = new Pessoa(nome: "Tássio", sobrenome: "Azevedo", idade: 27);

/// classe instanciada com valores atribuído propriedade por propriedade 
Pessoa pessoa_3 = new Pessoa();
Pessoa pessoa_4 = new Pessoa();
pessoa_3.Nome = "João Paulo";
pessoa_3.Sobrenome = "Fernandes";
pessoa_4.Nome = "Arthur";
pessoa_4.Sobrenome = "De Flávio";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa_1);
cursoDeIngles.AdicionarAluno(pessoa_2);
cursoDeIngles.AdicionarAluno(pessoa_3);
cursoDeIngles.AdicionarAluno(pessoa_4);

cursoDeIngles.ListarAlunos();
