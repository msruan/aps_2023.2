using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ruan.Models
{
   public class Usuario
   {    
       [Display(Name="Código")]
       public int Id { get; set; }
       [Required]
       [Display(Name="Nome")]
       public string ?Login { get; set; }
       [Required]
       [Display(Name="Senha")]
       public string ?Password { get; set; }
       
       public virtual Carrinho? Carrinho { get; set;}

   }
}
