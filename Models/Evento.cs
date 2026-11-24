using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_mvc.Models
{
    public class Evento
    {
        [Required(ErrorMessage = "O Id é obrigatório")]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "O nome deve possuir entre 5 e 80 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "A descrição necessita de no mínimo 10 caracteres")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O local é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O local deve possuir entre 3 e 100 caracteres")]
        public string Local { get; set; }
        [Required(ErrorMessage = "A data é obrigatória")]
        public DateTime DataEvento { get; set; }
        [Required(ErrorMessage = "A quantidade de vagas é obrigatória")]
        [Range(1, 1000, ErrorMessage = "Quantidade de vaga deve pertencer ao intervalo 1-1000")]
        public int QuantidadeVagas { get; set; }
        [Required(ErrorMessage = "O valor é obrigatório")]
        public decimal ValorIngresso { get; set; }
    }
}