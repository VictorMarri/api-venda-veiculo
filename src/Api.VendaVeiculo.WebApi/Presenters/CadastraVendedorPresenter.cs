using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor;
using Api.VendaVeiculo.WebApi.Models;
using Flunt.Notifications;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.WebApi.Presenters
{
    public class CadastraVendedorPresenter : ICadastraVendedorOutputPort
    {
        public IActionResult? ViewModel { get; set; }

        public void NotFound(string message) => this.ViewModel = new NotFoundObjectResult(new ErrorResult(message));


        public void Success(CadastraVendedorOutput output) => this.ViewModel = new OkObjectResult(output);


        public void WriteError(string message) => this.ViewModel = new BadRequestObjectResult(new ErrorResult(message));



        public void WriteError(IReadOnlyCollection<Notification> errors)
        {
            var erros = new ErrorResult(errors);
            this.ViewModel = new BadRequestObjectResult(erros);

        }
    }
}
