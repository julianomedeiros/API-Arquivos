﻿using API_Arquivos.Model.ResponseViewModel;

namespace API_Arquivos.Service.Interface
{
    public interface IExcelService
    {
        Task<ResponseViewModel> GET_GerarNovoExcel(decimal? qntPessoas);
    }
}
