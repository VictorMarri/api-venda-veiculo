using Api.VendaVeiculo.Application.ViewModels;
using Api.VendaVeiculo.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.Mapping
{
    public class VendedorMapping : Profile
    {
        public VendedorMapping()
        {
            CreateMap<CadastraVendedorModel, Vendedor>()
                .ForMember(vendedor => vendedor.CPF, model => model.MapFrom(y => y.CPF))
                .ForMember(vendedor => vendedor.Email, model => model.MapFrom(y => y.Email))
                .ForMember(vendedor => vendedor.Nome, model => model.MapFrom(y => y.Nome));
        }
    }
}
