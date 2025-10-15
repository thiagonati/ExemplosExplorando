using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public Pessoa (){

        }

        public Pessoa (string nome, string sobrenome, int idade){
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("O nome deve ter pelo menos 3 caracteres.");
                }

                _nome = value;
            }
        }

        public string Sobrenome
        {
            get;
            set;
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }

                _idade = value;
            }
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}