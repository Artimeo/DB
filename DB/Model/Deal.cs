using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model
{
    public class Deal
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        
        public int PartId { get; set; }
        
        public Part Part { get; set; }
        
        public int Count { get; set; }
    }
}
