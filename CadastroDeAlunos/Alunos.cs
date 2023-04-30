using CadastroDeAlunos.Modelos;
using System.Runtime.Serialization;

namespace CadastroDeAlunos
{
    public class Alunos
    {
        public void ListaAluno(List<Aluno> lista)
            //Dentro do parametro = O tipo que eu vou receber + o nome do parametro.
        //Estou recebendo o List<Aluno> do metodo principal ja preenchido com as informações que eu cadastrei.
        //E atribuindo na variavel LISTA, para ser lido pelo FOREACH.
        {
            var contadorAlunos = 1;

            Console.Clear();

            foreach (var item in lista)
            {
                Console.WriteLine($"Aluno cadastrado {contadorAlunos}:\n");
                Console.WriteLine($"Nome do aluno: {item.Nome}\n");
                Console.WriteLine($"Idade do aluno: {item.Idade} \n");
                Console.WriteLine($"Matricula do aluno: {item.Matricula}\n");
                Console.WriteLine($"Série do aluno: {item.Serie}\n");
                Console.Write("******************************************************* \n");

                contadorAlunos++;
            }
        }
    }
}

//Public = Publico
//int = O que retorna, no caso um valor inteiro
//Nome do metodo
//Dentro do parenteses = Parametro - Variaveis que o Metodo irá utilizar para realizar o algoritmo.
//        public int CalculoSoma(int a, int b)
//        {
//            var soma = a + b;
//            return soma;
//        }
