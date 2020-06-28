using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model
{
    public class ProviderPart
    {
        [Key]
        public int Id { get; set; }
        
        [Required, ForeignKey("Provider")]
        public int ProviderId { get; set; }
        
        [Required]
        public Provider Provider { get; set; }
        
        [Required, ForeignKey("Part")]
        public int PartId { get; set; }
        [Required]
        public Part Part { get; set; }
    }
}
