using Api.VendaVeiculo.Application.ViewModels;
using Api.VendaVeiculo.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.Mapping
{
    public class VeiculoMapper: Profile
    {
        public VeiculoMapper()
        {
            CreateMap<CadastraVeiculoModel, Veiculo>()
               .ForMember(venda => venda.AnoFabricacao, model => model.MapFrom(y => y.AnoFabricacao))
               .ForMember(venda => venda.Marca, model => model.MapFrom(y => y.Marca))
               .ForMember(venda => venda.Modelo, model => model.MapFrom(y => y.Modelo));
               
        }
        
      
    }
}
