using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Programacion_PC3.Models
{
    [Table("t_producto1")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string name { get; set; } 

        [Required]
        public string picture { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public int price { get; set; }

        [Required]
        public string phone { get; set; }

        [Required]
        public string place { get; set; }

        [Required]
        public string userName { get; set; }

        [Required]
        public DateTime addDate { get; set; }
    }
}