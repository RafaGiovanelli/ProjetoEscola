using CadastroDeAlunos.Modelos;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net;
using System.Reflection.PortableExecutable;

namespace Arquivo
{
    public class LerArquivo
    {
        public List<Aluno> LerArquivosAlunosCSV(List<Aluno> listaAluno)
        {
            Console.Clear();

            #region Dependencias a ser instaladas vias NUGET
            //Microsoft.Extensions.Configuration
            //Microsoft.Extensions.Configuration.Json
            #endregion

            #region codigo para acessar o arquivo de configuração
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            #endregion

            #region teste utilizando um valor do arquivo de configuração
            var diretorioCSV = config.GetSection("CaminhoDeLeituraDeArquivoCSV").Value;
            #endregion

            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(diretorioCSV);
            //Read the first line of text
            var line = sr.ReadLine();
            //Continue to read until you reach end of file


            while (line != null)
            {

                if (line.Contains("Nome"))
                {
                    line = sr.ReadLine();
                }

                var x = line.Split(";");

                //write the line to console window. Após o split o LINE foi cortado em varios pedacos e atribuiu os valores no X. O X virou uma lista de string.
                // X[0] = A primeira posição da lista de string gerada.
                //Console.WriteLine($"{x[0]} {x[1]} {x[2]} {x[3]}");

                var aluno = new Aluno();

                aluno.Nome = x[0];
                aluno.Idade = Convert.ToInt32(x[1]);
                aluno.Matricula = Convert.ToInt32(x[2]);
                aluno.Serie = x[3];

                listaAluno.Add(aluno);

                //Read the next line
                line = sr.ReadLine();

            }

            Console.WriteLine("Leitura realizada com sucesso!");

            //close the file
            sr.Close();

            //Trazer a lista de alunos cadastrados(6) do menu para ca
            //Inserir informações do arquivo na lista
            //Adicionar na lista e retornar.

            //Lembrar do header que nao precisamos gravar
            //Splitar as informações por ; para conseguir ler linha a linha

            return listaAluno;
        }

        public List<Aluno> LerArquivoAlunoJSON(List<Aluno> listaAluno)
        {
            //Foi utilizado o pacote NuGet = Newtonsoft.Json;

            Console.Clear();

            #region Dependencias a ser instaladas vias NUGET
            //Microsoft.Extensions.Configuration
            //Microsoft.Extensions.Configuration.Json
            #endregion

            #region codigo para acessar o arquivo de configuração
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            #endregion

            #region teste utilizando um valor do arquivo de configuração
            var diretorioJSON = config.GetSection("CaminhoDeLeituraDeArquivoJSON").Value;
            #endregion

            StreamReader sr = new StreamReader(diretorioJSON);


            //JsonConvert converte as informações que estão dentro da variavel SR e transforma em lista por conta do tipo especificado(List<Aluno>)
            listaAluno = JsonConvert.DeserializeObject<List<Aluno>>(sr.ReadToEnd());

            Console.WriteLine("Leitura realizada com sucesso!");

            sr.Close();

            return listaAluno;
        }
    }
}

