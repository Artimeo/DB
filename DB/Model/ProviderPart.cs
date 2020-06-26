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

        //[Key, Column(Order = 0)]
        [ForeignKey("Provider")]
        public int ProviderId { get; set; }
        //[Key, Column(Order = 1)]
        [ForeignKey("Part")]
        public int PartArticle { get; set; }

        public virtual Provider Provider { get; set; }
        public virtual Part Part { get; set; }
    }
}
