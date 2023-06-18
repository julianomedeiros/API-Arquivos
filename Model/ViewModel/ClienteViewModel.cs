namespace API_Arquivos.Model.ViewModel
{
    public class ClienteViewModel
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public short AgenciaBancaria { get; set; }
        public ushort ContaBancaria { get; set; }
    }
}
