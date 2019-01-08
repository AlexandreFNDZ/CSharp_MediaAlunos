using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_CalculoMedia
{
    /// <summary>
    /// Criar Lista de Alunos e Calcular a média da turma.
    /// </summary>
    public class TurmaDeAlunos
    {
        private Aluno[] _aluno;
        private double totalMedia;
        private int _proximaPosicao;

        /// <summary>
        /// Construtor para criar um Array de objetos, do tipo <see cref="Aluno"/>, com <paramref name="tamanhoInicial"/> informado ou padrão (5 slots).
        /// </summary>
        /// <param name="tamanhoInicial">Parâmetro opcional de tamanho inicial do array da turma de alunos.</param>
        public TurmaDeAlunos(int tamanhoInicial = 5)
        {
            _aluno = new Aluno[tamanhoInicial];
            _proximaPosicao = 0;
        }

        /// <summary>
        /// Adicionar o objeto <see cref="Aluno"/> cadastrado no slot disponível da lista <see cref="TurmaDeAlunos"/>.
        /// </summary>
        /// <param name="aluno">Parâmetro objeto do tipo <see cref="Aluno"/> que será incluído na lista <see cref="TurmaDeAlunos"/>.</param>
        public void Adicionar(Aluno aluno)
        {
            Console.WriteLine($"Adicionando aluno na posição {_proximaPosicao}");

            VerificarCapacidade(_proximaPosicao + 1);

            _aluno[_proximaPosicao] = aluno;
            _proximaPosicao++;

        }

        /// <summary>
        /// Verificar se existe slot vazio para o cadastro de <see cref="Aluno"/> novo. Criar o espaço necessário, caso a lista esteja toda ocupada.
        /// </summary>
        /// <param name="tamanhoNecessário">Parâmetro que determina o tamanho necessário da lista <see cref="TurmaDeAlunos"/>.</param>
        public void VerificarCapacidade(int tamanhoNecessário)
        {
            if (_aluno.Length < tamanhoNecessário)
            {
                int tamanhoIdeal = _aluno.Length * 2;

                if (tamanhoIdeal < tamanhoNecessário)
                {
                    tamanhoIdeal = tamanhoNecessário;
                }

                Aluno[] _novoArray = new Aluno[tamanhoIdeal];

                for (int indice = 0; indice < _aluno.Length; indice++)
                {
                    _novoArray[indice] = _aluno[indice];
                }

                _aluno = _novoArray;
            }
             
        }

        /// <summary>
        /// Calcular a Media da Turma toda, ou seja, todos os alunos da <see cref="TurmaDeAlunos"/>.
        /// </summary>
        /// <returns>Retorna a Média da turma.</returns>
        public double MediaTurma()
        {
            int indice = 0;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                totalMedia += _aluno[indice].Media;
                indice = i + 1;
            }

            totalMedia = totalMedia / indice;

            return totalMedia;
        }

        /// <summary>
        /// Retornar o número total de objetos contidos na lista.
        /// </summary>
        /// <returns>Retorna um valor inteiro que representa o total de Alunos cadastrados na <see cref="TurmaDeAlunos"/>.</returns>
        public int GetTotalAlunos()
        {
            return _proximaPosicao;
        }

        /// <summary>
        /// Indexador de acesso aos itens do array <see cref="_aluno"/>.
        /// </summary>
        /// <param name="indice">Parâmetro que indica qual indice da lista que deseja informações.</param>
        /// <returns>Retorna valor correspondente ao <paramref name="indice"/> correspondente no array <see cref="_aluno"/>.</returns>
        public Aluno this[int indice]
        {
            get
            {
                return _aluno[indice];
            }
        }
    }
}
