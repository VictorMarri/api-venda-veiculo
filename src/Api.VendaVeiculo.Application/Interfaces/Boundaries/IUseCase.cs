using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.Application.Interfaces.Boundaries
{
    public interface IUseCase<in TUseCaseInput>
    {
        /// <summary>
        /// Executa o método da classe de aplicação.
        /// </summary>
        /// <param name="input">Input a ser trabalhado.</param>
        /// <returns>Retorna uma task.</returns>
        Task Execute(TUseCaseInput input);
    }
}
