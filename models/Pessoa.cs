using System;

namespace Explorando_Uma_Classe.models
{
    public class Pessoa
    {
        /// construtores da classe, permitindo instanciar com ou sem valores passados como argumentos
        public Pessoa(){}
        public Pessoa(string nome, string sobrenome, int idade){
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        /// campos privados criados, que armazenam os valores passados na propriedades e que somente a classe
        /// pode manipular
        private string? _nome;
        private string? _sobrenome;
        private int _idade;
        public string? Nome { 
            /// body expression, retorna o valor do nome
            get => _nome;

            /// mecanismo criado para validar que o usuário não passe uma string vazia
            set{
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                /// se passar pela validação o valor é guardado no campo _nome
                _nome = value;
            } 
        }

        public string? Sobrenome { 
            /// body expression, retorna o valor do campo sobrenome
            get => _sobrenome;
            /// mecanismo criado para validar que o usuário não passe uma string vazia
            set{
                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }
                /// se passar pela validação o valor é guardado no campo sobrenome
                _sobrenome = value;
            } 
            }
        public string? NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); 
        public int Idade { 
            /// body expression, retorna o valor do campo idade
            get => _idade; 
            /// mecanismo criado para validar que o usuário não passe valor negativo para a idade
            set{
                if (value < 0)
                {
                    throw new AggregateException("A idade não pode ser menor que zero");
                }
                /// se passar pela validação o valor é guardado no campo idade
                _idade = value;
            } }

        /// método que faz a aprensetação da pessoa, exibindo no console seu nome completo e sua idade
        public void Apresentar()
        {
            Console.WriteLine($"Nome é {NomeCompleto}, idade é {Idade}");
        }
    }
}
