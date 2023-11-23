using System.ComponentModel.DataAnnotations;
namespace firstapp.Models {
    public class Pessoa {
        [Display(Name ="Código")]
        public int Id {get; set;}

        [Display(Name ="Nome")]
        public string ?Nome {get; set;}
    }
}