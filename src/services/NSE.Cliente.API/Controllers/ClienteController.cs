using Microsoft.AspNetCore.Mvc;
using NSE.Clientes.API.Application.Commands;
using NSE.Core.Mediator;
using NSE.WebAPI.Core.Controllers;

namespace NSE.Clientes.API.Controllers
{
    public class ClienteController : MainController
    {
        private readonly IMediatorHandler _mediator;

        public ClienteController(IMediatorHandler mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var result = await _mediator.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(), "Anderson", "anderson@teste.com", "01484527283"));

            return CustomResponse(result);
        }
    }
}
