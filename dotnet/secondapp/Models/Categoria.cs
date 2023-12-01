using System.ComponentModel.DataAnnotations;

namespace secondapp.Models {

    public class Categoria {

        [Display(Name="Código")]
        public int Id { get; set; }
        public string ?Nome {get; set; }
    }
}