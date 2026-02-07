using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sarah_Shop.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Column("varchar(50)")]
        [MinLength(4)]
        [MaxLength(50)]
        public string Name { get; set; }


        public List<Product>? Products { get; set; }
    }
}
