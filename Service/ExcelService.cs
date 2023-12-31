﻿using API_Arquivos.Model.ResponseViewModel;
using API_Arquivos.Model.SelectorRandomFake;
using API_Arquivos.Model.ViewModel;
using API_Arquivos.Service.Interface;

namespace API_Arquivos.Service
{
    public class ExcelService : IExcelService
    {
        private readonly IConfiguration _configuration;

        public ExcelService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ResponseViewModel> GET_GerarNovoExcel(decimal? qntPessoas = 1)
        {
            try
            {
                if(qntPessoas <= 0)
                {
                    return await RetornoMensagem.RetornoErro(400, "O numero informado precisa ser maior que 0");
                }

                var lista = new List<ClienteViewModel>();

                for (int i = 0; i <= qntPessoas; i++)
                {
                    var cliente = new ClienteViewModel();

                    cliente.Nome = SelectorRandom.GET_GerarNomeAleatorio();
                    cliente.DataNascimento = SelectorRandom.GET_GerarDataNascimento();
                    cliente.AgenciaBancaria = SelectorRandom.GET_GerarAgenciaBancaria();
                    cliente.ContaBancaria = SelectorRandom.GET_GerarContaBancaria();

                    lista.Add(cliente);
                }

                return await RetornoMensagem.RetornoSucesso(lista);
            }
            catch (Exception ex)
            {
                return await RetornoMensagem.RetornoErro(500, $"ERRO!! Falha ao gerar Lista. Motivo: {ex.Message}");
            }
        }

    }
}
