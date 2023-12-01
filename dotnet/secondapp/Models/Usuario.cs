using System.ComponentModel.DataAnnotations;
namespace secondapp.Models
{
   public class Usuario
   {    
       [Display(Name="Código")]
       public int Id { get; set; }
       public string ?Nome { get; set; }
       public string ?Login { get; set; }
       [Display(Name="Senha")]
       public string ?Password { get; set; }
   }
}
