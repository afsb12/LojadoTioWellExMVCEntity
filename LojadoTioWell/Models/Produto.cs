using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojadoTioWell.Models
{
    public class Produto
    {
        [Key]
        public int ID_prod { get; set; }
        [DisplayName("Descrição do Produto")]
        [StringLength(50, ErrorMessage = "O campo Nome permite no máximo 50 caracteres!")]
        public string Descricao { get; set; }
        [Required]
        public decimal ValorUnitario { get; set; }
      
    }
}