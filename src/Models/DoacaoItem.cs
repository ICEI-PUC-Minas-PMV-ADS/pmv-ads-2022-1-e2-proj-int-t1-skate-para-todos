using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace skateparatodos.Models
{
    [Table("DoacoesItens")]
    public class DoacaoItem
    {
        [Key]
        public int Id { get; set; }

        public int DoacaoId { get; set; }
        [ForeignKey("DoacaoId")]
        public Doacao Doacao { get; set; }

        public string Descricao { get; set; }

        [Display(Name = "Peça")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public TipoPeca Peca { get; set; }

        public int? UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
    public enum TipoPeca
    {
        Shape,
        Truck,
        Roda,
        Rolamento,
        Parafuso,
        Capacete,
        Joelheira,
        Cotoveleira
    }
}
