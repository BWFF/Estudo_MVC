using System.ComponentModel.DataAnnotations;
namespace PostGetModel.Models
{
    public class Pessoa
    {
        [Display(Name = "Código")]
        public int PessoaId { get; set; }

        [Required(ErrorMessage="Informe o nome.!")]
        public string Nome { get; set; }
        public string Twitter { get; set; }
    }
}