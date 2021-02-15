using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor;
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
    public class CadastraVendedor : Controller
    {
        private readonly IMediator _mediator;

        public CadastraVendedor(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(CadastraVendedorOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostVendedor(CadastraVendedorModel input, [FromServices] CadastraVendedorPresenter presenter)
        {
            await _mediator.PublishAsync(input).ConfigureAwait(false);

            return presenter.ViewModel;
        }
    }
}
