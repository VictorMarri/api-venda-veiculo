using Api.VendaVeiculo.Application.ViewModels;
using Api.VendaVeiculo.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.Mapping
{
    public class VendaMappping : Profile
    {
        public VendaMappping()
        {
            CreateMap<CadastraVendaModel, Venda>()
                .ForMember(venda => venda.StatusVenda, model => model.MapFrom(y => y.StatusVenda))
                .ForMember(venda => venda.Data, model => model.MapFrom(y => y.Data))
                .ForMember(venda => venda.IdVendedor, model => model.MapFrom(y => y.IdVendedor))
                .ForMember(venda => venda.Veiculo, model => model.MapFrom(y => y.Veiculo));
        }
    }
}
