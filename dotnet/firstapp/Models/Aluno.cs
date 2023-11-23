using System.ComponentModel.DataAnnotations;

namespace firstapp.Models {
    public class Aluno : Pessoa {
        [Display(Name="Senha")]
        public string ?Password {get; set;}
   }
}