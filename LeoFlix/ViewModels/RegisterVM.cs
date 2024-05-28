using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeoFlix.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Nome de usuário")]
        [Required(ErrorMessage = "Por favor, informe o nome de usuario")]
        [StringLength(60)]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Por Favor, informe o email")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Informe a data de nascimento")]
        public DateTime Birthday { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Por favor, informe a senha")]
        public string Password { get; set; }
        
        public string ReturnUrl { get; set; }
    }
}