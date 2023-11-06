using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManpreetBooks.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Category Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
