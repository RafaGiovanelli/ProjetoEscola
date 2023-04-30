using CadastroDeAlunos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAlunos
{
    public class MediaAluno
    {
        public void Media()
        {
            Console.Clear();

            Console.Write("Insira a quantidade de notas: ");
            var quantDeNotas = Convert.ToInt32(Console.ReadLine());
            var listaDeNotas = new List<double>();
            double media = 0;

            for (int i = 1; i <= quantDeNotas; i++)
            {
                Console.Write($"Insira a nota {i}: ");
                double coletaNota = Convert.ToDouble(Console.ReadLine());

                listaDeNotas.Add(coletaNota);
            }

            foreach (var item in listaDeNotas)
            {
                media += item;
            }

            Console.WriteLine($"\nMedia do aluno: {media / quantDeNotas} \n");

        }
    }
}
