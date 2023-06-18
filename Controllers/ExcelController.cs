using API_Arquivos.Model.ResponseViewModel;
using API_Arquivos.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API_Arquivos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExcelController: ControllerBase
    {
        private ILogger<ExcelController> _logger;
        private readonly IExcelService service;

        public ExcelController(ILogger<ExcelController> logger, IExcelService service)
        {
            _logger = logger;
            this.service = service;
        }



        [HttpGet]
        [ProducesResponseType(typeof(ResponseViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetTodosProcessos()
        {

            _logger.LogInformation((int)LogLevel.Information, "Método GET -  Api {0} ");

            try
            {
                var resposta = await service.GET_GerarNovoExcel();
                return Ok(resposta);
            }
            catch (Exception ex)
            {
                string err = string.Join("|", ex);
                return Problem(detail: err);
            }

        }





    }
}
