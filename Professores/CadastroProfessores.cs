using Professores.Modelos;
using System.Runtime.CompilerServices;

public class CadastroProfessores
{
    public List<Professor> CadastroProfessor(List<Professor> listaProfessor)
    {
        Console.Write("Insira o nome do Professor: ");
        var nomeProfessor = Console.ReadLine();
        Console.WriteLine("\n");
        Console.Write("Insira a Materia do Professor: ");
        var materiaProfessor = Console.ReadLine();
        Console.WriteLine("\n");
        Console.Write("Insira a Matricula do Professor: ");
        var matriculaProfessor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");

        var professor = new Professor();

        professor.Nome = nomeProfessor;
        professor.Materia = materiaProfessor;
        professor.Matricula = matriculaProfessor;

        listaProfessor.Add(professor);

        return listaProfessor;
    }

    public List<Professor> ListaProfessores(List<Professor> listaProfessor)
    {
        var contadorProfessor = 1;

        Console.Clear();

        foreach (var item in listaProfessor)
        {
            Console.WriteLine($"Professor Cadastrado {contadorProfessor} \n");
            Console.WriteLine($"Nome do Professor: {item.Nome}\n");
            Console.WriteLine($"Materia do Professor: {item.Materia} \n");
            Console.WriteLine($"Matricula do Professor: {item.Matricula} \n");
            Console.WriteLine($"*******************************************************");

            contadorProfessor++;
        }

        return listaProfessor;
    }
}