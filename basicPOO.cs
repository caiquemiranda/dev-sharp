using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threaing.Task;

namespace BasicPOO.NumberOne
{
    public abstract class Pessoa
    {
        public Pessoa(string nome, string documeento, DateTime dataNascimento)
        {
            Nome = nome
            Documento = documeento
            DataNascimento = dataNascimento

        }
        public string Nome {get; protected set;}
        public string Documento {get; protected set;}
        public DateTime DataNascimento {get; protected set;}

        public virtual void SeApresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, Documento {Documento}, Data de Nascimento {DataNascimento}")
        }
    }
}