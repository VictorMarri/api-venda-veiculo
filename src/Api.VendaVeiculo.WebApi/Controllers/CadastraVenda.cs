using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVenda;
using Api.VendaVeiculo.Application.ViewModels;
using Api.VendaVeiculo.WebApi.Models;
using Api.VendaVeiculo.WebApi.Presenters;
using FluentMediator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.WebApi.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    public class CadastraVenda : Controller
    {
        private readonly IMediator _mediator;

        public CadastraVenda(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost, Route("")]
        [ProducesResponseType(typeof(CadastraVendaOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostVenda(CadastraVendaModel input, [FromServices] CadastraVendaPresenter presenter)
        {
            await _mediator.PublishAsync(input).ConfigureAwait(false);

            return presenter.ViewModel;
        }
    }
}
