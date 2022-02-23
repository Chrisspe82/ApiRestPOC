using System;
using System.ComponentModel.DataAnnotations;

namespace AR.Domain
{

    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="O Campo {} é obrigatorio")]
        [MaxLength (50, ErrorMessage ="O campo {0} deve ter no maximo {1} Caracteres")]
        public  string  Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
    }
}
