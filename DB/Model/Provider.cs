using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        
        [MaxLength(12)]
        public string Phone { get; set; }

        public IList<ProviderPart> ProviderParts { get; set; }
    }
}
