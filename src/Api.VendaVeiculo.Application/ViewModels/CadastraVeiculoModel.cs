using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.ViewModels
{
    public class CadastraVeiculoModel: Notifiable,IValidatable
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                    .Requires().IsNotNullOrEmpty(Marca,nameof(Marca),"'Marca' não pode estar vazio!")
                    .Requires().IsNotNullOrEmpty(Modelo, nameof(Modelo),"'Modelo' não pode estar vazio!")
                    .Requires().IsNotNull(AnoFabricacao,nameof(AnoFabricacao),"Ano Fabricação não pode estar vazio!")
                    .Requires().IsGreaterThan(AnoFabricacao, 0, nameof(AnoFabricacao), "'Ano de Fabricação' não pode ser zero!")
                );
        }
    }
}
