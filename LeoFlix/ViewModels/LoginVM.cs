using System.ComponentModel.DataAnnotations;

namespace LeoFlix.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou Nome do Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuario")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    public string Password { get; set; }

    [Display(Name = "Manter conectado?")]
    public bool RememberMe { get; set; } = false;
    public string ReturnUrl { get; set; }
}
