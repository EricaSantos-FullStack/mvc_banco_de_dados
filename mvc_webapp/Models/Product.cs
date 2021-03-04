using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_webapp.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct { get; set; }

        [Display(Name = "Escreva o codigo do produto")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} é necessário.")]
        public string ProductCode { get; set; }

        [Display(Name = "Escreva o tipo do produto")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} é necessário.")]
        public string ProductType { get; set; }

        [Display(Name = "Apresente a descrição do produto")]
        [StringLength(150)]
        public string Description { get; set; }

        [Display(Name = "Preço unitário")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Required(ErrorMessage = "{0} é necessário.")]
        public decimal UniPrice { get; set; }

        [Display(Name = "Quantidade no estoque")]
        [Required(ErrorMessage = "{0} é necessário.")]
        public int QtyInStock { get; set; }

    }
}