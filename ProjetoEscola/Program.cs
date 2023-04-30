using Arquivo;
using CadastroDeAlunos;
using CadastroDeAlunos.Modelos;
using CadastroDeEscola;
using CadastroDeEscola.Modelos;
using Professores.Modelos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Olá, seja bem vindo ao cadastro do Aluno e Escola.\n");

        bool menu = true;
        //Contador de operações
        var listaOperacoes = 0;
        var listaAluno = new List<Aluno>();
        var listaEscola = new List<Escola>();
        var listaProfessor = new List<Professor>();

        while (menu)
        {
            Console.WriteLine("Pressione (1) para cadastrar Aluno. \n");
            Console.WriteLine("Pressione (2) para cadastrar Escola. \n");
            Console.WriteLine("Pressione (3) para cadastrar Professor. \n");
            Console.WriteLine("Pressione (4) para calcular Média. \n");
            Console.WriteLine("Pressione (5) para listar Alunos cadastrados. \n");
            Console.WriteLine("Pressione (6) para listar Escolas cadastradas. \n");
            Console.WriteLine("Pressione (7) para listar Professores cadastrados. \n");
            Console.WriteLine("Pressione (8) para ler arquivo Aluno CSV. \n");
            Console.WriteLine("Pressione (9) para ler arquivo Aluno JSON. \n");
            Console.WriteLine("Pressione (10) para gera arquivo CSV. \n");
            Console.WriteLine("Pressione (11) para gera arquivo JSON. \n");

            var cadastro = Convert.ToInt32(Console.ReadLine());

            switch (cadastro)
            {
                case 1:
                    listaAluno = CadastroAluno(listaAluno);
                    //EX: Estou chamando o metodo CadastroAluno e esperando um retorno e passando um PARAMETRO para ele utilizar dentro do codigo, sendo necessario somento preencher dentro
                    //do parenteses com o nome da VARIAVEL.
                    break;
                case 2:
                    listaEscola = new Escolas().CadastroEscola(listaEscola);
                    break;
                case 3:
                    new CadastroProfessores().CadastroProfessor(listaProfessor);
                    break;
                case 4:
                    new MediaAluno().Media();
                    break;
                case 5:
                    new Alunos().ListaAluno(listaAluno);
                    break;
                case 6:
                    new Escolas().ListaEscola(listaEscola);
                    break;
                case 7:
                    new CadastroProfessores().ListaProfessores(listaProfessor);
                    break;
                case 8:
                    listaAluno = new LerArquivo().LerArquivosAlunosCSV(listaAluno);
                    break;
                case 9:
                    listaAluno = new LerArquivo().LerArquivoAlunoJSON(listaAluno);
                    break;
                case 10:
                    new GeraArquivo().GeraArquivosAlunoCSV(listaAluno);
                    break;
                case 11:
                    new GeraArquivo().GerarArquivosAlunoJSON(listaAluno);
                    break;
                default:
                    Console.WriteLine("Numero incorreto. Favor digitar um numero valido.");
                    break;
            }
            //Contador de operações
            listaOperacoes++;

            Console.WriteLine("\nCadastro concluido. Deseja realizar uma nova ação?\n");
            Console.WriteLine("1 - Sim | 0 - Não \n");
            var cadastradoTotal = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (cadastradoTotal == 0)
            {
                Console.WriteLine($"\nContador de execuções: {listaOperacoes}. Tecle Enter para sair...");
                Console.ReadLine();
                menu = false;
            }
        }
    }

    public static List<Aluno> CadastroAluno(List<Aluno> listaAlunos)
    //Dentro do parametro eu coloco o TIPO e o PARAMETRO(VARIAVEL). EX: INT A.
    //Quando for passar para onde esta chamando, passar apenas o NOME DA VARIAVEL ou VALOR.
    {
        Console.Clear();

        Console.WriteLine("Por favor, insira as informações do aluno abaixo:\n");

        string execucaoCadastro = @"- Nome do Aluno
- Idade
- Matricula
- Serie";
        Console.WriteLine($"{execucaoCadastro}\n");

        Console.Write("Insira o nome do aluno: ");
        var nomeAluno = Convert.ToString(Console.ReadLine());
        Console.Write($"\n");
        Console.Write("Insira a idade do aluno: ");
        var idadeAluno = Convert.ToInt32(Console.ReadLine());
        Console.Write($"\n");
        Console.Write("Insira a matricula do aluno: ");
        var matriculaAluno = Convert.ToInt32(Console.ReadLine());
        Console.Write($"\n");
        Console.Write("Insira a série do aluno: ");
        var serieAluno = Convert.ToString(Console.ReadLine());
        Console.Write($"\n");

        var aluno = new Aluno();
        //Aluno = MODELO / .NOME = PROPRIEDADE DO MODELO. Ou seja, aluno.nome = Nome do aluno, caso ele precise de outra informação, ele colocaria aluno.XXX a informação que ele precisa.
        aluno.Nome = nomeAluno;
        aluno.Idade = idadeAluno;
        aluno.Matricula = matriculaAluno;
        aluno.Serie = serieAluno;

        listaAlunos.Add(aluno);


        return listaAlunos;
        //Retornou como LISTA(Difinido ao lado do metodo) la para o CASE 1 e utilizando o paramentro preenchido dentro do parenteses para receber a informação e passar para a variavel
        //ListaAlunos que esta aguardando para ser preenchida.

        //new Alunos().ListaAluno(nomeAluno, idadeAluno, matriculaAluno, serieAluno);
    }
}