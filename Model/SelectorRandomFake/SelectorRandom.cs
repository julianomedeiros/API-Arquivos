using Bogus;
using Bogus.DataSets;

namespace API_Arquivos.Model.SelectorRandomFake
{
    public class SelectorRandom
    {
        /// <summary>
        ///     Gerar Nome Aleatório
        /// </summary>
        /// <remarks>
        ///     Ele usufrui de uma biblioteca ASP.NET Faker (Install-Package Bogus)
        ///     ela é responsavel por gerar novos dados aleatórios
        /// </remarks>
        public static string GET_GerarNomeAleatorio()
        {
            return new Faker<NomeAleatorio>()
                .RuleFor(p => p.FullName, f => f.Person.FullName).Generate().FullName;
        }



        /// <summary>
        ///     Gerar Data de Nascimento Aleatório
        /// </summary>
        /// <remarks>
        ///     Ele usufrui de uma biblioteca ASP.NET Faker (Install-Package Bogus)
        ///     para gerar a data de nascimento ele colocou uma data limite entre a data de nascimento de seus associados
        ///     Pegando os nacidos entre 01/01/1940 e 31/12/2005
        /// </remarks>
        public static string GET_GerarDataNascimento()
        {
            var dataNascimento = new Bogus.DataSets.Date().Between(new DateTime(1940, 1, 1), new DateTime(2005, 12, 31));
            return dataNascimento.ToString("dd/MM/yyyy");
        }



        /// <summary>
        ///     Gerar numero Agencia Bancaria
        /// </summary>
        /// <remarks>
        ///     Ele vai gerar um numero aleatório de 4 casas
        /// </remarks>
        public static int GET_GerarAgenciaBancaria()
        {
            return new Random().Next(1000, 10000);
        }



        /// <summary>
        ///     Gerar numero Agencia Bancaria
        /// </summary>
        /// <remarks>
        ///     Ele vai gerar um numero aleatório de 8 casas
        /// </remarks>
        public static int GET_GerarContaBancaria()
        {
            return new Random().Next(10000000, 100000000);
        }




        private class NomeAleatorio
        {
            public string FullName { get; set; }
        }

    }
}
