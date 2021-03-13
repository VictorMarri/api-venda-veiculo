using Flunt.Notifications;
using Flunt.Validations;

namespace Api.VendaVeiculo.Application.ViewModels
{
    /// <summary>
    /// Utilizando o Flunt para validação dos inputs do usuario
    /// </summary>
    public class CadastraVendedorModel : Notifiable, IValidatable
    {

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                    .Requires().IsNotNullOrEmpty(Nome, nameof(Nome), "Nome do Vendedor não pode estar vazio!")
                    .Requires().IsNotNullOrEmpty(CPF, nameof(CPF), "CPF não pode ser nulo!")
                    .Requires().IsNotNullOrEmpty(Email, nameof(Email), "Email não pode estar vazio!")
                    .Requires().HasMinLen(CPF, 11, nameof(CPF), "Por favor, verifique se está faltando algum digito no CPF do vendedor e Tente novamente")

                );
        }
    }
}
