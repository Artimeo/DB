using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model
{
    public class Part
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Manufacturer { get; set; }

        public int Price { get; set; }
        [InverseProperty("Part")]
        public List<ProviderPart> ProviderParts { get; set; } = new List<ProviderPart>();
    }
}
