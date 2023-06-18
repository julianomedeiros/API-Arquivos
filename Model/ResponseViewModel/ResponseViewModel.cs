namespace API_Arquivos.Model.ResponseViewModel
{
    /// <summary>
    ///     Retorno padrão da API
    /// </summary>
    /// <remarks>
    ///     Com o intuito de padronizar os retornos da API, a classe tem a funcionalidade de ser reutilizada para quaisquer fins 
    ///     de resposta da API, podendo ser utilizada tanta para erros quanto para o sucesso. 
    ///     Tornando o retorno do json padronizado
    /// </remarks>
    public class ResponseViewModel
    {
        public object data { get; set; }

        public StatusResponseViewModel status { get; set; }
    }

    public class StatusResponseViewModel
    {
        public int code { get; set; }

        public string message { get; set; }
    }

}
