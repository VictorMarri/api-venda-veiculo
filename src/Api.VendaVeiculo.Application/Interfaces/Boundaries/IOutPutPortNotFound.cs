using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.Interfaces.Boundaries
{
    /// <summary>
    /// Output de retorno not found.
    /// </summary>
    public interface IOutPutPortNotFound
    {
        /// <summary>
        /// Informa que o recurso procurado não foi encontrado.
        /// </summary>
        /// <param name="message">Descrição do erro.</param>
        void NotFound(string message);
    }
}
