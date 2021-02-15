using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.Interfaces.Boundaries
{
    public interface IOutPutPortStandard<in TUseCaseOutPut>
    {
        /// <summary>
        ///  Registra o retorno normal de uma application.
        /// </summary>
        /// <param name="output">O output da mensagem da application</param>
        void Success(TUseCaseOutPut output);
    }
}
