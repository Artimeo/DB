using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model
{
    public class Part
    {
        [Key, Required]
        public int Article { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Manufacturer { get; set; }
        [Required]
        public int Price { get; set; }

        public virtual ICollection<Provider> Providers { get; set; }
        public Part()
        {
            this.Providers = new List<Provider>();
        }
    }
}
