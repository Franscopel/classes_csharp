using System;

namespace Aula01Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler a quantidade de alunos
            Console.WriteLine("Digite o numero de alunos curso");
            int alunosCurso = int.Parse(Console.ReadLine());

            //Declarar variáveis
            float totalNotasA = 0;
            float totalNotasB = 0;
            int totalAlunosA = 0;
            int totalAlunosB = 0;

            //Laço repetição com a qtde lida
            for (int i = 0; i < alunosCurso; i++)
            {

                //Ler a turma (A ou B)
                Console.WriteLine("Digite a turma (A ou B)");
                string turma = Console.ReadLine();

                //Ler a nota
                Console.WriteLine("Digite a nota");
                //Parse -> converte uma String para o tipo float
                float nota = float.Parse(Console.ReadLine());

                //Somar a nota no total de notas da turma
                //Adicionar mais um no contador do aluno da turma
                switch (turma)
                {
                    case "A":
                        totalAlunosA++;
                        totalNotasA += nota;
                        break;
                    case "B":
                        totalAlunosB++;
                        totalNotasB += nota;
                        break;
                    default:
                        Console.WriteLine("Turma inválida");
                        i--; //decrementa em um contador do laço
                        break;
                } //switch
            } //for

            //Fora do laço de repetição
            //Calcular as medias e exibir o resultado
            Console.WriteLine($"A média da turma A é {totalNotasA / totalAlunosA}");
            Console.WriteLine($"A média da turma B é {totalNotasB / totalAlunosB}");
            Console.WriteLine($"A média do curso é {(totalNotasA + totalNotasB) / (totalAlunosA + totalAlunosB)}");
        }
    }
}
