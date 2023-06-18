using Bogus;
using Bogus.DataSets;
using Faker;

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
            var instancia = new Faker<Person>().Generate().FullName;
            return instancia;
        }


        /// <summary>
        ///     Gerar Data de Nascimento Aleatório
        /// </summary>
        /// <remarks>
        ///     Ele usufrui de uma biblioteca ASP.NET Faker (Install-Package Bogus)
        ///     para gerar a data de nascimento ele colocou uma data limite entre a data de nascimento de seus associados
        ///     Pegando os nacidos entre 01/01/1940 e 31/12/2005
        /// </remarks>
        public static DateTime GET_GerarDataNascimento()
        {
            var instancia = new Faker<Date>().Generate().Between(new DateTime(1940, 1, 1), new DateTime(2005, 12, 31));
            return instancia;
        }


        public static short GET_GerarAgenciaBancaria()
        {
            var agencia = new Faker<Bogus.DataSets.Finance>().Generate().Account(4);
            return short.Parse(agencia);
        }


        public static ushort GET_GerarContaBancaria()
        {
            var conta = new Faker<Bogus.DataSets.Finance>().Generate().Account(8);
            return ushort.Parse(conta);
        }
    }
}
