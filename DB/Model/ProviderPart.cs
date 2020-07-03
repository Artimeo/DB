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
        public int Id { get; set; }
        [ForeignKey("Provider")]
        public int ProviderId { get; set; }        
        public Provider Provider { get; set; }
        [ForeignKey("Part")]
        public int PartId { get; set; }
        public Part Part { get; set; }
    }
}
