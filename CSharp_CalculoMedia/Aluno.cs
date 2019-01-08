using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CalculoMedia
{
    /// <summary>
    /// Cadastrar Aluno recebendo como parâmetros o e as notas parciais do aluno e Calcular a Média.
    /// </summary>
    public class Aluno
    {
        /// <summary>
        /// Propriedade <see cref="Nome"/> do aluno.
        /// </summary>
        public string Nome { get; }
        /// <summary>
        /// Propriedade Nota da <see cref="P1"/> do aluno.
        /// </summary>
        public double P1 { get; set; }
        /// <summary>
        /// Propriedade Nota da <see cref="P2"/> do aluno.
        /// </summary>
        public double P2 { get; set; }
        /// <summary>
        /// Propriedade <see cref="Media"/> das notas da <see cref="P1"/> e <see cref="P2"/> do aluno.
        /// </summary>
        public double Media { get; }

        /// <summary>
        /// Construtor de cadastro e cálculo de <see cref="Media"/> do aluno.
        /// </summary>
        /// <param name="nome">Parâmetro que recebe o Nome do aluno.</param>
        /// <param name="p1">Parâmetro que recebe a nota da P1 do aluno.</param>
        /// <param name="p2">Parâmetro que recebe a nota da P2 do aluno.</param>
        public Aluno(string nome, double p1, double p2)
        {
            Nome = nome;
            P1 = p1;
            P2 = p2;

            Media = (P1 + P2) / 2;
        }
    }
}
