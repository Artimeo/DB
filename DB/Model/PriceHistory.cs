using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model
{
    public class PriceHistory
    {
        [Key, Required]
        public int Id { get; set; }
        [ForeignKey("Part")]
        public int PartArticle { get; set; }
        [Required]
        public Part Part { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Price { get; set; }

    }
}
