using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CalculoMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            TurmaDeAlunos turma = new TurmaDeAlunos();

            turma.Adicionar(new Aluno("Ana", 10, 10));
            turma.Adicionar(new Aluno("Beatriz", 5, 8));
            turma.Adicionar(new Aluno("Carlos", 2, 7));
            turma.Adicionar(new Aluno("Daniel", 5, 5));
            turma.Adicionar(new Aluno("Elena", 8, 7));
            turma.Adicionar(new Aluno("Fabiana", 6, 8));
            turma.Adicionar(new Aluno("Gabriel", 8, 9));
            turma.Adicionar(new Aluno("Heitor", 10, 9));

            for (int i = 0; i < turma.GetTotalAlunos(); i++)
            {
                Console.Write($"\nAluno: {turma[i].Nome} | P1: {turma[i].P1} | P2: {turma[i].P2} | Média: {turma[i].Media}");
            }
            
            Console.WriteLine($"\n\n\nMédia da turma: {turma.MediaTurma()}");
            
            Console.ReadLine();
        }
    }
}
