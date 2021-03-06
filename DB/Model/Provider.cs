﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Model
{
    public class Provider
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Address { get; set; }
        
        public string Phone { get; set; }
        [InverseProperty("Provider")]
        public List<ProviderPart> ProviderParts { get; set; } = new List<ProviderPart>();
    }
}
