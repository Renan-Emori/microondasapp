using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microondas.Models
{
    public class PreDefinidoModel
    {
        [Key]
        public int Id { get; set; }
        [Column("Nome",TypeName="Varchar(200)")]
        [Required(ErrorMessage ="digite o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "digite o alimento")]
        public string Alimento { get; set;}

        [Required(ErrorMessage = "digite o tempo")]
        [Range(1, 120, ErrorMessage = "Digite um tempo válido")]
        public int Tempo { get; set; }

        [Range(1, 10, ErrorMessage = "Digite um número válido")]
        public int Potencia { get; set; }
        public string? Instrucoes { get; set; }
    }
}
