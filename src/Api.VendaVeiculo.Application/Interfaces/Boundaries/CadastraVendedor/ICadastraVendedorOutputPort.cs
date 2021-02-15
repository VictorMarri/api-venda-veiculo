using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor
{
    public interface ICadastraVendedorOutputPort : IOutPutPortNotFound, IOutputPortError, IOutPutPortStandard<CadastraVendedorOutput>
    {
    }
}
