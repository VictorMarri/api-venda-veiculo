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
                    .Requires().IsTrue(new ValidaEnum(StatusVenda.ToString()).enumValue(),nameof(StatusVenda),"Status de venda não está correto!")
                    //.Requires().IsNotEmpty<Vendedor>(Vendedor,
                );
        }


    }

    public class ValidaEnum
    {
        public string Item { get; set; }

        public ValidaEnum(string item)
        {
            Item = item;
        }

        public bool enumValue()
        {
            var checkEnum = numberRange(Convert.ToInt32(Item));

            return checkEnum;
        }

        public bool numberRange(int number)
        {
            int[] range = new int[] { 0, 1, 2, 3, 4 };

            foreach (var i in range)
            {
                if (i == number)
                 return true;
            }
                
            return false;
        }
                    
                



    }
}
