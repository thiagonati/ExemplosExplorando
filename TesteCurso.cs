using System;
using System.Collections.Generic;
using ExemplosExplorando.Models;

namespace ExemplosExplorando
{
    public class TesteCurso
    {
        public void Executar()
        {
            Console.WriteLine("==== Sistema de Curso ====\n");

            // Criando curso
            Curso cursoDeIngles = new Curso { Nome = "Inglês" };
            Console.WriteLine($"Curso criado: {cursoDeIngles.Nome}\n");

            // Criando alunos usando construtor
            Pessoa aluno1 = new Pessoa("João", "Silva", 30);
            Pessoa aluno2 = new Pessoa("Tiago", "Natividade", 28);
            Pessoa aluno3 = new Pessoa("Maria", "Souza", 25);
            Pessoa aluno4 = new Pessoa("Carla", "Oliveira", 32);
            Pessoa aluno5 = new Pessoa("Rafael", "Costa", 27);
            Pessoa aluno6 = new Pessoa("Ana", "Lima", 22);

            // Adicionando alunos ao curso
            cursoDeIngles.AdicionarAluno(aluno1);
            cursoDeIngles.AdicionarAluno(aluno2);
            cursoDeIngles.AdicionarAluno(aluno3);
            cursoDeIngles.AdicionarAluno(aluno4);
            cursoDeIngles.AdicionarAluno(aluno5);
            cursoDeIngles.AdicionarAluno(aluno6);

            Console.WriteLine("Alunos adicionados com sucesso!\n");

            // Listando alunos
            Console.WriteLine("=== Lista de alunos ===");
            cursoDeIngles.ListarAlunos();

            // Exibindo total de alunos matriculados
            Console.WriteLine($"\nTotal de alunos matriculados: {cursoDeIngles.ObterQuantidadeDeAlunosMatriculados()}");

            // Removendo um aluno
            Console.WriteLine("\nRemovendo aluno: Maria Souza...");
            cursoDeIngles.RemoverAluno(aluno3);

            // Exibindo novamente a lista e quantidade
            Console.WriteLine("\n=== Lista após remoção ===");
            cursoDeIngles.ListarAlunos();
            Console.WriteLine($"\nTotal de alunos agora: {cursoDeIngles.ObterQuantidadeDeAlunosMatriculados()}");

            // Testando método Apresentar de cada aluno
            Console.WriteLine("\n=== Apresentação dos alunos ===");
            foreach (var aluno in cursoDeIngles.Alunos)
            {
                aluno.Apresentar();
            }

            Console.WriteLine("\n==== Teste concluído ====");
        }
    }
}
