namespace API_Arquivos.Model.ResponseViewModel
{
    public static class RetornoMensagem
    {
        public static async Task<ResponseViewModel> RetornoSucesso(object objetoRetorno)
        {
            return await Task.FromResult(new ResponseViewModel
            {
                data = objetoRetorno,
                status = new StatusResponseViewModel { code = 200, message = "Sucesso" }
            });
        }

        /// <summary>
        ///     Retorno Erro
        /// </summary>
        /// <param name="NumeroErro">Numero do Erro: 500-400-404</param>
        /// <param name="Mensagem">Mensagem do Erro</param>
        /// <remarks>
        /// </remarks>
        public static async Task<ResponseViewModel> RetornoErro(int NumeroErro, string Mensagem)
        {
            return await Task.FromResult(new ResponseViewModel
            {
                data = Mensagem,
                status = new StatusResponseViewModel { code = NumeroErro, message = "Erro" }
            });
        }



    }
}
