using System.ComponentModel.DataAnnotations;
namespace firstapp.Models {
    public class Professor : Pessoa {
        public string ?Formacao {get; set;}
        public double ?Salario {get; set;}
    }
}