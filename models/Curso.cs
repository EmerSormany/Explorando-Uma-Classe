using System;

namespace Explorando_Uma_Classe.models
{
    public class Curso
    {
          public string? Nome { get; set; }
        /// cria uma lista do tipo Pessoa
        public List<Pessoa> Alunos { get; set; }
        /// adiciona um aluno à lista
        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }
        /// remove um aluno da lista
        public bool RemoverAluno(Pessoa aluno){
            /// o tipo retornado pelo método precisa ser igual ao tipo que o método é declarado
            return Alunos.Remove(aluno);
            /// método Remove retorna um booleano
        }
        /// obtém a quantidade de alunos da lista
        public int QuantidadeDeAlunos(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
        /// obtém os alunos registrados na lista
        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso de {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}
