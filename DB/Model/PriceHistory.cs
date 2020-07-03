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
        public int Id { get; set; }
        //[ForeignKey("Part")]
        public int PartId { get; set; }

        public Part Part { get; set; }

        public DateTime Date { get; set; }

        public int Price { get; set; }

    }
}
