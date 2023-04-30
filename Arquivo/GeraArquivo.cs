using CadastroDeAlunos.Modelos;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Arquivo
{
    public class GeraArquivo
    {
        public void GeraArquivosAlunoCSV(List<Aluno> listaAluno)
        {
            Console.Clear();

            #region Dependencias a ser instaladas vias NUGET
            //Microsoft.Extensions.Configuration
            //Microsoft.Extensions.Configuration.Json
            #endregion

            //teste do git

            #region codigo para acessar o arquivo de configuração
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            #endregion

            #region teste utilizando um valor do arquivo de configuração
            var diretorioCSV = config.GetSection("CaminhoDeGeracaoDeArquivoCSV").Value;
            #endregion


            StreamWriter sw = new StreamWriter($"{diretorioCSV}ArquivoAlunos_{DateTime.Now.ToString("yyyy_MM_dd__HH_mm_ss")}.csv");
            
            sw.WriteLine("Nome;Idade;Matricula;Serie");

            foreach (var item in listaAluno)
            {
                sw.WriteLine($"{item.Nome};{item.Idade};{item.Matricula};{item.Serie}");
            }

            //Close the file
            sw.Close();
        }

        public void GerarArquivosAlunoJSON(List<Aluno> listaAluno)
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
            var diretorioJSON = config.GetSection("CaminhoDeGeracaoDeArquivoJSON").Value;
            #endregion

            StreamWriter sw = new StreamWriter($"{diretorioJSON}ArquivoAlunos_{DateTime.Now.ToString("yyyy_MM_dd__HH_mm_ss")}.json");
            

            var teste = JsonConvert.SerializeObject(listaAluno, Formatting.Indented);

            sw.Write(teste);

            Console.WriteLine("Arquivo gerado com sucesso!");

            sw.Close();

        }
    }
}
