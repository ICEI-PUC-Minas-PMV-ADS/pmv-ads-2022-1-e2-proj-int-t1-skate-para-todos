using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace skateparatodos.Models
{
    [Table("Doacoes")]
    public class Doacao
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Titulo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Descricao { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime DataCriacao { get; set; }

        [Display(Name = "Status Doação")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public StatusDoacao Status { get; set; }

        [Required]
        public int UsuarioId { get; set; }
        [Display(Name = "Responsável")]
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        public ICollection<DoacaoItem> DoacoesItens { get; set; }

        public ICollection<Comentario> Comentarios { get; set; }

    }
    public enum StatusDoacao
    {
        Aberta, Concluida, Cancelada
    }
}
