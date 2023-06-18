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




        public static short GET_GerarAgenciaBancaria()
        {
            var agencia = new Faker<Bogus.DataSets.Finance>().Generate().Account().PadLeft(4, '0');
            return short.Parse(agencia);
        }


        public static int GET_GerarContaBancaria()
        {
            var conta = new Faker<Bogus.DataSets.Finance>().Generate().Account().PadLeft(8, '0');
            return int.Parse(conta);
        }




        private class NomeAleatorio
        {
            public string FullName { get; set; }
        }

        private class DataAleatoria
        {
            public DateTime dataAniversario { get; set; }
        }

    }
}
