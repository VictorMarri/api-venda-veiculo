using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVeiculo
{
    public interface ICadastraVeiculoOutputPort : IOutputPortError, IOutPutPortNotFound, IOutPutPortStandard<CadastraVeiculoOutput>
    {
    }
}
