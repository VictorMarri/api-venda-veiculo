using Api.VendaVeiculo.Application.ViewModels.Validators;
using Api.VendaVeiculo.Domain;
using Api.VendaVeiculo.Domain.Entities;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.ViewModels
{
    public class CadastraVendaModel : Notifiable, IValidatable
    {
        public Status StatusVenda { get; set; }

        public DateTime Data { get; set; }

        public List<Vendedor> Vendedor { get; set; }

        public List<Veiculo> Veiculo { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                    .Requires().IsTrue(new StatusExists(StatusVenda.ToString()).enumValue(),nameof(StatusVenda),"Status de venda não está correto!")
                    .Requires().IsNotNull(Vendedor, nameof(Vendedor),"Deve haver um vendedor preenchido para uma venda!")
                    .Requires().IsNotNullOrEmpty(Data.ToString(), nameof(Data), "Data não pode estar vazio!")
                    .Requires().IsNotNull(Veiculo, nameof(Veiculo), "Deve haver um veiculo preenchido!")
                );
        }


    }

}
