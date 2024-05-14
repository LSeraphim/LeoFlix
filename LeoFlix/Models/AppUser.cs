using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace LeoFlix.Models;

[Table("AppUser")]
public class AppUser
{
    [Key]
    public string AppUserId { get; set; }
    [ForeignKey("AppUserId")]
    public IdentityUser UserAccount { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Name { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "")]
    public DateTime Birthday {get; set;}

    [StringLength(300)]
    [Display(Name = "Foto")]
    public string Photo { get; set; }

}
