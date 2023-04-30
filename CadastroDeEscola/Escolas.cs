using CadastroDeEscola.Modelos;

namespace CadastroDeEscola
{
    public class Escolas
    {
        public List<Escola> CadastroEscola(List<Escola> listaEscola)
        {
            Console.Clear();

            Console.Write("Insira o nome da Escola: ");
            var nomeEscola = Console.ReadLine();
            Console.Write($"\n");
            Console.Write("Insira o logradouro da Escola: ");
            var logradouroEscola = Console.ReadLine();
            Console.Write($"\n");
            Console.Write("Insira o numero da Escola: ");
            var numeroEscola = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\n");
            Console.Write("Insira o bairro da Escola: ");
            var bairroEscola = Console.ReadLine();
            Console.Write($"\n");
            Console.Write("Insira a capacidade da Escola: ");
            var capacidadeEscola = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\n");

            var escola = new Escola();

            escola.Nome = nomeEscola;
            escola.Logradouro = logradouroEscola;
            escola.Numero = numeroEscola;
            escola.Bairro = bairroEscola;
            escola.Capacidade = capacidadeEscola;

            listaEscola.Add(escola);

            return listaEscola;

        }

        public List<Escola> ListaEscola(List<Escola> listaEscola)
        {
            var contadorEscola = 1;

            Console.Clear();

            foreach (var item in listaEscola)
            {
                Console.WriteLine($"Escola cadastrada {contadorEscola}: \n");
                Console.WriteLine($"Nome da Escola: {item.Nome}\n");
                Console.WriteLine($"Logradouro da Escola: {item.Logradouro}\n");
                Console.WriteLine($"Numero da Escola: {item.Numero}\n");
                Console.WriteLine($"Bairro da Escola: {item.Bairro}\n");
                Console.WriteLine($"Capacidade da Escola: {item.Capacidade}\n");
                Console.Write("******************************************************* \n");

                contadorEscola++;
            }

            return listaEscola;
        }
    }
}