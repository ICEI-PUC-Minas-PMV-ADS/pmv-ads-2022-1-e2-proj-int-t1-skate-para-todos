using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace skateparatodos.Models
{
    [Table("Comentarios")]
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        public int? DoacaoId { get; set; }
        [ForeignKey("DoacaoId")]
        public Doacao Doacao { get; set; }
        public int? UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public string Texto { get; set; }
        public DateTime Data { get; set; }
    }
}
